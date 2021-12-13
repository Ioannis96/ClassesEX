using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            BigPhotoAlbum a = new BigPhotoAlbum();
            a.SetPages(123);
            Console.WriteLine(a.GetNumberOfPages());

            Console.ReadLine();
        }
    }
}
