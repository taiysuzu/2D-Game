/* Taiyo Suzuki
 * October 4 2021
 * Basic 2D game
 */
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);                  //open menu screen on startup
        }
    }
}
