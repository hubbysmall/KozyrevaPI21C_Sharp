﻿using System;
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
    public partial class additionalForm : Form
    {
        ITransport boat = null;
        public ITransport getBoat { get { return boat; } }
        private event myDel eventAddBoat;
        public void AddEvent(myDel ev)
        {
            if (eventAddBoat == null)
                eventAddBoat = new myDel(ev);
            else
                eventAddBoat += ev;
        }

        public additionalForm()
        {
            InitializeComponent();
            redCol.MouseDown += colorPanel_MouseDown;
            greenCol.MouseDown += colorPanel_MouseDown;
            pinkCol.MouseDown += colorPanel_MouseDown;
            blueCol.MouseDown += colorPanel_MouseDown;
            whiteCol.MouseDown += colorPanel_MouseDown;
            brownCol.MouseDown += colorPanel_MouseDown;
            purpleCol.MouseDown += colorPanel_MouseDown;
            greyCol.MouseDown += colorPanel_MouseDown;

            CancelBtn.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void Boatlabel_MouseDown(object sender, MouseEventArgs e)
        {
            Boatlabel.DoDragDrop(Boatlabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void SetBoatpanel_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Лодка":
                    boat = new Boat(8, 5, 10, Color.Brown);
                    break;
                case "Парусник":
                    boat = new Sailing_ship(10, 20, 30, Color.Brown, true, Color.LightPink);
                    break;
            }
            DrawBoat(); 
        }

        private void SetBoatpanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void DrawBoat()
        {
            if (boat != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                boat.setPosition(10, 30);
                boat.drawBoat(gr);
                pictureBox1.Image = bmp;
            }
        }

        private void mainColLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void mainColLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
                boat.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawBoat();
            }
        }

        private void colorPanel_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void addColLabel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void addColLabel_DragDrop(object sender, DragEventArgs e)
        {
            if (boat != null)
            {
 //               boat.SetDopColor((Color)e.Data.GetData(typeof(Color)));
 // как определить метод дополнительного цвета
                if(boat is Sailing_ship)
                {
                    (boat as Sailing_ship).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawBoat();
                }

                
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (eventAddBoat != null)
                eventAddBoat(boat);
            Close();
        }

        private void Shiplabel_MouseDown(object sender, MouseEventArgs e)
        {
            Shiplabel.DoDragDrop(Shiplabel.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
