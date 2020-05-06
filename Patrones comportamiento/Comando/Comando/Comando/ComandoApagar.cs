namespace Comando
{

        class ComandoApagar : IComando
        {
            private Auto auto;

            public ComandoApagar(Auto auto)
            {
                this.auto = auto;
            }

            public void ejecutar()
            {
                auto.Apagar();
            }
        }

}
