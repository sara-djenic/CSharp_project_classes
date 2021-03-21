using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

namespace Zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        List<DesktopRacunar> rLista = new List<DesktopRacunar>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string proizvodjac = txtProizvodjac.Text;
                string procesor = cmbBoxProcesor.Text;
                string ram = cmbBoxRAM.Text;
                string maticnaPloca = txtMaticna.Text;
                decimal cena = Convert.ToDecimal(txtCena.Text);
                int kolicina = (int)numKolicina.Value;
                decimal cenaDostave = Convert.ToDecimal(txtCenaDostave.Text);
                string grafickaKartica = cmbBoxGraficka.Text;

                DesktopRacunar r1 = new DesktopRacunar(cena, kolicina, cenaDostave, maticnaPloca, procesor, ram, proizvodjac, grafickaKartica);
                rLista.Add(r1);

                Utilities.ResetAllControls(this);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public class Utilities
        {
            public static void ResetAllControls(Control form)
            {
                foreach (Control control in form.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox textBox = (TextBox)control;
                        textBox.Text = null;
                    }

                    if (control is ComboBox)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = 0;
                        
                    }

                    if(control is NumericUpDown)
                    {
                        NumericUpDown numericUpDown = (NumericUpDown)control;
                        numericUpDown.Value = 0;
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                string strJSON = js.Serialize(rLista);


                StreamWriter JSONFile = new StreamWriter(@"C:\Users\Sara\source\repos\Zadatak1\Desktop.json");
                JSONFile.Write(strJSON);
                JSONFile.Flush();
                JSONFile.Close();

                Process.Start("notepad.exe", @"C:\Users\Sara\source\repos\Zadatak1\Desktop.json");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
