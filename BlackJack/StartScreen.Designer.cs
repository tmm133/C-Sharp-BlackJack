namespace BlackJack
{
    partial class StartScreen
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboPlayers = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblNumAI = new System.Windows.Forms.Label();
            this.cboNumAI = new System.Windows.Forms.ComboBox();
            this.cboDecks = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewPlyer = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(159, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(362, 181);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboPlayers
            // 
            this.cboPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPlayers.FormattingEnabled = true;
            this.cboPlayers.Location = new System.Drawing.Point(240, 34);
            this.cboPlayers.Name = "cboPlayers";
            this.cboPlayers.Size = new System.Drawing.Size(185, 21);
            this.cboPlayers.TabIndex = 2;
            this.cboPlayers.SelectedIndexChanged += new System.EventHandler(this.cboPlayers_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(159, 38);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(75, 13);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select Player: ";
            // 
            // lblNumAI
            // 
            this.lblNumAI.AutoSize = true;
            this.lblNumAI.Location = new System.Drawing.Point(189, 103);
            this.lblNumAI.Name = "lblNumAI";
            this.lblNumAI.Size = new System.Drawing.Size(141, 26);
            this.lblNumAI.TabIndex = 4;
            this.lblNumAI.Text = "Number of Computer Players\r\n            To Start with";
            // 
            // cboNumAI
            // 
            this.cboNumAI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumAI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboNumAI.FormattingEnabled = true;
            this.cboNumAI.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboNumAI.Location = new System.Drawing.Point(336, 103);
            this.cboNumAI.Name = "cboNumAI";
            this.cboNumAI.Size = new System.Drawing.Size(64, 21);
            this.cboNumAI.TabIndex = 5;
            // 
            // cboDecks
            // 
            this.cboDecks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDecks.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDecks.FormattingEnabled = true;
            this.cboDecks.Items.AddRange(new object[] {
            "4",
            "6",
            "8"});
            this.cboDecks.Location = new System.Drawing.Point(336, 139);
            this.cboDecks.Name = "cboDecks";
            this.cboDecks.Size = new System.Drawing.Size(64, 21);
            this.cboDecks.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Decks Per Shoe";
            // 
            // btnNewPlyer
            // 
            this.btnNewPlyer.Location = new System.Drawing.Point(224, 66);
            this.btnNewPlyer.Name = "btnNewPlyer";
            this.btnNewPlyer.Size = new System.Drawing.Size(154, 23);
            this.btnNewPlyer.TabIndex = 8;
            this.btnNewPlyer.Text = "New Player";
            this.btnNewPlyer.UseVisualStyleBackColor = true;
            this.btnNewPlyer.Click += new System.EventHandler(this.btnNewPlyer_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(431, 38);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(19, 13);
            this.lblMoney.TabIndex = 9;
            this.lblMoney.Text = "$$";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 238);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.btnNewPlyer);
            this.Controls.Add(this.cboDecks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNumAI);
            this.Controls.Add(this.lblNumAI);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.cboPlayers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboPlayers;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblNumAI;
        private System.Windows.Forms.ComboBox cboNumAI;
        private System.Windows.Forms.ComboBox cboDecks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewPlyer;
        private System.Windows.Forms.Label lblMoney;
    }
}