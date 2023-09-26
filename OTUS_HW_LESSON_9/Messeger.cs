using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{

    public interface IMessage
    {
        public void sendMassage()
        {
            
        }
    }

    public class MessegeSender
    {

        public void send(IMessage message)
        {
            message.sendMassage();
        }
    }

    public class HelloMassage: IMessage
    {
        public void sendMassage()
        {
            Console.WriteLine("Привет! Это игра Угадай число");
        }
    }

    public class StartGameMassage : IMessage
    {
        public void sendMassage()
        {
            Console.WriteLine("Игра началась! Введи число!");
        }
    }

    public class SuccessMassage : IMessage
    {
        public  void sendMassage()
        {
            Console.WriteLine("Правильно! Поздравляю ты выйграл!");
        }
    }

    public class FailureMassage : IMessage
    {
        public void sendMassage()
        {
            Console.WriteLine("Попытки угадать закончились! Ты проиграл");
        }
    }

    public class AttempMassage : IMessage
    {
        public void sendMassage()
        {
            Console.WriteLine("Введите число попыток");
        }
    }

    public class RangeMassage : IMessage
    {
        public void sendMassage()
        {
            Console.WriteLine("Введите диапазон чисел");
        }
    }
    public class ErrorMessage : IMessage
    {
        Exception _ex;


        public ErrorMessage(Exception Ex)
        {
                _ex = Ex;
        }
        public void sendMassage()
        {
                Console.WriteLine($"Что то не так! {_ex.Message}Попробуй еще раз! ");
        }
    }
    

    public class RetryTakingValueAndAttemp : IMessage
    {
        string _value;
        int _attemps;
        public RetryTakingValueAndAttemp(string value, int attemps)
        {
                _value = value;
                _attemps = attemps;
        }
        public void sendMassage()
        {
            Console.WriteLine($"Нет! Загаданное число {_value}! Осталось {_attemps} попыток!");
        }
    }

    

    //public class Messeger
    //{

    //    public void helloMessege()
    //    {
    //        Console.WriteLine("Привет! Это игра Угадай число");
    //    }

    //    public void startGame()
    //    {
    //        Console.WriteLine("Игра началась! Введи число!");

    //    }

    //    public void retryTakingValue(string value)

    //    {
    //        Console.WriteLine($"Нет! Загаданное число {value}! Попробуй еще раз!");
    //    }
    //    public void retryTakingValueAndAttemp(string value, int attemps)

    //    {
    //        Console.WriteLine($"Нет! Загаданное число {value}! Осталось {attemps} попыток!");
    //    }

    //    public void success() 
    //    {
    //        Console.WriteLine("Правильно! Поздравляю ты выйграл!");
    //    }

    //    public void failure()
    //    {
    //        Console.WriteLine("Попытки угадать закончились! Ты проиграл");
    //    }   

    //    public void error(Exception Ex)
    //    {
    //        Console.WriteLine($"Что то не так! \n{Ex.Message} \nПопробуй еще раз! ");
    //    }


    //    public void attemp()
    //    {
    //        Console.WriteLine("Введите число попыток");
    //    }

    //    public void range()
    //    {
    //        Console.WriteLine("Введите диапазон чисел");
    //    }

    //}

}
