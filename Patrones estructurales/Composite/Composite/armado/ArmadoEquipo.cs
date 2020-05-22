using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    class ArmadoEquipo
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

        public List<CPU<IPerfomance>> GetEquipo()
        {
            List<CPU<IPerfomance>> equipos = new List<CPU<IPerfomance>>();

            foreach (var cpu in Carga.GetCPUs().FindAll(c => c.PerfomanceLevel > specification.GetCPULevel()))
            {
                double consumo = 0;
                consumo += cpu.Consumo;
                Mother<IPerfomance> mother = AddMother(cpu);
                AddRAM(mother);
                AddFan(mother);
                AddGabinete(mother);
                AddDisco(mother);

                bool gpuinstalda = false;

                if (!cpu.HasIntegrada)
                {
                    GPU<IPerfomance> gpu = AddGPU(mother);
                    consumo += gpu.Consumo;
                    gpuinstalda = true;
                }

                if (specification.GetGPULevel() != 1 && !gpuinstalda)
                {
                    GPU<IPerfomance> gpu = AddGPU(mother);
                    consumo += gpu.Consumo;
                }

                AddFuente(consumo, mother);

                bool existeInvalido = mother.GetElements().Exists(e => e.Name == NO_VALID);

                if (cpu.GetTotalPrice() < presupuesto && !existeInvalido)
                {
                    equipos.Add(cpu);
                }
            }
            return equipos;
        }

        private Mother<IPerfomance> AddMother(CPU<IPerfomance> cpu)
        {
            Mother<IPerfomance> mother = new Mother<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var mot in Carga.GetMothers())
            {
                if (mot.Socket == cpu.Socket && mot.PerfomanceLevel >= specification.GetMotherLevel())
                {
                    mother = mot;
                }
            }
            cpu.Add(mother);
            return mother;
        }

        private void AddDisco(Mother<IPerfomance> mother)
        {
            var disco = new Disco<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetDiscos())
            {
                if (item.Capacidad >= specification.GetDiscoCapacidad())
                {
                    disco = item;
                }
            }
            mother.Add(disco);
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
                if (item.Socket == mother.Socket && item.PerfomanceLevel >= specification.GetFanLevel())
                {
                    fan = item;
                }
            }
            mother.Add(fan);
        }

        private GPU<IPerfomance> AddGPU(Mother<IPerfomance> mother)
        {
            var gpu = new GPU<IPerfomance>(NO_VALID, 0, 0, 0);

            foreach (var item in Carga.GetGPUs())
            {
                if (item.PerfomanceLevel >= specification.GetGPULevel())
                {
                    gpu = item;
                }
            }
            mother.Add(gpu);
            return gpu;
        }

        private void AddRAM(Mother<IPerfomance> mother)
        {
            RAM<IPerfomance> ram = new RAM<IPerfomance>(NO_VALID, 0, 0, 0);
            foreach (var item in Carga.GetRAMs())
            {
                int capacidad = specification.GetCapacidadRam();
                if (item.TipoMemoriaRAM == mother.TipoMemoriaRAM && item.Capacidad >= capacidad)
                {
                    ram = item;
                }
            }

            mother.Add(ram);
        }


    }
}
