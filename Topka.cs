using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Topka
    {
       public int SpeedX { get; set; }
       public int SpeedY { get; set; }
       public PictureBox Ball { get; set; }
       private Form1 f;

       public Topka(Size golemina,int X,int Y)
       {
           SpeedX = X;
           SpeedY = Y;
           Ball = new PictureBox();
           Ball.Size = golemina;
       }

      public void resetBall()
       {
           //picBoxBall.Location = new Point(ClientSize.Width / 2 - picBoxBall.Width / 2, ClientSize.Height / 2 - picBoxBall.Height / 2);

       }
       
    }
}
