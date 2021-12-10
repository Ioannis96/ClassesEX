using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class BigPhotoAlbum
    {
        private int numberOfPages;
        
        public void SetPages(int val)
        {
            numberOfPages = val;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }

        public BigPhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }

    }
}
