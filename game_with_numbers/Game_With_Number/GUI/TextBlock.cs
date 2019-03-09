using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_With_Number.GUI
{
    class TextBlock : GuiObject
    {
        readonly List<TextLine> _textblocks = new List<TextLine>();
        


        public TextBlock (int x, int y, int width, params string [] text): base(x,y, width, text.Length)
        {
            for (int i = 0; i < text.Length; i++)
                {
                _textblocks.Add(new TextLine(x, y + i, width, text[i]));
                }
            //  = new List<TextLine> { 1 , 1 , };
        }



        public override void Render()
        {
            foreach(TextLine item in _textblocks)
            {
                item.Render();
            }
        }

    }
}
