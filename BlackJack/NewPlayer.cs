using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class NewPlayer : Form
    {
        List<Human> players;
        public Human newHuman { get; set; }

        public NewPlayer(List<Human> h)
        {
            InitializeComponent();
            players = h;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int lastid = players.Last().id;

                newHuman = new Human(lastid+=1, textBox1.Text, 1000);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
