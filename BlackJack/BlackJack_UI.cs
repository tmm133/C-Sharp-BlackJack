using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace BlackJack
{
    public partial class BlackJack_UI : Form
    {
        Random rng = new Random();
        List<Card> singleDeck = new List<Card>();
        Deck shoe = new Deck();
        List<Player> Players = new List<Player>();
        Dealer dealer = new Dealer();
        List<Seat> table = new List<Seat>();
        List<AI> AIs = new List<AI>();
        int currentSeat;
        #region PlayerControls
        List<Button> betBtns = new List<Button>();
        List<Button> hitBtns = new List<Button>();
        List<Button> standBtns = new List<Button>();
        List<Button> dblDwnBtns = new List<Button>();
        List<Button> srrndrBtns = new List<Button>();
        List<TextBox> betTxts = new List<TextBox>();
        List<ListBox> lstBoxs = new List<ListBox>();
        List<Label> playerLabels = new List<Label>();
        List<Label> cardValues = new List<Label>();
        #endregion

        //Main Function
        public BlackJack_UI(int numOfDecks, Player p, int numOfAI)
        {
            InitializeComponent();

            getControls();

            if (!File.Exists("Players.txt"))
                using (File.Create("Players.txt")) { }
            if (!File.Exists("ErrorLog.txt"))
                using (File.Create("ErrorLog.txt")) { }    

            createDeck();
            fillShoe(numOfDecks);
            //createDemoPlayers();
            createEmptyTable();
            currentSeat = 1;
            lblError.Text = string.Empty;

            Players.Add(p);
            sitAtTable(p);
            createAI();
            sitAIatTable(numOfAI);

            displayPlayerNameAndMoney();
        }

        private void getControls()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Name.Contains("PlcBet"))
                            betBtns.Add((Button)c);
                        else if (c.Name.Contains("Hit"))
                            hitBtns.Add((Button)c);
                        else if (c.Name.Contains("Stand"))
                            standBtns.Add((Button)c);
                        else if (c.Name.Contains("DblDwn"))
                            dblDwnBtns.Add((Button)c);
                        else if (c.Name.Contains("Srrndr"))
                            srrndrBtns.Add((Button)c);
                    }

                    if (c is TextBox)
                    {
                        if (c.Name.Contains("BetPlayer"))
                            betTxts.Add((TextBox)c);
                    }

                    if (c is ListBox)
                    {
                        if (c.Name.Contains("lstPlayer"))
                            lstBoxs.Add((ListBox)c);
                    }

                    if (c is Label)
                    {
                        if (c.Name.Contains("lblPlayer"))
                            playerLabels.Add((Label)c);
                    }

                    if (c is Label)
                    {
                        if (c.Name.Contains("CardValue"))
                            cardValues.Add((Label)c);
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void createDeck()
        {
            try
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
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void fillShoe(int numberOfDecks)
        {
            try
            {
                shoe.clearDeck();

                for (int i = 0; i < numberOfDecks; i++)
                {
                    foreach (Card c in singleDeck)
                    {
                        shoe.addCard(c);
                    }
                }

                shoe.shuffle();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void createAI()
        {
            try
            {
                AIs.Add(new AI("AI1", 0, 100001));
                AIs.Add(new AI("AI2", 0, 100002));
                AIs.Add(new AI("AI3", 0, 100003));
                AIs.Add(new AI("AI4", 0, 100004));
                AIs.Add(new AI("AI5", 0, 100005));
                for (int i = 0; i <= 4; i++)
                {
                    AI p = AIs[i];
                    p.money = rng.Next(150, 12000); ;
                }
            }
            catch(Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void sitAIatTable(int numOfAI)
        {
            try
            {
                for (int i = 0; i < numOfAI; i++)
                {
                    AI p = AIs[i];
                    sitAtTable(p);
                    Players.Add(p);
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void displayCards(bool initialDeal)
        {
            try
            {
                ListBox tempLstBox;
                Label tempLabel;

                foreach (Seat s in table)
                {
                    if (!(s.player is Dealer) && s.player != null)
                    {
                        tempLstBox = lstBoxs.First(l => l.Name.Contains(getPlayersSeatNumber(s.player).ToString()));
                        tempLabel = cardValues.First(l => l.Name.Contains(getPlayersSeatNumber(s.player).ToString()));

                        tempLstBox.Items.Clear();
                        foreach (Card c in s.player.hand)
                        {
                            tempLstBox.Items.Add(c.getRank() + c.getSuite());
                        }

                        if (s.player.getTotalCardValue() > 21)
                        {
                            tempLabel.Text = "BUST (" + s.player.getTotalCardValue().ToString() + ")";
                        }
                        else
                        {
                            tempLabel.Text = "(" + s.player.getTotalCardValue().ToString() + ")";
                        }
                    }
                    else if (s.player is Dealer)
                    {
                        lstDealer.Items.Clear();

                        foreach (Card c in dealer.hand)
                        {
                            if (initialDeal && c == dealer.hand[1])
                            {
                                lstDealer.Items.Add("??");
                                break;
                            }
                            lstDealer.Items.Add(c.getRank() + c.getSuite());
                        }
                        if (dealer.getTotalCardValue() > 21)
                        {
                            lblDealer.Text = "BUST " + s.player.getTotalCardValue().ToString();
                        }
                        else if (!initialDeal)
                        {
                            lblDealer.Text = dealer.getTotalCardValue().ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void displayPlayerNameAndMoney()
        {
            try
            {
                Label tempPlayerLabel;
                Button tempBet;
                Button temphitBtn;
                Button tempstandBtn;
                Button tempdblDwnBtn;
                Button tempsrrndrBtn;
                TextBox tempbetTxts;
                ListBox templstBox;
                Label tempcardValues;

                int prevPlayerSeat = 0;

                foreach (Seat s in table)
                {             
                    if (!(s.player is Dealer) && s.player != null)
                    {
                        prevPlayerSeat = getPlayersSeatNumber(s.player);
                        tempPlayerLabel = playerLabels.First(l => l.Name.Contains(prevPlayerSeat.ToString()));

                        tempPlayerLabel.Text = s.player.name + ": $" + s.player.money.ToString();
                    }
                    //Hide buttons and such for non existing players
                    else if (!(s.player is Dealer) && s.player == null)
                    {
                        prevPlayerSeat++;
                        tempPlayerLabel = playerLabels.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempBet       = betBtns.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        temphitBtn    = hitBtns.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempstandBtn  = standBtns.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempdblDwnBtn = dblDwnBtns.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempsrrndrBtn = srrndrBtns.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempbetTxts   = betTxts.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        templstBox    = lstBoxs.First(l => l.Name.Contains(prevPlayerSeat.ToString()));
                        tempcardValues = cardValues.First(l => l.Name.Contains(prevPlayerSeat.ToString()));


                        tempPlayerLabel.Text = string.Empty;
                        tempBet.Visible = false;
                        temphitBtn.Visible = false;
                        tempstandBtn.Visible = false;
                        tempdblDwnBtn.Visible = false;
                        tempsrrndrBtn.Visible = false;
                        tempbetTxts.Enabled = false;
                        templstBox.Enabled = false;
                        tempcardValues.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        #region Player Buttons
        private void btnPlcBet_Click(object sender, EventArgs e)
        {
            try
            {
                int playerBet = -1;
                Player activePlayer = getActivePlayer();
                //getPlayersSeatNumber(activePlayer);
                int o;
                string playersBet = betTxts.First(bet => bet.Name.Contains(getPlayersSeatNumber(activePlayer).ToString())).Text;

                if (!int.TryParse(playersBet, out o))
                    setErrorMessage("You must enter a non-decimal number");
                else if (int.Parse(playersBet) <= 0)
                    setErrorMessage("Your bet must be greater than zero");
                else if (int.Parse(playersBet) > activePlayer.money)
                    setErrorMessage("You cannot bet more than what you have");
                else
                {
                    playerBet = int.Parse(betTxts.First(bet => bet.Name.Contains(currentSeat.ToString())).Text);
                    activePlayer.placeBet(playerBet);
                    setNextCurrentSeat();
                    enableDisablePlayerControls(true);
                    if (getActivePlayer() is AI)
                    {
                        while (getActivePlayer() is AI)
                        {
                            aiBet();
                            setNextCurrentSeat();
                            enableDisablePlayerControls(true);
                        }
                    }
                    if (currentSeat == 7)
                    {
                        dealCards();
                        setNextCurrentSeat();
                        enableDisablePlayerControls(false);
                    }
                    displayCards(true);
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            try
            {
                Player activePlayer = getActivePlayer();
                activePlayer.hit(ref shoe);
                displayCards(true);
                bool hideSurr = true;

                if (activePlayer.getTotalCardValue() > 21)
                {
                    setNextCurrentSeat();
                    hideSurr = false;
                }
                enableDisablePlayerControls(false);

                if (getActivePlayer() is AI)
                {
                    while (getActivePlayer() is AI)
                    {
                        aiMove();
                        setNextCurrentSeat();
                        enableDisablePlayerControls(false);
                    }
                }
                if (currentSeat == 7)
                    dealersMove();
                else if (hideSurr)
                    srrndrBtns.First(bet => bet.Name.Contains(currentSeat.ToString())).Visible = false;
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            try
            {

                setNextCurrentSeat();
                enableDisablePlayerControls(false);

                if (getActivePlayer() is AI)
                {
                    while (getActivePlayer() is AI)
                    {
                        aiMove();
                        setNextCurrentSeat();
                        enableDisablePlayerControls(false);
                    }
                }
                if (currentSeat == 7)
                    dealersMove();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            try
            {
                getActivePlayer().surrender(true);

                setNextCurrentSeat();
                enableDisablePlayerControls(false);
                if (getActivePlayer() is AI)
                {
                    while (getActivePlayer() is AI)
                    {
                        aiMove();
                        setNextCurrentSeat();
                        enableDisablePlayerControls(false);
                    }
                }
                if (currentSeat == 7)
                    dealersMove();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void btnDoubleDown_Click(object sender, EventArgs e)
        {
            try
            {
                Player p = getActivePlayer();
                if (p.doubleDown())
                {
                    p.hit(ref shoe);
                    betTxts.First(bet => bet.Name.Contains(currentSeat.ToString())).Text = p.getBet().ToString();
                    displayCards(true);
                }
                else
                {
                    setErrorMessage("Not enough money to double down");
                    return;
                }

                setNextCurrentSeat();
                enableDisablePlayerControls(false);
                if (getActivePlayer() is AI)
                {
                    while (getActivePlayer() is AI)
                    {
                        aiMove();
                        setNextCurrentSeat();
                        enableDisablePlayerControls(false);
                    }
                }
                if (currentSeat == 7)
                    dealersMove();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }
        #endregion

        private void dealersMove()
        {
            try
            {
                displayCards(false);
                dealer.hit(ref shoe);
                displayCards(false);
                payoutAndCollect();
                displayPlayerNameAndMoney();
                kickPlayersFromTable();

                btnNextHand.Visible = true;
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void kickPlayersFromTable()
        {
            //If player money == 0
            try
            {
                foreach (Seat s in table)
                {
                    if (s.player != null)
                    {
                        if(s.player.money == 0)
                        {
                            if(s.player is Human)
                            {
                                MessageBox.Show("You have lost all your money\nBetter luck next time");
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else if(s.player is AI)
                            {
                                s.player = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void aiMove()
        {
            try
            {
                AI activeAI = (AI)getActivePlayer();

                activeAI.makeMove(ref shoe);
                displayCards(true);
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void aiBet()
        {
            try
            {
                AI activeAI = (AI)getActivePlayer();

                activeAI.makeBet(rng);
                TextBox betTxtBox = betTxts.First(bet => bet.Name.Contains(currentSeat.ToString()));
                betTxtBox.Text = activeAI.getBet().ToString();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void payoutAndCollect()
        {
            try
            {
                Label tempLabel;
                bool dealerTrueBlackJack = false;
                bool dealerBust = false;
                bool playerTrueBlackJack = false;

                if (dealer.hand.Count() == 2 && dealer.getTotalCardValue() == 21)
                    dealerTrueBlackJack = true;

                if (dealer.getTotalCardValue() > 21)
                    dealerBust = true;

                foreach (Seat s in table)
                {
                    if (!(s.player is Dealer) && s.player != null)
                    {
                        tempLabel = cardValues.First(l => l.Name.Contains(getPlayersSeatNumber(s.player).ToString()));
                        if (s.player.getSurrender())
                        {
                            s.player.collectSurrender();

                            tempLabel.ForeColor = Color.Yellow;
                            tempLabel.Text = "SURRENDERED";
                            s.player.surrender(false);
                            continue;
                        }

                        if (s.player.hand.Count() == 2 && s.player.getTotalCardValue() == 21)
                            playerTrueBlackJack = true;

                        //Losing
                        if ((s.player.getTotalCardValue() > 21) || (s.player.getTotalCardValue() < dealer.getTotalCardValue() && !dealerBust))
                        {
                            tempLabel.ForeColor = Color.Red;
                            if (s.player.getTotalCardValue() > 21)
                                tempLabel.Text = "BUST " + s.player.getTotalCardValue().ToString();
                            else
                                tempLabel.Text = "LOSE " + s.player.getTotalCardValue().ToString();

                            s.player.loseHand();
                        }
                        //Winning
                        else if ((s.player.getTotalCardValue() < 22 && dealerBust) || (s.player.getTotalCardValue() > dealer.getTotalCardValue()) || (playerTrueBlackJack && !dealerTrueBlackJack && s.player.getTotalCardValue() == dealer.getTotalCardValue()))
                        {
                            tempLabel.ForeColor = Color.LawnGreen;
                            tempLabel.Text = "WINNER " + s.player.getTotalCardValue().ToString();

                            determinePayout(s.player, playerTrueBlackJack, dealerTrueBlackJack, dealerBust);
                        }
                        else if (s.player.getTotalCardValue() == dealer.getTotalCardValue())
                        {
                            tempLabel.ForeColor = Color.Blue;
                            tempLabel.Text = "PUSH " + s.player.getTotalCardValue().ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void determinePayout(Player p, bool plyrTrueBlckJck, bool dlrTrueBlckJck, bool dealerBust)
        {
            try
            {
                if (plyrTrueBlckJck && !dlrTrueBlckJck)
                {
                    p.money += (p.getBet() * (3 / 2));
                }
                else if ((p.getTotalCardValue() < 22 && dealerBust) || (p.getTotalCardValue() > dealer.getTotalCardValue()))
                {
                    p.money += p.getBet();
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void createEmptyTable()
        {
            try
            {
                for (int i = 1; i <= 6; i++)
                {
                    table.Add(new Seat(i));
                }

                table.Add(new Seat(7, dealer));
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void sitAtTable(Player p)
        {
            try
            {
                foreach (Seat s in table)
                {
                    if (s.player == null)
                    {
                        s.player = p;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void dealCards()
        {
            try
            {
                for (int i = 0; i < 2; i++) //Deal two cards
                {
                    foreach (Seat s in table)
                    {
                        if (s.player != null)
                        {
                            s.player.hit(ref shoe);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private int getPlayersSeatNumber(Player p)
        {
            try
            {
                return table.First(s => s.player.id == p.id).seatNumber;
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
                return -1;
            }
        }

        private Player getActivePlayer()
        {
            //Gets active player based off current seat
            try
            {
                if (table.First(t => t.seatNumber == currentSeat).player == null)
                    return null;

                if (currentSeat == 7)
                { return dealer; }
                return Players.First(a => a.id == table.First(t => t.seatNumber == currentSeat).player.id);
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
                return null;
            }
        }

        private void setNextCurrentSeat()
        {
            try
            {
                Player activePlayer = getActivePlayer();
                int tempSeat;

                if (activePlayer is Dealer)
                    tempSeat = 7;
                else
                    tempSeat = getPlayersSeatNumber(activePlayer);

                //Keeps going until it gets to the dealer
                while (true)
                {
                    currentSeat = tempSeat + 1;
                    if (currentSeat == 8) //If it was dealer go back to start of table
                        currentSeat = 1;
                    activePlayer = getActivePlayer();
                    if (activePlayer == null)
                        tempSeat += 1;
                    else
                        break;
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void enableDisablePlayerControls(bool placingBet)
        {
            try
            {
                foreach (Button b in hitBtns)
                    b.Visible = false;
                foreach (Button b in standBtns)
                    b.Visible = false;
                foreach (Button b in srrndrBtns)
                    b.Visible = false;
                foreach (Button b in dblDwnBtns)
                    b.Visible = false;
                foreach (Button b in betBtns)
                    b.Visible = false;
                foreach (TextBox t in betTxts)
                    t.Enabled = false;

                if (placingBet && currentSeat != 7)
                {
                    betBtns.First(bet => bet.Name.Contains(currentSeat.ToString())).Visible = true;
                    betTxts.First(bet => bet.Name.Contains(currentSeat.ToString())).Enabled = true;
                }
                else if (!placingBet && currentSeat != 7)
                {
                    hitBtns.First(btn => btn.Name.Contains(currentSeat.ToString())).Visible = true;
                    standBtns.First(btn => btn.Name.Contains(currentSeat.ToString())).Visible = true;
                    srrndrBtns.First(btn => btn.Name.Contains(currentSeat.ToString())).Visible = true;
                    dblDwnBtns.First(btn => btn.Name.Contains(currentSeat.ToString())).Visible = true;
                }
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void btnNextHand_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListBox l in lstBoxs)
                { l.Items.Clear(); }
                lstDealer.Items.Clear();

                foreach (Label l in cardValues)
                {
                    l.ForeColor = Color.Black;
                    l.Text = string.Empty;
                }

                currentSeat = 1;

                foreach (Player p in Players)
                {
                    p.clearHand();
                }
                dealer.clearHand();

                foreach (TextBox t in betTxts)
                {
                    t.Text = string.Empty;
                }

                enableDisablePlayerControls(true);

                btnNextHand.Visible = false;
                lblDealer.Text = string.Empty;
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        #region Display Message
        private void setErrorMessage(string error)
        {
            try
            {
                lblError.Text = error;
                tmrErrorTime.Enabled = true;
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }

        private void tmrErrorTime_Tick(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                tmrErrorTime.Enabled = false;
            }
            catch(Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }
        #endregion

        private void writeToErrorLog(string error)
        {
            if (!File.Exists("ErrorLog.txt"))
            {
                using (File.Create("ErrorLog.txt")) { }
            }

            error = DateTime.Now.ToString() + "  " + error;
            using (StreamWriter sw = File.AppendText("ErrorLog.txt"))
            {
                sw.WriteLine(error);
            }
        }

        #region SavePlayerData
        public void SavePlayers(List<Player> list)
        {
            List<Human> h = new List<Human>();
            foreach(Player p in list)
            {
                if(p is Human)
                {
                    h.Add((Human)p);
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));
            using (TextWriter writer = new StreamWriter("Players.txt"))
            {
                serializer.Serialize(writer, h);
            }
        }

        public void LoadPlayers()
        {
            List<Human> SavedHumans = new List<Human>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Human>));

            using (FileStream fileStream = new FileStream("Players.txt", FileMode.Open))
            {
                SavedHumans = (List<Human>)serializer.Deserialize(fileStream);
            }
        }
        #endregion

        private void BlackJack_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Players[0].clearHand();
            this.DialogResult = DialogResult.OK;
            //this.Close();
            //Environment.Exit(1);
        }

        private void btnLeaveTable_Click(object sender, EventArgs e)
        {
            try
            {
                Players[0].clearHand();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                writeToErrorLog("Function: " + System.Reflection.MethodBase.GetCurrentMethod().Name + " --- Message: " + ex.Message);
            }
        }
    }
}
