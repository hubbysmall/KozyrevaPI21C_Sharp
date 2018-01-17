using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3sharpNEW
{
    public abstract class Water_transport: ITransport
    {
        protected float startPosX;
        protected float startPosY;
        protected int countCargos;
        public virtual int MaxCountCargos
        {
            protected set;
            get;
        }
        public virtual int MaxSpeed
        {
            protected set;
            get;
        }
        public Color BodyColor
        {
            protected set;
            get;
        }
        public virtual double Weight
        {
            protected set;
            get;
        }
        public abstract void drawBoat(Graphics g);
        public abstract void moveBoat(Graphics g);

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void loadCargo(int count)
        {
            if (countCargos + count < MaxCountCargos)
            {
                countCargos += count;
            }
        }

        public int relieveCargo()
        {
            int count = countCargos;
            countCargos = 0;
            return count;
        } 

        public virtual void setMainColor(Color color)
        {
            BodyColor = color;
        }

        public abstract string getInfo();
    }
}
