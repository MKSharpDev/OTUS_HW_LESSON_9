using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    public class Options
    {
        public Game gameBuild()
        {
            bool sasuccess = false;
            Messeger messeger = new Messeger();

            while (!sasuccess)
            {
                try
                {
                    messeger.attemp();
                    int attemps = int.Parse(Console.ReadLine());

                    messeger.range();
                    int range = int.Parse(Console.ReadLine());
                    sasuccess = true;

                    return new Game(attemps, range);
                }
                catch (Exception Ex)
                {
                    messeger.error(Ex);
                }


            }
            return new Game();



        }
    }
}
