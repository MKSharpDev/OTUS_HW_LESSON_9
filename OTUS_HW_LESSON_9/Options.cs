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
            //Messeger messeger = new Messeger();
            MessegeSender sender = new MessegeSender();
            

            while (!sasuccess)
            {
                try
                {
                    //messeger.attemp();
                    sender.send(new AttempMassage());
                    int attemps = int.Parse(Console.ReadLine());

                    //messeger.range();
                    sender.send(new RangeMassage());
                    int range = int.Parse(Console.ReadLine());
                    sasuccess = true;

                    return new Game(attemps, range);
                }
                catch (Exception Ex)
                {
                    //messeger.error(Ex);
                    sender.send(new ErrorMessage(Ex));
                }


            }
            return new Game();



        }
    }
}
