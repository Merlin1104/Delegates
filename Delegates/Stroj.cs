using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Stroj
    {
        private string nazovStroja;
        private Teplomer teplomer = new Teplomer();

        public Stroj(string nazovStroja)
        {
            teplomer.Prehrati += onPrehratiStroje;

            this.nazovStroja = nazovStroja;
        }

        private void onPrehratiStroje(int teplota)
        {
            Console.WriteLine("Doslo k prehriatiu");
            VypniStroj();
        }


        public void VypniStroj()
        {
            Console.WriteLine("Vypinam " + " " + nazovStroja);
        }

        public void ZapniStroj()
        {
            Console.WriteLine("Zapinam " + "  " + nazovStroja);
        }
    }
}
