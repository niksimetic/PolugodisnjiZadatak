using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikSimeticPolugodisnjiZadatak1
{
    public partial class Form1 : Form
    {
        List<Unos> Unos = new List<Unos>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = list2.Text;
            int godiste;
            bool provjera = int.TryParse(txtGodiste.Text, out godiste);

            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text) || provjera == false)
            {
                MessageBox.Show("Krivo su upisani podatci","Pogreška");
                return;
            }
            Unos.Add(new Unos(marka, model, godiste));
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(string.Format("{0, -20} {1, -20} {2, -20} {3, -20}", "Marka", "Model", "Godište","Status"));

            foreach (Unos unos in Unos)
            {
                listBox1.Items.Add(unos.ToString());
            }

        }

        private void btnObradi_Click(object sender, EventArgs e)
        {
            foreach (Unos unos in Unos)
            {
                unos.Provjera();
            }
        }
    }
}
