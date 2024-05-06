namespace Mercado.Menus
{
    public class MenuMostrarProdutosRegistrados : Menu
    {
        public override void Executar(Dictionary<string, List<int>> produtosRegistrados)
        {
            base.Executar(produtosRegistrados);
            ExibirTituloDaOpcao("Exibindo todos os Produtos registrados na nossa aplicação");

            foreach (string PrdutoRegistrado in produtosRegistrados.Keys)
            {
                Console.WriteLine($"Produto: {PrdutoRegistrado}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
