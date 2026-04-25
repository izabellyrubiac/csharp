Console.WriteLine("Digite seu ano de nascimento: ");
int ano = Convert.ToInt32(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - ano;
Console.WriteLine($"Sua idade é {idade}!");
