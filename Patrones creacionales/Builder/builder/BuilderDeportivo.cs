namespace builder
{
    class BuilderDeportivo : IBuilder
    {
        private Auto auto = new Auto();

        public void construyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaDeportiva());
        }

        public void construyeLlantas()
        {
            auto.ColocarLlantas(new LlantasDeportivas());
        }

        public void construyeMotor()
        {
            auto.ColocarMotor(new MotorDeportivo());
        }

        public Auto GetAuto()
        {
            return auto;
        }
    }
}
