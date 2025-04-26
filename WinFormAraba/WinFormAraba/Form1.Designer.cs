namespace WinFormAraba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            lblKapisayi = new Label();
            lblYakit = new Label();
            lblPencere = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox6 = new ComboBox();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(172, 77);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(50, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "Marka";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(172, 122);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "Model";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(172, 167);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(41, 20);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "Renk";
            // 
            // lblKapisayi
            // 
            lblKapisayi.AutoSize = true;
            lblKapisayi.Location = new Point(172, 216);
            lblKapisayi.Name = "lblKapisayi";
            lblKapisayi.Size = new Size(80, 20);
            lblKapisayi.TabIndex = 3;
            lblKapisayi.Text = "Kapı Sayısı";
            // 
            // lblYakit
            // 
            lblYakit.AutoSize = true;
            lblYakit.Location = new Point(172, 265);
            lblYakit.Name = "lblYakit";
            lblYakit.Size = new Size(84, 20);
            lblYakit.TabIndex = 4;
            lblYakit.Text = "100kmyakıt";
            // 
            // lblPencere
            // 
            lblPencere.AutoSize = true;
            lblPencere.Location = new Point(172, 311);
            lblPencere.Name = "lblPencere";
            lblPencere.Size = new Size(93, 20);
            lblPencere.TabIndex = 5;
            lblPencere.Text = "PencereSayis";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(354, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(354, 119);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "kırmızı", " mavi" });
            comboBox3.Location = new Point(354, 176);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 8;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "3", "5" });
            comboBox4.Location = new Point(354, 226);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(151, 28);
            comboBox4.TabIndex = 9;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "3", "5" });
            comboBox6.Location = new Point(354, 308);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(151, 28);
            comboBox6.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(630, 163);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 12;
            button1.Text = "kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(comboBox6);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblPencere);
            Controls.Add(lblYakit);
            Controls.Add(lblKapisayi);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private Label lblKapisayi;
        private Label lblYakit;
        private Label lblPencere;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private Button button1;
        private TextBox textBox1;
    }
}
