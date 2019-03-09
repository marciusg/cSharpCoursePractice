using Game_With_Number.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.Game.MyGameGui
{
    class CreditWindow : Window
    {
        private TextBlock _CreditInfo;
        private Button _returnButton;


        public CreditWindow() : base(10, 2, 60, 20, '*', "Credits")
        {

            _CreditInfo = new TextBlock(13, 6, Width - 2, "First try by Martynas_G","\n", "2019-03-03");
            _returnButton = new Button(34, 14, 16, 5, "BACK");

        }
             

               
        public override void Render()
        {
           
            base.Render();
            _CreditInfo.Render();
            _returnButton.SetActive();
            _returnButton.Render();
           

         }



        public void ShowCredits()
        {
            Render(); 
            bool needToRender = true;
            do
            {
                             
                while (Console.KeyAvailable)
                {   
                    ConsoleKeyInfo pressedChar = Console.ReadKey(true);
                    switch (pressedChar.Key)
                    {
                        case ConsoleKey.Escape:
                            needToRender = false;
                            break;
                        case ConsoleKey.Enter:
                            needToRender = false;
                            break;
                    }
                } 
               
            } while (needToRender);
        }


    }
}
