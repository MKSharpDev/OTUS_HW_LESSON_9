using OTUS_HW_LESSON_9;


//Messeger messeger = new Messeger();
//messeger.HelloMessege();

MessegeSender sender = new MessegeSender();
sender.Send(new HelloMassage());
Options options = new Options().GameConfigure(sender);

Game game = new Game(options, sender);

game.StartGame();

// SRP - каждый класс отвечает за одну цель - meseger генерирует сообщения, Game - за игру , Options - настройка.
// При замене модуля Messager, программа продолжает корректно работать.
// OCP - класс Messeger легко расширяется без необходимости изменения имеющихся классов
// LCP - реализация месенджера через классы, при котором метод Send работая с классом Message, корректно работает со всеми наследниками
// ISP - реализация месенджера через простые интерфейсы
// DIP - классы месседжера реализуют интерфейс IMessege 
