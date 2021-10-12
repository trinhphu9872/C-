using System;

namespace year
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            string[] Can = { "Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky" };
            string[] Chi = { "Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui" };
            string done = checkYear(userInput, Can, Chi);
            Console.Write(done);
            Console.ReadLine();
        }

        private static string checkYear(int inputUser,string[] can, string[] chi)
        {
            string dp = "Năm âm là " + can[inputUser % 10] + " " + can[inputUser % 12];
            return dp;
        }
    }
}
