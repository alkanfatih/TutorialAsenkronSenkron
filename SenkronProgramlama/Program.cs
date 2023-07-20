namespace SenkronProgramlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartSchool();
            TeachClass12();
            TeachClass11();
        }
        public static void StartSchool()
        {
            Thread.Sleep(8000);
            Console.WriteLine("Okul Başladı");
        }
        public static void TeachClass12()
        {
            Thread.Sleep(3000);
            Console.WriteLine("12. Sınıf Eğitime Başladı");
        }
        public static void TeachClass11()
        {
            Thread.Sleep(2000);
            Console.WriteLine("11. Sınıf Eğitime Başladı");
        }
    }
}