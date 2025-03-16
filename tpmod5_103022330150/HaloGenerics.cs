using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5_103022330150
{
    class HaloGenerics
    {
        public void SapaUser<T>(T nama)
        {
            Console.WriteLine($"Halo, {nama}! Selamat datang.");
        }
    }
}
