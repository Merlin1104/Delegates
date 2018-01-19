using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Delegates
{
    class Teplomer
    {
        private Timer timer;
        private static Random randomizer = new Random(); // keby nebolo static tak vsetky by skoncili rovnako

        public delegate void PrehratieHandler(int teplota); //funkcia ktora vraca void, nema ziadne vstupne parametre
        public event PrehratieHandler Prehrati;

        public Teplomer()
        {
            timer = new Timer(randomizer.Next(2000, 10000));
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            //timer.Elapsed -= Timer_Elapsed; // odstrani timer elapsed 
            if (Prehrati != null) //kontrola, ze tam niekto nieco z vonku dal
            {
                Prehrati(100);
            }
        }
    }
}
