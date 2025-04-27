namespace SerializationOrnek
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
            lblAd = new Label();
            lblTelno = new Label();
            lblDepartman = new Label();
            lblDogum = new Label();
            lblMaas = new Label();
            textBox1Ad = new TextBox();
            textBoxMaas = new TextBox();
            textBoxDepartman = new TextBox();
            textBoxTel = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lblSerialize = new Button();
            btnDeserialze = new Button();
            btnjsonOlustur = new Button();
            btnjsonOku = new Button();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(132, 70);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblTelno
            // 
            lblTelno.AutoSize = true;
            lblTelno.Location = new Point(132, 113);
            lblTelno.Name = "lblTelno";
            lblTelno.Size = new Size(58, 20);
            lblTelno.TabIndex = 1;
            lblTelno.Text = "Telefon";
            // 
            // lblDepartman
            // 
            lblDepartman.AutoSize = true;
            lblDepartman.Location = new Point(132, 160);
            lblDepartman.Name = "lblDepartman";
            lblDepartman.Size = new Size(84, 20);
            lblDepartman.TabIndex = 2;
            lblDepartman.Text = "Departman";
            // 
            // lblDogum
            // 
            lblDogum.AutoSize = true;
            lblDogum.Location = new Point(132, 203);
            lblDogum.Name = "lblDogum";
            lblDogum.Size = new Size(95, 20);
            lblDogum.TabIndex = 3;
            lblDogum.Text = "Dogum Traih";
            // 
            // lblMaas
            // 
            lblMaas.AutoSize = true;
            lblMaas.Location = new Point(122, 254);
            lblMaas.Name = "lblMaas";
            lblMaas.Size = new Size(44, 20);
            lblMaas.TabIndex = 4;
            lblMaas.Text = "Maaş";
            // 
            // textBox1Ad
            // 
            textBox1Ad.Location = new Point(318, 68);
            textBox1Ad.Name = "textBox1Ad";
            textBox1Ad.Size = new Size(125, 27);
            textBox1Ad.TabIndex = 5;
            // 
            // textBoxMaas
            // 
            textBoxMaas.Location = new Point(309, 254);
            textBoxMaas.Name = "textBoxMaas";
            textBoxMaas.Size = new Size(125, 27);
            textBoxMaas.TabIndex = 6;
            // 
            // textBoxDepartman
            // 
            textBoxDepartman.Location = new Point(309, 160);
            textBoxDepartman.Name = "textBoxDepartman";
            textBoxDepartman.Size = new Size(125, 27);
            textBoxDepartman.TabIndex = 7;
            // 
            // textBoxTel
            // 
            textBoxTel.Location = new Point(309, 122);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(125, 27);
            textBoxTel.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(300, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // lblSerialize
            // 
            lblSerialize.Location = new Point(116, 337);
            lblSerialize.Name = "lblSerialize";
            lblSerialize.Size = new Size(94, 29);
            lblSerialize.TabIndex = 10;
            lblSerialize.Text = "serialize et";
            lblSerialize.UseVisualStyleBackColor = true;
            lblSerialize.Click += lblSerialize_Click;
            // 
            // btnDeserialze
            // 
            btnDeserialze.Location = new Point(478, 337);
            btnDeserialze.Name = "btnDeserialze";
            btnDeserialze.Size = new Size(94, 29);
            btnDeserialze.TabIndex = 11;
            btnDeserialze.Text = "deserialize";
            btnDeserialze.UseVisualStyleBackColor = true;
            btnDeserialze.Click += btnDeserialze_Click;
            // 
            // btnjsonOlustur
            // 
            btnjsonOlustur.Location = new Point(156, 399);
            btnjsonOlustur.Name = "btnjsonOlustur";
            btnjsonOlustur.Size = new Size(94, 29);
            btnjsonOlustur.TabIndex = 12;
            btnjsonOlustur.Text = "json olustur";
            btnjsonOlustur.UseVisualStyleBackColor = true;
            btnjsonOlustur.Click += btnjsonOlustur_Click;
            // 
            // btnjsonOku
            // 
            btnjsonOku.Location = new Point(478, 399);
            btnjsonOku.Name = "btnjsonOku";
            btnjsonOku.Size = new Size(94, 29);
            btnjsonOku.TabIndex = 13;
            btnjsonOku.Text = "JSONoku";
            btnjsonOku.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnjsonOku);
            Controls.Add(btnjsonOlustur);
            Controls.Add(btnDeserialze);
            Controls.Add(lblSerialize);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxTel);
            Controls.Add(textBoxDepartman);
            Controls.Add(textBoxMaas);
            Controls.Add(textBox1Ad);
            Controls.Add(lblMaas);
            Controls.Add(lblDogum);
            Controls.Add(lblDepartman);
            Controls.Add(lblTelno);
            Controls.Add(lblAd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblTelno;
        private Label lblDepartman;
        private Label lblDogum;
        private Label lblMaas;
        private TextBox textBox1Ad;
        private TextBox textBoxMaas;
        private TextBox textBoxDepartman;
        private TextBox textBoxTel;
        private DateTimePicker dateTimePicker1;
        private Button lblSerialize;
        private Button btnDeserialze;
        private Button btnjsonOlustur;
        private Button btnjsonOku;
    }
}
