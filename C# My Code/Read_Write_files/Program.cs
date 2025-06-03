using System.IO;

namespace Read_Write_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // read from file
            string myfile1 = File.ReadAllText(@"D:\\Programming Projects\\C#\\General\\Read_Write_files\\TextFile1.txt");
            Console.WriteLine(myfile1);

            string[] myfilelines1 = File.ReadAllLines(@"D:\\Programming Projects\\C#\\General\\Read_Write_files\\TextFile1.txt");

            int i = 0;
            foreach (string line in myfilelines1)
            {
                i++;
                Console.WriteLine($"Line {i} "+line);
            }

            // write in file
            string myfile2 = "mostafa";
            string[] myfilelines2 = { "hi", "iam mostafa" };

            File.WriteAllLines(@"D:\Programming Projects\C#\General\Read_Write_files\TextFile2.txt", myfilelines2);
            File.WriteAllText(@"D:\Programming Projects\C#\General\Read_Write_files\TextFile3.txt", myfile2);
        }
    }
}
