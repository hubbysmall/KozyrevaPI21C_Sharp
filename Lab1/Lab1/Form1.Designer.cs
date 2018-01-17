namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.indredients = new System.Windows.Forms.GroupBox();
            this.meat = new System.Windows.Forms.Label();
            this.Rice = new System.Windows.Forms.Label();
            this.Spice = new System.Windows.Forms.Label();
            this.Vegs = new System.Windows.Forms.Label();
            this.numericMeat = new System.Windows.Forms.NumericUpDown();
            this.numericRice = new System.Windows.Forms.NumericUpDown();
            this.numericSpice = new System.Windows.Forms.NumericUpDown();
            this.numericVegs = new System.Windows.Forms.NumericUpDown();
            this.Tap = new System.Windows.Forms.GroupBox();
            this.tap_close = new System.Windows.Forms.RadioButton();
            this.tap_open = new System.Windows.Forms.RadioButton();
            this.wash_rice = new System.Windows.Forms.Button();
            this.groupKnife = new System.Windows.Forms.GroupBox();
            this.Cut_meat = new System.Windows.Forms.Button();
            this.cut_vegs = new System.Windows.Forms.Button();
            this.groupPan = new System.Windows.Forms.GroupBox();
            this.add_vegs = new System.Windows.Forms.Button();
            this.Add_meat = new System.Windows.Forms.Button();
            this.add_spice = new System.Windows.Forms.Button();
            this.add_rice = new System.Windows.Forms.Button();
            this.add_water = new System.Windows.Forms.Button();
            this.groupStove = new System.Windows.Forms.GroupBox();
            this.turnOn = new System.Windows.Forms.CheckBox();
            this.indredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegs)).BeginInit();
            this.Tap.SuspendLayout();
            this.groupKnife.SuspendLayout();
            this.groupPan.SuspendLayout();
            this.groupStove.SuspendLayout();
            this.SuspendLayout();
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
            this.indredients.Location = new System.Drawing.Point(12, 12);
            this.indredients.Name = "indredients";
            this.indredients.Size = new System.Drawing.Size(119, 186);
            this.indredients.TabIndex = 1;
            this.indredients.TabStop = false;
            this.indredients.Text = "Ингредиенты";
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
            // Rice
            // 
            this.Rice.AutoSize = true;
            this.Rice.Location = new System.Drawing.Point(6, 68);
            this.Rice.Name = "Rice";
            this.Rice.Size = new System.Drawing.Size(26, 13);
            this.Rice.TabIndex = 1;
            this.Rice.Text = "Рис";
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
            // Vegs
            // 
            this.Vegs.AutoSize = true;
            this.Vegs.Location = new System.Drawing.Point(6, 153);
            this.Vegs.Name = "Vegs";
            this.Vegs.Size = new System.Drawing.Size(42, 13);
            this.Vegs.TabIndex = 3;
            this.Vegs.Text = "Овощи";
            // 
            // numericMeat
            // 
            this.numericMeat.Location = new System.Drawing.Point(46, 29);
            this.numericMeat.Name = "numericMeat";
            this.numericMeat.Size = new System.Drawing.Size(30, 20);
            this.numericMeat.TabIndex = 4;
            // 
            // numericRice
            // 
            this.numericRice.Location = new System.Drawing.Point(46, 61);
            this.numericRice.Name = "numericRice";
            this.numericRice.Size = new System.Drawing.Size(30, 20);
            this.numericRice.TabIndex = 5;
            // 
            // numericSpice
            // 
            this.numericSpice.Location = new System.Drawing.Point(56, 103);
            this.numericSpice.Name = "numericSpice";
            this.numericSpice.Size = new System.Drawing.Size(30, 20);
            this.numericSpice.TabIndex = 6;
            // 
            // numericVegs
            // 
            this.numericVegs.Location = new System.Drawing.Point(54, 146);
            this.numericVegs.Name = "numericVegs";
            this.numericVegs.Size = new System.Drawing.Size(30, 20);
            this.numericVegs.TabIndex = 7;
            // 
            // Tap
            // 
            this.Tap.Controls.Add(this.wash_rice);
            this.Tap.Controls.Add(this.tap_open);
            this.Tap.Controls.Add(this.tap_close);
            this.Tap.Location = new System.Drawing.Point(147, 12);
            this.Tap.Name = "Tap";
            this.Tap.Size = new System.Drawing.Size(82, 186);
            this.Tap.TabIndex = 2;
            this.Tap.TabStop = false;
            this.Tap.Text = "Кран";
            this.Tap.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tap_close
            // 
            this.tap_close.AutoSize = true;
            this.tap_close.Location = new System.Drawing.Point(6, 27);
            this.tap_close.Name = "tap_close";
            this.tap_close.Size = new System.Drawing.Size(63, 17);
            this.tap_close.TabIndex = 2;
            this.tap_close.TabStop = true;
            this.tap_close.Text = "Закрыт";
            this.tap_close.UseVisualStyleBackColor = true;
            // 
            // tap_open
            // 
            this.tap_open.AutoSize = true;
            this.tap_open.Location = new System.Drawing.Point(6, 50);
            this.tap_open.Name = "tap_open";
            this.tap_open.Size = new System.Drawing.Size(63, 17);
            this.tap_open.TabIndex = 3;
            this.tap_open.TabStop = true;
            this.tap_open.Text = "Открыт";
            this.tap_open.UseVisualStyleBackColor = true;
            // 
            // wash_rice
            // 
            this.wash_rice.Location = new System.Drawing.Point(11, 90);
            this.wash_rice.Name = "wash_rice";
            this.wash_rice.Size = new System.Drawing.Size(57, 75);
            this.wash_rice.TabIndex = 4;
            this.wash_rice.Text = "Помыть рис";
            this.wash_rice.UseVisualStyleBackColor = true;
            // 
            // groupKnife
            // 
            this.groupKnife.Controls.Add(this.cut_vegs);
            this.groupKnife.Controls.Add(this.Cut_meat);
            this.groupKnife.Location = new System.Drawing.Point(254, 12);
            this.groupKnife.Name = "groupKnife";
            this.groupKnife.Size = new System.Drawing.Size(92, 186);
            this.groupKnife.TabIndex = 3;
            this.groupKnife.TabStop = false;
            this.groupKnife.Text = "Нож";
            // 
            // Cut_meat
            // 
            this.Cut_meat.Location = new System.Drawing.Point(6, 27);
            this.Cut_meat.Name = "Cut_meat";
            this.Cut_meat.Size = new System.Drawing.Size(80, 63);
            this.Cut_meat.TabIndex = 0;
            this.Cut_meat.Text = "Порезать мясо";
            this.Cut_meat.UseVisualStyleBackColor = true;
            // 
            // cut_vegs
            // 
            this.cut_vegs.Location = new System.Drawing.Point(6, 103);
            this.cut_vegs.Name = "cut_vegs";
            this.cut_vegs.Size = new System.Drawing.Size(80, 63);
            this.cut_vegs.TabIndex = 1;
            this.cut_vegs.Text = "Порезать овощи";
            this.cut_vegs.UseVisualStyleBackColor = true;
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
            this.groupPan.TabIndex = 4;
            this.groupPan.TabStop = false;
            this.groupPan.Text = "Сковорода";
            // 
            // add_vegs
            // 
            this.add_vegs.Location = new System.Drawing.Point(6, 103);
            this.add_vegs.Name = "add_vegs";
            this.add_vegs.Size = new System.Drawing.Size(80, 63);
            this.add_vegs.TabIndex = 1;
            this.add_vegs.Text = "Добавить овощи";
            this.add_vegs.UseVisualStyleBackColor = true;
            // 
            // Add_meat
            // 
            this.Add_meat.Location = new System.Drawing.Point(6, 27);
            this.Add_meat.Name = "Add_meat";
            this.Add_meat.Size = new System.Drawing.Size(80, 63);
            this.Add_meat.TabIndex = 0;
            this.Add_meat.Text = "Добавить мясо";
            this.Add_meat.UseVisualStyleBackColor = true;
            // 
            // add_spice
            // 
            this.add_spice.Location = new System.Drawing.Point(92, 27);
            this.add_spice.Name = "add_spice";
            this.add_spice.Size = new System.Drawing.Size(80, 63);
            this.add_spice.TabIndex = 2;
            this.add_spice.Text = "Добавить специи";
            this.add_spice.UseVisualStyleBackColor = true;
            // 
            // add_rice
            // 
            this.add_rice.Location = new System.Drawing.Point(92, 103);
            this.add_rice.Name = "add_rice";
            this.add_rice.Size = new System.Drawing.Size(80, 63);
            this.add_rice.TabIndex = 3;
            this.add_rice.Text = "Добавить рис";
            this.add_rice.UseVisualStyleBackColor = true;
            // 
            // add_water
            // 
            this.add_water.Location = new System.Drawing.Point(178, 27);
            this.add_water.Name = "add_water";
            this.add_water.Size = new System.Drawing.Size(80, 63);
            this.add_water.TabIndex = 4;
            this.add_water.Text = "Добавить воду";
            this.add_water.UseVisualStyleBackColor = true;
            // 
            // groupStove
            // 
            this.groupStove.Controls.Add(this.turnOn);
            this.groupStove.Location = new System.Drawing.Point(280, 204);
            this.groupStove.Name = "groupStove";
            this.groupStove.Size = new System.Drawing.Size(262, 186);
            this.groupStove.TabIndex = 5;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 562);
            this.Controls.Add(this.groupStove);
            this.Controls.Add(this.groupPan);
            this.Controls.Add(this.groupKnife);
            this.Controls.Add(this.Tap);
            this.Controls.Add(this.indredients);
            this.Name = "Form1";
            this.Text = "И";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.indredients.ResumeLayout(false);
            this.indredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVegs)).EndInit();
            this.Tap.ResumeLayout(false);
            this.Tap.PerformLayout();
            this.groupKnife.ResumeLayout(false);
            this.groupPan.ResumeLayout(false);
            this.groupStove.ResumeLayout(false);
            this.groupStove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox indredients;
        private System.Windows.Forms.Label Vegs;
        private System.Windows.Forms.Label Spice;
        private System.Windows.Forms.Label Rice;
        private System.Windows.Forms.Label meat;
        private System.Windows.Forms.NumericUpDown numericVegs;
        private System.Windows.Forms.NumericUpDown numericSpice;
        private System.Windows.Forms.NumericUpDown numericRice;
        private System.Windows.Forms.NumericUpDown numericMeat;
        private System.Windows.Forms.GroupBox Tap;
        private System.Windows.Forms.Button wash_rice;
        private System.Windows.Forms.RadioButton tap_open;
        private System.Windows.Forms.RadioButton tap_close;
        private System.Windows.Forms.GroupBox groupKnife;
        private System.Windows.Forms.Button cut_vegs;
        private System.Windows.Forms.Button Cut_meat;
        private System.Windows.Forms.GroupBox groupPan;
        private System.Windows.Forms.Button add_vegs;
        private System.Windows.Forms.Button Add_meat;
        private System.Windows.Forms.Button add_spice;
        private System.Windows.Forms.Button add_rice;
        private System.Windows.Forms.Button add_water;
        private System.Windows.Forms.GroupBox groupStove;
        private System.Windows.Forms.CheckBox turnOn;
    }
}

