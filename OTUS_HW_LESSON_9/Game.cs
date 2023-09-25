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
            bool endGame = false;
            int needed = random.Next(0, _range);


            //Messeger messeger = new Messeger();
            MessegeSender sender = new MessegeSender();

            int attemp = _attemps;
            //messeger.startGame();
            sender.send(new StartGameMassage());

            while (!endGame)
            {
                try
                {
                    if(attemp == 0)
                    {
                        //messeger.failure();
                        endGame = true;
                        sender.send(new FailureMassage());
                        break;
                    }
                    int inn = int.Parse(Console.ReadLine());
                    if (needed == inn)
                    {
                        endGame = true;
                        //messeger.success();
                        sender.send(new SuccessMassage());
                       
                    }
                    else if (needed > inn)
                    {
                        //messeger.retryTakingValueAndAttemp("больше", --attemp);
                        sender.send(new RetryTakingValueAndAttemp("больше", --attemp));
                           
                        
                    }
                    else if (needed < inn)
                    {
                        //messeger.retryTakingValueAndAttemp("меньше", --attemp);
                        sender.send(new RetryTakingValueAndAttemp("меньше", --attemp));

                    }
                }
                catch (Exception Ex)
                {
                    sender.send(new ErrorMessage(Ex));
                    //messeger.error(Ex);
                }
            }
        }
    }
}
