using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2sharp
{
    public partial class Form2 : Form
    {
        Timer timer;
        Color color;
        Color addColor;
        int maxSpeed;
        int maxCountCargo;
        int weight;
        private ITransport interFace;

        public Form2()
        {
            InitializeComponent();
            color = Color.White;
            addColor = Color.Yellow;
            maxSpeed = 30;
            maxCountCargo = 3000;
            weight = 5000;
            buttonMainColor.BackColor = color;
            buttonAddColor.BackColor = addColor;

        }

        private void buttonMainColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                color = cd.Color;
                buttonMainColor.BackColor = color;
            }

        }

        private void buttonAddColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                addColor = cd.Color;
                buttonAddColor.BackColor = addColor;
            }

        }

        private bool Check_input() {
            if (!int.TryParse(textBoxLoad.Text, out maxCountCargo))
                return false;
            if (!int.TryParse(textBoxSpeed.Text, out maxSpeed))
                return false;
            if (!int.TryParse(textBoxWeight.Text, out weight))
                return false;
            return true;
        }

        private void buttonMakeBoat_Click(object sender, EventArgs e)
        {
            if (Check_input()) {
                interFace = new Boat(maxSpeed, maxCountCargo, weight,color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                interFace.drawBoat(gr);
                pictureBox1.Image = bmp;
            }
        }

      

        private void buttonMOve_Click(object sender, EventArgs e)
        {
            if (interFace != null)
            {
                
                timer = new Timer();
                timer.Tick += new EventHandler(timer_Tick);
                timer.Interval = 25;
                timer.Start();
                
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
          Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
          Graphics gr = Graphics.FromImage(bmp);
          interFace.moveBoat(gr);
          pictureBox1.Image = bmp;
        }

        private void buttonMakeShip_Click(object sender, EventArgs e)
        {
            if (Check_input())
            {
                interFace = new Sailing_ship(maxSpeed, maxCountCargo, weight, color,checkBoxSailOn.Checked, addColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                interFace.drawBoat(gr);
                pictureBox1.Image = bmp;
            }
            else
            {
                interFace = new Sailing_ship(30, 3000, 5000, Color.Black, true, Color.Yellow);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                interFace.drawBoat(gr);
                pictureBox1.Image = bmp;
            }
        }
    }
}
