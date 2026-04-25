string mensagemDeBoasVindas = " Boas vindas ao Screen Sound ";


//List<string> listaBandas = new List<string> { "Banda de teste1", "Banda fixa da lista"}; --UMA LISTA

Dictionary<string, List<int>> bandasDiciona = new Dictionary<string, List<int>>();
bandasDiciona.Add("Pao com ovo", new List<int> { 10, 9, 8, 7});
bandasDiciona.Add("Feijao com farinha", new List<int>());

void exibirMensagemDeBV()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void Menu()
{
    Console.WriteLine("\n{ Digite 1 para registrar uma banda          }");
    Console.WriteLine("{ Digite 2 para mostrar todas as banda       }");
    Console.WriteLine("{ Digite 3 para avaliar uma banda            }");
    Console.WriteLine("{ Digite 4 para exibir a media de uma banda  }");
    Console.WriteLine("{ Digite 0 para sair                         }");

    Console.Write("\nSua Opção: ");
    int opcaoMenu = Convert.ToInt32(Console.ReadLine());

    switch (opcaoMenu)
    {
        case 1:
            registrarBanda();
            break;
        case 2:
            mostrarBandas();
            break;
        case 3:
            avaliarBanda();
            break;
        case 4:
            mediaNotas();
            break;
        case 0:
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("opcao invalida");
            break;
    }
}
void registrarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    Console.Write("\nDigite o nome da banda: ");
    string registroBanda = Console.ReadLine()!;
    bandasDiciona.Add(registroBanda, new List<int>());
    Console.WriteLine($"A banda {registroBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    exibirMensagemDeBV();
    Menu();
}

void mostrarBandas()
{
    Console.Clear();
    Console.WriteLine(@"
█░░ █ █▀ ▀█▀ ▄▀█   █▀▄ █▀▀   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█ █▀
█▄▄ █ ▄█ ░█░ █▀█   █▄▀ ██▄   █▄█ █▀█ █░▀█ █▄▀ █▀█ ▄█");
    /*for (int i = 0; i < listaBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaBandas[i]}");
    }*/

    foreach (string banda in bandasDiciona.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione qualquer tecla para exibir Menu");
    Console.ReadKey();
    Console.Clear();
    exibirMensagemDeBV();
    Menu();
}

void avaliarBanda()
{
    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ ▄▀█ █▀█   █▄▄ ▄▀█ █▄░█ █▀▄ ▄▀█
█▀█ ▀▄▀ █▀█ █▄▄ █ █▀█ █▀▄   █▄█ █▀█ █░▀█ █▄▀ █▀█");
    Console.Write("\nDigite o nome da Banda que deseja avaliar: ");
    string bandaAvalia = Console.ReadLine()!;
    if (bandasDiciona.ContainsKey(bandaAvalia))
    {
        Console.Write($"Qual nota a banda {bandaAvalia} merece?: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasDiciona[bandaAvalia].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {bandaAvalia}");
        Thread.Sleep(3000);
        Console.Clear();
        exibirMensagemDeBV();
        Menu();
    }
    else
    {
        Console.WriteLine("Banda não encontrada");
        Console.WriteLine("Pressione qualquer tecla para voltar ao Menu");
        Console.ReadKey();
        Console.Clear();
        exibirMensagemDeBV() ;
        Menu();
    }

}

void mediaNotas()
{
    Console.Clear();
    Console.WriteLine(@"
█▀▀ █▀█ █▄░█ █▀ █░█ █░░ ▀█▀ ▄▀█ █▀█   █▀▄▀█ █▀▀ █▀▄ █ ▄▀█
█▄▄ █▄█ █░▀█ ▄█ █▄█ █▄▄ ░█░ █▀█ █▀▄   █░▀░█ ██▄ █▄▀ █ █▀█");
    Console.Write("Qual Banda voce deseja visualizar sua média de notas ?: ");
    string conBanda = Console.ReadLine()!.ToLower();
    if (bandasDiciona.ContainsKey(conBanda))
    {
        List<int> notasBandas = bandasDiciona[conBanda];
        Console.WriteLine($"A média é: {notasBandas.Average()}");
        Console.WriteLine("Pressione qualquer tecla para o Menu");
        Console.ReadKey();
        Console.Clear();
        exibirMensagemDeBV();
        Menu();
    }
    else
    {
        Console.WriteLine("Essa banda não existe! Tente novamente!!");
        Thread.Sleep(2000);
        Console.Clear();
        exibirMensagemDeBV();
        Menu();
    }
}

exibirMensagemDeBV();
Menu();
