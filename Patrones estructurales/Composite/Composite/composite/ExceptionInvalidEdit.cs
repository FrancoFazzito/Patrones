using System;

namespace Composite
{
    class ExceptionInvalidEdit : Exception
    {
        public override string Message => "no se puede cambiar elementos de esta parte del equipo";
    }
}
