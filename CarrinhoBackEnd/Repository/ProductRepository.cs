using CarrinhoBackEnd.Models;

namespace CarrinhoBackEnd.Repository
{
    public static class ProductRepository
    {
        public static List<Product> stock = new List<Product>
        {
            new Product { Id = 1, Name = "Mouse Logitec", Description = "Mouse sem fio de alto desempenho", Price = 149.99F},
            new Product { Id = 2, Name = "Teclado Mecânico", Description = "Teclado mecânico de Alta frequência", Price = 129.99F},
            new Product { Id = 3, Name = "Monitor UltraWide", Description = "Monitor de 30 polegadas", Price = 1490.99F},
            new Product { Id = 4, Name = "MousePad Gamer", Description = "Mousepad de 30x30 cm", Price = 50.99F},
        };

    }
}
