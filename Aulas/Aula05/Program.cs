namespace Aula05
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("=====Operadores Relacionais=====\n");
            Console.WriteLine("Digite o primeiro número: ");
            int x = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int y = Convert.ToInt32 (Console.ReadLine());

            bool condicao = x == y;

            string result;

            //Operador de Igualdade (==)
            if (x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }

            Console.WriteLine("\nIgualdade (==): " + result);

        }
    }
}
