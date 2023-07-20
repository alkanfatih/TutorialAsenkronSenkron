namespace TaskWait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAny(StartSchool(),TeachClass12());
            TeachClass11();

            Console.Read();
        }
        public static async Task StartSchool()
        {
            await Task.Delay(8000);
            Console.WriteLine("Okul Başladı");
        }
        public static async Task TeachClass12()
        {
            await Task.Delay(3000);
            Console.WriteLine("12. Sınıflar Derse Başladı");
        }
        public static async Task TeachClass11()
        {
            await Task.Delay(2000);
            Console.WriteLine("11. Sınıflar Derse Başladı");
        }
    }
}