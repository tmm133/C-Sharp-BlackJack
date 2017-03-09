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
    public partial class BlackJack_UI : Form
    {
        Deck shoe = new Deck();
        List<Card> singleDeck = new List<Card>();
        List<Human> humanPlayers = new List<Human>();
        List<AI> AI_Players = new List<AI>();
        Dealer dealer = new Dealer();

        //Main Function
        public BlackJack_UI()
        {
            InitializeComponent();

            createDeck();
            fillShoe(4);
            displayCardAndDeckData();
            createDemoPlayers();
            displayHumanData();
            displayDealerData();

        }

        private void createDeck()
        {
            List<string> suit = new List<string> { "H", "D", "S", "C" };
            List<string> rank = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            List<int> value = new List<int> { 11, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            int valueIndex = 0;

            foreach (string s in suit)
            {
                foreach (string r in rank)
                {
                    singleDeck.Add(new Card(s, r, value[valueIndex]));
                    valueIndex++;
                }
                valueIndex = 0;
            }
        }

        private void fillShoe(int numberOfDecks)
        {
            shoe.clearDeck();

            for (int i = 0; i < numberOfDecks; i++)
            {
                foreach (Card c in singleDeck)
                {
                    shoe.addCard(c);
                }
            }
        }

        #region Testing functions
        private void displayCardAndDeckData()
        {
            foreach (Card c in singleDeck)
            {
                listBox1.Items.Add(c.getRank() + c.getSuite());
            }
            label1.Text += " ( " + singleDeck.Count().ToString() + " Cards ) ";

            foreach (Card c in shoe.cards)
            {
                listBox2.Items.Add(c.getRank() + c.getSuite());
            }
            label2.Text += " ( " + shoe.getNumCardsRemaining().ToString() + " Cards ) ";

            shoe.shuffle();
            foreach (Card c in shoe.cards)
            {
                listBox3.Items.Add(c.getRank() + c.getSuite());
            }
        }

        private void createDemoPlayers()
        {
            humanPlayers.Add(new Human(1, "Timmy", 150));
            humanPlayers.Add(new Human(2, "Sarah", 6540));
        }

        private void displayHumanData()
        {
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox3.Items.Clear();

            label4.Text = humanPlayers[0].name + " ($" + humanPlayers[0].money.ToString() + " )";
            label5.Text = humanPlayers[1].name + " ($" + humanPlayers[1].money.ToString() + " )";
            label6.Text = "Total card values: " + humanPlayers[0].getTotalCardValue().ToString();
            label7.Text = "Total card values: " + humanPlayers[1].getTotalCardValue().ToString();

            foreach (Card c in humanPlayers[0].hand)
            {
                listBox4.Items.Add(c.getRank() + c.getSuite());
            }

            foreach (Card c in humanPlayers[1].hand)
            {
                listBox5.Items.Add(c.getRank() + c.getSuite());
            }

            foreach (Card c in shoe.cards)
            {
                listBox3.Items.Add(c.getRank() + c.getSuite());
            }

            label11.Text = "Number of Cards left in Shoe: " + shoe.getNumCardsRemaining().ToString();
        }

        private void displayDealerData()
        {
            listBox6.Items.Clear();
            listBox3.Items.Clear();

            label9.Text = "Total card values: " + dealer.getTotalCardValue().ToString();

            foreach (Card c in dealer.hand)
            {
                listBox6.Items.Add(c.getRank() + c.getSuite());
            }

            foreach (Card c in shoe.cards)
            {
                listBox3.Items.Add(c.getRank() + c.getSuite());
            }

            label11.Text = "Number of Cards left in Shoe: " + shoe.getNumCardsRemaining().ToString();
        }
        #endregion

        #region Player Test Buttons
        private void button1_Click(object sender, EventArgs e) //Test button Hit top player
        {
            humanPlayers[0].hit(ref shoe);
            label6.Text = "Total card values: " + humanPlayers[0].getTotalCardValue().ToString();
            displayHumanData();
        }

        private void button2_Click(object sender, EventArgs e) //Test button clear top player
        {
            humanPlayers[0].clearHand();
            label6.Text = "Total card values: " + humanPlayers[0].getTotalCardValue().ToString();
            displayHumanData();
        }

        private void button4_Click(object sender, EventArgs e) //Test button Hit bottom player
        {
            humanPlayers[1].hit(ref shoe);
            label7.Text = "Total card values: " + humanPlayers[1].getTotalCardValue().ToString();
            displayHumanData();
        }

        private void button3_Click(object sender, EventArgs e) //Test button clear top player
        {
            humanPlayers[1].clearHand();
            label7.Text = "Total card values: " + humanPlayers[1].getTotalCardValue().ToString();
            displayHumanData();
        }
        #endregion

        #region Dealer Test Buttons
        private void button5_Click(object sender, EventArgs e)
        {
            dealer.hit(ref shoe);
            label9.Text = "Total card values: " + dealer.getTotalCardValue().ToString();
            displayDealerData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dealer.clearHand();
            label9.Text = "Total card values: " + dealer.getTotalCardValue().ToString();
            displayDealerData();
        }
        #endregion
    }
}
