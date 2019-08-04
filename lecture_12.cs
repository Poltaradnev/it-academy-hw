using System;
namespace lecture_12
{
    class Program

    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Rectangle[] rectanglesNew = new Rectangle[100];
            byte Сopies = 0;
           
            rectanglesNew[0].length = random.Next(1, 10);
            rectanglesNew[0].width = random.Next(1, 10);
            Console.Write($"{0} : Length = {rectanglesNew[0].length}, Width = {rectanglesNew[0].width}\n");

            for (int i = 1; i < rectanglesNew.Length; i++)
            {
                rectanglesNew[i].length = random.Next(1, 10);
                rectanglesNew[i].width = random.Next(1, 10);

                Console.Write($"{i} : Length = {rectanglesNew[i].length}, Width = {rectanglesNew[i].width}\n");

                if (rectanglesNew[i].Equals(rectanglesNew[0]))
                {
                    Сopies++;
                }
            }

            Console.WriteLine($"Copies: {Сopies}");
            Console.ReadLine();
        }
    }
    struct Rectangle
    {
        public int length;
        public int width;
    }
}