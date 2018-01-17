namespace Lab3sharpNEW
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
            this.putBoatInDock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.putShipInDock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TakeBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // putBoatInDock
            // 
            this.putBoatInDock.Location = new System.Drawing.Point(812, 25);
            this.putBoatInDock.Name = "putBoatInDock";
            this.putBoatInDock.Size = new System.Drawing.Size(70, 58);
            this.putBoatInDock.TabIndex = 0;
            this.putBoatInDock.Text = "Поставить лодку в док";
            this.putBoatInDock.UseVisualStyleBackColor = true;
            this.putBoatInDock.Click += new System.EventHandler(this.putBoatInDock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 412);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // putShipInDock
            // 
            this.putShipInDock.Location = new System.Drawing.Point(812, 90);
            this.putShipInDock.Name = "putShipInDock";
            this.putShipInDock.Size = new System.Drawing.Size(70, 60);
            this.putShipInDock.TabIndex = 2;
            this.putShipInDock.Text = "Парусник в док";
            this.putShipInDock.UseVisualStyleBackColor = true;
            this.putShipInDock.Click += new System.EventHandler(this.putShipInDock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TakeBoat);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(790, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 281);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забратьт из дока";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(72, 28);
            this.maskedTextBox1.Mask = "00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(20, 20);
            this.maskedTextBox1.TabIndex = 0;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(7, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 171);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // TakeBoat
            // 
            this.TakeBoat.Location = new System.Drawing.Point(22, 68);
            this.TakeBoat.Name = "TakeBoat";
            this.TakeBoat.Size = new System.Drawing.Size(75, 23);
            this.TakeBoat.TabIndex = 3;
            this.TakeBoat.Text = "Забрать";
            this.TakeBoat.UseVisualStyleBackColor = true;
            this.TakeBoat.Click += new System.EventHandler(this.TakeBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.putShipInDock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.putBoatInDock);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button putBoatInDock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button putShipInDock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button TakeBoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

