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
    public partial class CEkranSzczegolyLicznika : Form
    {
        private CPomieszczenie wybranePomieszcznie;
        public CEkranSzczegolyLicznika(CPomieszczenie wybranePomieszcznie)
        {
            InitializeComponent();
            this.wybranePomieszcznie = wybranePomieszcznie;
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            CEkranZarzadzaniaKlimatem ekranZK = new CEkranZarzadzaniaKlimatem();
            ekranZK.ShowDialog();
            this.Close();
        }

        private void buttonFiltruj_Click(object sender, EventArgs e)
        {
            this.textBoxZuzycieCiepla.Text = "Zużycie ciepła w danym przedziale czasowym wyniosło " + wybranePomieszcznie.licznikPomieszczenia.ObliczZuzycieCiepla(this.dateTimePickerOdKiedy.Value, this.dateTimePickerDoKiedy.Value).ToString();
            this.textBoxZuzyciePradu.Text = "Zużycie pradu w danym przedziale czasowym wyniosło " + wybranePomieszcznie.licznikPomieszczenia.ObliczZuzyciePradu(this.dateTimePickerOdKiedy.Value, this.dateTimePickerDoKiedy.Value).ToString();
            this.textBoxZuzycieWody.Text = "Zużycie wody w danym przedziale czasowym wyniosło " + wybranePomieszcznie.licznikPomieszczenia.ObliczZuzycieWody(this.dateTimePickerOdKiedy.Value, this.dateTimePickerDoKiedy.Value).ToString();
        }
    }
}
