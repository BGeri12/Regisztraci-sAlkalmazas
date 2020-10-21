namespace RegisztraciósAlkalmazas
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
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.textBoxUjHobbi = new System.Windows.Forms.TextBox();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelSzDatum = new System.Windows.Forms.Label();
            this.labelUjHobbi = new System.Windows.Forms.Label();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelKedvencHobbi = new System.Windows.Forms.Label();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonN = new System.Windows.Forms.RadioButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonHozzaad = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBetoltes = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(90, 9);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 23);
            this.textBoxNev.TabIndex = 0;
            // 
            // textBoxUjHobbi
            // 
            this.textBoxUjHobbi.Location = new System.Drawing.Point(209, 156);
            this.textBoxUjHobbi.Name = "textBoxUjHobbi";
            this.textBoxUjHobbi.Size = new System.Drawing.Size(100, 23);
            this.textBoxUjHobbi.TabIndex = 0;
            this.textBoxUjHobbi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(12, 17);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(31, 15);
            this.labelNev.TabIndex = 1;
            this.labelNev.Text = "Név:";
            this.labelNev.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSzDatum
            // 
            this.labelSzDatum.AutoSize = true;
            this.labelSzDatum.Location = new System.Drawing.Point(12, 57);
            this.labelSzDatum.Name = "labelSzDatum";
            this.labelSzDatum.Size = new System.Drawing.Size(72, 15);
            this.labelSzDatum.TabIndex = 2;
            this.labelSzDatum.Text = "Szül. dátum:";
            // 
            // labelUjHobbi
            // 
            this.labelUjHobbi.AutoSize = true;
            this.labelUjHobbi.Location = new System.Drawing.Point(135, 159);
            this.labelUjHobbi.Name = "labelUjHobbi";
            this.labelUjHobbi.Size = new System.Drawing.Size(55, 15);
            this.labelUjHobbi.TabIndex = 2;
            this.labelUjHobbi.Text = "Új hobbi:";
            this.labelUjHobbi.Click += new System.EventHandler(this.labelUjHobbi_Click);
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(12, 97);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(36, 15);
            this.labelNem.TabIndex = 2;
            this.labelNem.Text = "Nem:";
            // 
            // labelKedvencHobbi
            // 
            this.labelKedvencHobbi.AutoSize = true;
            this.labelKedvencHobbi.Location = new System.Drawing.Point(209, 17);
            this.labelKedvencHobbi.Name = "labelKedvencHobbi";
            this.labelKedvencHobbi.Size = new System.Drawing.Size(91, 15);
            this.labelKedvencHobbi.TabIndex = 2;
            this.labelKedvencHobbi.Text = "Kedvenc Hobbi:";
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(90, 97);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(31, 19);
            this.radioButtonF.TabIndex = 3;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            this.radioButtonF.CheckedChanged += new System.EventHandler(this.radioButtonF_CheckedChanged);
            // 
            // radioButtonN
            // 
            this.radioButtonN.AutoSize = true;
            this.radioButtonN.Location = new System.Drawing.Point(156, 99);
            this.radioButtonN.Name = "radioButtonN";
            this.radioButtonN.Size = new System.Drawing.Size(34, 19);
            this.radioButtonN.TabIndex = 4;
            this.radioButtonN.TabStop = true;
            this.radioButtonN.Text = "N";
            this.radioButtonN.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Items.AddRange(new object[] {
            "Úszás",
            "Horgászat",
            "Futás"});
            this.listBox.Location = new System.Drawing.Point(209, 49);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(100, 94);
            this.listBox.TabIndex = 5;
            this.listBox.TabStop = false;
            // 
            // buttonHozzaad
            // 
            this.buttonHozzaad.Location = new System.Drawing.Point(234, 198);
            this.buttonHozzaad.Name = "buttonHozzaad";
            this.buttonHozzaad.Size = new System.Drawing.Size(75, 23);
            this.buttonHozzaad.TabIndex = 6;
            this.buttonHozzaad.Text = "Hozzáad";
            this.buttonHozzaad.UseVisualStyleBackColor = true;
            this.buttonHozzaad.Click += new System.EventHandler(this.buttonHozzaad_Click);
            // 
            // buttonMentes
            // 
            this.buttonMentes.Location = new System.Drawing.Point(135, 261);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(75, 23);
            this.buttonMentes.TabIndex = 6;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = true;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // buttonBetoltes
            // 
            this.buttonBetoltes.Location = new System.Drawing.Point(234, 261);
            this.buttonBetoltes.Name = "buttonBetoltes";
            this.buttonBetoltes.Size = new System.Drawing.Size(75, 23);
            this.buttonBetoltes.TabIndex = 6;
            this.buttonBetoltes.Text = "Betöltés";
            this.buttonBetoltes.UseVisualStyleBackColor = true;
            this.buttonBetoltes.Click += new System.EventHandler(this.buttonBetoltes_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Szöveges fájlok (*.txt)|*.txt|CSV fájlok (*.csv)|*.csv|Minden fájl (*.*)|*.*";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 296);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonBetoltes);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonHozzaad);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.radioButtonN);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.labelKedvencHobbi);
            this.Controls.Add(this.labelNem);
            this.Controls.Add(this.labelUjHobbi);
            this.Controls.Add(this.labelSzDatum);
            this.Controls.Add(this.labelNev);
            this.Controls.Add(this.textBoxUjHobbi);
            this.Controls.Add(this.textBoxNev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.TextBox textBoxUjHobbi;
        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelSzDatum;
        private System.Windows.Forms.Label labelUjHobbi;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Label labelKedvencHobbi;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonN;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonHozzaad;
        private System.Windows.Forms.Button buttonMentes;
        private System.Windows.Forms.Button buttonBetoltes;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

