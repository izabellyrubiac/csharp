
    Console.Write("Digite o valor recebido: ");
    decimal valorDoado = decimal.Parse(Console.ReadLine()!);


    Console.Write("\nDoação anônima? Digite 'SIM' ou 'NAO': ");
    string sn = (Console.ReadLine()!.ToLower());
    bool anonimo = (sn == "sim");


    Console.Write("Qual tipo de conta? Digite: (C) para Corrente ou (P) para poupança: ");
    char cp = char.Parse(Console.ReadLine()!.ToLower());

Console.WriteLine("Valor recebido: R$" + valorDoado);
Console.WriteLine("Doação anônima: " + anonimo); //Retorna True or False


if (cp == 'c')
{
    Console.WriteLine("Tipo de conta: C");
}
else if (cp == 'p')
{
    Console.WriteLine("Tipo de conta: P");
}
else
{
    Console.WriteLine("Opcao inválida do tipo de conta! Por favor escolha a opção correta para continuar com o registro.");
}



