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
    public partial class CEkranZarzadzaniaWybranymiRoletami : Form
    {
        public CRolety wybraneRolety = new CRolety(0, 0);
        public CPomieszczenie wybranePomieszczenie = new CPomieszczenie(0, 0, 0);
        public CEkranZarzadzaniaWybranymiRoletami()
        {
            InitializeComponent();
        }

        public CEkranZarzadzaniaWybranymiRoletami(CRolety rolety, CPomieszczenie wybranePomieszczenie)
        {
            this.wybranePomieszczenie = wybranePomieszczenie;
            this.wybraneRolety = rolety;
            InitializeComponent();
        }

        private void textObecnyPoziomWysunieciaRolet_TextChanged(object sender, EventArgs e)
        {

        }
        private void utworzEkranSzczegolyPomieszczenia()
        {
            this.Hide();
            CEkranSzczegolyPomieszczenia ekranSP = new CEkranSzczegolyPomieszczenia(wybranePomieszczenie);
            ekranSP.ShowDialog();
            this.Close();
        }
        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            utworzEkranSzczegolyPomieszczenia();
        }

        private void CEkranZarzadzaniaWybranymiRoletami_Load(object sender, EventArgs e)
        {
            this.textObecnyPoziomWysunieciaRolet.Text = this.wybraneRolety.zwrocPoziomWysuniecia().ToString();
        }

        private void buttonZatwierdzZmiane_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToSingle(this.textNowyPoziomWysunieciaRolet.Text) < Convert.ToSingle(0))
                {
                    this.textBoxKomunikatOBledzie.Text = "Poziom wysunięcia nie może być mniejszy od 0.";
                    this.textNowyPoziomWysunieciaRolet.Clear();
                }
                else if (Convert.ToSingle(this.textNowyPoziomWysunieciaRolet.Text) > Convert.ToSingle(100.0))
                {
                    this.textBoxKomunikatOBledzie.Text = "Poziom wysunięcia nie może być większy od 100%.";
                    this.textNowyPoziomWysunieciaRolet.Clear();
                }
                else
                {
                    this.textBoxKomunikatOBledzie.Clear();
                    this.textObecnyPoziomWysunieciaRolet.Text = this.textNowyPoziomWysunieciaRolet.Text;
                    this.wybraneRolety.zmienPoziomWysuniecia(Convert.ToSingle(textNowyPoziomWysunieciaRolet.Text));
                    this.textNowyPoziomWysunieciaRolet.Clear();
                }
            }
            catch(FormatException)
            {
                this.textBoxKomunikatOBledzie.Text = "Podany poziom wysunięcia został napisany w nieprawidłowy sposób.";
                this.textNowyPoziomWysunieciaRolet.Clear();
            }
        }
    }
}
