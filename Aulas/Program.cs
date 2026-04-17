namespace Aula03
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-------------CALCULADORA BEEEEEEMM SIMPLES----------------");
            Console.WriteLine("Digite um numero: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int soma = number1 + number2;
            int sub = number1 - number2;
            int multi = number1 * number2;
            int div = number1 / number2;
            int module = number1 % number2;

            Console.WriteLine("Soma dos numeros: " + soma);
            Console.WriteLine("Subtrção dos numeros:" + sub);
            Console.WriteLine("Multiplicação dos numeros: " + multi);
            Console.WriteLine("Divisão dos numeros: " + div);
            Console.WriteLine("Resto da divisao dos numeros: " + module);
        }
    }
}
