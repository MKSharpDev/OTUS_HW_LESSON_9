using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    public class Game
    {
        int _attemps;
        int _range;
        public Game() 
        {
            _attemps = 10;
            _range = 100;
        }

        public Game(int attemps, int range) 
        { 
            _attemps = attemps;
            _range = range;
        }

        public void StartGame()
        {
            Random random = new Random();
            bool sasuccess = false;
            int needed = random.Next(0, _range);
            Messeger messeger = new Messeger();
            int attemp = _attemps;
            messeger.startGame();

            while (!sasuccess)
            {
                try
                {
                    if(attemp == 0)
                    {
                        messeger.failure();
                    }
                    int inn = int.Parse(Console.ReadLine());
                    if (needed == inn)
                    {
                        sasuccess = true;
                        messeger.success();
                    }
                    else if (needed > inn)
                    {
                        messeger.retryTakingValueAndAttemp("больше", --attemp);
                           
                        
                    }
                    else if (needed < inn)
                    {
                        messeger.retryTakingValueAndAttemp("меньше", --attemp);                      
                    }
                }
                catch (Exception Ex)
                {
                    messeger.error(Ex);
                }
            }
        }
    }
}
