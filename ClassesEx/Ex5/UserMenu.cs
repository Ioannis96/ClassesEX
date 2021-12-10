using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class UserMenu
    {
        Controller ct;

        public UserMenu(Controller ct)
        {
            this.ct = ct;
        }

        public void PrintMenu()
        {
            Console.WriteLine("Press Q To show CD List");
            Console.WriteLine("Press L To Load CD");
        }

    }
}
