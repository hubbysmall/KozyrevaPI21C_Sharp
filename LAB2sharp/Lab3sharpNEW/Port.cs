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
       List<Docks<ITransport>> port;

        int countDocks = 20;
        int DockWidth = 210;
        int DockHeight = 100;
        int currentDock;

        public int getCurrentDock { get { return currentDock; } }

        public Port(int countStages)
        {
            port = new List<Docks<ITransport>>(countStages);
            for(int i=0; i<countStages; i++)
            {
                Docks<ITransport> oneDockStage = new Docks<ITransport>(20,null);
                port.Add(oneDockStage);
            }
        }

        public int PutInDock(ITransport ship)
        {
            return port[currentDock] + ship;
        }

        public ITransport PutOutDock(int dockNumber)
        {
            return port[currentDock] - dockNumber;
        }

        public void LevelUp() {
            if (currentDock + 1 < port.Count)
                currentDock++;
        }

        public void LevelDown() {
            if (currentDock > 0)
                currentDock--;
        }

        public void DrawDocks(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 4);
            g.DrawString("L" + (currentDock), new Font("Arial", 30), new SolidBrush(Color.Blue), (countDocks / 5) * DockWidth - 70, 420);
            g.DrawRectangle(pen, 0, 0, (countDocks / 5) * DockWidth, 480);
            for(int i=0; i < countDocks / 5; i++)
            {
                for(int j=0; j<5; j++)
                {
                    g.DrawLine(pen, i * DockWidth, j * DockHeight, i * DockWidth + 110, j * DockHeight);
                    if (j < 4)
                    {
                        g.DrawString((i * 5 + j ).ToString(), new Font("Arial", 30), new SolidBrush(Color.Blue), i * DockWidth + 30, j * DockHeight + 20);
                    }
                }
                g.DrawLine(pen, i * DockWidth, 0, i * DockWidth, 400);
            }
         
        }

        public void DrawItAll(Graphics g, int width, int height)
        {
            DrawDocks(g);
            for (int i = 0; i < countDocks; i++)
            {
                var ship = port[currentDock][i];
                if (ship != null)
                {         
                    ship.setPosition(5 + i / 5 * DockWidth + 5, i % 5 * DockHeight + 45);
                    ship.drawBoat(g);
                }             
            }
        }



    }
}
