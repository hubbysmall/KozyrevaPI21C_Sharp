using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2sharp
{
    public class Boat: Water_transport
    {
        public virtual int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value <= 10)
                    base.MaxSpeed = value;
                else
                {
                    base.MaxSpeed = 5; //тогда по умолчанию 


                }
            }
        }

        public virtual int MaxCountCargos
        {
            get
            {
                return base.MaxCountCargos;
            }

            protected set
            {
                if (value > 0 && value <= 500)
                    base.MaxCountCargos = value;
                else
                    base.MaxCountCargos = 300;

            }
        }

        public virtual double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 0 & value <= 1000)
                    base.Weight = value;
                else
                    base.Weight = 500;

            }
        }

        public Boat(int maxSpeed, int maxCountCargo,
            double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountCargos = maxCountCargo;
            this.BodyColor = color;
            this.Weight = weight;
            this.countCargos = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }

        public override void moveBoat(Graphics g)
        {

            startPosX += (MaxSpeed * 50 / (float)Weight) /
                (countCargos == 0 ? 1 : countCargos);
            drawBoat(g);

        }
        public override void drawBoat(Graphics g)
        {
            drawSailingShip(g);
        }
        protected virtual void drawSailingShip(Graphics g)
        {
            Pen pen = new Pen(BodyColor);
            Brush brBrown = new SolidBrush(BodyColor);
            g.FillPie(brBrown, startPosX, startPosY, 70, 50, 0, 180);
            g.DrawArc(pen, startPosX, startPosY, 70, 50, 0, 180);

        }
    }
}
