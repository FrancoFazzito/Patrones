namespace Comando
{

        class ComandoEncender : IComando
        {
            private Auto auto;

            public ComandoEncender(Auto auto)
            {
                this.auto = auto;
            }

            public void ejecutar()
            {
                auto.Encender();
            }
        }
}
