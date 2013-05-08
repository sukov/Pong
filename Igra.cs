using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Igra
    {
        public Timer GameTime { get; set; }
        public Palka Player1 { get; set; }
        public Palka Player2 { get; set; }
        public Topka Topka1 { get; set; }
        private Form1 f;


        public Igra(Form1 f,Palka Player1,Palka Player2,Topka Topka1)
        {
            this.f = f;
            this.Topka1 = Topka1;
            this.Player1 = Player1;
            this.Player2 = Player2;
            GameTime = new Timer();//Initializes the Timer

            GameTime.Enabled = true;//Enables the Timer
            GameTime.Interval = 1;//Set the timer's interval in miliseconds

            GameTime.Tick += new EventHandler(gameTime_Tick);//Creates the Timer's Tick event
            
        }




       public void padlleCollision()
        {
            if (Topka1.Ball.Bounds.IntersectsWith(Player2.Pbox.Bounds))
            {
                Topka1.SpeedX = -Topka1.SpeedX;
            }

            if (Topka1.Ball.Bounds.IntersectsWith(Player1.Pbox.Bounds))
            {
                Topka1.SpeedX = -Topka1.SpeedX;
            }

        }

       public void gameAreaCollisions()
       {
           if (Topka1.Ball.Location.Y > f.ClientSize.Height - Topka1.Ball.Height || Topka1.Ball.Location.Y < 0)
           {
               Topka1.SpeedY = -Topka1.SpeedY;
           }
           else if (Topka1.Ball.Location.X > f.ClientSize.Width)
           {
               Topka1.resetBall();
           }
           else if (Topka1.Ball.Location.X < 0)
           {
               Topka1.resetBall();
           }
       }

        
        void gameTime_Tick(object sender, EventArgs e)
        {
            Topka1.Ball.Location = new Point(Topka1.Ball.Location.X + Topka1.SpeedX, Topka1.Ball.Location.Y + Topka1.SpeedY);
            gameAreaCollisions();//Checks for collisions with the form's border
            padlleCollision();//Checks for collisions with the padlles
            Player1.playerMovement(Cursor.Position);//Updates the player's position
            if (Player2.AI)
                Player2.aiMovement(Cursor.Position, Topka1);//Updates the ai's position
            else
                Player2.player2Movement();
            
            
        }
        

    }
}
