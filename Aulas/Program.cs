namespace Aula02;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("---------CADASTRO DE USUARIO------------");

        //Solicitar o nome do usuario
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();

        //Solicitar a idade do usuario
        Console.WriteLine("Digite sua Idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Nome do Usuário: " + name);
        Console.WriteLine("Idade do Usuário: " + age);
    }
}
