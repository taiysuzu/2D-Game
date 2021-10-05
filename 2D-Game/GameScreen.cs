using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2D_Game
{
    public partial class GameScreen : UserControl
    {
        bool upArrowDown, downArrowDown = false; //player control keys

        Random randGen = new Random();

        List<Shuriken> shurikens = new List<Shuriken>(); //shuriken values (list, counter etc.)
        int newShurikenCounter = 0;
        int shurikenX = 700;
        int shurikenY = 130;
        int shurikenSpeed = 8;
        int shurikenSizeX = 40;
        int shurikenSizeY = 7;

        Player player1;//player values
        int playerSpeed = 5;
        int playerSize = 60;
        int playerStartX = 10;
        int playerStartY = 120;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e) //initial game values / on start setup
        {
            player1 = new Player(playerStartX, playerStartY, playerSpeed, playerSize);
            CreateShuriken(shurikenX, shurikenY);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            newShurikenCounter++;
            foreach (Shuriken shuriken in shurikens) //update location of obstacles
            {
                shuriken.Move("left");
            }
            if (shurikens[0].x + shurikens[0].sizeX <= 0)
            {
                shurikens.RemoveAt(0);
            }

            if (upArrowDown == true && player1.y >= 0) //update location of player
            {
                player1.Move("up");
            }
            else if (downArrowDown == true && player1.y + player1.size <= this.Height)
            {
                player1.Move("down");
            }

            if (newShurikenCounter == 10)//add shuriken if it is time
            {
                shurikenY = randGen.Next(1, 293);
                CreateShuriken(shurikenX, shurikenY);
                newShurikenCounter = 0;
            }

            foreach (Shuriken shuriken in shurikens)   //check for collisions, if there is one, end game and display game over screen
            {
                if (shuriken.Collision(player1) == true)
                {
                    Form f = this.FindForm();               
                    f.Controls.Remove(this);
                    GameOverScreen gos = new GameOverScreen();
                    f.Controls.Add(gos);
                }
            }
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {   //draw player
            e.Graphics.DrawImage(_2D_Game.Properties.Resources.ninja, player1.x, player1.y, player1.size, player1.size);

            foreach (Shuriken shuriken in shurikens)
            {//draw shuriken
                e.Graphics.DrawImage(_2D_Game.Properties.Resources.kunai, shuriken.x, shuriken.y, shurikenSizeX, shurikenSizeY);
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)              //player key down check
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)              //player key up check
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

        public void CreateShuriken(int x, int y)
        {//create a new obstacle and add it to the list
            Shuriken shuriken = new Shuriken(x, y, shurikenSpeed, shurikenSizeX, shurikenSizeY);
            shurikens.Add(shuriken);
        }
    }
}
