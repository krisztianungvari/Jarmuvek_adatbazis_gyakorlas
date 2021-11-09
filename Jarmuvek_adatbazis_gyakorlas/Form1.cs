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

namespace Jarmuvek_adatbazis_gyakorlas
{
    public partial class Form1 : Form
    {
        List<AutoOsztaly> auto;
        public Form1()
        {
            InitializeComponent();
            AdatKapcsolat.Csatlakozas();
            AutokFrissitese();

            
        }

        public void AutokFrissitese()
        {
            auto = AdatKapcsolat.AutokkListazasa();
            listBox_Autok.DataSource = null;
            listBox_Autok.DataSource = auto;
        }

        private void button_UjAuto_Click(object sender, EventArgs e)
        {
            AutoForm autoForm = new AutoForm();
            if (autoForm.ShowDialog() == DialogResult.OK)
            {
                AdatKapcsolat.AutoFelvitel(autoForm.Auto);
                AutokFrissitese();
            }
        }

        private void button_AutoModositas_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex != -1)
            {
                AutoOsztaly auto = (AutoOsztaly)listBox_Autok.SelectedItem;
                AutoForm autoForm = new AutoForm(auto);
                if (autoForm.ShowDialog() == DialogResult.OK)
                {
                    AdatKapcsolat.AutoModositasa(auto);
                    AutokFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy autót!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AutoTorles_Click(object sender, EventArgs e)
        {
            if (listBox_Autok.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan szeretné törölni ezt az autót?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AutoOsztaly auto = (AutoOsztaly)listBox_Autok.SelectedItem;
                    AdatKapcsolat.AutoTorlese(auto);
                    AutokFrissitese();
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy autót!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_AutoMentes_Click(object sender, EventArgs e)
        {
            try
            {
                string autofajl = "CSV_autok.TXT"; 
              
                using (StreamWriter kimentes = new StreamWriter(autofajl, true, Encoding.Default))
                {
                    foreach (AutoOsztaly item in listBox_Autok.Items) 
                    {
                        kimentes.Write(item.ToString());
                    }
                }

                MessageBox.Show("Sikeres mentés!", "Mentés", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Sikertelen mentés!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
