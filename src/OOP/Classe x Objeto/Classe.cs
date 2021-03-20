using System;

namespace OOP.Classe_x_Objeto
{
    //Definição de classe
    public class Classe
    {
        public Classe(string propriedade)
        {
            Propriedade = propriedade;
        }

        public string Propriedade { get; private set; }

        public void Metodo(string parametro)
        {
            throw new NotImplementedException();
        }
    }
}
