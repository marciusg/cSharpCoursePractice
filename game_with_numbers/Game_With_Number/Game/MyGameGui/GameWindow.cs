using Game_With_Number.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Game.MyGameGui
{
    class GameWindow : Window
    {
        private TextBlock _gameTitle;
        public List <Button> AllButtons = new List<Button>();

        public GameWindow() : base(0, 0, 80, 24, '#', "Game Menu")
        {
            _gameTitle = new TextBlock(0, 4, Width - 2, "GAME WITH NUMBERS", "Beta v1.0");

            AllButtons.Add(new Button( 8, 15, 20, 5, "Start"));
            AllButtons.Add(new Button(30, 15, 20, 5, "Credit"));
            AllButtons.Add(new Button(52, 15, 20, 5, "Quit"));
            
        }

        public override void Render()
        {
            base.Render();
            
            _gameTitle.Render();
            AllButtons[0].Render();
            AllButtons[1].Render();
            AllButtons[2].Render();

           
        }

        public int ButtonNr()
        {
            int btnNr = AllButtons.Count - 1;
            return btnNr;
        }
    }
}
