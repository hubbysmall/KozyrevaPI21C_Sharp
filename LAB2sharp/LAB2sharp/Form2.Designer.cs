namespace LAB2sharp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonMainColor = new System.Windows.Forms.Button();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.textBoxLoad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.buttonMakeBoat = new System.Windows.Forms.Button();
            this.buttonMakeShip = new System.Windows.Forms.Button();
            this.buttonMOve = new System.Windows.Forms.Button();
            this.checkBoxSailOn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(665, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonMainColor
            // 
            this.buttonMainColor.Location = new System.Drawing.Point(19, 253);
            this.buttonMainColor.Name = "buttonMainColor";
            this.buttonMainColor.Size = new System.Drawing.Size(75, 23);
            this.buttonMainColor.TabIndex = 1;
            this.buttonMainColor.Text = "Main_Color";
            this.buttonMainColor.UseVisualStyleBackColor = true;
            this.buttonMainColor.Click += new System.EventHandler(this.buttonMainColor_Click);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Location = new System.Drawing.Point(19, 283);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddColor.TabIndex = 2;
            this.buttonAddColor.Text = "Add_Color";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.buttonAddColor_Click);
            // 
            // textBoxLoad
            // 
            this.textBoxLoad.Location = new System.Drawing.Point(172, 256);
            this.textBoxLoad.Name = "textBoxLoad";
            this.textBoxLoad.Size = new System.Drawing.Size(41, 20);
            this.textBoxLoad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MaxLoad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(172, 280);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(41, 20);
            this.textBoxWeight.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MaxSpeed";
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(172, 306);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(41, 20);
            this.textBoxSpeed.TabIndex = 8;
            // 
            // buttonMakeBoat
            // 
            this.buttonMakeBoat.Location = new System.Drawing.Point(389, 249);
            this.buttonMakeBoat.Name = "buttonMakeBoat";
            this.buttonMakeBoat.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeBoat.TabIndex = 9;
            this.buttonMakeBoat.Text = "Boat";
            this.buttonMakeBoat.UseVisualStyleBackColor = true;
            this.buttonMakeBoat.Click += new System.EventHandler(this.buttonMakeBoat_Click);
            // 
            // buttonMakeShip
            // 
            this.buttonMakeShip.Location = new System.Drawing.Point(389, 273);
            this.buttonMakeShip.Name = "buttonMakeShip";
            this.buttonMakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeShip.TabIndex = 10;
            this.buttonMakeShip.Text = "SailShip";
            this.buttonMakeShip.UseVisualStyleBackColor = true;
            this.buttonMakeShip.Click += new System.EventHandler(this.buttonMakeShip_Click);
            // 
            // buttonMOve
            // 
            this.buttonMOve.Location = new System.Drawing.Point(389, 299);
            this.buttonMOve.Name = "buttonMOve";
            this.buttonMOve.Size = new System.Drawing.Size(75, 23);
            this.buttonMOve.TabIndex = 11;
            this.buttonMOve.Text = "Move";
            this.buttonMOve.UseVisualStyleBackColor = true;
            this.buttonMOve.Click += new System.EventHandler(this.buttonMOve_Click);
            // 
            // checkBoxSailOn
            // 
            this.checkBoxSailOn.AutoSize = true;
            this.checkBoxSailOn.Location = new System.Drawing.Point(245, 258);
            this.checkBoxSailOn.Name = "checkBoxSailOn";
            this.checkBoxSailOn.Size = new System.Drawing.Size(58, 17);
            this.checkBoxSailOn.TabIndex = 12;
            this.checkBoxSailOn.Text = "Sail on";
            this.checkBoxSailOn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 349);
            this.Controls.Add(this.checkBoxSailOn);
            this.Controls.Add(this.buttonMOve);
            this.Controls.Add(this.buttonMakeShip);
            this.Controls.Add(this.buttonMakeBoat);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLoad);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.buttonMainColor);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMainColor;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.TextBox textBoxLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Button buttonMakeBoat;
        private System.Windows.Forms.Button buttonMakeShip;
        private System.Windows.Forms.Button buttonMOve;
        private System.Windows.Forms.CheckBox checkBoxSailOn;
    }
}