using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2sharp
{
    class Sailing_ship : Boat
    {
        private bool sail;
        private Color addColor;

        public Sailing_ship(int maxSpeed, int maxCount_cargo, double weight, Color color, bool Sail, Color addiColor) : 
            base(maxSpeed, maxCount_cargo, weight, color)
        {
            this.sail = Sail;
            this.addColor = addiColor;

        }

        protected override void drawSailingShip(Graphics g)
        {
            base.drawSailingShip(g);
            if (sail) {
                Pen pen = new Pen(Color.White);
                Brush brWhite = new SolidBrush(Color.White);
                g.FillPie(brWhite, startPosX+25, startPosY-40, 50, 70, -90, 180);
                g.DrawArc(pen, startPosX+25, startPosY-40, 50, 70, -90, 180);
            }
        }
    }
}
