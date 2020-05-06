namespace Comando
{
        class ComandoColocarAlarma : IComando
        {
            private Auto auto;

            public ComandoColocarAlarma(Auto auto)
            {
                this.auto = auto;
            }

            public void ejecutar()
            {
                auto.ColocarAlarma();
            }
        }
}
