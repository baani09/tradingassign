namespace assign3_rad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPlayers = new DataGridView();
            panelCard = new Panel();
            pictureBoxPlayer = new PictureBox();
            lblPlayerRating = new Label();
            lblPlayerMatches = new Label();
            lblPlayerAssists = new Label();
            lblPlayerGoals = new Label();
            lblPlayerTeam = new Label();
            lblPlayerName = new Label();
            addbtn = new Button();
            removebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).BeginInit();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            SuspendLayout();
            // 
            // dgvPlayers
            // 
            dgvPlayers.AllowUserToOrderColumns = true;
            dgvPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlayers.Location = new Point(12, 12);
            dgvPlayers.Name = "dgvPlayers";
            dgvPlayers.RowHeadersWidth = 51;
            dgvPlayers.Size = new Size(300, 188);
            dgvPlayers.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.Controls.Add(pictureBoxPlayer);
            panelCard.Controls.Add(lblPlayerRating);
            panelCard.Controls.Add(lblPlayerMatches);
            panelCard.Controls.Add(lblPlayerAssists);
            panelCard.Controls.Add(lblPlayerGoals);
            panelCard.Controls.Add(lblPlayerTeam);
            panelCard.Controls.Add(lblPlayerName);
            panelCard.Location = new Point(449, 22);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(282, 357);
            panelCard.TabIndex = 1;
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(42, 198);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(189, 131);
            pictureBoxPlayer.TabIndex = 5;
            pictureBoxPlayer.TabStop = false;
            // 
            // lblPlayerRating
            // 
            lblPlayerRating.AutoSize = true;
            lblPlayerRating.Location = new Point(97, 175);
            lblPlayerRating.Name = "lblPlayerRating";
            lblPlayerRating.Size = new Size(50, 20);
            lblPlayerRating.TabIndex = 4;
            lblPlayerRating.Text = "label1";
            // 
            // lblPlayerMatches
            // 
            lblPlayerMatches.AutoSize = true;
            lblPlayerMatches.Location = new Point(97, 146);
            lblPlayerMatches.Name = "lblPlayerMatches";
            lblPlayerMatches.Size = new Size(50, 20);
            lblPlayerMatches.TabIndex = 3;
            lblPlayerMatches.Text = "label1";
            // 
            // lblPlayerAssists
            // 
            lblPlayerAssists.AutoSize = true;
            lblPlayerAssists.Location = new Point(97, 116);
            lblPlayerAssists.Name = "lblPlayerAssists";
            lblPlayerAssists.Size = new Size(50, 20);
            lblPlayerAssists.TabIndex = 2;
            lblPlayerAssists.Text = "label1";
            // 
            // lblPlayerGoals
            // 
            lblPlayerGoals.AutoSize = true;
            lblPlayerGoals.Location = new Point(97, 87);
            lblPlayerGoals.Name = "lblPlayerGoals";
            lblPlayerGoals.Size = new Size(54, 20);
            lblPlayerGoals.TabIndex = 2;
            lblPlayerGoals.Text = "label 3";
            // 
            // lblPlayerTeam
            // 
            lblPlayerTeam.AutoSize = true;
            lblPlayerTeam.Location = new Point(97, 57);
            lblPlayerTeam.Name = "lblPlayerTeam";
            lblPlayerTeam.Size = new Size(50, 20);
            lblPlayerTeam.TabIndex = 1;
            lblPlayerTeam.Text = "label1";
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(97, 27);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(50, 20);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "label1";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(61, 232);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(144, 29);
            addbtn.TabIndex = 2;
            addbtn.Text = "add new player";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // removebtn
            // 
            removebtn.Location = new Point(61, 291);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(144, 29);
            removebtn.TabIndex = 3;
            removebtn.Text = "remove player";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += removebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(panelCard);
            Controls.Add(dgvPlayers);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvPlayers).EndInit();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPlayers;
        private Panel panelCard;
        private Label lblPlayerGoals;
        private Label lblPlayerTeam;
        private Label lblPlayerName;
        private PictureBox pictureBoxPlayer;
        private Label lblPlayerRating;
        private Label lblPlayerMatches;
        private Label lblPlayerAssists;
        private Button addbtn;
        private Button removebtn;
    }
}
