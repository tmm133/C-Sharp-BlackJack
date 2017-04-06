using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace BlackJack
{
    public partial class StartScreen : Form
    {
        List<Human> SavedHumans = new List<Human>();

        public StartScreen()
        {
            InitializeComponent();

            LoadPlayers();
            populatePlayerCbo();

            initilizeCbos();
            Human h = (Human)cboPlayers.Items[0];
            lblMoney.Text = "Current Money  $" + h.money.ToString();
        }

        public void LoadPlayers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));

            using (FileStream fileStream = new FileStream("Players.txt", FileMode.Open))
            {
                SavedHumans = (List<Human>)serializer.Deserialize(fileStream);
            }
        }

        public void populatePlayerCbo()
        {
            //h.name + "    $" + h.money.ToString()
            cboPlayers.DataSource = SavedHumans;
            cboPlayers.DisplayMember = "name";
            cboPlayers.ValueMember = "id";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            BlackJack_UI b = new BlackJack_UI(int.Parse(cboDecks.SelectedItem.ToString()), (Human)cboPlayers.SelectedItem, int.Parse(cboNumAI.SelectedItem.ToString()));
            b.Show();

            this.Visible = false;
        }

        private void cboPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Human selectedHuman = (Human)cboPlayers.SelectedItem;
            lblMoney.Text = "Current Money  $" + selectedHuman.money.ToString();
        }

        private void initilizeCbos()
        {
            cboNumAI.SelectedIndex = 0;
            cboDecks.SelectedIndex = 0;
        }
    }
}
