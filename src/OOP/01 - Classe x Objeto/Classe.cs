using System;

namespace OOP
{
    //Definição de classe
    public class Carro
    {
        public Guid CarroId { get; set; }
        public string Placa { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            //Definição de Objeto
            var objeto = new Carro()
            {
                CarroId = Guid.NewGuid(),
                Placa = "DXD-4180"
            };
        }
    }
}
