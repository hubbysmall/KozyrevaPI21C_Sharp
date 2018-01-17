using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    public class Sailing_ship: Boat
    {
        private bool sail;
        private Color addColor;
        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value <= 50)
                    base.MaxSpeed = value;
                else
                {
                    base.MaxSpeed = 17;


                }
            }
        }

        public override int MaxCountCargos
        {
            get
            {
                return base.MaxCountCargos;
            }

            protected set
            {
                if (value > 0 && value <= 5000)
                    base.MaxCountCargos = value;
                else
                    base.MaxCountCargos = 2000;

            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {
                if (value > 0 & value <= 7000)
                    base.Weight = value;
                else
                    base.Weight = 2500;

            }
        }



        public Sailing_ship(int maxSpeed, int maxCount_cargo, double weight, Color color, bool Sail, Color addiColor) :
            base(maxSpeed, maxCount_cargo, weight, color)
        {
            this.sail = Sail;
            this.addColor = addiColor;

        }

        public Sailing_ship(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 6)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountCargos = Convert.ToInt32(strs[1]);
                Weight = Convert.ToDouble(strs[2]);
                BodyColor = Color.FromName(strs[3]);
                sail = Convert.ToBoolean(strs[4]);
                addColor = Color.FromName(strs[5]);
                
            }
        }



        protected override void drawSailingShip(Graphics g)
        {
            base.drawSailingShip(g);
            if (sail)
            {
                Pen pen = new Pen(addColor);
                Brush brWhite = new SolidBrush(addColor);
                g.FillPie(brWhite, startPosX + 25, startPosY - 40, 50, 70, -90, 180);
                g.DrawArc(pen, startPosX + 25, startPosY - 40, 50, 70, -90, 180);
            }
        }

        public void SetDopColor(Color color)
        {
            addColor = color;
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountCargos + ";" + Weight + ";" + BodyColor.Name + ";" + sail + ";"+
                addColor.Name;
        }

    }
}
