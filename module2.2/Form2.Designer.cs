namespace module2._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label1 = new Label();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(733, 24);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 21;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 24);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 20;
            label2.Text = "label2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(210, 246, 231);
            flowLayoutPanel1.Location = new Point(12, 170);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(972, 479);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(112, 178, 175);
            button1.Location = new Point(1057, 187);
            button1.Name = "button1";
            button1.Size = new Size(162, 36);
            button1.TabIndex = 18;
            button1.Text = "Товар";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(951, -52);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 17;
            label1.Text = "Поиск";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Все категории", "Детская обувь", "Мужская обувь", "Женская обувь" });
            comboBox2.Location = new Point(1110, 125);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(170, 33);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Чудо_Обувь;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(21, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "По возрастанию", "По убыванию" });
            comboBox1.Location = new Point(1110, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 33);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1110, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 31);
            textBox1.TabIndex = 14;
            textBox1.Click += textBox1_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(977, 24);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 22;
            label4.Text = "Поиск: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(977, 73);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 23;
            label5.Text = "Сортировка: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(977, 128);
            label6.Name = "label6";
            label6.Size = new Size(112, 25);
            label6.TabIndex = 24;
            label6.Text = "Категория: ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1292, 694);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Label label1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}