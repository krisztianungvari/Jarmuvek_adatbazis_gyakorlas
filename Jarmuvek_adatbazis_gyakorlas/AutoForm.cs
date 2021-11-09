using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarmuvek_adatbazis_gyakorlas
{
    public partial class AutoForm : Form
    {
        private AutoOsztaly auto;
        public AutoForm()
        {
            InitializeComponent();
            comboBox_AutoTipus.DataSource = Enum.GetValues(typeof(Autotipus));
        }
        internal AutoForm(AutoOsztaly auto) : this()
        {
            this.auto = auto;

            textBox_AutoMarka.Text = auto.Marka;
            numericUpDown_AutoKM.Value = auto.Km;
            dateTimePicker1.Value = auto.Gyartasido;
            textBox_AutoSzin.Text = auto.Szin;
            comboBox_AutoTipus.SelectedItem = auto.AutoTipus;
            /*
            dateTimePicker1.Enabled = false;
            textBox_AutoMarka.Enabled = false;
            comboBox_AutoTipus.Enabled = false;
            */
        }

        internal AutoOsztaly Auto { get; set; }

        private void button_AutoOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (auto == null) 
                {
                    auto = new AutoOsztaly(textBox_AutoMarka.Text, (int)numericUpDown_AutoKM.Value, dateTimePicker1.Value, textBox_AutoSzin.Text, (Autotipus)comboBox_AutoTipus.SelectedItem);             
                }
                else 
                {
                    auto.Marka = textBox_AutoMarka.Text;
                    auto.Km = (int)numericUpDown_AutoKM.Value;
                    auto.Gyartasido = dateTimePicker1.Value;
                    auto.Szin = textBox_AutoSzin.Text;
                    //auto.AutoTipus = comboBox_AutoTipus.SelectedItem;
                    //MessageBox.Show("Nincs minden mező kitöltve!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }

        private void button_AutoMegse_Click(object sender, EventArgs e)
        {
            
            AutoForm autoForm = new AutoForm();
            autoForm.Close();
            
        }
    }
    
}
