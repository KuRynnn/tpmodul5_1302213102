internal class Program
{
    class HaloGeneric
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine ("Halo User " + nama);
        }
    }
    private static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Fahryan");
    }
}