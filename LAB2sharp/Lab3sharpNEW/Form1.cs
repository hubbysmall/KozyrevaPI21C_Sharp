
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3sharpNEW
{
    public partial class Form1 : Form
    {
        Port port;
        additionalForm addiForm;

		private Logger log;

        public Form1()
        {
            InitializeComponent();
			log = LogManager.GetCurrentClassLogger();
            port = new Port(4);
            for(int i=0; i<4; i++)
            {
                listBox1.Items.Add("subport" + i);
            }
            listBox1.SelectedIndex = port.getCurrentDock;
            Draw();

        }

        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics grf = Graphics.FromImage(bmp);
                port.DrawItAll(grf, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }
        }





        private void putBoatInDock_Click(object sender, EventArgs e)
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

        private void putShipInDock_Click(object sender, EventArgs e)
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

        private void TakeBoat_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                string stage = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
					try
					{
						var boat = port.PutOutDock(Convert.ToInt32(maskedTextBox1.Text));                   
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        boat.setPosition(5, 45);
                        boat.drawBoat(gr);
                        pictureBox2.Image = bmp;
                        Draw();
					}
					catch(ParkingIndexOutOfRangeException ex)
					{
						MessageBox.Show(ex.Message, "No such a place", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Common error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}


				}
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            port.LevelUp();
            listBox1.SelectedIndex = port.getCurrentDock;
            Draw();
			log.Info("Going to next level:" + port.getCurrentDock);
			if(port.getCurrentDock==2)
				log.Warn("It was the level before the last one:" + port.getCurrentDock);
		}

        private void previousBtn_Click(object sender, EventArgs e)
        {
            port.LevelDown();
            listBox1.SelectedIndex = port.getCurrentDock;
            Draw();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            addiForm = new additionalForm();
            addiForm.AddEvent(addBoat);
            addiForm.Show();
        }

        private void addBoat(ITransport boat) {
            if (boat != null)
            {
				try
				{
					int place = port.PutInDock(boat);
					Draw();
                    MessageBox.Show("Ваше место:" + place);
				}
				catch(ParkingOverflowException ex)
				{
					MessageBox.Show(ex.Message,"Overflow", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Common error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}



			}
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Незагрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }       

    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (port.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Несохранилось", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            port.Sort();
        }
    }
}
