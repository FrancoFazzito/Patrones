﻿namespace Composite
{
    class Mother<T> : ParteSocketImplement<T>
    {
        public Mother(string name, int id, double price, int level) : base(name, id, price, level)
        {
        }

        public string Socket { get; set; }
        public string TipoMemoriaRAM { get; set; }
        public string Formato { get; internal set; }
    }


}
