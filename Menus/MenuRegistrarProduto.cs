
using Mercado.Modelos;

namespace Mercado.Menus
{
    public class MenuRegistrarProduto : Menu
    {
        public override void Executar(Dictionary<string, List<int>> produtosRegistrados)
        {
            base.Executar(produtosRegistrados);
            ExibirTituloDaOpcao("Registro de Produtos");

            Console.Write("Digite o nome do produto que deseja registrar: ");
            string nomeDoProduto = Console.ReadLine()!;
            if(!produtosRegistrados.ContainsKey(nomeDoProduto)) 
                {
                    produtosRegistrados.Add(nomeDoProduto, new List<int>());
                    Console.WriteLine($"Produto {nomeDoProduto} adicionado!");

                //for (var i = 1; i <= 3; i++)
                //{
                    Console.Write($"Digite a quantidade do {nomeDoProduto}º item: ");
                    int quantidade = int.Parse(Console.ReadLine()!);
                    produtosRegistrados[nomeDoProduto].Add(quantidade);

                    Console.Write($"Digite o código de barras do {nomeDoProduto}º item: ");
                    int codBarras = int.Parse(Console.ReadLine()!);
                    produtosRegistrados[nomeDoProduto].Add(codBarras);

                    Console.Write($"Digite o preço do {nomeDoProduto}º item: ");
                    double preco = Convert.ToDouble(Console.ReadLine());
                    produtosRegistrados[nomeDoProduto].Add((int)preco);

                //}

              Console.WriteLine($"O Produto {nomeDoProduto} foi registrada com sucesso!");
            }
            else
            {
                Console.WriteLine($"O produto {nomeDoProduto} já está registrado. Deseja adicionar mais itens? (S/N)");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "S")
                {
                        Console.Write($"Digite a quantidade do {nomeDoProduto} item novo: ");
                        int quantidade = int.Parse(Console.ReadLine()!);
                        produtosRegistrados[nomeDoProduto].Add(quantidade);
                        Console.WriteLine($"Itens adicionais do produto {nomeDoProduto} registrados com sucesso!");
                }
            }
            Thread.Sleep(3000);
            Console.Clear();
        }

    }
}
