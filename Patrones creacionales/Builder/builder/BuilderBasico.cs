namespace builder
{
    class BuilderBasico : IBuilder
    {
        private Auto auto = new Auto();

        public void construyeCarroceria()
        {
            auto.ColocarCarroceria(new CarroceriaBasica());
        }

        public void construyeLlantas()
        {
            auto.ColocarLlantas(new LlantasBasicas());
        }

        public void construyeMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        public Auto GetAuto()
        {
            return auto;
        }
    }
}
