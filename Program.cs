namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameUser;
            char symbol;
            int nameUserLength;

            Console.WriteLine("Как Вас зовут ? ");
            nameUser = Console.ReadLine();
            Console.WriteLine("Какой символ Вы выберете ? ");
            symbol = Convert.ToChar(Console.ReadLine());
            nameUserLength = nameUser.Length;

            for (int i = 0; i < nameUserLength + 2; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine("\n" + symbol + nameUser + symbol);
            for (int i = 0; i < nameUserLength + 2; i++)
            {
                Console.Write(symbol);
            }
        }
    }
}