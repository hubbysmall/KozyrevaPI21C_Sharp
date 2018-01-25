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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.putBoatInDock = new System.Windows.Forms.Button();
            this.putShipInDock = new System.Windows.Forms.Button();
            this.TakeBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 406);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TakeBoat);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(758, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 281);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Забратьт из дока";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 178);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 28);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(20, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // putBoatInDock
            // 
            this.putBoatInDock.Location = new System.Drawing.Point(764, 99);
            this.putBoatInDock.Name = "putBoatInDock";
            this.putBoatInDock.Size = new System.Drawing.Size(112, 35);
            this.putBoatInDock.TabIndex = 5;
            this.putBoatInDock.Text = "Поставить лодку в док";
            this.putBoatInDock.UseVisualStyleBackColor = true;
            this.putBoatInDock.Click += new System.EventHandler(this.putBoatInDock_Click_1);
            // 
            // putShipInDock
            // 
            this.putShipInDock.Location = new System.Drawing.Point(764, 58);
            this.putShipInDock.Name = "putShipInDock";
            this.putShipInDock.Size = new System.Drawing.Size(112, 35);
            this.putShipInDock.TabIndex = 6;
            this.putShipInDock.Text = "Парусник в док";
            this.putShipInDock.UseVisualStyleBackColor = true;
            this.putShipInDock.Click += new System.EventHandler(this.putShipInDock_Click_1);
            // 
            // TakeBoat
            // 
            this.TakeBoat.Location = new System.Drawing.Point(6, 68);
            this.TakeBoat.Name = "TakeBoat";
            this.TakeBoat.Size = new System.Drawing.Size(105, 23);
            this.TakeBoat.TabIndex = 8;
            this.TakeBoat.Text = "Забрать";
            this.TakeBoat.UseVisualStyleBackColor = true;
            this.TakeBoat.Click += new System.EventHandler(this.TakeBoat_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 433);
            this.Controls.Add(this.putShipInDock);
            this.Controls.Add(this.putBoatInDock);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button putBoatInDock;
        private System.Windows.Forms.Button putShipInDock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button TakeBoat;
    }
}