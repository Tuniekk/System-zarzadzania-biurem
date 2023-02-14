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
    public partial class CEkranSzczegolyPomieszczenia : Form
    {
        public CPomieszczenie wybranePomieszczenie = new CPomieszczenie(0,0,0);

        public CEkranSzczegolyPomieszczenia()
        {
            InitializeComponent();
        }
        public CEkranSzczegolyPomieszczenia(CPomieszczenie pomieszczenie)
        {
            this.wybranePomieszczenie = pomieszczenie;
            InitializeComponent();
        }


        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            CEkranZarzadzaniaKlimatem ekranZK = new CEkranZarzadzaniaKlimatem();
            ekranZK.ShowDialog();
            this.Close();
        }

        private void CEkranSzczegolyPomieszczenia_Load(object sender, EventArgs e)
        {
            this.textBoxObecnaTemperatura.Text = this.wybranePomieszczenie.ZwrocObacnaTemperature().ToString();
            foreach (var roleta in this.wybranePomieszczenie.listaRolet)
            {
                var rzad = new string[] { roleta.zwrocNumer().ToString(), roleta.zwrocPoziomWysuniecia().ToString() };
                var lvi = new ListViewItem(rzad);
                lvi.Tag = roleta;
                listViewListaRolet.Items.Add(lvi);
            }
        }

        private void buttonZatwierdzZmiane_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToSingle(this.textBoxNowaTemperatura.Text) < this.wybranePomieszczenie.ZwrocMinTemperature())
                {
                    this.textBoxKomunikatOBledzieTemp.Text = "Podana temperatura jest zbyt niska (najmniejsza wartosc to " + this.wybranePomieszczenie.ZwrocMinTemperature() + " stopni Celsjusza).";
                    this.textBoxNowaTemperatura.Clear();
                }
                else if (Convert.ToSingle(this.textBoxNowaTemperatura.Text) > this.wybranePomieszczenie.ZwrocMaxTemperature())
                {
                    this.textBoxKomunikatOBledzieTemp.Text = "Podana temperatura jest zbyt wysoka (najwieksza wartosc to " + this.wybranePomieszczenie.ZwrocMaxTemperature() + " stopni Celsjusza).";
                    this.textBoxNowaTemperatura.Clear();
                }
                else
                {
                    this.textBoxKomunikatOBledzieTemp.Clear();
                    this.textBoxObecnaTemperatura.Text = this.textBoxNowaTemperatura.Text;
                    this.wybranePomieszczenie.ZmienTemperature(Convert.ToSingle(this.textBoxNowaTemperatura.Text));
                    this.textBoxNowaTemperatura.Clear();
                }
            }
            catch(FormatException)
            {
                this.textBoxKomunikatOBledzieTemp.Text = "Podana temperatura jest napisana w niepoprawny sposób.";
                this.textBoxNowaTemperatura.Clear();
            }
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (ListViewItem item in listViewListaRolet.SelectedItems)
            {
                foreach (var roleta in wybranePomieszczenie.listaRolet)
                {
                    if (listViewListaRolet.SelectedItems[0].SubItems[0].Text.ToString() == roleta.zwrocNumer().ToString())
                    {
                        CEkranZarzadzaniaWybranymiRoletami ekranZWR = new CEkranZarzadzaniaWybranymiRoletami(roleta, this.wybranePomieszczenie);
                        ekranZWR.ShowDialog();
                    }
                }

            }
            this.Close();
        }
    }
}
