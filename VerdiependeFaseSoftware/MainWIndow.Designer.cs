namespace VerdiependeFaseSoftware
{
    partial class MainWIndow
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
            groupBox2=new GroupBox();
            lbxPlayer1=new ListBox();
            btnGetRandomPlayer1=new Button();
            label2=new Label();
            cmxClubPlayer1=new ComboBox();
            label1=new Label();
            cmxLeaguePlayer1=new ComboBox();
            lblControl=new Label();
            lblDefend=new Label();
            lblAttack=new Label();
            groupBox1=new GroupBox();
            button2=new Button();
            label3=new Label();
            cmxClubPlayer2=new ComboBox();
            label4=new Label();
            cmxLeaguePlayer2=new ComboBox();
            pictureBox2=new PictureBox();
            label5=new Label();
            label6=new Label();
            label10=new Label();
            menuStrip1=new MenuStrip();
            infoToolStripMenuItem=new ToolStripMenuItem();
            aboutToolStripMenuItem=new ToolStripMenuItem();
            githubToolStripMenuItem=new ToolStripMenuItem();
            exitToolStripMenuItem=new ToolStripMenuItem();
            gamesToolStripMenuItem=new ToolStripMenuItem();
            game1ToolStripMenuItem=new ToolStripMenuItem();
            game2ToolStripMenuItem=new ToolStripMenuItem();
            game3ToolStripMenuItem=new ToolStripMenuItem();
            playerToolStripMenuItem=new ToolStripMenuItem();
            playerOverviewToolStripMenuItem=new ToolStripMenuItem();
            teamToolStripMenuItem=new ToolStripMenuItem();
            leagueToolStripMenuItem=new ToolStripMenuItem();
            lblPlayerName1=new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPlayerName1);
            groupBox2.Controls.Add(lbxPlayer1);
            groupBox2.Controls.Add(btnGetRandomPlayer1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmxClubPlayer1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmxLeaguePlayer1);
            groupBox2.Controls.Add(lblControl);
            groupBox2.Controls.Add(lblDefend);
            groupBox2.Controls.Add(lblAttack);
            groupBox2.Location=new Point(68, 201);
            groupBox2.Margin=new Padding(2);
            groupBox2.Name="groupBox2";
            groupBox2.Padding=new Padding(2);
            groupBox2.Size=new Size(598, 359);
            groupBox2.TabIndex=8;
            groupBox2.TabStop=false;
            groupBox2.Text="Player01";
            // 
            // lbxPlayer1
            // 
            lbxPlayer1.FormattingEnabled=true;
            lbxPlayer1.ItemHeight=25;
            lbxPlayer1.Location=new Point(236, 29);
            lbxPlayer1.Name="lbxPlayer1";
            lbxPlayer1.Size=new Size(341, 204);
            lbxPlayer1.TabIndex=10;
            // 
            // btnGetRandomPlayer1
            // 
            btnGetRandomPlayer1.Location=new Point(4, 242);
            btnGetRandomPlayer1.Margin=new Padding(2);
            btnGetRandomPlayer1.Name="btnGetRandomPlayer1";
            btnGetRandomPlayer1.Size=new Size(182, 34);
            btnGetRandomPlayer1.TabIndex=9;
            btnGetRandomPlayer1.Text="Zoeken";
            btnGetRandomPlayer1.UseVisualStyleBackColor=true;
            btnGetRandomPlayer1.Click+=btnGetRandomPlayer1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(6, 141);
            label2.Margin=new Padding(2, 0, 2, 0);
            label2.Name="label2";
            label2.Size=new Size(48, 25);
            label2.TabIndex=8;
            label2.Text="Club";
            // 
            // cmxClubPlayer1
            // 
            cmxClubPlayer1.FormattingEnabled=true;
            cmxClubPlayer1.Location=new Point(6, 172);
            cmxClubPlayer1.Margin=new Padding(2);
            cmxClubPlayer1.Name="cmxClubPlayer1";
            cmxClubPlayer1.Size=new Size(182, 33);
            cmxClubPlayer1.TabIndex=7;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(6, 52);
            label1.Margin=new Padding(2, 0, 2, 0);
            label1.Name="label1";
            label1.Size=new Size(99, 25);
            label1.TabIndex=6;
            label1.Text="Competitie";
            // 
            // cmxLeaguePlayer1
            // 
            cmxLeaguePlayer1.FormattingEnabled=true;
            cmxLeaguePlayer1.Location=new Point(6, 82);
            cmxLeaguePlayer1.Margin=new Padding(2);
            cmxLeaguePlayer1.Name="cmxLeaguePlayer1";
            cmxLeaguePlayer1.Size=new Size(182, 33);
            cmxLeaguePlayer1.TabIndex=5;
            cmxLeaguePlayer1.SelectedIndexChanged+=cmxLeaguePlayer1_SelectedIndexChanged;
            // 
            // lblControl
            // 
            lblControl.AutoSize=true;
            lblControl.Location=new Point(346, 298);
            lblControl.Margin=new Padding(2, 0, 2, 0);
            lblControl.Name="lblControl";
            lblControl.Size=new Size(71, 25);
            lblControl.TabIndex=3;
            lblControl.Text="Control";
            // 
            // lblDefend
            // 
            lblDefend.AutoSize=true;
            lblDefend.Location=new Point(432, 298);
            lblDefend.Margin=new Padding(2, 0, 2, 0);
            lblDefend.Name="lblDefend";
            lblDefend.Size=new Size(70, 25);
            lblDefend.TabIndex=0;
            lblDefend.Text="Defend";
            // 
            // lblAttack
            // 
            lblAttack.AutoSize=true;
            lblAttack.Location=new Point(253, 298);
            lblAttack.Margin=new Padding(2, 0, 2, 0);
            lblAttack.Name="lblAttack";
            lblAttack.Size=new Size(62, 25);
            lblAttack.TabIndex=2;
            lblAttack.Text="Attack";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmxClubPlayer2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmxLeaguePlayer2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label10);
            groupBox1.Location=new Point(1008, 201);
            groupBox1.Margin=new Padding(2);
            groupBox1.Name="groupBox1";
            groupBox1.Padding=new Padding(2);
            groupBox1.Size=new Size(598, 359);
            groupBox1.TabIndex=9;
            groupBox1.TabStop=false;
            groupBox1.Text="Player02";
            // 
            // button2
            // 
            button2.Location=new Point(5, 242);
            button2.Margin=new Padding(2);
            button2.Name="button2";
            button2.Size=new Size(182, 34);
            button2.TabIndex=9;
            button2.Text="Zoeken";
            button2.UseVisualStyleBackColor=true;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(6, 141);
            label3.Margin=new Padding(2, 0, 2, 0);
            label3.Name="label3";
            label3.Size=new Size(48, 25);
            label3.TabIndex=8;
            label3.Text="Club";
            // 
            // cmxClubPlayer2
            // 
            cmxClubPlayer2.FormattingEnabled=true;
            cmxClubPlayer2.Location=new Point(6, 172);
            cmxClubPlayer2.Margin=new Padding(2);
            cmxClubPlayer2.Name="cmxClubPlayer2";
            cmxClubPlayer2.Size=new Size(182, 33);
            cmxClubPlayer2.TabIndex=7;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(6, 52);
            label4.Margin=new Padding(2, 0, 2, 0);
            label4.Name="label4";
            label4.Size=new Size(99, 25);
            label4.TabIndex=6;
            label4.Text="Competitie";
            // 
            // cmxLeaguePlayer2
            // 
            cmxLeaguePlayer2.FormattingEnabled=true;
            cmxLeaguePlayer2.Location=new Point(6, 82);
            cmxLeaguePlayer2.Margin=new Padding(2);
            cmxLeaguePlayer2.Name="cmxLeaguePlayer2";
            cmxLeaguePlayer2.Size=new Size(182, 33);
            cmxLeaguePlayer2.TabIndex=5;
            // 
            // pictureBox2
            // 
            pictureBox2.Location=new Point(214, 30);
            pictureBox2.Margin=new Padding(2);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(339, 185);
            pictureBox2.TabIndex=4;
            pictureBox2.TabStop=false;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(360, 262);
            label5.Margin=new Padding(2, 0, 2, 0);
            label5.Name="label5";
            label5.Size=new Size(71, 25);
            label5.TabIndex=3;
            label5.Text="Control";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(452, 262);
            label6.Margin=new Padding(2, 0, 2, 0);
            label6.Name="label6";
            label6.Size=new Size(70, 25);
            label6.TabIndex=0;
            label6.Text="Defend";
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(254, 262);
            label10.Margin=new Padding(2, 0, 2, 0);
            label10.Name="label10";
            label10.Size=new Size(62, 25);
            label10.TabIndex=2;
            label10.Text="Attack";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, gamesToolStripMenuItem, playerToolStripMenuItem, teamToolStripMenuItem, leagueToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Size=new Size(1924, 33);
            menuStrip1.TabIndex=10;
            menuStrip1.Text="menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, githubToolStripMenuItem, exitToolStripMenuItem });
            infoToolStripMenuItem.Name="infoToolStripMenuItem";
            infoToolStripMenuItem.Size=new Size(60, 29);
            infoToolStripMenuItem.Text="Info";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size=new Size(167, 34);
            aboutToolStripMenuItem.Text="About";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name="githubToolStripMenuItem";
            githubToolStripMenuItem.Size=new Size(167, 34);
            githubToolStripMenuItem.Text="Github";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new Size(167, 34);
            exitToolStripMenuItem.Text="Exit";
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { game1ToolStripMenuItem, game2ToolStripMenuItem, game3ToolStripMenuItem });
            gamesToolStripMenuItem.Name="gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size=new Size(82, 29);
            gamesToolStripMenuItem.Text="Games";
            // 
            // game1ToolStripMenuItem
            // 
            game1ToolStripMenuItem.Name="game1ToolStripMenuItem";
            game1ToolStripMenuItem.Size=new Size(170, 34);
            game1ToolStripMenuItem.Text="Game1";
            // 
            // game2ToolStripMenuItem
            // 
            game2ToolStripMenuItem.Name="game2ToolStripMenuItem";
            game2ToolStripMenuItem.Size=new Size(170, 34);
            game2ToolStripMenuItem.Text="Game2";
            // 
            // game3ToolStripMenuItem
            // 
            game3ToolStripMenuItem.Name="game3ToolStripMenuItem";
            game3ToolStripMenuItem.Size=new Size(170, 34);
            game3ToolStripMenuItem.Text="Game3";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerOverviewToolStripMenuItem });
            playerToolStripMenuItem.Name="playerToolStripMenuItem";
            playerToolStripMenuItem.Size=new Size(75, 29);
            playerToolStripMenuItem.Text="Player";
            // 
            // playerOverviewToolStripMenuItem
            // 
            playerOverviewToolStripMenuItem.Name="playerOverviewToolStripMenuItem";
            playerOverviewToolStripMenuItem.Size=new Size(239, 34);
            playerOverviewToolStripMenuItem.Text="Player Overview";
            playerOverviewToolStripMenuItem.Click+=playerOverviewToolStripMenuItem_Click;
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.Name="teamToolStripMenuItem";
            teamToolStripMenuItem.Size=new Size(69, 29);
            teamToolStripMenuItem.Text="Team";
            // 
            // leagueToolStripMenuItem
            // 
            leagueToolStripMenuItem.Name="leagueToolStripMenuItem";
            leagueToolStripMenuItem.Size=new Size(84, 29);
            leagueToolStripMenuItem.Text="League";
            // 
            // lblPlayerName1
            // 
            lblPlayerName1.AutoSize=true;
            lblPlayerName1.Font=new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayerName1.Location=new Point(312, 246);
            lblPlayerName1.Name="lblPlayerName1";
            lblPlayerName1.Size=new Size(105, 45);
            lblPlayerName1.TabIndex=11;
            lblPlayerName1.Text="label7";
            // 
            // MainWIndow
            // 
            AutoScaleDimensions=new SizeF(10F, 25F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1924, 1055);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            MainMenuStrip=menuStrip1;
            Margin=new Padding(2);
            Name="MainWIndow";
            Text="Form1";
            Load+=MainWIndow_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnGetRandomPlayer1;
        private Label label2;
        private ComboBox cmxClubPlayer1;
        private Label label1;
        private ComboBox cmxLeaguePlayer1;
        private Label lblControl;
        private Label lblDefend;
        private Label lblAttack;
        private GroupBox groupBox1;
        private Button button2;
        private Label label3;
        private ComboBox cmxClubPlayer2;
        private Label label4;
        private ComboBox cmxLeaguePlayer2;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label6;
        private Label label10;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem game1ToolStripMenuItem;
        private ToolStripMenuItem game2ToolStripMenuItem;
        private ToolStripMenuItem game3ToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem playerOverviewToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem leagueToolStripMenuItem;
        private ListBox lbxPlayer1;
        private Label lblPlayerName1;
    }
}