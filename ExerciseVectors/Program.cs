namespace ExerciseVectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Option list:");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1 - Register a room");
                Console.WriteLine("2 - Register a student");
                Console.WriteLine("3 - Rent a room");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Choose an option: ");
                option = int.Parse(Console.ReadLine());

                doChoosedFunction(option);
            } while (option != 0);
        }
        static void doChoosedFunction(int choosedOption) {
            switch (choosedOption)
            {
                case 1:
                    
                    break;
                default:
                    return;
            }
        }
    }
    
    
}
