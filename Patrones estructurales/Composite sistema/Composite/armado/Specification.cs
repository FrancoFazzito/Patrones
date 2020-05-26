using System.Collections.Generic;

namespace Composite //permite crear estructuras jerarquicas o de arbol
{

    public class Specification
    {
        private Dictionary<string, int> perfomanceLevels;
        private const string CPU = "CPU";
        private const string FAN = "FAN";
        private const string CAPACIDAD_DISCO = "CAPACIDAD_DISCO";
        private const string TIPO_DISCO = "TIPO_DISCO";
        private const string GPU = "GPU";
        private const string MOTHER = "MOTHER";
        private const string RAM_CAPACIDAD = "RAM_CAPACIDAD";

        public void SetUseType(UseType use)
        {
            perfomanceLevels = new Dictionary<string, int>();
            switch (use)
            {
                case UseType.gaming:
                    perfomanceLevels.Add(CPU, 3);
                    perfomanceLevels.Add(FAN, 1);
                    perfomanceLevels.Add(CAPACIDAD_DISCO, 1000);
                    perfomanceLevels.Add(GPU, 4);
                    perfomanceLevels.Add(MOTHER, 3);
                    perfomanceLevels.Add(RAM_CAPACIDAD, 8);
                    break;
                case UseType.diseño:
                    perfomanceLevels.Add(CPU, 5);
                    perfomanceLevels.Add(FAN, 3);
                    perfomanceLevels.Add(CAPACIDAD_DISCO, 240);
                    perfomanceLevels.Add(GPU, 5);
                    perfomanceLevels.Add(MOTHER, 5);
                    perfomanceLevels.Add(RAM_CAPACIDAD, 8);
                    break;
                case UseType.oficina:
                    perfomanceLevels.Add(CPU, 2);
                    perfomanceLevels.Add(FAN, 1);
                    perfomanceLevels.Add(CAPACIDAD_DISCO, 500);
                    perfomanceLevels.Add(GPU, 1);
                    perfomanceLevels.Add(MOTHER, 2);
                    perfomanceLevels.Add(RAM_CAPACIDAD, 4);
                    break;
                default:
                    break;
            }
        }

        public int GetCPULevel()
        {
            return perfomanceLevels[CPU];
        }

        public int GetFanLevel()
        {
            return perfomanceLevels[FAN];
        }

        public int GetDiscoCapacidad()
        {
            return perfomanceLevels[CAPACIDAD_DISCO];
        }

        public int GetGPULevel()
        {
            return perfomanceLevels[GPU];
        }

        public int GetMotherLevel()
        {
            return perfomanceLevels[MOTHER];
        }

        public int GetCapacidadRam()
        {
            return perfomanceLevels[RAM_CAPACIDAD];
        }
    }

}
