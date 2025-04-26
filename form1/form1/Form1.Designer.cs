namespace form1
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
            lblAdiniz = new Label();
            lblSoyadiniz = new Label();
            lblGozrengi = new Label();
            lblKulak = new Label();
            lblBurun = new Label();
            textBoxadiniz = new TextBox();
            textBoxSoyadin = new TextBox();
            comboBoxGoz = new ComboBox();
            buttonkaydet = new Button();
            sonuC = new Label();
            comboBoxburun = new ComboBox();
            comboBoxkulak = new ComboBox();
            SuspendLayout();
            // 
            // lblAdiniz
            // 
            lblAdiniz.AutoSize = true;
            lblAdiniz.Location = new Point(321, 112);
            lblAdiniz.Name = "lblAdiniz";
            lblAdiniz.Size = new Size(54, 20);
            lblAdiniz.TabIndex = 0;
            lblAdiniz.Text = "Adınız:";
            lblAdiniz.Click += label1_Click;
            // 
            // lblSoyadiniz
            // 
            lblSoyadiniz.AutoSize = true;
            lblSoyadiniz.Location = new Point(321, 192);
            lblSoyadiniz.Name = "lblSoyadiniz";
            lblSoyadiniz.Size = new Size(73, 20);
            lblSoyadiniz.TabIndex = 1;
            lblSoyadiniz.Text = "Soyadınız";
            lblSoyadiniz.Click += lblSoyadiniz_Click;
            // 
            // lblGozrengi
            // 
            lblGozrengi.AutoSize = true;
            lblGozrengi.Location = new Point(321, 258);
            lblGozrengi.Name = "lblGozrengi";
            lblGozrengi.Size = new Size(73, 20);
            lblGozrengi.TabIndex = 2;
            lblGozrengi.Text = "Goz rengi";
            // 
            // lblKulak
            // 
            lblKulak.AutoSize = true;
            lblKulak.Location = new Point(330, 314);
            lblKulak.Name = "lblKulak";
            lblKulak.Size = new Size(45, 20);
            lblKulak.TabIndex = 3;
            lblKulak.Text = "Kulak";
            // 
            // lblBurun
            // 
            lblBurun.AutoSize = true;
            lblBurun.Location = new Point(330, 364);
            lblBurun.Name = "lblBurun";
            lblBurun.Size = new Size(47, 20);
            lblBurun.TabIndex = 4;
            lblBurun.Text = "Burun";
            // 
            // textBoxadiniz
            // 
            textBoxadiniz.Location = new Point(509, 93);
            textBoxadiniz.Name = "textBoxadiniz";
            textBoxadiniz.Size = new Size(125, 27);
            textBoxadiniz.TabIndex = 5;
            // 
            // textBoxSoyadin
            // 
            textBoxSoyadin.Location = new Point(509, 172);
            textBoxSoyadin.Name = "textBoxSoyadin";
            textBoxSoyadin.Size = new Size(125, 27);
            textBoxSoyadin.TabIndex = 9;
            // 
            // comboBoxGoz
            // 
            comboBoxGoz.FormattingEnabled = true;
            comboBoxGoz.Items.AddRange(new object[] { "seciniz", "kahverengi ", "mavi ", "yesil" });
            comboBoxGoz.Location = new Point(509, 255);
            comboBoxGoz.Name = "comboBoxGoz";
            comboBoxGoz.Size = new Size(151, 28);
            comboBoxGoz.TabIndex = 10;
            comboBoxGoz.SelectedIndexChanged += comboBoxGoz_SelectedIndexChanged;
            // 
            // buttonkaydet
            // 
            buttonkaydet.Location = new Point(873, 186);
            buttonkaydet.Name = "buttonkaydet";
            buttonkaydet.Size = new Size(94, 29);
            buttonkaydet.TabIndex = 11;
            buttonkaydet.Text = "Kaydet";
            buttonkaydet.UseVisualStyleBackColor = true;
            buttonkaydet.Click += buttonkaydet_Click;
            // 
            // sonuC
            // 
            sonuC.AutoSize = true;
            sonuC.Location = new Point(633, 452);
            sonuC.Name = "sonuC";
            sonuC.Size = new Size(58, 20);
            sonuC.TabIndex = 12;
            sonuC.Text = "SONUÇ";
            // 
            // comboBoxburun
            // 
            comboBoxburun.FormattingEnabled = true;
            comboBoxburun.Items.AddRange(new object[] { "seciniz", "kemer", "normal" });
            comboBoxburun.Location = new Point(509, 361);
            comboBoxburun.Name = "comboBoxburun";
            comboBoxburun.Size = new Size(151, 28);
            comboBoxburun.TabIndex = 13;
            comboBoxburun.SelectedIndexChanged += comboBoxburun_SelectedIndexChanged;
            // 
            // comboBoxkulak
            // 
            comboBoxkulak.FormattingEnabled = true;
            comboBoxkulak.Items.AddRange(new object[] { "seciniz", "kepce", "uzun", "kısa" });
            comboBoxkulak.Location = new Point(500, 314);
            comboBoxkulak.Name = "comboBoxkulak";
            comboBoxkulak.Size = new Size(151, 28);
            comboBoxkulak.TabIndex = 14;
            comboBoxkulak.SelectedIndexChanged += comboBoxkulak_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 514);
            Controls.Add(comboBoxkulak);
            Controls.Add(comboBoxburun);
            Controls.Add(sonuC);
            Controls.Add(buttonkaydet);
            Controls.Add(comboBoxGoz);
            Controls.Add(textBoxSoyadin);
            Controls.Add(textBoxadiniz);
            Controls.Add(lblBurun);
            Controls.Add(lblKulak);
            Controls.Add(lblGozrengi);
            Controls.Add(lblSoyadiniz);
            Controls.Add(lblAdiniz);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdiniz;
        private Label lblSoyadiniz;
        private Label lblGozrengi;
        private Label lblKulak;
        private Label lblBurun;
        private TextBox textBoxadiniz;
        private TextBox textBoxSoyadin;
        private ComboBox comboBoxGoz;
        private Button buttonkaydet;
        private Label sonuC;
        private ComboBox comboBoxburun;
        private ComboBox comboBoxkulak;
    }
}
