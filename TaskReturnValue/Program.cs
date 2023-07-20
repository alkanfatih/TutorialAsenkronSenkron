namespace TaskReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => GetRandomNumber());
            Console.WriteLine("Rastgele Sayı:" + task.Result);
            Console.WriteLine("Program başladı...");
            Console.Read();
        }
        static int GetRandomNumber()
        {
            Thread.Sleep(1000);
            int randomNumber = (new Random()).Next(1, 100);
            return randomNumber;
        }
    }
}