using System;

namespace OOP
{
    //Definição de classe
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            //Definição de Objeto
            var objeto = new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Headset beats"
            };
        }
    }
}
