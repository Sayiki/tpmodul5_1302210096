// See https://aka.ms/new-console-template for more information
using tpmodul5_1302210096;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string namaPanggilan = "Arzaq";
        halo.SapaUser(namaPanggilan);

        DataGeneric<string> data = new DataGeneric<string>("1302210096");
        data.PrintData();
    }
}
