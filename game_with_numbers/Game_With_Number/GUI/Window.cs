using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.GUI
{
    class Window : GuiObject
    {
        private Frame _frame;
        private TextLine _title;

        public Window ( int x, int y, int width, int heigth, char framechar, string title) : base(x, y, width, heigth)
        {
            _frame = new Frame(x, y, width, heigth, framechar);
            if(title != "")
            {
                _title = new TextLine(x + 2, y, width - 2, title);
            }
        }


        public override void Render()
        {
            _frame.Render();
        }




    }
}
