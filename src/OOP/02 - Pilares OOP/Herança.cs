namespace OOP
{
    public class Automovel
    {
        public string Montadora { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Potencia { get; set; }

        public void Acelerar () { }
        public void Freiar() { }
    }

    public class Carro : Automovel
    {
        public int Portas { get; set; }
        public float CapacidadePortaMala { get; set; }

        public void FecharPortaMalas() { }
    }

    public class Processo
    {
        public void Execucao()
        {
            var carro = new Carro()
            {
                Montadora = "Volkwagem",
                Modelo = "Golf",
                Placa = "HPK-5456",
                Potencia = 140,
                Portas = 4,
                CapacidadePortaMala = 380.10F
            };

            carro.FecharPortaMalas();
            carro.Acelerar();
            carro.Freiar();
        }
    }
}
