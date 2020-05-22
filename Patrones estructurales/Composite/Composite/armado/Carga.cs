using System.Collections.Generic;

namespace Composite
{
    static class Carga
    {
        private const string DDR4 = "DDR4";
        private const string DDR3 = "DDR3";

        private const string AM4 = "AM4";
        private const string INTEL_1151 = "1151";
        private const string INTEL_1051 = "1051";

        private const string ATX = "ATX";
        private const string ITX = "ITX";

        private const string SSD = "SSD";
        private const string HDD = "HDD";

        public static List<CPU<IPerfomance>> GetCPUs()
        {
            var cpus = new List<CPU<IPerfomance>>
            {
                new CPU<IPerfomance>("I3-8100", 1, 4400, 4)
                {
                    Socket = INTEL_1151,
                    Consumo = 50,
                    HasIntegrada = true
                },
                new CPU<IPerfomance>("R7-2700", 2, 7700, 7)
                {
                    Socket = AM4,
                    Consumo = 50,
                    HasIntegrada = false
                },
                new CPU<IPerfomance>("I3-2100", 3, 2200, 2)
                {
                    Socket = INTEL_1051,
                    Consumo = 50,
                    HasIntegrada = true
                },
                new CPU<IPerfomance>("I5-2100", 3, 3300, 3)
                {
                    Socket = INTEL_1051,
                    Consumo = 50,
                    HasIntegrada = true
                },
                new CPU<IPerfomance>("R5-2600", 3, 5500, 5)
                {
                    Socket = AM4,
                    Consumo = 50,
                    HasIntegrada = false
                }
            };

            return cpus;
        }

        public static List<GPU<IPerfomance>> GetGPUs()
        {
            var gpus = new List<GPU<IPerfomance>>
            {
                new GPU<IPerfomance>("GTX 1080", 4, 8800, 8)
                {
                    Consumo = 150
                },
                new GPU<IPerfomance>("GTX 1070", 5, 6600, 6)
                {
                    Consumo = 120
                },
                new GPU<IPerfomance>("GTX 1060", 6, 4000, 4)
                {
                    Consumo = 100
                },
                new GPU<IPerfomance>("GTX 1050", 6, 3000, 3)
                {
                    Consumo = 100
                },
                new GPU<IPerfomance>("GTX 1030", 6, 2000, 2)
                {
                    Consumo = 100
                }
            };

            return gpus;
        }

        public static List<RAM<IPerfomance>> GetRAMs()
        {
            var rams = new List<RAM<IPerfomance>>
            {
                new RAM<IPerfomance>("corsair", 7, 8000, 4)
                {
                    TipoMemoriaRAM = DDR4,
                    Capacidad = 8
                },
                new RAM<IPerfomance>("corsair", 9, 4000, 4)
                {
                    TipoMemoriaRAM = DDR4,
                    Capacidad = 4
                },
                new RAM<IPerfomance>("crucial", 8, 2000, 2)
                {
                    TipoMemoriaRAM = DDR4,
                    Capacidad = 4
                },
                new RAM<IPerfomance>("ballistix", 8, 3000, 4)
                {
                    TipoMemoriaRAM = DDR4,
                    Capacidad = 8
                }
            };
            return rams;
        }

        public static List<Mother<IPerfomance>> GetMothers()
        {
            var mothers = new List<Mother<IPerfomance>>
            {
                new Mother<IPerfomance>("asus a", 10, 5000, 5)
                {
                    Socket = AM4,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },

                new Mother<IPerfomance>("asus b", 11, 6000, 6)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ITX
                },

                new Mother<IPerfomance>("asus c", 12, 4000, 4)
                {
                    Socket = INTEL_1051,
                    TipoMemoriaRAM = DDR3,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus a", 10, 3000, 3)
                {
                    Socket = AM4,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus d", 10, 3000, 3)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus e", 10, 5500, 6)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus e", 10, 7000, 8)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus e", 10, 5000, 9)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                },
                new Mother<IPerfomance>("asus e", 10, 3500, 3)
                {
                    Socket = INTEL_1151,
                    TipoMemoriaRAM = DDR4,
                    Formato = ATX
                }
            };

            return mothers;
        }

        public static List<Gabinete<IPerfomance>> GetGabinetes()
        {
            var gabinetes = new List<Gabinete<IPerfomance>>
            {
                new Gabinete<IPerfomance>("sentey K20", 13, 2000, 4),
                new Gabinete<IPerfomance>("sentey K10", 14, 1500, 2),
                new Gabinete<IPerfomance>("Thermaltake K30", 13, 3000, 6)
            };

            return gabinetes;
        }

        public static List<Fan<IPerfomance>> GetFans()
        {
            var fans = new List<Fan<IPerfomance>>
            {
                new Fan<IPerfomance>("idcooling", 15, 550, 4)
                {
                    Socket = AM4,
                    TamañoFan = 140
                },

                new Fan<IPerfomance>("Artic", 15, 650, 5)
                {
                    Socket = INTEL_1151,
                    TamañoFan = 140
                },

                new Fan<IPerfomance>("Artic old", 15, 700, 6)
                {
                    Socket = INTEL_1051,
                    TamañoFan = 140
                }
            };

            return fans;
        }

        public static List<Fuente<IPerfomance>> GetFuentes()
        {
            var fuentes = new List<Fuente<IPerfomance>>
            {
                new Fuente<IPerfomance>("seasonic 600", 20, 1400, 4)
                {
                    Watts = 600
                },
                new Fuente<IPerfomance>("seasonic 500", 20, 1500, 5)
                {
                    Watts = 500
                },
                new Fuente<IPerfomance>("seasonic 400", 20, 1600, 6)
                {
                    Watts = 400
                }
            };

            return fuentes;
        }

        public static List<Disco<IPerfomance>> GetDiscos()
        {
            var discos = new List<Disco<IPerfomance>>() {
                new Disco<IPerfomance>("seagate", 1, 100, 2)
                {
                    Capacidad = 1000,
                    Tipo = HDD
                },
                new Disco<IPerfomance>("seagate", 1, 100, 4)
                {
                    Capacidad = 1120,
                    Tipo = SSD
                },
                new Disco<IPerfomance>("samsung", 1, 100, 5)
                {
                    Capacidad = 240,
                    Tipo = SSD
                }
            };
            return discos;
        }
    }
}
