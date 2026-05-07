Console.Write("Digite os minutos para converter em horas: ");

int totalminutos = int.Parse(Console.ReadLine()!);
int horas = totalminutos / 60;
int minutos = totalminutos % 60;
Console.WriteLine($"Tempo: {horas} horas e {minutos} minutos");