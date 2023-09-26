using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{

    public interface IMessage
    {    
        string Massage { get ;  }
    }

    public class MessegeSender
    {

        public void Send(IMessage message)
        {
            Console.WriteLine(message.Massage);
        }
    }

    public class HelloMassage: IMessage
    {
        string IMessage.Massage { get { return "Привет! Это игра Угадай число"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Привет! Это игра Угадай число");
        //}
    }

    public class StartGameMassage : IMessage
    {
        string IMessage.Massage { get { return "Игра началась!Введи число!"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Игра началась! Введи число!");
        //}

    }

    public class SuccessMassage : IMessage
    {
        string IMessage.Massage { get { return "Правильно! Поздравляю ты выйграл!"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Правильно! Поздравляю ты выйграл!");
        //}
    }

    public class FailureMassage : IMessage
    {
        string IMessage.Massage { get { return "Попытки угадать закончились! Ты проиграл"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Попытки угадать закончились! Ты проиграл");
        //}
    }

    public class AttempMassage : IMessage
    {
        string IMessage.Massage { get { return "Введите число попыток"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Введите число попыток");
        //}
    }

    public class RangeMassage : IMessage
    {
        string IMessage.Massage { get { return "Введите диапазон чисел"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Введите диапазон чисел");
        //}
    }
    public class ErrorMessage : IMessage
    {
        Exception _ex;
        public ErrorMessage(Exception Ex)
        {
            _ex = Ex;
        }
        string IMessage.Massage { get { return $"Что то не так! {_ex.Message}Попробуй еще раз! "; } }


        //public void SendMassage()
        //{
        //        Console.WriteLine($"Что то не так! {_ex.Message}Попробуй еще раз! ");
        //}
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
        string IMessage.Massage { get { return $"Нет! Загаданное число {_value}! Осталось {_attemps} попыток!"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine($"Нет! Загаданное число {_value}! Осталось {_attemps} попыток!");
        //}
    }

    public class OptionsMessage : IMessage
    {
        string IMessage.Massage { get { return "Хотите настроить игру? y/n"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Хотите настроить игру? y/n");
        //}
    }

    public class Warning : IMessage
    {
        string IMessage.Massage { get { return "Что то не так! Возможно вы неправильно ввели!"; } }

        //public void SendMassage()
        //{
        //    Console.WriteLine("Что то не так! Возможно вы неправильно ввели!");
        //}
    }


    //public class Messeger
    //{

    //    public void HelloMessege()
    //    {
    //        Console.WriteLine("Привет! Это игра Угадай число");
    //    }

    //    public void StartGame()
    //    {
    //        Console.WriteLine("Игра началась! Введи число!");

    //    }

    //    public void RetryTakingValue(string value)

    //    {
    //        Console.WriteLine($"Нет! Загаданное число {value}! Попробуй еще раз!");
    //    }
    //    public void RetryTakingValueAndAttemp(string value, int attemps)

    //    {
    //        Console.WriteLine($"Нет! Загаданное число {value}! Осталось {attemps} попыток!");
    //    }

    //    public void Success() 
    //    {
    //        Console.WriteLine("Правильно! Поздравляю ты выйграл!");
    //    }

    //    public void Failure()
    //    {
    //        Console.WriteLine("Попытки угадать закончились! Ты проиграл");
    //    }   

    //    public void Error(Exception Ex)
    //    {
    //        Console.WriteLine($"Что то не так! \n{Ex.Message} \nПопробуй еще раз! ");
    //    }


    //    public void Attemp()
    //    {
    //        Console.WriteLine("Введите число попыток");
    //    }

    //    public void Range()
    //    {
    //        Console.WriteLine("Введите диапазон чисел");
    //    }

    //}

}
