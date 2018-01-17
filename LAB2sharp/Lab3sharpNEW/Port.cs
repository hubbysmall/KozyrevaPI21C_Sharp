using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    class Port
    {
        Docks<ITransport> port;

        int countDocks = 20;
        int DockWidth = 210;
        int DockHeight = 100;




        public Port()
        {
            port = new Docks<ITransport>(countDocks, null);
        }

        public int PutInDock(ITransport ship)
        {
            return port + ship;
        }

        public ITransport PutOutDock(int dockNumber)
        {
            return port - dockNumber;
        }

        public void DrawDocks(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);
            for (int i = 0; i < countDocks / 5; i++)
            {
                g.DrawLine(pen, DockWidth * i, 0, DockWidth * i, 400);
                for (int j = 0; j < 5; ++j)
                {
                    g.DrawLine(pen, (DockWidth * i), (DockHeight * j), (DockWidth * i) + 100, (DockHeight * j));
                }
            }
        }

        public void DrawItAll(Graphics g, int width, int height)
        {
            DrawDocks(g);
            for (int i = 0; i < countDocks; i++)
            {
                var ship = port.getShip(i);
                if (ship != null)
                {

                    ship.setPosition(5 + i / 5 * DockWidth + 5, i % 5 * DockHeight + 45);
                    ship.drawBoat(g);
                }

            }
        }

    }
}
