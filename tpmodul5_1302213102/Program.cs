internal class Program
{
    class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }
    private static void Main(string[] args)
    {
        DataGeneric<string> tes = new DataGeneric<string> ("1302213102");
        tes.PrintData();
    }
}