namespace Maxima.Domain
{
    public class Produto
    {    
        public int ProdutoId { get; set; }

        //Representa o ID em hexa que está no Json do Teste. Vem de integração com algum outro software?
        public string Id { get; set; }
        public string Codigo { get; set; }

        public string Nome { get; set; }

        public decimal PrecoUnitario { get; set; }
        public string ImagemURL { get; set; }
        
    }
    
}