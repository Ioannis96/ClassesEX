using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public void SetPages(int val)
        {
            numberOfPages = val;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }
        
        public PhotoAlbum(int pages)
        {
            numberOfPages = pages;
        }
    }
}
