namespace Lab1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tap = new System.Windows.Forms.GroupBox();
            this.wash_rice = new System.Windows.Forms.Button();
            this.tap_open = new System.Windows.Forms.RadioButton();
            this.tap_close = new System.Windows.Forms.RadioButton();
            this.indredients = new System.Windows.Forms.GroupBox();
            this.numericVegs = new System.Windows.Forms.NumericUpDown();
            this.numericSpice = new System.Windows.Forms.NumericUpDown();
            this.numericRice = new System.Windows.Forms.NumericUpDown();
            this.numericMeat = new System.Windows.Forms.NumericUpDown();
            this.Vegs = new System.Windows.Forms.Label();
            this.Spice = new System.Windows.Forms.Label();
            this.Rice = new System.Windows.Forms.Label();
            this.meat = new System.Windows.Forms.Label();
            this.groupKnife = new System.Windows.Forms.GroupBox();
            this.Cut_meat_vegs = new System.Windows.Forms.Button();
            this.groupPan = new System.Windows.Forms.GroupBox();
            this.add_water = new System.Windows.Forms.Button();
            this.add_rice = new System.Windows.Forms.Button();
            this.add_spice = new System.Windows.Forms.Button();
            this.add_vegs = new System.Windows.Forms.Button();
            this.Add_meat = new System.Windows.Forms.Button();
            this.groupStove = new System.Windows.Forms.GroupBox();
            this.turnOn = new System.Windows.Forms.CheckBox();
            this.put_pan = new System.Windows.Forms.Button();
            this.cook = new System.Windows.Forms.Button();
            this.take_pan = new System.Windows.Forms.Button();
            this.Tap.SuspendLayout();
            this.indredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMeat)).BeginInit();
            this.groupKnife.SuspendLayout();
            this.groupPan.SuspendLayout();
            this.groupStove.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tap
            // 
            this.Tap.Controls.Add(this.wash_rice);
            this.Tap.Controls.Add(this.tap_open);
            this.Tap.Controls.Add(this.tap_close);
            this.Tap.Location = new System.Drawing.Point(12, 12);
            this.Tap.Name = "Tap";
            this.Tap.Size = new System.Drawing.Size(82, 186);
            this.Tap.TabIndex = 3;
            this.Tap.TabStop = false;
            this.Tap.Text = "Кран";
            // 
            // wash_rice
            // 
            this.wash_rice.Location = new System.Drawing.Point(11, 90);
            this.wash_rice.Name = "wash_rice";
            this.wash_rice.Size = new System.Drawing.Size(57, 75);
            this.wash_rice.TabIndex = 4;
            this.wash_rice.Text = "Помыть рис";
            this.wash_rice.UseVisualStyleBackColor = true;
            this.wash_rice.Click += new System.EventHandler(this.wash_rice_Click);
            // 
            // tap_open
            // 
            this.tap_open.AutoSize = true;
            this.tap_open.Location = new System.Drawing.Point(6, 50);
            this.tap_open.Name = "tap_open";
            this.tap_open.Size = new System.Drawing.Size(63, 17);
            this.tap_open.TabIndex = 3;
            this.tap_open.Text = "Открыт";
            this.tap_open.UseVisualStyleBackColor = true;
            this.tap_open.CheckedChanged += new System.EventHandler(this.tap_open_CheckedChanged);
            // 
            // tap_close
            // 
            this.tap_close.AutoSize = true;
            this.tap_close.Checked = true;
            this.tap_close.Location = new System.Drawing.Point(6, 27);
            this.tap_close.Name = "tap_close";
            this.tap_close.Size = new System.Drawing.Size(63, 17);
            this.tap_close.TabIndex = 2;
            this.tap_close.TabStop = true;
            this.tap_close.Text = "Закрыт";
            this.tap_close.UseVisualStyleBackColor = true;
            this.tap_close.CheckedChanged += new System.EventHandler(this.tap_close_CheckedChanged);
            // 
            // indredients
            // 
            this.indredients.Controls.Add(this.numericVegs);
            this.indredients.Controls.Add(this.numericSpice);
            this.indredients.Controls.Add(this.numericRice);
            this.indredients.Controls.Add(this.numericMeat);
            this.indredients.Controls.Add(this.Vegs);
            this.indredients.Controls.Add(this.Spice);
            this.indredients.Controls.Add(this.Rice);
            this.indredients.Controls.Add(this.meat);
            this.indredients.Location = new System.Drawing.Point(100, 12);
            this.indredients.Name = "indredients";
            this.indredients.Size = new System.Drawing.Size(119, 186);
            this.indredients.TabIndex = 4;
            this.indredients.TabStop = false;
            this.indredients.Text = "Ингредиенты";
            // 
            // numericVegs
            // 
            this.numericVegs.Location = new System.Drawing.Point(54, 146);
            this.numericVegs.Name = "numericVegs";
            this.numericVegs.Size = new System.Drawing.Size(30, 20);
            this.numericVegs.TabIndex = 7;
            // 
            // numericSpice
            // 
            this.numericSpice.Location = new System.Drawing.Point(56, 103);
            this.numericSpice.Name = "numericSpice";
            this.numericSpice.Size = new System.Drawing.Size(30, 20);
            this.numericSpice.TabIndex = 6;
            // 
            // numericRice
            // 
            this.numericRice.Location = new System.Drawing.Point(46, 61);
            this.numericRice.Name = "numericRice";
            this.numericRice.Size = new System.Drawing.Size(30, 20);
            this.numericRice.TabIndex = 5;
            // 
            // numericMeat
            // 
            this.numericMeat.Location = new System.Drawing.Point(46, 29);
            this.numericMeat.Name = "numericMeat";
            this.numericMeat.Size = new System.Drawing.Size(30, 20);
            this.numericMeat.TabIndex = 4;
            // 
            // Vegs
            // 
            this.Vegs.AutoSize = true;
            this.Vegs.Location = new System.Drawing.Point(6, 153);
            this.Vegs.Name = "Vegs";
            this.Vegs.Size = new System.Drawing.Size(42, 13);
            this.Vegs.TabIndex = 3;
            this.Vegs.Text = "Овощи";
            // 
            // Spice
            // 
            this.Spice.AutoSize = true;
            this.Spice.Location = new System.Drawing.Point(6, 110);
            this.Spice.Name = "Spice";
            this.Spice.Size = new System.Drawing.Size(44, 13);
            this.Spice.TabIndex = 2;
            this.Spice.Text = "Специи";
            // 
            // Rice
            // 
            this.Rice.AutoSize = true;
            this.Rice.Location = new System.Drawing.Point(6, 68);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(26, 13);
            this.Rice.TabIndex = 1;
            this.Rice.Text = "Рис";
            // 
            // meat
            // 
            this.meat.AutoSize = true;
            this.meat.Location = new System.Drawing.Point(6, 31);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(34, 13);
            this.meat.TabIndex = 0;
            this.meat.Text = "Мясо";
            // 
            // groupKnife
            // 
            this.groupKnife.Controls.Add(this.Cut_meat_vegs);
            this.groupKnife.Location = new System.Drawing.Point(225, 12);
            this.groupKnife.Name = "groupKnife";
            this.groupKnife.Size = new System.Drawing.Size(92, 186);
            this.groupKnife.TabIndex = 5;
            this.groupKnife.TabStop = false;
            this.groupKnife.Text = "Нож";
            // 
            // Cut_meat_vegs
            // 
            this.Cut_meat_vegs.Location = new System.Drawing.Point(6, 27);
            this.Cut_meat_vegs.Name = "Cut_meat_vegs";
            this.Cut_meat_vegs.Size = new System.Drawing.Size(80, 139);
            this.Cut_meat_vegs.TabIndex = 0;
            this.Cut_meat_vegs.Text = "Порезать мясо и овощи";
            this.Cut_meat_vegs.UseVisualStyleBackColor = true;
            this.Cut_meat_vegs.Click += new System.EventHandler(this.Cut_meat_Click);
            // 
            // groupPan
            // 
            this.groupPan.Controls.Add(this.add_water);
            this.groupPan.Controls.Add(this.add_rice);
            this.groupPan.Controls.Add(this.add_spice);
            this.groupPan.Controls.Add(this.add_vegs);
            this.groupPan.Controls.Add(this.Add_meat);
            this.groupPan.Location = new System.Drawing.Point(12, 204);
            this.groupPan.Name = "groupPan";
            this.groupPan.Size = new System.Drawing.Size(262, 186);
            this.groupPan.TabIndex = 6;
            this.groupPan.TabStop = false;
            this.groupPan.Text = "Сковорода";
            // 
            // add_water
            // 
            this.add_water.Location = new System.Drawing.Point(178, 27);
            this.add_water.Name = "add_water";
            this.add_water.Size = new System.Drawing.Size(80, 63);
            this.add_water.TabIndex = 4;
            this.add_water.Text = "Добавить воду";
            this.add_water.UseVisualStyleBackColor = true;
            this.add_water.Click += new System.EventHandler(this.add_water_Click);
            // 
            // add_rice
            // 
            this.add_rice.Location = new System.Drawing.Point(92, 103);
            this.add_rice.Name = "add_rice";
            this.add_rice.Size = new System.Drawing.Size(80, 63);
            this.add_rice.TabIndex = 3;
            this.add_rice.Text = "Добавить рис";
            this.add_rice.UseVisualStyleBackColor = true;
            this.add_rice.Click += new System.EventHandler(this.add_rice_Click);
            // 
            // add_spice
            // 
            this.add_spice.Location = new System.Drawing.Point(92, 27);
            this.add_spice.Name = "add_spice";
            this.add_spice.Size = new System.Drawing.Size(80, 63);
            this.add_spice.TabIndex = 2;
            this.add_spice.Text = "Добавить специи";
            this.add_spice.UseVisualStyleBackColor = true;
            this.add_spice.Click += new System.EventHandler(this.add_spice_Click);
            // 
            // add_vegs
            // 
            this.add_vegs.Location = new System.Drawing.Point(6, 103);
            this.add_vegs.Name = "add_vegs";
            this.add_vegs.Size = new System.Drawing.Size(80, 63);
            this.add_vegs.TabIndex = 1;
            this.add_vegs.Text = "Добавить овощи";
            this.add_vegs.UseVisualStyleBackColor = true;
            this.add_vegs.Click += new System.EventHandler(this.add_vegs_Click);
            // 
            // Add_meat
            // 
            this.Add_meat.Location = new System.Drawing.Point(6, 27);
            this.Add_meat.Name = "Add_meat";
            this.Add_meat.Size = new System.Drawing.Size(80, 63);
            this.Add_meat.TabIndex = 0;
            this.Add_meat.Text = "Добавить мясо";
            this.Add_meat.UseVisualStyleBackColor = true;
            this.Add_meat.Click += new System.EventHandler(this.Add_meat_Click);
            // 
            // groupStove
            // 
            this.groupStove.Controls.Add(this.take_pan);
            this.groupStove.Controls.Add(this.cook);
            this.groupStove.Controls.Add(this.put_pan);
            this.groupStove.Controls.Add(this.turnOn);
            this.groupStove.Location = new System.Drawing.Point(280, 204);
            this.groupStove.Name = "groupStove";
            this.groupStove.Size = new System.Drawing.Size(223, 186);
            this.groupStove.TabIndex = 7;
            this.groupStove.TabStop = false;
            this.groupStove.Text = "Плита";
            // 
            // turnOn
            // 
            this.turnOn.AutoSize = true;
            this.turnOn.Location = new System.Drawing.Point(15, 27);
            this.turnOn.Name = "turnOn";
            this.turnOn.Size = new System.Drawing.Size(75, 17);
            this.turnOn.TabIndex = 0;
            this.turnOn.Text = "Включить";
            this.turnOn.UseVisualStyleBackColor = true;
            this.turnOn.CheckedChanged += new System.EventHandler(this.turnOn_CheckedChanged);
            // 
            // put_pan
            // 
            this.put_pan.Location = new System.Drawing.Point(15, 50);
            this.put_pan.Name = "put_pan";
            this.put_pan.Size = new System.Drawing.Size(145, 40);
            this.put_pan.TabIndex = 1;
            this.put_pan.Text = "Поставить сковороду";
            this.put_pan.UseVisualStyleBackColor = true;
            this.put_pan.Click += new System.EventHandler(this.put_pan_Click);
            // 
            // cook
            // 
            this.cook.Location = new System.Drawing.Point(15, 96);
            this.cook.Name = "cook";
            this.cook.Size = new System.Drawing.Size(145, 40);
            this.cook.TabIndex = 2;
            this.cook.Text = "Готовить";
            this.cook.UseVisualStyleBackColor = true;
            this.cook.Click += new System.EventHandler(this.cook_Click);
            // 
            // take_pan
            // 
            this.take_pan.Location = new System.Drawing.Point(15, 142);
            this.take_pan.Name = "take_pan";
            this.take_pan.Size = new System.Drawing.Size(145, 40);
            this.take_pan.TabIndex = 3;
            this.take_pan.Text = "Снять сковороду";
            this.take_pan.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 388);
            this.Controls.Add(this.groupStove);
            this.Controls.Add(this.groupPan);
            this.Controls.Add(this.groupKnife);
            this.Controls.Add(this.indredients);
            this.Controls.Add(this.Tap);
            this.Name = "Form2";
            this.Text = "Кухня";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Tap.ResumeLayout(false);
            this.Tap.PerformLayout();
            this.indredients.ResumeLayout(false);
            this.indredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMeat)).EndInit();
            this.groupKnife.ResumeLayout(false);
            this.groupPan.ResumeLayout(false);
            this.groupStove.ResumeLayout(false);
            this.groupStove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tap;
        private System.Windows.Forms.Button wash_rice;
        private System.Windows.Forms.RadioButton tap_open;
        private System.Windows.Forms.RadioButton tap_close;
        private System.Windows.Forms.GroupBox indredients;
        private System.Windows.Forms.NumericUpDown numericVegs;
        private System.Windows.Forms.NumericUpDown numericSpice;
        private System.Windows.Forms.NumericUpDown numericRice;
        private System.Windows.Forms.NumericUpDown numericMeat;
        private System.Windows.Forms.Label Vegs;
        private System.Windows.Forms.Label Spice;
        private System.Windows.Forms.Label Rice;
        private System.Windows.Forms.Label meat;
        private System.Windows.Forms.GroupBox groupKnife;
        private System.Windows.Forms.Button Cut_meat_vegs;
        private System.Windows.Forms.GroupBox groupPan;
        private System.Windows.Forms.Button add_water;
        private System.Windows.Forms.Button add_rice;
        private System.Windows.Forms.Button add_spice;
        private System.Windows.Forms.Button add_vegs;
        private System.Windows.Forms.Button Add_meat;
        private System.Windows.Forms.GroupBox groupStove;
        private System.Windows.Forms.Button take_pan;
        private System.Windows.Forms.Button cook;
        private System.Windows.Forms.Button put_pan;
        private System.Windows.Forms.CheckBox turnOn;
    }
}