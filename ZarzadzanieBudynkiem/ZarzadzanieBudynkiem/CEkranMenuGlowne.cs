using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarzadzanieBudynkiem
{
    public partial class CEkranMenuGlowne : Form
    {
        public CEkranMenuGlowne()
        {
            InitializeComponent();
        }

        private void buttonWylogujSie_Click(object sender, EventArgs e)
        {

            this.Hide();
            CEkranLogowania ekranL = new CEkranLogowania();
            ekranL.ShowDialog();
            this.Close();
        }

        private void buttonPomieszczenia_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CEkranZarzadzaniaKlimatem>().Any())
            {
                Application.OpenForms.OfType<CEkranZarzadzaniaKlimatem>().First().BringToFront();
            }
            else
            {
                CEkranZarzadzaniaKlimatem ekranTR = new CEkranZarzadzaniaKlimatem();
                ekranTR.ShowDialog();
            }
        }

        private void buttonTabliceRejestracyjne_Click(object sender, EventArgs e)
        {
            CEkranTablicRejestracyjnych ekranTR = new CEkranTablicRejestracyjnych();
            ekranTR.ShowDialog();
        }

        private void buttonMiejsceParkingowe_Click(object sender, EventArgs e)
        {
            CEkranMiejscParkingowych ekranMP = new CEkranMiejscParkingowych();
            ekranMP.ShowDialog();
        }

        private void CEkranMenuGlowne_Load(object sender, EventArgs e)
        {

        }
    }
}
