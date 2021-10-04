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

        List <Shuriken> shurikens = new List<Shuriken>(); //list of obstacles
        int newShurikenCounter = 0;                       //timer to add obstacle
        int shurikenX = 700;
        int interval = 0;

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e) 
        {

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
    }
}
