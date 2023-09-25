using OTUS_HW_LESSON_9;


//Messeger messeger = new Messeger();
//messeger.helloMessege();

MessegeSender sender = new MessegeSender();
sender.send(new HelloMassage());

Options options = new Options();
Game game = options.gameBuild();
game.StartGame();