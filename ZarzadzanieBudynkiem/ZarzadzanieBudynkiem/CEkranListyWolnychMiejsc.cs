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
    public partial class CEkranListyWolnychMiejsc : Form
    {
        public CEkranListyWolnychMiejsc()
        {
            InitializeComponent();
            foreach (var miejsce in Program.parking1.listaMiejsc)
            {
                if (miejsce.zwrocStanMiejsca() == false)
                {
                    var rzad = new string[] { miejsce.zwrocNumer().ToString(), miejsce.zwrocNumerPietra().ToString() };
                    var lvi = new ListViewItem(rzad);
                    lvi.Tag = miejsce;
                    this.listViewWolneMiejsca.Items.Add(lvi);
                }
            }
        }

        private void utworzEkranMiejscParkingowych()
        {
            this.Hide();
            CEkranMiejscParkingowych ekranMP = new CEkranMiejscParkingowych();
            ekranMP.ShowDialog();
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.utworzEkranMiejscParkingowych();
        }

        private void listViewWolneMiejsca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonZarezerwuj_Click(object sender, EventArgs e)
        {
            var potwierdzRezerwacje = MessageBox.Show("Czy jesteś pewien, że chcesz zarezerwować wybrane miejsce?", "Potwierdzenie działania", MessageBoxButtons.YesNo);
            if (potwierdzRezerwacje == DialogResult.Yes)
            {
                foreach (ListViewItem wolneMiejsce in this.listViewWolneMiejsca.SelectedItems)
                {
                    foreach (var miejsce in Program.parking1.listaMiejsc.ToList())
                    {
                        if (listViewWolneMiejsca.SelectedItems[0].SubItems[0].Text.ToString() == miejsce.zwrocNumer().ToString())
                        {
                            miejsce.zmienWlasciciela(Program.pracownikAdministracyjny);
                            this.utworzEkranMiejscParkingowych();
                        }
                    }
                }
            }
        }
    }
}
