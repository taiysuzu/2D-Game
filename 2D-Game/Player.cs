using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Game
{
    class Player
    {
        public int x, y, speed, size;
        public Player(int _x, int _y, int _speed, int _size)
        {
            x = _x;
            y = _y;
            speed = _speed;
            size = _size;
        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;
            }
            if (direction == "down")
            {
                y += speed;
            }
        }
    }
}
