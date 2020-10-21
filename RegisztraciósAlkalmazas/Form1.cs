using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztraciósAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelUjHobbi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonHozzaad_Click(object sender, EventArgs e)
        {

            string szoveg = textBoxUjHobbi.Text;
            if (String.IsNullOrWhiteSpace(szoveg))
            {
                MessageBox.Show("Üres beviteli mező");
                return;
            }
            if (listBox.Items.Contains(szoveg))
            {
                MessageBox.Show("Ez a elem már szerepel");
                return;
            }
            listBox.Items.Add(szoveg);
            textBoxUjHobbi.Text = " ";
            textBoxUjHobbi.Focus();

        }

        private void textBoxUjHobbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonHozzaad.PerformClick();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            var mentes = saveFileDialog1.ShowDialog();

            if (mentes != DialogResult.OK)
            {
                return;
            }

            string fileNev = saveFileDialog1.FileName;

            try
            {
                using (var sw = new StreamWriter(fileNev))
                {
                    sw.WriteLine(textBoxNev.Text);
                    sw.WriteLine(dateTimePicker1.Value);
                    sw.WriteLine(radioButtonF.Checked);
                    sw.WriteLine(radioButtonN.Checked);
                    
                    foreach (var item in listBox.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem jó a mentés, hiba");
            }
        }

        private void buttonBetoltes_Click(object sender, EventArgs e)
        {
            var megnyit = openFileDialog1.ShowDialog();
            if (megnyit != DialogResult.OK)
            {
                return;
            }

            string fileNev = openFileDialog1.FileName;

            try
            {
                using (var sr = new StreamReader(fileNev))
                {
                    listBox.Items.Clear();

                    textBoxNev.Text = sr.ReadLine();
                    dateTimePicker1 = sr.ReadLine();
                    radioButtonF.Checked = bool.Parse(sr.ReadLine());
                    radioButtonN.Checked = bool.Parse(sr.ReadLine());
                    

                    while (!sr.EndOfStream)
                    {
                        listBox.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nem jó a megnyitás, hiba");
            }
        }
    }
}
