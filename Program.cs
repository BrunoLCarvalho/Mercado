using Mercado.Menus;
using Mercado.Modelos;

Dictionary<string, List<int>> produtosRegistrados = new();
produtosRegistrados.Add("Manteiga", new List<int> { 10, 10 });
produtosRegistrados.Add("Leite", new List<int> { 15 });

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarProduto());
opcoes.Add(2, new MenuMostrarProdutosRegistrados());
opcoes.Add(3, new MenuAdiconarQuantidade());
opcoes.Add(4, new MenuExibirDetalhes());
opcoes.Add(9, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

█▀▄▀█ █▀▀ █▀█ █▀▀ ▄▀█ █▀▄ █▀█
█░▀░█ ██▄ █▀▄ █▄▄ █▀█ █▄▀ █▄█
");
    Console.WriteLine("Boas vindas ao Mercadinho!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um Produto:");
    Console.WriteLine("Digite 2 para exibir Produtos Cadastrados:");
    Console.WriteLine("Digite 3 para adicionar estoque de produtos ja cadastrados");
    Console.WriteLine("Digite 4 para exibir os detalhes de Produto");
    Console.WriteLine("Digite 9 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if(opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menu = opcoes[opcaoEscolhidaNumerica];
        menu.Executar(produtosRegistrados);
        if(opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();  
    }
    else
    {
        Console.WriteLine("Opção inválida"); 
    }
}
ExibirOpcoesDoMenu();



