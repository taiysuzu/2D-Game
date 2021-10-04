using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Game
{
    class Shuriken
    {
        public int x, y, speed;

        public Shuriken(int _x, int _y, int _speed)
        {
            x = _x;
            y = _y;
            speed = _speed;
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


     }
}
