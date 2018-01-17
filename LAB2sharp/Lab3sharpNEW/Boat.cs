using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    public class Boat: Water_transport, IComparable<Boat>, IEquatable<Boat>
    {
        public int CompareTo(Boat other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (MaxCountCargos != other.MaxCountCargos)
            {
                return MaxCountCargos.CompareTo(other.MaxCountCargos);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (BodyColor != other.BodyColor)
            {
                BodyColor.Name.CompareTo(other.BodyColor.Name);
            }
            return 0;
        }

        public bool Equals(Boat other)
        {
            if (other == null)
                return false;
            if (MaxSpeed != other.MaxSpeed)
                return false;
            if (MaxCountCargos != other.MaxCountCargos)
                return false;
            if (Weight != other.Weight)
                return false;
            if (BodyColor != other.BodyColor)
                return false;
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Boat boatObj = obj as Boat;
            if (boatObj == null)
                return false;
            else
                return Equals(boatObj);
        }
        public override int GetHashCode()
        {
            return MaxSpeed.GetHashCode();
        }

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

        public Boat(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 4)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountCargos = Convert.ToInt32(strs[1]);
                BodyColor = Color.FromName(strs[2]);
                Weight = Convert.ToInt32(strs[3]);
            }
           
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

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountCargos + ";" + BodyColor.Name + ";" + Weight;
        }
    }
}
