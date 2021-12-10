using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum myAlbum1 = new PhotoAlbum();
            PhotoAlbum myAlbum2 = new PhotoAlbum(24);
            BigPhotoAlbum myBigAlbum = new BigPhotoAlbum();

            Console.WriteLine($" My First album has {myAlbum1.GetNumberOfPages()} pages \n My Second Album has {myAlbum2.GetNumberOfPages()} pages \n My Big Album has {myBigAlbum.GetNumberOfPages()} pages");

            Console.ReadLine();
        }
    }
}
