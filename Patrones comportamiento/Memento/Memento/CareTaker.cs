﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class CareTaker
    {
        private Memento memento;

        public Memento Memento { get => memento; set => memento = value; }
    }
}
