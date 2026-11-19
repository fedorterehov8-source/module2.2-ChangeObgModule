namespace module2._2
{
    partial class ProductControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            lblPrice = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(808, 112);
            label6.Name = "label6";
            label6.Size = new Size(77, 22);
            label6.TabIndex = 13;
            label6.Text = "jknkjnkn";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Calibri", 9F, FontStyle.Bold);
            lblPrice.Location = new Point(808, 81);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(55, 22);
            lblPrice.TabIndex = 12;
            lblPrice.Text = "label5";
            lblPrice.Click += label5_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(238, 103);
            label4.Name = "label4";
            label4.Size = new Size(446, 98);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label3.Location = new Point(238, 81);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label2.Location = new Point(238, 59);
            label2.Name = "label2";
            label2.Size = new Size(55, 22);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.Font = new Font("Calibri", 9F, FontStyle.Bold);
            label1.Location = new Point(285, 11);
            label1.Name = "label1";
            label1.Size = new Size(558, 48);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(690, 112);
            label7.Name = "label7";
            label7.Size = new Size(77, 22);
            label7.TabIndex = 14;
            label7.Text = "jknkjnkn";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 178, 175);
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(690, 161);
            button1.Name = "button1";
            button1.Size = new Size(195, 40);
            button1.TabIndex = 15;
            button1.Text = "Просмотр";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(11F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "ProductControl";
            Size = new Size(934, 218);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label lblPrice;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button1;
    }
}
