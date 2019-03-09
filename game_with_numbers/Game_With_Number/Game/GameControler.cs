using Game_With_Number.Game;
using Game_With_Number.Unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number
{
    class GameControler
    {

        GameScreen myGame = new GameScreen(10, 10);
        public void StartGame()
        {
            InitGame();
            StartGameLoop();
        }

        public void InitGame()
        {
            myGame.SetHero(new Hero(5, 9, "BatMan"));
            Random rnd = new Random();
            int enemyNr = 0;
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(enemyNr, rnd.Next(0, 10), rnd.Next(0, 10), "enemy" + enemyNr));
                enemyNr++;
            }
        }

        public void StartGameLoop()
        {
            bool needToRender = true;
            do
            {
                Console.Clear();
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            myGame.MoveHeroRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myGame.MoveHeroLeft();
                            break;
                    }
                }
                myGame.render();
                System.Threading.Thread.Sleep(250);

            } while (needToRender);
        }










    }
}
