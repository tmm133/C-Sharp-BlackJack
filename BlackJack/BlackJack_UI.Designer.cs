namespace BlackJack
{
    partial class BlackJack_UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDealer = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lstDealer = new System.Windows.Forms.ListBox();
            this.lstPlayer1 = new System.Windows.Forms.ListBox();
            this.btnHitPlayer1 = new System.Windows.Forms.Button();
            this.btnStandPlayer1 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer1 = new System.Windows.Forms.Button();
            this.btnSrrndrPlayer1 = new System.Windows.Forms.Button();
            this.txtBetPlayer1 = new System.Windows.Forms.TextBox();
            this.btnPlcBetPlayer1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnPlcBetPlayer2 = new System.Windows.Forms.Button();
            this.txtBetPlayer2 = new System.Windows.Forms.TextBox();
            this.btnSrrndrPlayer2 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer2 = new System.Windows.Forms.Button();
            this.btnStandPlayer2 = new System.Windows.Forms.Button();
            this.btnHitPlayer2 = new System.Windows.Forms.Button();
            this.lstPlayer2 = new System.Windows.Forms.ListBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.btnPlcBetPlayer3 = new System.Windows.Forms.Button();
            this.txtBetPlayer3 = new System.Windows.Forms.TextBox();
            this.btnSrrndrPlayer3 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer3 = new System.Windows.Forms.Button();
            this.btnStandPlayer3 = new System.Windows.Forms.Button();
            this.btnHitPlayer3 = new System.Windows.Forms.Button();
            this.lstPlayer3 = new System.Windows.Forms.ListBox();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.btnPlcBetPlayer4 = new System.Windows.Forms.Button();
            this.txtBetPlayer4 = new System.Windows.Forms.TextBox();
            this.btnSrrndrPlayer4 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer4 = new System.Windows.Forms.Button();
            this.btnStandPlayer4 = new System.Windows.Forms.Button();
            this.btnHitPlayer4 = new System.Windows.Forms.Button();
            this.lstPlayer4 = new System.Windows.Forms.ListBox();
            this.lblPlayer4 = new System.Windows.Forms.Label();
            this.btnPlcBetPlayer5 = new System.Windows.Forms.Button();
            this.txtBetPlayer5 = new System.Windows.Forms.TextBox();
            this.btnSrrndrPlayer5 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer5 = new System.Windows.Forms.Button();
            this.btnStandPlayer5 = new System.Windows.Forms.Button();
            this.btnHitPlayer5 = new System.Windows.Forms.Button();
            this.lstPlayer5 = new System.Windows.Forms.ListBox();
            this.lblPlayer5 = new System.Windows.Forms.Label();
            this.btnPlcBetPlayer6 = new System.Windows.Forms.Button();
            this.txtBetPlayer6 = new System.Windows.Forms.TextBox();
            this.btnSrrndrPlayer6 = new System.Windows.Forms.Button();
            this.btnDblDwnPlayer6 = new System.Windows.Forms.Button();
            this.btnStandPlayer6 = new System.Windows.Forms.Button();
            this.btnHitPlayer6 = new System.Windows.Forms.Button();
            this.lstPlayer6 = new System.Windows.Forms.ListBox();
            this.lblPlayer6 = new System.Windows.Forms.Label();
            this.btnNextHand = new System.Windows.Forms.Button();
            this.tmrErrorTime = new System.Windows.Forms.Timer(this.components);
            this.CardValue1 = new System.Windows.Forms.Label();
            this.CardValue2 = new System.Windows.Forms.Label();
            this.CardValue3 = new System.Windows.Forms.Label();
            this.CardValue4 = new System.Windows.Forms.Label();
            this.CardValue5 = new System.Windows.Forms.Label();
            this.CardValue6 = new System.Windows.Forms.Label();
            this.btnLeaveTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(368, 2);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(38, 13);
            this.lblDealer.TabIndex = 0;
            this.lblDealer.Text = "Dealer";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(630, 306);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player1";
            // 
            // lstDealer
            // 
            this.lstDealer.FormattingEnabled = true;
            this.lstDealer.Location = new System.Drawing.Point(363, 18);
            this.lstDealer.Name = "lstDealer";
            this.lstDealer.Size = new System.Drawing.Size(49, 108);
            this.lstDealer.TabIndex = 2;
            // 
            // lstPlayer1
            // 
            this.lstPlayer1.FormattingEnabled = true;
            this.lstPlayer1.Location = new System.Drawing.Point(637, 195);
            this.lstPlayer1.Name = "lstPlayer1";
            this.lstPlayer1.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer1.TabIndex = 3;
            // 
            // btnHitPlayer1
            // 
            this.btnHitPlayer1.Location = new System.Drawing.Point(692, 195);
            this.btnHitPlayer1.Name = "btnHitPlayer1";
            this.btnHitPlayer1.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer1.TabIndex = 4;
            this.btnHitPlayer1.Text = "Hit";
            this.btnHitPlayer1.UseVisualStyleBackColor = true;
            this.btnHitPlayer1.Visible = false;
            this.btnHitPlayer1.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStandPlayer1
            // 
            this.btnStandPlayer1.Location = new System.Drawing.Point(692, 224);
            this.btnStandPlayer1.Name = "btnStandPlayer1";
            this.btnStandPlayer1.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer1.TabIndex = 5;
            this.btnStandPlayer1.Text = "Stand";
            this.btnStandPlayer1.UseVisualStyleBackColor = true;
            this.btnStandPlayer1.Visible = false;
            this.btnStandPlayer1.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnDblDwnPlayer1
            // 
            this.btnDblDwnPlayer1.Location = new System.Drawing.Point(692, 253);
            this.btnDblDwnPlayer1.Name = "btnDblDwnPlayer1";
            this.btnDblDwnPlayer1.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer1.TabIndex = 6;
            this.btnDblDwnPlayer1.Text = "Double Down";
            this.btnDblDwnPlayer1.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer1.Visible = false;
            this.btnDblDwnPlayer1.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnSrrndrPlayer1
            // 
            this.btnSrrndrPlayer1.Location = new System.Drawing.Point(692, 282);
            this.btnSrrndrPlayer1.Name = "btnSrrndrPlayer1";
            this.btnSrrndrPlayer1.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer1.TabIndex = 7;
            this.btnSrrndrPlayer1.Text = "Surrender";
            this.btnSrrndrPlayer1.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer1.Visible = false;
            this.btnSrrndrPlayer1.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // txtBetPlayer1
            // 
            this.txtBetPlayer1.Location = new System.Drawing.Point(617, 169);
            this.txtBetPlayer1.Name = "txtBetPlayer1";
            this.txtBetPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer1.TabIndex = 8;
            // 
            // btnPlcBetPlayer1
            // 
            this.btnPlcBetPlayer1.Location = new System.Drawing.Point(624, 140);
            this.btnPlcBetPlayer1.Name = "btnPlcBetPlayer1";
            this.btnPlcBetPlayer1.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer1.TabIndex = 9;
            this.btnPlcBetPlayer1.Text = "PlaceBet";
            this.btnPlcBetPlayer1.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer1.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(144, 140);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(67, 29);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "Error";
            // 
            // btnPlcBetPlayer2
            // 
            this.btnPlcBetPlayer2.Location = new System.Drawing.Point(548, 327);
            this.btnPlcBetPlayer2.Name = "btnPlcBetPlayer2";
            this.btnPlcBetPlayer2.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer2.TabIndex = 18;
            this.btnPlcBetPlayer2.Text = "PlaceBet";
            this.btnPlcBetPlayer2.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer2.Visible = false;
            this.btnPlcBetPlayer2.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // txtBetPlayer2
            // 
            this.txtBetPlayer2.Enabled = false;
            this.txtBetPlayer2.Location = new System.Drawing.Point(541, 356);
            this.txtBetPlayer2.Name = "txtBetPlayer2";
            this.txtBetPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer2.TabIndex = 17;
            // 
            // btnSrrndrPlayer2
            // 
            this.btnSrrndrPlayer2.Location = new System.Drawing.Point(616, 469);
            this.btnSrrndrPlayer2.Name = "btnSrrndrPlayer2";
            this.btnSrrndrPlayer2.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer2.TabIndex = 16;
            this.btnSrrndrPlayer2.Text = "Surrender";
            this.btnSrrndrPlayer2.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer2.Visible = false;
            this.btnSrrndrPlayer2.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnDblDwnPlayer2
            // 
            this.btnDblDwnPlayer2.Location = new System.Drawing.Point(616, 440);
            this.btnDblDwnPlayer2.Name = "btnDblDwnPlayer2";
            this.btnDblDwnPlayer2.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer2.TabIndex = 15;
            this.btnDblDwnPlayer2.Text = "Double Down";
            this.btnDblDwnPlayer2.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer2.Visible = false;
            this.btnDblDwnPlayer2.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnStandPlayer2
            // 
            this.btnStandPlayer2.Location = new System.Drawing.Point(616, 411);
            this.btnStandPlayer2.Name = "btnStandPlayer2";
            this.btnStandPlayer2.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer2.TabIndex = 14;
            this.btnStandPlayer2.Text = "Stand";
            this.btnStandPlayer2.UseVisualStyleBackColor = true;
            this.btnStandPlayer2.Visible = false;
            this.btnStandPlayer2.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHitPlayer2
            // 
            this.btnHitPlayer2.Location = new System.Drawing.Point(616, 382);
            this.btnHitPlayer2.Name = "btnHitPlayer2";
            this.btnHitPlayer2.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer2.TabIndex = 13;
            this.btnHitPlayer2.Text = "Hit";
            this.btnHitPlayer2.UseVisualStyleBackColor = true;
            this.btnHitPlayer2.Visible = false;
            this.btnHitPlayer2.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstPlayer2
            // 
            this.lstPlayer2.FormattingEnabled = true;
            this.lstPlayer2.Location = new System.Drawing.Point(561, 382);
            this.lstPlayer2.Name = "lstPlayer2";
            this.lstPlayer2.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer2.TabIndex = 12;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(554, 493);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer2.TabIndex = 11;
            this.lblPlayer2.Text = "Player2";
            // 
            // btnPlcBetPlayer3
            // 
            this.btnPlcBetPlayer3.Location = new System.Drawing.Point(388, 377);
            this.btnPlcBetPlayer3.Name = "btnPlcBetPlayer3";
            this.btnPlcBetPlayer3.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer3.TabIndex = 26;
            this.btnPlcBetPlayer3.Text = "PlaceBet";
            this.btnPlcBetPlayer3.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer3.Visible = false;
            this.btnPlcBetPlayer3.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // txtBetPlayer3
            // 
            this.txtBetPlayer3.Enabled = false;
            this.txtBetPlayer3.Location = new System.Drawing.Point(381, 406);
            this.txtBetPlayer3.Name = "txtBetPlayer3";
            this.txtBetPlayer3.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer3.TabIndex = 25;
            // 
            // btnSrrndrPlayer3
            // 
            this.btnSrrndrPlayer3.Location = new System.Drawing.Point(456, 519);
            this.btnSrrndrPlayer3.Name = "btnSrrndrPlayer3";
            this.btnSrrndrPlayer3.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer3.TabIndex = 24;
            this.btnSrrndrPlayer3.Text = "Surrender";
            this.btnSrrndrPlayer3.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer3.Visible = false;
            this.btnSrrndrPlayer3.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnDblDwnPlayer3
            // 
            this.btnDblDwnPlayer3.Location = new System.Drawing.Point(456, 490);
            this.btnDblDwnPlayer3.Name = "btnDblDwnPlayer3";
            this.btnDblDwnPlayer3.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer3.TabIndex = 23;
            this.btnDblDwnPlayer3.Text = "Double Down";
            this.btnDblDwnPlayer3.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer3.Visible = false;
            this.btnDblDwnPlayer3.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnStandPlayer3
            // 
            this.btnStandPlayer3.Location = new System.Drawing.Point(456, 461);
            this.btnStandPlayer3.Name = "btnStandPlayer3";
            this.btnStandPlayer3.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer3.TabIndex = 22;
            this.btnStandPlayer3.Text = "Stand";
            this.btnStandPlayer3.UseVisualStyleBackColor = true;
            this.btnStandPlayer3.Visible = false;
            this.btnStandPlayer3.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHitPlayer3
            // 
            this.btnHitPlayer3.Location = new System.Drawing.Point(456, 432);
            this.btnHitPlayer3.Name = "btnHitPlayer3";
            this.btnHitPlayer3.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer3.TabIndex = 21;
            this.btnHitPlayer3.Text = "Hit";
            this.btnHitPlayer3.UseVisualStyleBackColor = true;
            this.btnHitPlayer3.Visible = false;
            this.btnHitPlayer3.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstPlayer3
            // 
            this.lstPlayer3.FormattingEnabled = true;
            this.lstPlayer3.Location = new System.Drawing.Point(401, 432);
            this.lstPlayer3.Name = "lstPlayer3";
            this.lstPlayer3.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer3.TabIndex = 20;
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.AutoSize = true;
            this.lblPlayer3.Location = new System.Drawing.Point(394, 543);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer3.TabIndex = 19;
            this.lblPlayer3.Text = "Player3";
            // 
            // btnPlcBetPlayer4
            // 
            this.btnPlcBetPlayer4.Location = new System.Drawing.Point(223, 379);
            this.btnPlcBetPlayer4.Name = "btnPlcBetPlayer4";
            this.btnPlcBetPlayer4.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer4.TabIndex = 34;
            this.btnPlcBetPlayer4.Text = "PlaceBet";
            this.btnPlcBetPlayer4.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer4.Visible = false;
            this.btnPlcBetPlayer4.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // txtBetPlayer4
            // 
            this.txtBetPlayer4.Enabled = false;
            this.txtBetPlayer4.Location = new System.Drawing.Point(216, 408);
            this.txtBetPlayer4.Name = "txtBetPlayer4";
            this.txtBetPlayer4.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer4.TabIndex = 33;
            // 
            // btnSrrndrPlayer4
            // 
            this.btnSrrndrPlayer4.Location = new System.Drawing.Point(291, 521);
            this.btnSrrndrPlayer4.Name = "btnSrrndrPlayer4";
            this.btnSrrndrPlayer4.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer4.TabIndex = 32;
            this.btnSrrndrPlayer4.Text = "Surrender";
            this.btnSrrndrPlayer4.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer4.Visible = false;
            this.btnSrrndrPlayer4.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnDblDwnPlayer4
            // 
            this.btnDblDwnPlayer4.Location = new System.Drawing.Point(291, 492);
            this.btnDblDwnPlayer4.Name = "btnDblDwnPlayer4";
            this.btnDblDwnPlayer4.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer4.TabIndex = 31;
            this.btnDblDwnPlayer4.Text = "Double Down";
            this.btnDblDwnPlayer4.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer4.Visible = false;
            this.btnDblDwnPlayer4.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnStandPlayer4
            // 
            this.btnStandPlayer4.Location = new System.Drawing.Point(291, 463);
            this.btnStandPlayer4.Name = "btnStandPlayer4";
            this.btnStandPlayer4.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer4.TabIndex = 30;
            this.btnStandPlayer4.Text = "Stand";
            this.btnStandPlayer4.UseVisualStyleBackColor = true;
            this.btnStandPlayer4.Visible = false;
            this.btnStandPlayer4.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHitPlayer4
            // 
            this.btnHitPlayer4.Location = new System.Drawing.Point(291, 434);
            this.btnHitPlayer4.Name = "btnHitPlayer4";
            this.btnHitPlayer4.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer4.TabIndex = 29;
            this.btnHitPlayer4.Text = "Hit";
            this.btnHitPlayer4.UseVisualStyleBackColor = true;
            this.btnHitPlayer4.Visible = false;
            this.btnHitPlayer4.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstPlayer4
            // 
            this.lstPlayer4.FormattingEnabled = true;
            this.lstPlayer4.Location = new System.Drawing.Point(236, 434);
            this.lstPlayer4.Name = "lstPlayer4";
            this.lstPlayer4.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer4.TabIndex = 28;
            // 
            // lblPlayer4
            // 
            this.lblPlayer4.AutoSize = true;
            this.lblPlayer4.Location = new System.Drawing.Point(229, 545);
            this.lblPlayer4.Name = "lblPlayer4";
            this.lblPlayer4.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer4.TabIndex = 27;
            this.lblPlayer4.Text = "Player4";
            // 
            // btnPlcBetPlayer5
            // 
            this.btnPlcBetPlayer5.Location = new System.Drawing.Point(43, 327);
            this.btnPlcBetPlayer5.Name = "btnPlcBetPlayer5";
            this.btnPlcBetPlayer5.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer5.TabIndex = 42;
            this.btnPlcBetPlayer5.Text = "PlaceBet";
            this.btnPlcBetPlayer5.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer5.Visible = false;
            this.btnPlcBetPlayer5.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // txtBetPlayer5
            // 
            this.txtBetPlayer5.Enabled = false;
            this.txtBetPlayer5.Location = new System.Drawing.Point(36, 356);
            this.txtBetPlayer5.Name = "txtBetPlayer5";
            this.txtBetPlayer5.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer5.TabIndex = 41;
            // 
            // btnSrrndrPlayer5
            // 
            this.btnSrrndrPlayer5.Location = new System.Drawing.Point(111, 469);
            this.btnSrrndrPlayer5.Name = "btnSrrndrPlayer5";
            this.btnSrrndrPlayer5.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer5.TabIndex = 40;
            this.btnSrrndrPlayer5.Text = "Surrender";
            this.btnSrrndrPlayer5.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer5.Visible = false;
            this.btnSrrndrPlayer5.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnDblDwnPlayer5
            // 
            this.btnDblDwnPlayer5.Location = new System.Drawing.Point(111, 440);
            this.btnDblDwnPlayer5.Name = "btnDblDwnPlayer5";
            this.btnDblDwnPlayer5.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer5.TabIndex = 39;
            this.btnDblDwnPlayer5.Text = "Double Down";
            this.btnDblDwnPlayer5.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer5.Visible = false;
            this.btnDblDwnPlayer5.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnStandPlayer5
            // 
            this.btnStandPlayer5.Location = new System.Drawing.Point(111, 411);
            this.btnStandPlayer5.Name = "btnStandPlayer5";
            this.btnStandPlayer5.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer5.TabIndex = 38;
            this.btnStandPlayer5.Text = "Stand";
            this.btnStandPlayer5.UseVisualStyleBackColor = true;
            this.btnStandPlayer5.Visible = false;
            this.btnStandPlayer5.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHitPlayer5
            // 
            this.btnHitPlayer5.Location = new System.Drawing.Point(111, 382);
            this.btnHitPlayer5.Name = "btnHitPlayer5";
            this.btnHitPlayer5.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer5.TabIndex = 37;
            this.btnHitPlayer5.Text = "Hit";
            this.btnHitPlayer5.UseVisualStyleBackColor = true;
            this.btnHitPlayer5.Visible = false;
            this.btnHitPlayer5.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstPlayer5
            // 
            this.lstPlayer5.FormattingEnabled = true;
            this.lstPlayer5.Location = new System.Drawing.Point(56, 382);
            this.lstPlayer5.Name = "lstPlayer5";
            this.lstPlayer5.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer5.TabIndex = 36;
            // 
            // lblPlayer5
            // 
            this.lblPlayer5.AutoSize = true;
            this.lblPlayer5.Location = new System.Drawing.Point(49, 493);
            this.lblPlayer5.Name = "lblPlayer5";
            this.lblPlayer5.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer5.TabIndex = 35;
            this.lblPlayer5.Text = "Player5";
            // 
            // btnPlcBetPlayer6
            // 
            this.btnPlcBetPlayer6.Location = new System.Drawing.Point(13, 140);
            this.btnPlcBetPlayer6.Name = "btnPlcBetPlayer6";
            this.btnPlcBetPlayer6.Size = new System.Drawing.Size(85, 23);
            this.btnPlcBetPlayer6.TabIndex = 50;
            this.btnPlcBetPlayer6.Text = "PlaceBet";
            this.btnPlcBetPlayer6.UseVisualStyleBackColor = true;
            this.btnPlcBetPlayer6.Visible = false;
            this.btnPlcBetPlayer6.Click += new System.EventHandler(this.btnPlcBet_Click);
            // 
            // txtBetPlayer6
            // 
            this.txtBetPlayer6.Enabled = false;
            this.txtBetPlayer6.Location = new System.Drawing.Point(6, 169);
            this.txtBetPlayer6.Name = "txtBetPlayer6";
            this.txtBetPlayer6.Size = new System.Drawing.Size(100, 20);
            this.txtBetPlayer6.TabIndex = 49;
            // 
            // btnSrrndrPlayer6
            // 
            this.btnSrrndrPlayer6.Location = new System.Drawing.Point(81, 282);
            this.btnSrrndrPlayer6.Name = "btnSrrndrPlayer6";
            this.btnSrrndrPlayer6.Size = new System.Drawing.Size(85, 23);
            this.btnSrrndrPlayer6.TabIndex = 48;
            this.btnSrrndrPlayer6.Text = "Surrender";
            this.btnSrrndrPlayer6.UseVisualStyleBackColor = true;
            this.btnSrrndrPlayer6.Visible = false;
            this.btnSrrndrPlayer6.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnDblDwnPlayer6
            // 
            this.btnDblDwnPlayer6.Location = new System.Drawing.Point(81, 253);
            this.btnDblDwnPlayer6.Name = "btnDblDwnPlayer6";
            this.btnDblDwnPlayer6.Size = new System.Drawing.Size(85, 23);
            this.btnDblDwnPlayer6.TabIndex = 47;
            this.btnDblDwnPlayer6.Text = "Double Down";
            this.btnDblDwnPlayer6.UseVisualStyleBackColor = true;
            this.btnDblDwnPlayer6.Visible = false;
            this.btnDblDwnPlayer6.Click += new System.EventHandler(this.btnDoubleDown_Click);
            // 
            // btnStandPlayer6
            // 
            this.btnStandPlayer6.Location = new System.Drawing.Point(81, 224);
            this.btnStandPlayer6.Name = "btnStandPlayer6";
            this.btnStandPlayer6.Size = new System.Drawing.Size(85, 23);
            this.btnStandPlayer6.TabIndex = 46;
            this.btnStandPlayer6.Text = "Stand";
            this.btnStandPlayer6.UseVisualStyleBackColor = true;
            this.btnStandPlayer6.Visible = false;
            this.btnStandPlayer6.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnHitPlayer6
            // 
            this.btnHitPlayer6.Location = new System.Drawing.Point(81, 195);
            this.btnHitPlayer6.Name = "btnHitPlayer6";
            this.btnHitPlayer6.Size = new System.Drawing.Size(85, 23);
            this.btnHitPlayer6.TabIndex = 45;
            this.btnHitPlayer6.Text = "Hit";
            this.btnHitPlayer6.UseVisualStyleBackColor = true;
            this.btnHitPlayer6.Visible = false;
            this.btnHitPlayer6.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // lstPlayer6
            // 
            this.lstPlayer6.FormattingEnabled = true;
            this.lstPlayer6.Location = new System.Drawing.Point(26, 195);
            this.lstPlayer6.Name = "lstPlayer6";
            this.lstPlayer6.Size = new System.Drawing.Size(49, 108);
            this.lstPlayer6.TabIndex = 44;
            // 
            // lblPlayer6
            // 
            this.lblPlayer6.AutoSize = true;
            this.lblPlayer6.Location = new System.Drawing.Point(19, 306);
            this.lblPlayer6.Name = "lblPlayer6";
            this.lblPlayer6.Size = new System.Drawing.Size(42, 13);
            this.lblPlayer6.TabIndex = 43;
            this.lblPlayer6.Text = "Player6";
            // 
            // btnNextHand
            // 
            this.btnNextHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextHand.Location = new System.Drawing.Point(327, 195);
            this.btnNextHand.Name = "btnNextHand";
            this.btnNextHand.Size = new System.Drawing.Size(125, 40);
            this.btnNextHand.TabIndex = 51;
            this.btnNextHand.Text = "Next Hand";
            this.btnNextHand.UseVisualStyleBackColor = true;
            this.btnNextHand.Visible = false;
            this.btnNextHand.Click += new System.EventHandler(this.btnNextHand_Click);
            // 
            // tmrErrorTime
            // 
            this.tmrErrorTime.Interval = 1500;
            this.tmrErrorTime.Tick += new System.EventHandler(this.tmrErrorTime_Tick);
            // 
            // CardValue1
            // 
            this.CardValue1.AutoSize = true;
            this.CardValue1.BackColor = System.Drawing.Color.White;
            this.CardValue1.Location = new System.Drawing.Point(646, 287);
            this.CardValue1.Name = "CardValue1";
            this.CardValue1.Size = new System.Drawing.Size(27, 13);
            this.CardValue1.TabIndex = 52;
            this.CardValue1.Text = "(##)";
            // 
            // CardValue2
            // 
            this.CardValue2.AutoSize = true;
            this.CardValue2.BackColor = System.Drawing.Color.White;
            this.CardValue2.Location = new System.Drawing.Point(571, 474);
            this.CardValue2.Name = "CardValue2";
            this.CardValue2.Size = new System.Drawing.Size(27, 13);
            this.CardValue2.TabIndex = 53;
            this.CardValue2.Text = "(##)";
            // 
            // CardValue3
            // 
            this.CardValue3.AutoSize = true;
            this.CardValue3.BackColor = System.Drawing.Color.White;
            this.CardValue3.Location = new System.Drawing.Point(411, 524);
            this.CardValue3.Name = "CardValue3";
            this.CardValue3.Size = new System.Drawing.Size(27, 13);
            this.CardValue3.TabIndex = 54;
            this.CardValue3.Text = "(##)";
            // 
            // CardValue4
            // 
            this.CardValue4.AutoSize = true;
            this.CardValue4.BackColor = System.Drawing.Color.White;
            this.CardValue4.Location = new System.Drawing.Point(246, 526);
            this.CardValue4.Name = "CardValue4";
            this.CardValue4.Size = new System.Drawing.Size(27, 13);
            this.CardValue4.TabIndex = 55;
            this.CardValue4.Text = "(##)";
            // 
            // CardValue5
            // 
            this.CardValue5.AutoSize = true;
            this.CardValue5.BackColor = System.Drawing.Color.White;
            this.CardValue5.Location = new System.Drawing.Point(67, 474);
            this.CardValue5.Name = "CardValue5";
            this.CardValue5.Size = new System.Drawing.Size(27, 13);
            this.CardValue5.TabIndex = 56;
            this.CardValue5.Text = "(##)";
            // 
            // CardValue6
            // 
            this.CardValue6.AutoSize = true;
            this.CardValue6.BackColor = System.Drawing.Color.White;
            this.CardValue6.Location = new System.Drawing.Point(37, 287);
            this.CardValue6.Name = "CardValue6";
            this.CardValue6.Size = new System.Drawing.Size(27, 13);
            this.CardValue6.TabIndex = 57;
            this.CardValue6.Text = "(##)";
            // 
            // btnLeaveTable
            // 
            this.btnLeaveTable.Location = new System.Drawing.Point(702, 2);
            this.btnLeaveTable.Name = "btnLeaveTable";
            this.btnLeaveTable.Size = new System.Drawing.Size(75, 23);
            this.btnLeaveTable.TabIndex = 58;
            this.btnLeaveTable.Text = "Leave Table";
            this.btnLeaveTable.UseVisualStyleBackColor = true;
            this.btnLeaveTable.Click += new System.EventHandler(this.btnLeaveTable_Click);
            // 
            // BlackJack_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLeaveTable);
            this.Controls.Add(this.CardValue6);
            this.Controls.Add(this.CardValue5);
            this.Controls.Add(this.CardValue4);
            this.Controls.Add(this.CardValue3);
            this.Controls.Add(this.CardValue2);
            this.Controls.Add(this.CardValue1);
            this.Controls.Add(this.btnNextHand);
            this.Controls.Add(this.btnPlcBetPlayer6);
            this.Controls.Add(this.txtBetPlayer6);
            this.Controls.Add(this.btnSrrndrPlayer6);
            this.Controls.Add(this.btnDblDwnPlayer6);
            this.Controls.Add(this.btnStandPlayer6);
            this.Controls.Add(this.btnHitPlayer6);
            this.Controls.Add(this.lstPlayer6);
            this.Controls.Add(this.lblPlayer6);
            this.Controls.Add(this.btnPlcBetPlayer5);
            this.Controls.Add(this.txtBetPlayer5);
            this.Controls.Add(this.btnSrrndrPlayer5);
            this.Controls.Add(this.btnDblDwnPlayer5);
            this.Controls.Add(this.btnStandPlayer5);
            this.Controls.Add(this.btnHitPlayer5);
            this.Controls.Add(this.lstPlayer5);
            this.Controls.Add(this.lblPlayer5);
            this.Controls.Add(this.btnPlcBetPlayer4);
            this.Controls.Add(this.txtBetPlayer4);
            this.Controls.Add(this.btnSrrndrPlayer4);
            this.Controls.Add(this.btnDblDwnPlayer4);
            this.Controls.Add(this.btnStandPlayer4);
            this.Controls.Add(this.btnHitPlayer4);
            this.Controls.Add(this.lstPlayer4);
            this.Controls.Add(this.lblPlayer4);
            this.Controls.Add(this.btnPlcBetPlayer3);
            this.Controls.Add(this.txtBetPlayer3);
            this.Controls.Add(this.btnSrrndrPlayer3);
            this.Controls.Add(this.btnDblDwnPlayer3);
            this.Controls.Add(this.btnStandPlayer3);
            this.Controls.Add(this.btnHitPlayer3);
            this.Controls.Add(this.lstPlayer3);
            this.Controls.Add(this.lblPlayer3);
            this.Controls.Add(this.btnPlcBetPlayer2);
            this.Controls.Add(this.txtBetPlayer2);
            this.Controls.Add(this.btnSrrndrPlayer2);
            this.Controls.Add(this.btnDblDwnPlayer2);
            this.Controls.Add(this.btnStandPlayer2);
            this.Controls.Add(this.btnHitPlayer2);
            this.Controls.Add(this.lstPlayer2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPlcBetPlayer1);
            this.Controls.Add(this.txtBetPlayer1);
            this.Controls.Add(this.btnSrrndrPlayer1);
            this.Controls.Add(this.btnDblDwnPlayer1);
            this.Controls.Add(this.btnStandPlayer1);
            this.Controls.Add(this.btnHitPlayer1);
            this.Controls.Add(this.lstPlayer1);
            this.Controls.Add(this.lstDealer);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblDealer);
            this.Name = "BlackJack_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BlackJack_UI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.ListBox lstDealer;
        private System.Windows.Forms.ListBox lstPlayer1;
        private System.Windows.Forms.Button btnHitPlayer1;
        private System.Windows.Forms.Button btnStandPlayer1;
        private System.Windows.Forms.Button btnDblDwnPlayer1;
        private System.Windows.Forms.Button btnSrrndrPlayer1;
        private System.Windows.Forms.TextBox txtBetPlayer1;
        private System.Windows.Forms.Button btnPlcBetPlayer1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnPlcBetPlayer2;
        private System.Windows.Forms.TextBox txtBetPlayer2;
        private System.Windows.Forms.Button btnSrrndrPlayer2;
        private System.Windows.Forms.Button btnDblDwnPlayer2;
        private System.Windows.Forms.Button btnStandPlayer2;
        private System.Windows.Forms.Button btnHitPlayer2;
        private System.Windows.Forms.ListBox lstPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Button btnPlcBetPlayer3;
        private System.Windows.Forms.TextBox txtBetPlayer3;
        private System.Windows.Forms.Button btnSrrndrPlayer3;
        private System.Windows.Forms.Button btnDblDwnPlayer3;
        private System.Windows.Forms.Button btnStandPlayer3;
        private System.Windows.Forms.Button btnHitPlayer3;
        private System.Windows.Forms.ListBox lstPlayer3;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Button btnPlcBetPlayer4;
        private System.Windows.Forms.TextBox txtBetPlayer4;
        private System.Windows.Forms.Button btnSrrndrPlayer4;
        private System.Windows.Forms.Button btnDblDwnPlayer4;
        private System.Windows.Forms.Button btnStandPlayer4;
        private System.Windows.Forms.Button btnHitPlayer4;
        private System.Windows.Forms.ListBox lstPlayer4;
        private System.Windows.Forms.Label lblPlayer4;
        private System.Windows.Forms.Button btnPlcBetPlayer5;
        private System.Windows.Forms.TextBox txtBetPlayer5;
        private System.Windows.Forms.Button btnSrrndrPlayer5;
        private System.Windows.Forms.Button btnDblDwnPlayer5;
        private System.Windows.Forms.Button btnStandPlayer5;
        private System.Windows.Forms.Button btnHitPlayer5;
        private System.Windows.Forms.ListBox lstPlayer5;
        private System.Windows.Forms.Label lblPlayer5;
        private System.Windows.Forms.Button btnPlcBetPlayer6;
        private System.Windows.Forms.TextBox txtBetPlayer6;
        private System.Windows.Forms.Button btnSrrndrPlayer6;
        private System.Windows.Forms.Button btnDblDwnPlayer6;
        private System.Windows.Forms.Button btnStandPlayer6;
        private System.Windows.Forms.Button btnHitPlayer6;
        private System.Windows.Forms.ListBox lstPlayer6;
        private System.Windows.Forms.Label lblPlayer6;
        private System.Windows.Forms.Button btnNextHand;
        private System.Windows.Forms.Timer tmrErrorTime;
        private System.Windows.Forms.Label CardValue1;
        private System.Windows.Forms.Label CardValue2;
        private System.Windows.Forms.Label CardValue3;
        private System.Windows.Forms.Label CardValue4;
        private System.Windows.Forms.Label CardValue5;
        private System.Windows.Forms.Label CardValue6;
        private System.Windows.Forms.Button btnLeaveTable;
    }
}

