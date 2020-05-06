using System;

namespace adaptador
{
    class SumaAdaptada : ITarget
    {
        SumaEnteros suma = new SumaEnteros();

        public string SumaDouble(double num1, double num2)
        {
            //adaptadmos la entrada
            int numero1 = Convert.ToInt32(num1);
            int numero2 = Convert.ToInt32(num2);
            return $"suma de double: {suma.SumaInt(numero1,numero2)}";
        }
    }
}
