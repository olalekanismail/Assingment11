using System;
using CreatingAndUsingObjects;


namespace Question_8
{
    class call
    {
        static void Main(string[] args)
        {

            Sequence sequence = new Sequence();
            Cat cat = new Cat("Bingo", "dark");
           string a = cat.SayMiau("bingo");
            for (int i = 0; i <= 10; i++)
            {
                
                Console.WriteLine($"the cat name is {a}");
            }   
                 
                
               

            Console.ReadLine();
            
        }
    }
}
