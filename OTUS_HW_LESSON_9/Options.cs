using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    public class Options
    {
        private int _attemps;
        private int _range;
        public int Attemps { get { return _attemps; } set { _attemps = value; } }

        public int Range { get { return _range; } set { _range = value; } }


        public static int AttemptsByDefault = 5;
        public static int RangeByDefault = 100;
        public Options()
        {
            _attemps = AttemptsByDefault;
            _range = RangeByDefault;
        }


        public Options GameConfigure(MessegeSender sender)
        {
            bool sasuccess = false;
            Options options = new Options();



            while (!sasuccess)
            {
                try
                {
                    sender.Send(new OptionsMessage());
                    string startGameConfig = Console.ReadLine();
                    if (startGameConfig.ToLower() == "y")
                    {

                        sender.Send(new AttempMassage());
                        options.Attemps = int.Parse(Console.ReadLine());

                        sender.Send(new RangeMassage());
                        options.Range = int.Parse(Console.ReadLine());
                        sasuccess = true;

                        return options;
                    }
                    else if (startGameConfig.ToLower() == "n")
                    {
                        sasuccess = true;
                        return options;
                    }
                    else
                    {
                        sender.Send(new Warning());
                    }
                }
                catch (Exception Ex)
                {
                    sender.Send(new ErrorMessage(Ex));
                }


            }
            return options;
        }
    }
}
