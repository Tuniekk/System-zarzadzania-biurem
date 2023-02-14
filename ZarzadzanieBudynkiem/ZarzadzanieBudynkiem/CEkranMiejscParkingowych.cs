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
    public partial class CEkranMiejscParkingowych : Form
    {
        public CEkranMiejscParkingowych()
        {
            InitializeComponent();
        }

        public void utworzEkranListyWolnychMiejsc()
        {
            this.Hide();
            CEkranListyWolnychMiejsc ekranLWM = new CEkranListyWolnychMiejsc();
            ekranLWM.ShowDialog();
            this.Close();
        }

        private void CEkranMiejscParkingowych_Load(object sender, EventArgs e)
        {
            bool czyZajete = false;
            foreach (var miejsce in Program.parking1.listaMiejsc.ToList())
            {
                if (miejsce.zwrocZajmujacegoMiejsce() == Program.pracownikAdministracyjny)
                {
                    czyZajete=true;
                    this.textBoxZarezerwowaneMiejsce.Text = "Obecnie zajmowane jest miejsce numer " + miejsce.zwrocNumer().ToString() + ".";
                }
            }
            if (czyZajete == true)
            {
                this.buttonZarezerwujMiejsce.Enabled = false;
                this.buttonZwolnijMiejsce.Enabled = true;
            }
            else if(czyZajete==false)
            {
                this.buttonZarezerwujMiejsce.Enabled = true;
                this.buttonZwolnijMiejsce.Enabled = false;
            }
        }

        private void buttonZwolnijMiejsce_Click(object sender, EventArgs e)
        {
            var potwierdzZwolnienie = MessageBox.Show("Czy jesteś pewien, że chcesz zwolnić swoje obecne miejsce parkingowe?","Potwierdzenie działania",MessageBoxButtons.YesNo);
            if (potwierdzZwolnienie == DialogResult.Yes)
            {
                foreach (var miejsce in Program.parking1.listaMiejsc.ToList())
                {
                    if (miejsce.zwrocZajmujacegoMiejsce() == Program.pracownikAdministracyjny)
                    {
                        miejsce.zmienWlasciciela(null);
                        this.textBoxZarezerwowaneMiejsce.Clear();
                        CEkranMiejscParkingowych_Load(sender, e);
                    }
                }
            }
        }

        private void buttonZarezerwujMiejsce_Click(object sender, EventArgs e)
        {
            this.utworzEkranListyWolnychMiejsc();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
