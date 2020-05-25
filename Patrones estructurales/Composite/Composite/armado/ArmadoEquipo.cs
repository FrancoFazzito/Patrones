using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class ArmadoEquipo
    {
        private const string NO_VALID = "no valido";
        private Specification specification;
        private double presupuesto;

        public ArmadoEquipo(UseType use, double presupuesto)
        {
            specification = new Specification();
            this.presupuesto = presupuesto;
            specification.SetUseType(use);
        }

        public List<CPU<IPerfomance>> GetEquipos()
        {
            List<CPU<IPerfomance>> equipos = new List<CPU<IPerfomance>>();

            foreach (var cpu in GetCpusSpecification())
            {
                double consumoTotal = cpu.Consumo;

                Mother<IPerfomance> mother = AddMother(cpu);
                AddRAM(mother);
                AddFan(mother);
                AddGabinete(mother);
                AddDisco(mother);

                bool gpuinstalda = false;

                if (!cpu.HasIntegrada)
                {
                    GPU<IPerfomance> gpu = AddGPU(mother);
                    consumoTotal += gpu.Consumo;
                    gpuinstalda = true;
                }

                if (specification.GetGPULevel() != 1 && !gpuinstalda)
                {
                    GPU<IPerfomance> gpu = AddGPU(mother);
                    consumoTotal += gpu.Consumo;
                }

                AddFuente(consumoTotal, mother);

                bool existeInvalido = ExistsParteInvalida(mother);

                if (GetEquiposPrecioIndicado(cpu, existeInvalido))
                {
                    equipos.Add(cpu);
                }
            }
            return equipos;
        }

        private List<CPU<IPerfomance>> GetCpusSpecification()
        {
            return Carga.GetCPUs().FindAll(c => c.PerfomanceLevel > specification.GetCPULevel());
        }

        private static bool ExistsParteInvalida(Mother<IPerfomance> mother)
        {
            return mother.GetElements().Exists(e => e.Name == NO_VALID);
        }

        private bool GetEquiposPrecioIndicado(CPU<IPerfomance> cpu, bool existeInvalido)
        {
            return cpu.GetTotalPrice() <= presupuesto && !existeInvalido;
        }

        private Mother<IPerfomance> AddMother(CPU<IPerfomance> cpu)
        {
            Mother<IPerfomance> mother = new Mother<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var mot in Carga.GetMothers())
            {
                if (ValidateMother(cpu, mot))
                {
                    mother = mot;
                }
            }
            cpu.Add(mother);
            return mother;
        }

        private bool ValidateMother(CPU<IPerfomance> cpu, Mother<IPerfomance> mot)
        {
            return mot.Socket == cpu.Socket && mot.PerfomanceLevel >= specification.GetMotherLevel();
        }

        private void AddDisco(Mother<IPerfomance> mother)
        {
            var disco = new Disco<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetDiscos())
            {
                if (ValidateDisco(item))
                {
                    disco = item;
                }
            }
            mother.Add(disco);
        }

        private bool ValidateDisco(Disco<IPerfomance> item)
        {
            return item.Capacidad >= specification.GetDiscoCapacidad();
        }

        private void AddFuente(double consumo, Mother<IPerfomance> mother)
        {
            var fuente = new Fuente<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetFuentes())
            {
                if (item.Watts80 > consumo)
                {
                    fuente = item;
                }
            }
            mother.Add(fuente);
        }

        private void AddGabinete(Mother<IPerfomance> mother)
        {
            var gabinete = Carga.GetGabinetes().First();
            mother.Add(gabinete);
        }

        private void AddFan(Mother<IPerfomance> mother)
        {
            Fan<IPerfomance> fan = new Fan<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetFans())
            {
                if (ValidateFan(mother, item))
                {
                    fan = item;
                }
            }
            mother.Add(fan);
        }

        private bool ValidateFan(Mother<IPerfomance> mother, Fan<IPerfomance> item)
        {
            return item.Socket == mother.Socket && item.PerfomanceLevel >= specification.GetFanLevel();
        }

        private GPU<IPerfomance> AddGPU(Mother<IPerfomance> mother)
        {
            var gpu = new GPU<IPerfomance>(NO_VALID, 0, 0, 0);

            foreach (var item in Carga.GetGPUs())
            {
                if (ValidateFan(item))
                {
                    gpu = item;
                }
            }
            mother.Add(gpu);
            return gpu;
        }

        private bool ValidateFan(GPU<IPerfomance> item)
        {
            return item.PerfomanceLevel >= specification.GetGPULevel();
        }

        private void AddRAM(Mother<IPerfomance> mother)
        {
            RAM<IPerfomance> ram = new RAM<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetRAMs())
            {
                int capacidad = specification.GetCapacidadRam();
                if (ValidateRAM(mother, item, capacidad))
                {
                    ram = item;
                }
            }

            mother.Add(ram);
        }

        private static bool ValidateRAM(Mother<IPerfomance> mother, RAM<IPerfomance> item, int capacidad)
        {
            return item.TipoMemoriaRAM == mother.TipoMemoriaRAM && item.Capacidad >= capacidad;
        }
    }
}
