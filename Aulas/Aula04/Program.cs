namespace Aula04
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------VERIFICADOR DE NUMEROS PARES OU IMPARES--------");
            Console.WriteLine("DIGITE UM NUMERO: ");
            int number = Convert.ToInt32 (Console.ReadLine());

            int result = number % 2;

            if(result == 0)
            {
                Console.WriteLine("O numero é par!");

            }
            else
            {
                Console.WriteLine("O número é ímpar!");
            }
        }
    }
}
