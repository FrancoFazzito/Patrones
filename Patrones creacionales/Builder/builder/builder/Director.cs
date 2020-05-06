namespace builder
{
    class Director
    {
        public void Construye(IBuilder constructor)
        {
            //el director indica los pasos para que el builder construya
            constructor.construyeMotor();
            constructor.construyeCarroceria();
            constructor.construyeLlantas();
        }
    }
}
