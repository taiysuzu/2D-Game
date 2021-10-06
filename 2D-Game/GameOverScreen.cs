using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _2D_Game
{
    public partial class GameOverScreen : UserControl
    {
        public static int score;

        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //if exit button is pressed, exit game
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();               //if start button is pressed, start game
            f.Controls.Remove(this);
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            scoreLabel.Text += $"{score}";
            Refresh();
        }
    }
}
