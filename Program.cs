namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spc, len = 1, count;
            Console.WriteLine("Enter the Number");
            count=Convert.ToInt32(Console.ReadLine());
            spc = count - 1;
            for (int i = 1; i <= count; i++)
            {
                for (int r = 1; r <= spc; r++)
                {
                    Console.WriteLine(" ");
                }
            }
            for(int s=1; s <= len; s++)
            {
                Console.Write("*");
            }
            spc--;
            len = len + 2;
            Console.WriteLine();
        }
         
    }

}