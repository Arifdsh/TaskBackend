namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK-1************* 1-1000 Ededleri icerisinde 3-e ve 5-e bolunen ededler

            /*for(int i=0; i<1000;i++)
            {
                if (i % 3 == 0 && i%5==0)
                {
                 Console.WriteLine(i);
                }
            }*/

            //TASK-3*********  10 ve 20 arasinda reqem daxil edilir.say qeder random.daha sonra tek ve cut ededler ariliqda yazilir. 


            Console.WriteLine("10-la 20 arasinda 1 eded daxil edin");

            string input = Console.ReadLine();
            List<int> arr = new List<int>();
            if (int.TryParse(input, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    Random random = new Random();
                    arr.Add(random.Next());
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Enter integeer");
            }
            int[] myArray = arr.ToArray();
            string odd = "";
            string even = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    even += " # " + myArray[i] + " # ";
                }
                else
                {
                    odd += " # " + myArray[i] + " # ";
                }
            }
            Console.WriteLine("This is even numbers : " + even);
            Console.WriteLine("This is odd numbers : " + odd);

            //TASK-2************ Random eded daxil edin  o qederde ekrana reqem cixsin

            /*Console.WriteLine("Reqem daxil edin");
            string count = Console.ReadLine();
            if(int.TryParse(count,out int number))
            {
               for(int i = 0; i < number; i++)
                {
                    Random random=new Random();
                    int randomNumber = random.Next();
                    Console.WriteLine(randomNumber);
                }
            }
            else
            {
                Console.WriteLine("You must be enter integeer");
            }*/

            //TASK-4******** 3 reqemli ededin reqemleri cemi

            /*Console.WriteLine("3 reqemli eded daxil edin");
            string input = Console.ReadLine();
            if(int.TryParse(input,out int number))
            {
                    int total =0;
                for(int i = 0; i < input.Length; i++)
                {
                    //input[i] is ASC code.Thats why to convert to int must write input[i]-'0'
                    total +=input[i]-'0';
                }
                Console.WriteLine(total);
            }*/


            //TASK-5*******Verilmis 3 ededden en boyuk ve en kiciyini mueyyen edin

            /*List<int> numbers = new List<int>();

            int number1 = 125;
            int number2 = 19;
            int number3 = 53;

            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);

            int[] numbersArray = numbers.ToArray();
            Console.WriteLine(string.Join(",",numbersArray));
            Console.WriteLine("Maximum number is : "+numbersArray.Max());
            Console.WriteLine("Minimum number is : "+numbersArray.Min());*/

            //TASK-6*********  3 reqemli ededlerden 7 ve 8 bolunen ededlerin cemini tapin

            /*  int result = 0;
          for (int i = 100; i < 1000; i++)
          {
              if(i%7==0 && i%8==0)
              {
                  result += i;
              }
          } 
              Console.WriteLine(result);*/
        }
    }
}
 