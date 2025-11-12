namespace MyFile
{
    internal class Program
    {        
        static string getCezar(string st, int shift)
        {

            return "";
        }

        static void getFirstandLastDays(int year, int month)
        {
            DateTime dtBegin = DateTime.Now;
            DateTime dtEnd = DateTime.Now;




            Console.WriteLine($"первый день месяца: {dtBegin}");
            Console.WriteLine($"последний день месяца: {dtEnd}");
        }
        static void Main(string[] args)
        {
            string sDt = "2025-10-30";
            DateTime dTemp = DateTime.Now;
            var isDatetime = DateTime.TryParse(sDt, out dTemp);
            dTemp = dTemp.AddDays(-10);

            //string st = "hello world";
            //var cc = st.ToArray();

            //char symbol = 'a';            
            //Console.WriteLine((int)symbol);

            //int a = 97;
            //Console.WriteLine((char)a);

            //createNewFile();
            //foreach (string file in getFilesInFolder(@"C:\Temp\folder"))
            //{
            //    Console.WriteLine(file);
            //}
            //Directory.CreateDirectory(@"C:\Temp\folder\myFolder");
            //Directory.Delete(@"C:\Temp\folder\myFolder");            
        }

        static string[] getContentFile()
        {
            return File.ReadAllLines(@"C:\Temp\folder\1.txt");
        }

        static void createNewFile()
        {
            var content = getContentFile();
            //File.WriteAllLines(@"C:\Temp\folder\2.txt", content);
            File.AppendAllLines(@"C:\Temp\folder\2.txt", content);
            var isExists = File.Exists(@"C:\Temp\folder\2.txt");
            if (isExists)
                Console.WriteLine("File created");
            else
                Console.WriteLine("File not found");
        }

        static string[] getFilesInFolder(string folder)
        {
            return Directory.GetFiles(folder);
        }
    }
}
