using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    public class Options
    {
        MessegeSender _sender;
        Game _game;
        public Options(Game game , MessegeSender sender) 
        {
            _sender = sender;
            _game  = game;
        }
        public Game GameConfigure()
        {
            bool sasuccess = false;


            
            while (!sasuccess)
            {
                try
                {
                    _sender.Send(new OptionsMessage());
                    string startGameConfig = Console.ReadLine();
                    if (startGameConfig.ToLower() == "y")
                    {

                        _sender.Send(new AttempMassage());
                        _game.Attemps = int.Parse(Console.ReadLine());

                        _sender.Send(new RangeMassage());
                        _game.Range = int.Parse(Console.ReadLine());
                        sasuccess = true;

                        return _game;
                    }
                    else if (startGameConfig.ToLower() == "n")
                    {
                        sasuccess = true;
                        return _game;
                    }
                    else
                    {
                        _sender.Send(new Warning());
                    }
                }
                catch (Exception Ex)
                {
                    _sender.Send(new ErrorMessage(Ex));
                }


            }
            return new Game(_sender);
        }
    }
}
