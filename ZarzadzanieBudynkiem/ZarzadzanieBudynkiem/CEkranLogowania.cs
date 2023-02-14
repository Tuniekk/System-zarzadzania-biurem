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
    public partial class CEkranLogowania : Form
    {
        public CEkranLogowania()
        {
            InitializeComponent();
        }

        private void utworzEkranMenuGlownego()
        {
            this.Hide();
            CEkranMenuGlowne ekranMG = new CEkranMenuGlowne();
            ekranMG.ShowDialog();
            this.Close();
        }

        private void buttonZalogujSie_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == Program.pracownikAdministracyjny.ZwrocLogin() && textHaslo.Text == Program.pracownikAdministracyjny.ZwrocHaslo())
            {
                this.utworzEkranMenuGlownego();
            }
            else
            {
                label1.Text = "Nieprawidłowe dane logowania!";
            }
        }
    }
}
