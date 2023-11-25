namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };
            PrintArray();

            Console.WriteLine();

            Array.Reverse(array);
            PrintArray();
            Console.WriteLine();

            void PrintArray() //если войд, то return не будет
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }
            }
            
            //====== Метод без параметров ========
            void MethodWithoutParameters()
            {
                //тело метода
            }
            
            //======= Метод без возвращаемого значения ==========
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            
            PrintMessage("Text");
            string tmp = "Ghdksksj";
            PrintMessage(tmp);
            
            // ========= Метод с возвращаемым значением ======
            string GetInfo()
            {
                return "Test"; //полное соответствие типу, указанному перед названием метода
            }

            string result = GetInfo();
            Console.WriteLine(result);
            
            // -=================== Метод с параметрами по умолчанию ===================-
            void DisplayGreeting(string greetingMessage, string name = "Гость")
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }
            
            DisplayGreeting("Hello");
            DisplayGreeting("Hello", "Polenka");
            
            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)  //массив параметров
            {
                int sum = 0;

                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
            
            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
        }
    }
}