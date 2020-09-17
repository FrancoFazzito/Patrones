namespace prototipo
{
    class Auto : IPrototipo //clonar los valores del estado del objeto
    {
        public Auto(string modelo)
        {
            this.Modelo = modelo;
        }

        public string Modelo { get; set; }

        public object Clonar()
        {
            return MemberwiseClone();
        }
    }
}
