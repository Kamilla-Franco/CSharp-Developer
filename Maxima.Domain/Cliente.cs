namespace Maxima.Domain
{
    public class Cliente
    {
        public int Cli_Id { get; set; }

        //Representa o ID em hexa que está no Json do Teste. Vem de integração com algum outro software?
        public string Id { get; set; }

        public string Codigo { get; set; }

        public string Nome { get; set; }
        
    }
}