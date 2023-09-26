using OTUS_HW_LESSON_9;


//Messeger messeger = new Messeger();
//messeger.HelloMessege();

MessegeSender sender = new MessegeSender();
sender.Send(new HelloMassage());
Game game = new Game(sender);
Options options = new Options(game, sender);

game = options.GameConfigure();
game.StartGame();

// SRP - каждый класс отвечает за одну цель - meseger генерирует сообщения, Game - за игру , Options - настройка и запуск игры
// OCP - класс Messeger легко расширяется без необходимости изменения имеющихся классов
// LCP -
// ISP - 
// DIP - классы месседжера реализуют интерфейс IMessege 