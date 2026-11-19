namespace module2._2
{
    partial class FormBasket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasket));
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(996, 134);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 35;
            label6.Text = "Категория: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(996, 79);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 34;
            label5.Text = "Сортировка: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(996, 30);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 33;
            label4.Text = "Поиск: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 30);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 32;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 30);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 31;
            label2.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(210, 246, 231);
            flowLayoutPanel1.Location = new Point(31, 176);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(972, 479);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 178, 175);
            button1.Location = new Point(1076, 193);
            button1.Name = "button1";
            button1.Size = new Size(162, 36);
            button1.TabIndex = 29;
            button1.Text = "Товар";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Все категории", "Детская обувь", "Мужская обувь", "Женская обувь" });
            comboBox2.Location = new Point(1129, 131);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 33);
            comboBox2.TabIndex = 28;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Чудо_Обувь;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(40, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBox1.Location = new Point(1129, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 33);
            comboBox1.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1129, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 31);
            textBox1.TabIndex = 26;
            // 
            // FormBasket
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 669);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "FormBasket";
            Text = "FormBasket";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
    }
}