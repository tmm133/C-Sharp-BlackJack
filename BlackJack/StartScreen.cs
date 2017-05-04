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
        bool newPlayerAdded = false;

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
            Environment.Exit(1);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (var form = new BlackJack_UI(int.Parse(cboDecks.SelectedItem.ToString()), (Human)cboPlayers.SelectedItem, int.Parse(cboNumAI.SelectedItem.ToString())))
            {
                this.Visible = false;

                var n = form.ShowDialog();

                if (n == DialogResult.OK)
                {
                    this.Visible = true;
                    //Reloads Cbo with updated money values
                    newPlayerAdded = true;
                    cboPlayers.DataSource = null;
                    cboPlayers.Items.Clear();
                    newPlayerAdded = false;
                    populatePlayerCbo();
                    SavePlayers(SavedHumans);
                }
            }
        }

        private void cboPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!newPlayerAdded)
            {
                Human selectedHuman = (Human)cboPlayers.SelectedItem;
                lblMoney.Text = "Current Money  $" + selectedHuman.money.ToString();
            }
        }

        private void initilizeCbos()
        {
            cboNumAI.SelectedIndex = 0;
            cboDecks.SelectedIndex = 0;
        }

        private void btnNewPlyer_Click(object sender, EventArgs e)
        {
            using (var form = new NewPlayer(SavedHumans))
            {
                this.Visible = false;

                var n = form.ShowDialog();

                if (n == DialogResult.OK)
                {
                    newPlayerAdded = true;
                    cboPlayers.DataSource = null;
                    cboPlayers.Items.Clear();
                    newPlayerAdded = false;
                    SavedHumans.Add(form.newHuman);
                    populatePlayerCbo();
                    SavePlayers(SavedHumans);
                    this.Visible = true;
                }
                else
                {
                    this.Visible = true;
                }            
            }
        }

        public void SavePlayers(List<Human> list)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            using (TextWriter writer = new StreamWriter("Players.txt"))
            {
                serializer.Serialize(writer, list);
            }
        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
