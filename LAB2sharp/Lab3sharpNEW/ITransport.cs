using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2sharp
{
     public interface ITransport
    {
        void drawBoat(Graphics g);
        void moveBoat(Graphics g);
        void setPosition(int x, int y);
        void loadCargo(int count);
        int relieveCargo();
    }
}
