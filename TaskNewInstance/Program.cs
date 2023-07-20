namespace TaskNewInstance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(()=> GetRandomNumber());
            task.Start();
            Console.WriteLine("Program başladı...");
            Console.Read();
        }
        static int GetRandomNumber()
        {
            Thread.Sleep(1000);
            int randomNumber = (new Random()).Next(1, 100);
            Console.WriteLine($"Rastgele Sayı: {randomNumber}");
            return randomNumber;
        }

    }
}