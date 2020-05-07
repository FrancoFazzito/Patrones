namespace prototipo
{
    class Auto : IPrototipo //clonar los valores del estado del objeto
    {
        private string modelo;

        public Auto(string modelo)
        {
            this.modelo = modelo;
        }

        public string Modelo { get => modelo; set => modelo = value; }

        public object Clonar()
        {
            return this.MemberwiseClone();
        }
    }
}
