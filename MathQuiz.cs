using System;
namespace mathquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,ans=0,ques=0,count=0,opt,noq=0,ra=0,wa=0;
            Random generator = new Random();
            Console.WriteLine("welcome to math quiz");
            bool b = true;
            while (b)
            {
                Console.WriteLine("you want to continue press y or n");
                string ch = Console.ReadLine();
                if (ch == "n")
                {
                    Console.WriteLine("your score is=" + count);
                    Console.WriteLine("total no of questions=" + noq);
                    Console.WriteLine("total right answers=" + ra);
                    Console.WriteLine("total wrong answers=" + wa);

                    break;
                }
                n1 = generator.Next(99);
                n2 = generator.Next(99);
                opt = generator.Next(3);
                switch (opt)
                {
                    case 0:
                        Console.WriteLine(n1 + "+" + n2 + "=");
                        ques = n1 + n2;
                        noq++;
                        break;
                    case 1:
                        Console.WriteLine(n1 + "-" + n2 + "=");
                        ques = n1 - n2;
                        noq++;
                        break;
                    case 2:
                        Console.WriteLine(n1 + "*" + n2 + "=");
                        ques = n1 * n2;
                        noq++;
                        break;


                }
                ans = Convert.ToInt32(Console.ReadLine());
                if (ans == ques)
                {
                    Console.WriteLine("right answer");
                    count = count + 2;
                    ra++;

                }
                else
                {
                    Console.WriteLine("wrong answer");
                    count--;
                    wa--;

                }

            }
        }
    }
}
