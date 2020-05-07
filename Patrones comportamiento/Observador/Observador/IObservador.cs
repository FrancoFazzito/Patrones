namespace Observador
{
    interface IObservador
    {
        void Update(string mensaje); //modelo push -> se envia todo lo relacionado al cambio de estado del objeto
        void UpdatePull(); //modelo pull -> solo se informa que hay un cambio de esta y el observador que esta interesado pide la informacion
    }
}
