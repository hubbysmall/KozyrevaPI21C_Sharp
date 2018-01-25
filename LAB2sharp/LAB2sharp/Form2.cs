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
        Port port;

        public Form2()
        {
            InitializeComponent();
            port = new Port();
            Draw();

        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grf = Graphics.FromImage(bmp);
            port.DrawItAll(grf, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void putShipInDock_Click_1(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();
            if (colDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var sail_boat = new Sailing_ship(20, 1000, 1500, colDialog.Color, true, dialogDop.Color);
                    int place = port.PutInDock(sail_boat);
                    Draw();
                    MessageBox.Show("Парусник в доке с номером:" + place);
                }

            }
        }

        private void putBoatInDock_Click_1(object sender, EventArgs e)
        {
            ColorDialog colDialog = new ColorDialog();
            if (colDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var boat = new Boat(8, 180, 200, colDialog.Color);
                int place = port.PutInDock(boat);
                Draw();
                MessageBox.Show("Судно в доке с номером:" + place);
            }
        }
        private void TakeBoat_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var boat = port.PutOutDock(Convert.ToInt32(maskedTextBox1.Text));

                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.setPosition(5, 45);
                boat.drawBoat(gr);
                pictureBox2.Image = bmp;
                Draw();
            }
        }
    }
}
