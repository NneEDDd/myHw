using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace gomoku
{
    abstract class Piece:PictureBox
    {
        private static readonly int Image_width = 50;
        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x-Image_width/2, y-Image_width / 2);
            this.Size = new Size(Image_width, Image_width);
        }
    }
}
