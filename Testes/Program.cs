decimal conversao = 1.60934m;
Console.Write("Digite quantas milhas: ");
decimal milhas = long.Parse(Console.ReadLine()!);
decimal milhaToKm = (milhas * conversao);
Console.WriteLine($"\n{milhas} milhas equivalem a {milhaToKm} quilômetros");