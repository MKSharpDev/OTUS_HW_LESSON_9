using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    public class Game
    {
        private int _attemps;
        private int _range;
        MessegeSender _sender;
        public int Attemps { get { return _attemps; } set { _attemps = value; } }

        public int Range { get { return _range; } set { _range = value; } }

        public Game(MessegeSender sender) 
        {
            _attemps = 10;
            _range = 100;
            _sender = sender;
    }

        public Game(int attemps, int range, MessegeSender sender) 
        { 
            _attemps = attemps;
            _range = range;
            _sender = sender;
        }

        public void StartGame()
        {
            Random random = new Random();
            bool endGame = false;
            int needed = random.Next(0, _range);


            //Messeger messeger = new Messeger();
            //MessegeSender sender = new MessegeSender();

            int attemp = _attemps;
            //messeger.startGame();
            _sender.Send(new StartGameMassage());

            while (!endGame)
            {
                try
                {
                    if(attemp == 0)
                    {
                        //messeger.failure();
                        endGame = true;
                        _sender.Send(new FailureMassage());
                        break;
                    }
                    int inn = int.Parse(Console.ReadLine());
                    if (needed == inn)
                    {
                        endGame = true;
                        //messeger.success();
                        _sender.Send(new SuccessMassage());
                       
                    }
                    else if (needed > inn)
                    {
                        //messeger.retryTakingValueAndAttemp("больше", --attemp);
                        _sender.Send(new RetryTakingValueAndAttemp("больше", --attemp));
                           
                        
                    }
                    else if (needed < inn)
                    {
                        //messeger.retryTakingValueAndAttemp("меньше", --attemp);
                        _sender.Send(new RetryTakingValueAndAttemp("меньше", --attemp));

                    }
                }
                catch (Exception Ex)
                {
                    _sender.Send(new ErrorMessage(Ex));
                    //messeger.error(Ex);
                }
            }
        }
    }
}
