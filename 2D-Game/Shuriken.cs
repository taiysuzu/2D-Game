using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2D_Game
{
    class Shuriken
    {
        public int x, y, speed, sizeX, sizeY;

        public Shuriken(int _x, int _y, int _speed, int _sizeX, int _sizeY)
        {
            x = _x;
            y = _y;
            speed = _speed;
            sizeX = _sizeX;
            sizeY = _sizeY;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }

        public bool Collision(Player player)
        {
            Rectangle playerRect = new Rectangle(player.x, player.y, player.size, player.size);

            Rectangle shurikenRect = new Rectangle(x, y, sizeX, sizeY);

            if (shurikenRect.IntersectsWith(playerRect))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
