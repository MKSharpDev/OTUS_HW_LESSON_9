using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS_HW_LESSON_9
{
    //#region LCP messeger 
    //public abstract class Message
    //{
    //    private string _massage;
    //    public string Massage { get { return _massage; } set { _massage = value; } }
    //}

    //public class MessegeSender
    //{
    //    public void Send(Message message)
    //    {
    //        Console.WriteLine(message.Massage);
    //    }
    //}

    //public class HelloMassage : Message
    //{
    //    public HelloMassage()
    //    {
    //        this.Massage = "Привет! Это игра Угадай число";
    //    }
    //}

    //public class StartGameMassage : Message
    //{
    //    public StartGameMassage()
    //    {
    //        this.Massage = "Игра началась!Введи число!";
    //    }
    //}

    //public class SuccessMassage : Message
    //{
    //    public SuccessMassage()
    //    {
    //        this.Massage = "Правильно! Поздравляю ты выйграл!";
    //    }
    //}

    //public class FailureMassage : Message
    //{
    //    public FailureMassage()
    //    {
    //        this.Massage = "Попытки угадать закончились! Ты проиграл";
    //    }
    //}

    //public class AttempMassage : Message
    //{
    //    public AttempMassage()
    //    {
    //        this.Massage = "Введите число попыток";
    //    }
    //}

    //public class RangeMassage : Message
    //{
    //    public RangeMassage()
    //    {
    //        this.Massage = "Введите диапазон чисел";
    //    }
    //}
    //public class ErrorMessage : Message
    //{
    //    Exception _ex;
    //    public ErrorMessage(Exception Ex)
    //    {
    //        this._ex = Ex;
    //        this.Massage = $"Что то не так! {_ex.Message}Попробуй еще раз! ";
    //    }
    //}


    //public class RetryTakingValueAndAttemp : Message
    //{
    //    string _value;
    //    int _attemps;
    //    public RetryTakingValueAndAttemp(string value, int attemps)
    //    {
    //        _value = value;
    //        _attemps = attemps;
    //        this.Massage = $"Нет! Загаданное число {_value}! Осталось {_attemps} попыток!"; ;

    //    }
    //}

    //public class OptionsMessage : Message
    //{
    //    public OptionsMessage()
    //    {
    //        this.Massage = "Хотите настроить игру? y/n";
    //    }
    //}

    //public class Warning : Message
    //{
    //    public Warning()
    //    {
    //        this.Massage = "Что то не так! Возможно вы неправильно ввели!";
    //    }
    //}

    //#endregion


    #region ISP messeger 
    public interface IMessage
    {
        string Massage { get; }
    }
    public interface ISender
    {
        public void Send(IMessage message) { }
    }
    public class MessegeSender : ISender
    {

        public void Send(IMessage message)
        {
            Console.WriteLine(message.Massage);
        }
    }

    public class HelloMassage : IMessage
    {
        string IMessage.Massage { get { return "Привет! Это игра Угадай число"; } }


    }

    public class StartGameMassage : IMessage
    {
        string IMessage.Massage { get { return "Игра началась!Введи число!"; } }



    }

    public class SuccessMassage : IMessage
    {
        string IMessage.Massage { get { return "Правильно! Поздравляю ты выйграл!"; } }


    }

    public class FailureMassage : IMessage
    {
        string IMessage.Massage { get { return "Попытки угадать закончились! Ты проиграл"; } }


    }

    public class AttempMassage : IMessage
    {
        string IMessage.Massage { get { return "Введите число попыток"; } }


    }

    public class RangeMassage : IMessage
    {
        string IMessage.Massage { get { return "Введите диапазон чисел"; } }

    }
    public class ErrorMessage : IMessage
    {
        Exception _ex;
        public ErrorMessage(Exception Ex)
        {
            _ex = Ex;
        }
        string IMessage.Massage { get { return $"Что то не так! {_ex.Message}Попробуй еще раз! "; } }



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

    }

    public class OptionsMessage : IMessage
    {
        string IMessage.Massage { get { return "Хотите настроить игру? y/n"; } }


    }

    public class Warning : IMessage
    {
        string IMessage.Massage { get { return "Что то не так! Возможно вы неправильно ввели!"; } }

    }
    #endregion

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