namespace testeRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int times = 0;
            int[] hits = new int[5];

            while (times <= 4) { 
                int retorno = NewAttack();
                Console.Clear();
                hits[times] = retorno;

                times++;
            }

            for (int i = 0; i <= 4; i++)
                Console.WriteLine(hits[i]);
        }

        static int NewAttack()
        {
            ConsoleKey[] test = [ConsoleKey.UpArrow, ConsoleKey.LeftArrow, ConsoleKey.RightArrow, ConsoleKey.DownArrow];
            Random random = new Random();
            int pad1 = Convert.ToInt32(random.Next(0, 4));
            int pad2 = Convert.ToInt32(random.Next(0, 4));
            int pad3 = Convert.ToInt32(random.Next(0, 4));
            int pad4 = Convert.ToInt32(random.Next(0, 4));
            int pad5 = Convert.ToInt32(random.Next(0, 4));

            int[] numbers = [pad1, pad2, pad3, pad4, pad5];
            string[] numbersText = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                if (numbers[i] == 0)
                    numbersText[i] = "CIMA";
                else if (numbers[i] == 1)
                    numbersText[i] = "ESQUERDA";
                else if (numbers[i] == 2)
                    numbersText[i] = "DIREITA";
                else if (numbers[i] == 3)
                    numbersText[i] = "BAIXO";
            }

            for (int i = 0; i <= 4; i++)
            Console.WriteLine($"{numbersText[i]}");


            ConsoleKeyInfo input1 = Console.ReadKey();
            ConsoleKeyInfo input2 = Console.ReadKey();
            ConsoleKeyInfo input3 = Console.ReadKey();
            ConsoleKeyInfo input4 = Console.ReadKey();
            ConsoleKeyInfo input5 = Console.ReadKey();

            ConsoleKeyInfo[] inputs = [input1, input2, input3, input4, input5];

            int count = 0;

            for (int i = 0; i <= 4; i++)
            {

                if (inputs[i].Key == test[numbers[i]]);
                {
                    count++;
                }
            }
            /*
           Todos os acertos estão vindo como certos, não há como errar
            */
            return count;
        }
    }
}
