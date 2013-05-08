using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApplication1
{
    class Palka
    {
        public PictureBox Pbox { get; set; }
        public Size Golemina { get; set; }
        public bool AI { get; set; }  //Dali e bot
        private Form1 f;

        public Palka(Form1 f,Size Golemina)
        {
            Pbox =new PictureBox();
            this.Pbox.Size = Golemina;
            this.Golemina = Golemina;
            this.f = f;
            AI = false;
        }

        public Palka() { }

        public void playerMovement(Point m)
        {


            if (f.PointToClient(m).Y >= Pbox.Height / 2 && f.PointToClient(m).Y <= f.ClientSize.Height - Pbox.Height / 2)
            {
                int playerX = Pbox.Width / 2;
                int playerY = f.PointToClient(m).Y - Pbox.Height / 2;

                Pbox.Location = new Point(playerX, playerY);
            }
        }

        public void aiMovement(Point m,Topka t)
        {
            if (t.SpeedX > 0)
            {
                Pbox.Location = new Point(f.ClientSize.Width - (Pbox.Width + Pbox.Width / 2), t.Ball.Location.Y - Pbox.Height / 2);
            }
        }

        public void player2Movement()  
        {
            //Funkcija za Player2
        }

    }
}
