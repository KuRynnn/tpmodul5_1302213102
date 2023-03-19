internal class Program
{
    class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo User " + nama);
        }
    }
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

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Fahryan");

        DataGeneric<string> tes = new DataGeneric<string> ("1302213102");
        tes.PrintData();
    }
}