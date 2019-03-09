using Game_With_Number.Game.MyGameGui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Game
{
    class GUIControler
    {
        //MyGameGui.GameWindow gameWindow = new MyGameGui.GameWindow();



        public void ShowMenu()
        {
            GameWindow _gameWindow = new GameWindow();
            CreditWindow creditWindow = new CreditWindow();
            GameControler NewGame = new GameControler();
            _gameWindow.AllButtons[0].SetActive();
            _gameWindow.Render();
    

            int i = 0;
            int k = 0;
            int q = _gameWindow.ButtonNr();
            bool needToRender = true;
            do
            {
                //Console.Clear();
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);


                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.RightArrow:
                            k = i;
                            if (i == q)
                            {
                                i -= q;
                            }
                            else
                            {
                                i += 1;
                            }
                     
                            _gameWindow.AllButtons[i].SetActive();
                            _gameWindow.AllButtons[i].Render();
                            _gameWindow.AllButtons[k].SetInActive();
                            _gameWindow.AllButtons[k].Render();
                            break;
                        case ConsoleKey.LeftArrow:
                            k = i;
                            if (i == 0)
                            {
                                i += q;
                            }
                            else
                            {
                                i -= 1;
                            }
                            _gameWindow.AllButtons[i].SetActive();
                            _gameWindow.AllButtons[i].Render();
                            _gameWindow.AllButtons[k].SetInActive();
                            _gameWindow.AllButtons[k].Render();
                            break;
                        case ConsoleKey.Enter:
                            if (i == 0)
                            {
                                
                                NewGame.StartGame();
                                _gameWindow.Render();

                            }
                            else if (i == 1)
                            {
                                creditWindow.ShowCredits();
                                _gameWindow.Render();                            
                            }
                            else
                                needToRender = false;
                            break;
                    }
                }

            } while (needToRender);

        }

        
    }
}
