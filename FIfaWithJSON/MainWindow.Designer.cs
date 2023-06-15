namespace FIfaWithJSON
{
    partial class frmFifa
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
            leagueToolStripMenuItem=new ToolStripMenuItem();
            leagueOverviewToolStripMenuItem=new ToolStripMenuItem();
            playerOverviewToolStripMenuItem=new ToolStripMenuItem();
            playerToolStripMenuItem=new ToolStripMenuItem();
            game3ToolStripMenuItem=new ToolStripMenuItem();
            game2ToolStripMenuItem=new ToolStripMenuItem();
            game1ToolStripMenuItem=new ToolStripMenuItem();
            gamesToolStripMenuItem=new ToolStripMenuItem();
            exitToolStripMenuItem=new ToolStripMenuItem();
            githubToolStripMenuItem=new ToolStripMenuItem();
            aboutToolStripMenuItem=new ToolStripMenuItem();
            infoToolStripMenuItem=new ToolStripMenuItem();
            menuStrip1=new MenuStrip();
            teamToolStripMenuItem=new ToolStripMenuItem();
            teamsOverviewToolStripMenuItem=new ToolStripMenuItem();
            label3=new Label();
            cmxClubPlayer2=new ComboBox();
            label4=new Label();
            cmxLeaguePlayer2=new ComboBox();
            groupBox2=new GroupBox();
            btnStartGame=new Button();
            label7=new Label();
            label6=new Label();
            label5=new Label();
            lvwPlayer1=new ListView();
            btnDefendPlayer1=new Button();
            btnControlPlayer1=new Button();
            btnAttackPlayer1=new Button();
            label2=new Label();
            cmxClubPlayer1=new ComboBox();
            label1=new Label();
            cmxLeaguePlayer1=new ComboBox();
            groupBox1=new GroupBox();
            label8=new Label();
            label9=new Label();
            label10=new Label();
            lvwPlayer2=new ListView();
            btnDefendPlayer2=new Button();
            btnControlPlayer2=new Button();
            btnAttackPlayer2=new Button();
            lblResultPlayer1=new Label();
            lblResultPlayer2=new Label();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // leagueToolStripMenuItem
            // 
            leagueToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { leagueOverviewToolStripMenuItem });
            leagueToolStripMenuItem.Name="leagueToolStripMenuItem";
            leagueToolStripMenuItem.Size=new Size(71, 24);
            leagueToolStripMenuItem.Text="League";
            // 
            // leagueOverviewToolStripMenuItem
            // 
            leagueOverviewToolStripMenuItem.Name="leagueOverviewToolStripMenuItem";
            leagueOverviewToolStripMenuItem.Size=new Size(205, 26);
            leagueOverviewToolStripMenuItem.Text="League Overview";
            // 
            // playerOverviewToolStripMenuItem
            // 
            playerOverviewToolStripMenuItem.Name="playerOverviewToolStripMenuItem";
            playerOverviewToolStripMenuItem.Size=new Size(197, 26);
            playerOverviewToolStripMenuItem.Text="Player Overview";
            playerOverviewToolStripMenuItem.Click+=playerOverviewToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerOverviewToolStripMenuItem });
            playerToolStripMenuItem.Name="playerToolStripMenuItem";
            playerToolStripMenuItem.Size=new Size(63, 24);
            playerToolStripMenuItem.Text="Player";
            // 
            // game3ToolStripMenuItem
            // 
            game3ToolStripMenuItem.Name="game3ToolStripMenuItem";
            game3ToolStripMenuItem.Size=new Size(139, 26);
            game3ToolStripMenuItem.Text="Game3";
            // 
            // game2ToolStripMenuItem
            // 
            game2ToolStripMenuItem.Name="game2ToolStripMenuItem";
            game2ToolStripMenuItem.Size=new Size(139, 26);
            game2ToolStripMenuItem.Text="Game2";
            // 
            // game1ToolStripMenuItem
            // 
            game1ToolStripMenuItem.Name="game1ToolStripMenuItem";
            game1ToolStripMenuItem.Size=new Size(139, 26);
            game1ToolStripMenuItem.Text="Game1";
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { game1ToolStripMenuItem, game2ToolStripMenuItem, game3ToolStripMenuItem });
            gamesToolStripMenuItem.Name="gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size=new Size(68, 24);
            gamesToolStripMenuItem.Text="Games";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new Size(136, 26);
            exitToolStripMenuItem.Text="Exit";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name="githubToolStripMenuItem";
            githubToolStripMenuItem.Size=new Size(136, 26);
            githubToolStripMenuItem.Text="Github";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size=new Size(136, 26);
            aboutToolStripMenuItem.Text="About";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, githubToolStripMenuItem, exitToolStripMenuItem });
            infoToolStripMenuItem.Name="infoToolStripMenuItem";
            infoToolStripMenuItem.Size=new Size(49, 24);
            infoToolStripMenuItem.Text="Info";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, gamesToolStripMenuItem, playerToolStripMenuItem, teamToolStripMenuItem, leagueToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Padding=new Padding(5, 2, 0, 2);
            menuStrip1.Size=new Size(1513, 28);
            menuStrip1.TabIndex=13;
            menuStrip1.Text="menuStrip1";
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { teamsOverviewToolStripMenuItem });
            teamToolStripMenuItem.Name="teamToolStripMenuItem";
            teamToolStripMenuItem.Size=new Size(59, 24);
            teamToolStripMenuItem.Text="Team";
            // 
            // teamsOverviewToolStripMenuItem
            // 
            teamsOverviewToolStripMenuItem.Name="teamsOverviewToolStripMenuItem";
            teamsOverviewToolStripMenuItem.Size=new Size(199, 26);
            teamsOverviewToolStripMenuItem.Text="Teams Overview";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(3, 308);
            label3.Margin=new Padding(2, 0, 2, 0);
            label3.Name="label3";
            label3.Size=new Size(39, 20);
            label3.TabIndex=8;
            label3.Text="Club";
            // 
            // cmxClubPlayer2
            // 
            cmxClubPlayer2.FormattingEnabled=true;
            cmxClubPlayer2.Location=new Point(4, 334);
            cmxClubPlayer2.Margin=new Padding(2);
            cmxClubPlayer2.Name="cmxClubPlayer2";
            cmxClubPlayer2.Size=new Size(146, 28);
            cmxClubPlayer2.TabIndex=7;
            
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(3, 237);
            label4.Margin=new Padding(2, 0, 2, 0);
            label4.Name="label4";
            label4.Size=new Size(83, 20);
            label4.TabIndex=6;
            label4.Text="Competitie";
            // 
            // cmxLeaguePlayer2
            // 
            cmxLeaguePlayer2.FormattingEnabled=true;
            cmxLeaguePlayer2.Location=new Point(4, 262);
            cmxLeaguePlayer2.Margin=new Padding(2);
            cmxLeaguePlayer2.Name="cmxLeaguePlayer2";
            cmxLeaguePlayer2.Size=new Size(146, 28);
            cmxLeaguePlayer2.TabIndex=5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnStartGame);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lvwPlayer1);
            groupBox2.Controls.Add(btnDefendPlayer1);
            groupBox2.Controls.Add(btnControlPlayer1);
            groupBox2.Controls.Add(btnAttackPlayer1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(cmxClubPlayer1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cmxLeaguePlayer1);
            groupBox2.Location=new Point(54, 54);
            groupBox2.Margin=new Padding(2);
            groupBox2.Name="groupBox2";
            groupBox2.Padding=new Padding(2);
            groupBox2.Size=new Size(643, 601);
            groupBox2.TabIndex=11;
            groupBox2.TabStop=false;
            groupBox2.Text="Player01";
            // 
            // btnStartGame
            // 
            btnStartGame.Location=new Point(10, 76);
            btnStartGame.Name="btnStartGame";
            btnStartGame.Size=new Size(125, 47);
            btnStartGame.TabIndex=17;
            btnStartGame.Text="Start Game";
            btnStartGame.UseVisualStyleBackColor=true;
            btnStartGame.Click+=btnStartGame_Click;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(408, 513);
            label7.Name="label7";
            label7.Size=new Size(58, 20);
            label7.TabIndex=16;
            label7.Text="Defend";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(313, 513);
            label6.Name="label6";
            label6.Size=new Size(58, 20);
            label6.TabIndex=15;
            label6.Text="Control";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(216, 513);
            label5.Name="label5";
            label5.Size=new Size(51, 20);
            label5.TabIndex=14;
            label5.Text="Attack";
            // 
            // lvwPlayer1
            // 
            lvwPlayer1.Location=new Point(156, 25);
            lvwPlayer1.Name="lvwPlayer1";
            lvwPlayer1.Size=new Size(428, 473);
            lvwPlayer1.TabIndex=13;
            lvwPlayer1.UseCompatibleStateImageBehavior=false;
            lvwPlayer1.SelectedIndexChanged+=lvwPlayer1_SelectedIndexChanged;
            // 
            // btnDefendPlayer1
            // 
            btnDefendPlayer1.Location=new Point(394, 536);
            btnDefendPlayer1.Name="btnDefendPlayer1";
            btnDefendPlayer1.Size=new Size(94, 29);
            btnDefendPlayer1.TabIndex=12;
            btnDefendPlayer1.Text="Defend";
            btnDefendPlayer1.UseVisualStyleBackColor=true;
            btnDefendPlayer1.Click+=btnDefendPlayer1_Click;
            // 
            // btnControlPlayer1
            // 
            btnControlPlayer1.Location=new Point(294, 536);
            btnControlPlayer1.Name="btnControlPlayer1";
            btnControlPlayer1.Size=new Size(94, 29);
            btnControlPlayer1.TabIndex=11;
            btnControlPlayer1.Text="Control";
            btnControlPlayer1.UseVisualStyleBackColor=true;
            btnControlPlayer1.Click+=btnControlPlayer1_Click;
            // 
            // btnAttackPlayer1
            // 
            btnAttackPlayer1.Location=new Point(196, 536);
            btnAttackPlayer1.Name="btnAttackPlayer1";
            btnAttackPlayer1.Size=new Size(94, 29);
            btnAttackPlayer1.TabIndex=10;
            btnAttackPlayer1.Text="Attack";
            btnAttackPlayer1.UseVisualStyleBackColor=true;
            btnAttackPlayer1.Click+=btnAttackPlayer1_Click;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(0, 312);
            label2.Margin=new Padding(2, 0, 2, 0);
            label2.Name="label2";
            label2.Size=new Size(39, 20);
            label2.TabIndex=8;
            label2.Text="Club";
            // 
            // cmxClubPlayer1
            // 
            cmxClubPlayer1.FormattingEnabled=true;
            cmxClubPlayer1.Location=new Point(0, 334);
            cmxClubPlayer1.Margin=new Padding(2);
            cmxClubPlayer1.Name="cmxClubPlayer1";
            cmxClubPlayer1.Size=new Size(146, 28);
            cmxClubPlayer1.TabIndex=7;
                      // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(0, 246);
            label1.Margin=new Padding(2, 0, 2, 0);
            label1.Name="label1";
            label1.Size=new Size(83, 20);
            label1.TabIndex=6;
            label1.Text="Competitie";
            // 
            // cmxLeaguePlayer1
            // 
            cmxLeaguePlayer1.FormattingEnabled=true;
            cmxLeaguePlayer1.Location=new Point(0, 268);
            cmxLeaguePlayer1.Margin=new Padding(2);
            cmxLeaguePlayer1.Name="cmxLeaguePlayer1";
            cmxLeaguePlayer1.Size=new Size(146, 28);
            cmxLeaguePlayer1.TabIndex=5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lvwPlayer2);
            groupBox1.Controls.Add(btnDefendPlayer2);
            groupBox1.Controls.Add(btnControlPlayer2);
            groupBox1.Controls.Add(btnAttackPlayer2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cmxClubPlayer2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cmxLeaguePlayer2);
            groupBox1.Location=new Point(781, 54);
            groupBox1.Margin=new Padding(2);
            groupBox1.Name="groupBox1";
            groupBox1.Padding=new Padding(2);
            groupBox1.Size=new Size(721, 601);
            groupBox1.TabIndex=12;
            groupBox1.TabStop=false;
            groupBox1.Text="Player02";
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Location=new Point(479, 513);
            label8.Name="label8";
            label8.Size=new Size(58, 20);
            label8.TabIndex=19;
            label8.Text="Defend";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Location=new Point(384, 513);
            label9.Name="label9";
            label9.Size=new Size(58, 20);
            label9.TabIndex=18;
            label9.Text="Control";
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Location=new Point(287, 513);
            label10.Name="label10";
            label10.Size=new Size(51, 20);
            label10.TabIndex=17;
            label10.Text="Attack";
            // 
            // lvwPlayer2
            // 
            lvwPlayer2.Location=new Point(165, 16);
            lvwPlayer2.Name="lvwPlayer2";
            lvwPlayer2.Size=new Size(513, 473);
            lvwPlayer2.TabIndex=14;
            lvwPlayer2.UseCompatibleStateImageBehavior=false;
            lvwPlayer2.SelectedIndexChanged+=lvwPlayer2_SelectedIndexChanged;
            // 
            // btnDefendPlayer2
            // 
            btnDefendPlayer2.Location=new Point(470, 536);
            btnDefendPlayer2.Name="btnDefendPlayer2";
            btnDefendPlayer2.Size=new Size(94, 29);
            btnDefendPlayer2.TabIndex=15;
            btnDefendPlayer2.Text="Defend";
            btnDefendPlayer2.UseVisualStyleBackColor=true;
            // 
            // btnControlPlayer2
            // 
            btnControlPlayer2.Location=new Point(370, 536);
            btnControlPlayer2.Name="btnControlPlayer2";
            btnControlPlayer2.Size=new Size(94, 29);
            btnControlPlayer2.TabIndex=14;
            btnControlPlayer2.Text="Control";
            btnControlPlayer2.UseVisualStyleBackColor=true;
            // 
            // btnAttackPlayer2
            // 
            btnAttackPlayer2.Location=new Point(272, 536);
            btnAttackPlayer2.Name="btnAttackPlayer2";
            btnAttackPlayer2.Size=new Size(94, 29);
            btnAttackPlayer2.TabIndex=13;
            btnAttackPlayer2.Text="Attack";
            btnAttackPlayer2.UseVisualStyleBackColor=true;
            // 
            // lblResultPlayer1
            // 
            lblResultPlayer1.AutoSize=true;
            lblResultPlayer1.Font=new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultPlayer1.Location=new Point(724, 166);
            lblResultPlayer1.Name="lblResultPlayer1";
            lblResultPlayer1.Size=new Size(26, 31);
            lblResultPlayer1.TabIndex=14;
            lblResultPlayer1.Text="0";
            // 
            // lblResultPlayer2
            // 
            lblResultPlayer2.AutoSize=true;
            lblResultPlayer2.Font=new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultPlayer2.Location=new Point(724, 261);
            lblResultPlayer2.Name="lblResultPlayer2";
            lblResultPlayer2.Size=new Size(26, 31);
            lblResultPlayer2.TabIndex=15;
            lblResultPlayer2.Text="0";
            // 
            // frmFifa
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1513, 696);
            Controls.Add(lblResultPlayer2);
            Controls.Add(lblResultPlayer1);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name="frmFifa";
            Text="Form1";
            Load+=frmFifa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem leagueToolStripMenuItem;
        private ToolStripMenuItem playerOverviewToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem game3ToolStripMenuItem;
        private ToolStripMenuItem game2ToolStripMenuItem;
        private ToolStripMenuItem game1ToolStripMenuItem;
        private ToolStripMenuItem gamesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem githubToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem teamToolStripMenuItem;
        private Label label3;
        private ComboBox cmxClubPlayer2;
        private Label label4;
        private ComboBox cmxLeaguePlayer2;
        private GroupBox groupBox2;
        private Label label2;
        private ComboBox cmxClubPlayer1;
        private Label label1;
        private ComboBox cmxLeaguePlayer1;
        private GroupBox groupBox1;
        private Button btnDefendPlayer1;
        private Button btnControlPlayer1;
        private Button btnAttackPlayer1;
        private Button btnDefendPlayer2;
        private Button btnControlPlayer2;
        private Button btnAttackPlayer2;
        private ToolStripMenuItem leagueOverviewToolStripMenuItem;
        private ToolStripMenuItem teamsOverviewToolStripMenuItem;
        private ListView lvwPlayer1;
        private ListView lvwPlayer2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnStartGame;
        private Label lblResultPlayer1;
        private Label lblResultPlayer2;
    }
}