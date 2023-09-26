using OTUS_HW_LESSON_9;


//Messeger messeger = new Messeger();
//messeger.helloMessege();

MessegeSender sender = new MessegeSender();
sender.send(new HelloMassage());

Options options = new Options();
Game game = options.gameBuild();
game.StartGame();

// SRP - каждый класс отвечает за одну цель - meseger генерирует сообщения, Game - за игру , Options - настройка и запуск игры
// OCP - класс Messeger легко расширяется без необходимости изменения имеющихся классов
// LCP -
// ISP -
// DIP - классы месседжера реализуют интерфейс IMessege 