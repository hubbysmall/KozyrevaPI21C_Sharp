using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        private Meat meats;

        private spice spices;

        private vegs Vegtbls;

        private rice rices;

        private Tap waterTap;

        private Knife knife;

        private Pan pan;

        private Stove stove;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            waterTap = new Tap();
            knife = new Knife();
            pan = new Pan();
            stove = new Stove();
        }

        private void tap_open_CheckedChanged(object sender, EventArgs e)
        {
            if (tap_open.Checked) {
                waterTap.State = true;
            }
        }

        private void tap_close_CheckedChanged(object sender, EventArgs e)
        {
            if(tap_close.Checked)
                waterTap.State = false;
        }

        private void wash_rice_Click(object sender, EventArgs e)
        {
            if (numericRice.Value>0) {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                rices = new rice();
                rices.Dirty = 0;
                numericRice.Enabled = false;
                tap_close.Checked = true;
                MessageBox.Show("Рис помыли, можно резать мясо и овощи", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Риса нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cut_meat_Click(object sender, EventArgs e)
        {
          /*  if (meats == null || Vegtbls == null) {
                MessageBox.Show("Мяса или овощей нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            if (numericMeat.Value == 0 || numericVegs.Value==0)
            {
                MessageBox.Show("Мяса или овощей нет, что резать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            numericMeat.Enabled = false;
            numericVegs.Enabled = false;
            knife.cut(meats, Vegtbls);
            Add_meat.Enabled = true;
            add_vegs.Enabled = true;
            MessageBox.Show("Мясо и овощи порезаны, можно закладывать их в сковороду, потом добавить рис, специи и воду", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (numericSpice.Value!= 0) {
                add_spice.Enabled = true;
                numericSpice.Enabled = false;
            }
            add_rice.Enabled = true;
        }

        private void Add_meat_Click(object sender, EventArgs e) {
            meats = new Meat();
            pan.Add_meat(meats);
            MessageBox.Show("Мясо добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void add_vegs_Click(object sender, EventArgs e) {
            Vegtbls = new vegs();
            pan.Add_vegs(Vegtbls);
            MessageBox.Show("Овощи добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void add_rice_Click(object sender, EventArgs e) {
            rices = new rice();
            pan.Add_rice(rices);
            MessageBox.Show("Рис добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void add_spice_Click(object sender, EventArgs e) {
            spices = new spice();
            pan.Add_spice(spices);
            MessageBox.Show("Рис добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void add_water_Click(object sender, EventArgs e)
        {
            if (!waterTap.State) {
                MessageBox.Show("Кран закрыт, как наливать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < 3; ++i)
            {
                pan.Add_water(waterTap.get_water());

            }
            tap_close.Checked = true;
            MessageBox.Show("Воду залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void put_pan_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            turnOn.Enabled = true;
            MessageBox.Show("Сковорода на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void turnOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = turnOn.Checked;
        }

        private void cook_Click(object sender, EventArgs e)
        {
            if (!pan.Ready_to_go)
            {
                MessageBox.Show("У нас не все готово к варке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (!stove.State) {
                MessageBox.Show("Нужно включить плиту!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.Is_ready()) {
                take_pan.Enabled = true;
                turnOn.Checked = false;
                MessageBox.Show("Готово!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
