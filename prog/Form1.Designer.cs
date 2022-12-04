namespace prog
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
            this.ipAdressBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prefixBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hostAdressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.networkAdressBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maxHostsBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ipAdressBox2 = new System.Windows.Forms.TextBox();
            this.ipAdressBox3 = new System.Windows.Forms.TextBox();
            this.ipAdressBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipAdressBox1
            // 
            this.ipAdressBox1.Location = new System.Drawing.Point(92, 101);
            this.ipAdressBox1.Name = "ipAdressBox1";
            this.ipAdressBox1.Size = new System.Drawing.Size(44, 20);
            this.ipAdressBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-адреса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(284, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "/";
            // 
            // prefixBox
            // 
            this.prefixBox.Location = new System.Drawing.Point(298, 102);
            this.prefixBox.Name = "prefixBox";
            this.prefixBox.Size = new System.Drawing.Size(32, 20);
            this.prefixBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Префікс";
            // 
            // maskBox
            // 
            this.maskBox.Location = new System.Drawing.Point(120, 199);
            this.maskBox.Name = "maskBox";
            this.maskBox.ReadOnly = true;
            this.maskBox.Size = new System.Drawing.Size(189, 20);
            this.maskBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Маска";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер вузла";
            // 
            // hostAdressBox
            // 
            this.hostAdressBox.Location = new System.Drawing.Point(120, 300);
            this.hostAdressBox.Name = "hostAdressBox";
            this.hostAdressBox.ReadOnly = true;
            this.hostAdressBox.Size = new System.Drawing.Size(190, 20);
            this.hostAdressBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Адреса мережі";
            // 
            // networkAdressBox
            // 
            this.networkAdressBox.Location = new System.Drawing.Point(120, 249);
            this.networkAdressBox.Name = "networkAdressBox";
            this.networkAdressBox.ReadOnly = true;
            this.networkAdressBox.Size = new System.Drawing.Size(189, 20);
            this.networkAdressBox.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Максимальна кількість вузлів";
            // 
            // maxHostsBox
            // 
            this.maxHostsBox.Location = new System.Drawing.Point(120, 356);
            this.maxHostsBox.Name = "maxHostsBox";
            this.maxHostsBox.ReadOnly = true;
            this.maxHostsBox.Size = new System.Drawing.Size(189, 20);
            this.maxHostsBox.TabIndex = 11;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(164, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(103, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Розрахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // ipAdressBox2
            // 
            this.ipAdressBox2.Location = new System.Drawing.Point(142, 101);
            this.ipAdressBox2.Name = "ipAdressBox2";
            this.ipAdressBox2.Size = new System.Drawing.Size(44, 20);
            this.ipAdressBox2.TabIndex = 14;
            // 
            // ipAdressBox3
            // 
            this.ipAdressBox3.Location = new System.Drawing.Point(192, 101);
            this.ipAdressBox3.Name = "ipAdressBox3";
            this.ipAdressBox3.Size = new System.Drawing.Size(44, 20);
            this.ipAdressBox3.TabIndex = 15;
            // 
            // ipAdressBox4
            // 
            this.ipAdressBox4.Location = new System.Drawing.Point(242, 101);
            this.ipAdressBox4.Name = "ipAdressBox4";
            this.ipAdressBox4.Size = new System.Drawing.Size(44, 20);
            this.ipAdressBox4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.ipAdressBox4);
            this.Controls.Add(this.ipAdressBox3);
            this.Controls.Add(this.ipAdressBox2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxHostsBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.networkAdressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hostAdressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prefixBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAdressBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "ipCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipAdressBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prefixBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maskBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hostAdressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox networkAdressBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxHostsBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox ipAdressBox2;
        private System.Windows.Forms.TextBox ipAdressBox3;
        private System.Windows.Forms.TextBox ipAdressBox4;
    }
}

