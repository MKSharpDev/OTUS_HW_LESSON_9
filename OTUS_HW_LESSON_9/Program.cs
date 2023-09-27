using OTUS_HW_LESSON_9;


//Messeger messeger = new Messeger();
//messeger.HelloMessege();

MessegeSender sender = new MessegeSender();
sender.Send(new HelloMassage());
Options options = new Options().GameConfigure(sender);

Game game = new Game(options, sender);

game.StartGame();

// SRP - каждый класс отвечает за одну цель - meseger генерирует сообщения, Game - за игру , Options - настройка 
// OCP - класс Messeger легко расширяется без необходимости изменения имеющихся классов
// LCP -
// ISP - 
// DIP - классы месседжера реализуют интерфейс IMessege 