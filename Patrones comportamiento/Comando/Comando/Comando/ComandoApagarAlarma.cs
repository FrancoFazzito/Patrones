namespace Comando
{

        class ComandoApagarAlarma : IComando
        {
            private Auto auto;

            public ComandoApagarAlarma(Auto auto)
            {
                this.auto = auto;
            }

            public void ejecutar()
            {
                auto.QuitarAlarma();
            }
        }

}
