using Level_24_Paper_Rock_Scissor;

bool looper = true; //locks the game into a loop. The game will continue until the window is closed. 
Game game = new Game(); 

while (true)
{
    game.CollectInputs();
    game.GameCheck();
    game.Scoreboard();
}