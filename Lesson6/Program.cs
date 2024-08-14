namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task1************START
            /*int[] array = { 1, 2, 3,4,5,6,7 };
            Console.WriteLine("Bir eded daxil edin");
            string input=Console.ReadLine();
            if(int.TryParse(input,out int number)){
                for (int i = 0; i < array.Length; i++)
                {
                    if (number == array[i])
                    {
                        Console.WriteLine("Daxil etdiyiniz reqem bu arrayde movcuddur");
                    }
                }
            }*/
            //Task1************END



            //Task2************START

            /*Console.WriteLine("Arrayi reqemleri daxil edin yalniz bosluqla ");

            string input = Console.ReadLine();
            string[] stringArray = input.Split(" ");
            //Console.WriteLine(stringArray);
            try
            {
                int[] intArray = Array.ConvertAll(stringArray, int.Parse);
                for (int i = 0; i < intArray.Length;i++)
                {
                    for (int j = 0; j < intArray.Length;  j++)
                    {
                        if (intArray[i]== intArray[j] && i!=j)
                        {
                            Console.WriteLine("Tekrarlanan eded : " + intArray[i] + " reqemidir." + '\n' + "Indexler ise " + i + "ve" + j);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Yalniz reqem daxil edin");
            }*/


            //Task2************END

            //Task3************START
            /*Console.WriteLine("Eded daxil edin");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int number))
            {
                if(number%!number==0)
            }*/
            //Task3************END

            //Task4************START
            /*bool result = true;
            while (result) 
            { 
                string input1=Console.ReadLine();
                string input2 = Console.ReadLine();
                if(int.TryParse(input1,out int number1)&&int.TryParse(input2,out int number2))
                {
                    if ((number1 + number2) % 6 == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }*/
            //Task4************END

            //Task5************Start

            /*Console.WriteLine(" faktorialini hesabalayacaginiz Eded daxil edin ");
            string input=Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                int result = 1;
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Netice: "+result);
            }*/
            //Task5************END

            //Task6***********Start

            Console.WriteLine("Fibonaci sirsini teyin edin");

            string input=Console.ReadLine();
            int count=int.Parse(input);
            int[] fibonaccinumbers = new int[count];
            if (count < 0) fibonaccinumbers[0] = 0;
            if (count > 1) fibonaccinumbers[1] = 1;
            for (int i = 2; i < count; i++)
            {
                fibonaccinumbers[i] = fibonaccinumbers[i - 1] + fibonaccinumbers[i - 2];
            }
            foreach (var number in fibonaccinumbers)
            {
                Console.Write(number + " ");
            }
            //First method
            /*if (int.TryParse(input, out int number))
            {
                List<int> list = new List<int>();
                int number1 = 1;
                int[] numberArray = [];
                for (int i = 1; i <= number+1; i++)
                {
                    numberArray = list.ToArray();
                    if (numberArray.Length<2)
                    {
                        list.Add(number1);
                    }
                    else
                    {
                        list.Add(numberArray[i - 3] + numberArray[i - 2]);
                    }

                }
                string result = string.Join(", ", numberArray);
                Console.WriteLine(result);
            }*/

            //TAsk6***********End
        }
    }
}
