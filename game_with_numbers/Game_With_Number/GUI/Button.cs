using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.GUI
{
    class Button : GuiObject
    {
        private Frame _buttonFrame;
        private TextLine _label;

        private bool _isActive;

        public Button(int x, int y, int width, int height, string label) : base(x, y, width, height)
        {
            _buttonFrame = new Frame(x, y, width, height, '.');
            _label = new TextLine(x + 1, y + Height / 2, Width - 2, label);
        }

        public override void Render()
        {
            if (_isActive)
            {
                _buttonFrame.ActiveFrame();
            }
            else
            {
                _buttonFrame.InActiveFrame();
            }

            _label.Render();
        }


        public void SetActive()
        {
            _isActive = true;
        }


        public void SetInActive()
        {
            _isActive = false;
        }



    }
}
