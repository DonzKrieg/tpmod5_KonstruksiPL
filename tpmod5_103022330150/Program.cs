using System;
using tpmod5_103022330150;

class Program
{
    static void Main()
    {
        HaloGenerics halo = new HaloGenerics();
        halo.SapaUser("Ihsan");

        DataGeneric<string> nimData = new DataGeneric<string>("103022330150");

        nimData.PrintData();
    }
}
