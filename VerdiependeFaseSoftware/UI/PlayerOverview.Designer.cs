namespace VerdiependeFaseSoftware.UI
{
    partial class PlayerOverview
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
            lvwPlayerOverview=new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize=new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { infoToolStripMenuItem, gamesToolStripMenuItem, playerToolStripMenuItem, teamToolStripMenuItem, leagueToolStripMenuItem });
            menuStrip1.Location=new Point(0, 0);
            menuStrip1.Name="menuStrip1";
            menuStrip1.Padding=new Padding(5, 2, 0, 2);
            menuStrip1.Size=new Size(1435, 28);
            menuStrip1.TabIndex=11;
            menuStrip1.Text="menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem, githubToolStripMenuItem, exitToolStripMenuItem });
            infoToolStripMenuItem.Name="infoToolStripMenuItem";
            infoToolStripMenuItem.Size=new Size(49, 24);
            infoToolStripMenuItem.Text="Info";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size=new Size(136, 26);
            aboutToolStripMenuItem.Text="About";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name="githubToolStripMenuItem";
            githubToolStripMenuItem.Size=new Size(136, 26);
            githubToolStripMenuItem.Text="Github";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.Size=new Size(136, 26);
            exitToolStripMenuItem.Text="Exit";
            // 
            // gamesToolStripMenuItem
            // 
            gamesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { game1ToolStripMenuItem, game2ToolStripMenuItem, game3ToolStripMenuItem });
            gamesToolStripMenuItem.Name="gamesToolStripMenuItem";
            gamesToolStripMenuItem.Size=new Size(68, 24);
            gamesToolStripMenuItem.Text="Games";
            // 
            // game1ToolStripMenuItem
            // 
            game1ToolStripMenuItem.Name="game1ToolStripMenuItem";
            game1ToolStripMenuItem.Size=new Size(139, 26);
            game1ToolStripMenuItem.Text="Game1";
            // 
            // game2ToolStripMenuItem
            // 
            game2ToolStripMenuItem.Name="game2ToolStripMenuItem";
            game2ToolStripMenuItem.Size=new Size(139, 26);
            game2ToolStripMenuItem.Text="Game2";
            // 
            // game3ToolStripMenuItem
            // 
            game3ToolStripMenuItem.Name="game3ToolStripMenuItem";
            game3ToolStripMenuItem.Size=new Size(139, 26);
            game3ToolStripMenuItem.Text="Game3";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { playerOverviewToolStripMenuItem });
            playerToolStripMenuItem.Name="playerToolStripMenuItem";
            playerToolStripMenuItem.Size=new Size(63, 24);
            playerToolStripMenuItem.Text="Player";
            // 
            // playerOverviewToolStripMenuItem
            // 
            playerOverviewToolStripMenuItem.Name="playerOverviewToolStripMenuItem";
            playerOverviewToolStripMenuItem.Size=new Size(197, 26);
            playerOverviewToolStripMenuItem.Text="Player Overview";
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.Name="teamToolStripMenuItem";
            teamToolStripMenuItem.Size=new Size(59, 24);
            teamToolStripMenuItem.Text="Team";
            // 
            // leagueToolStripMenuItem
            // 
            leagueToolStripMenuItem.Name="leagueToolStripMenuItem";
            leagueToolStripMenuItem.Size=new Size(71, 24);
            leagueToolStripMenuItem.Text="League";
            // 
            // lvwPlayerOverview
            // 
            lvwPlayerOverview.Location=new Point(42, 56);
            lvwPlayerOverview.Margin=new Padding(2);
            lvwPlayerOverview.Name="lvwPlayerOverview";
            lvwPlayerOverview.Size=new Size(620, 314);
            lvwPlayerOverview.TabIndex=12;
            lvwPlayerOverview.UseCompatibleStateImageBehavior=false;
            // 
            // PlayerOverview
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1435, 777);
            Controls.Add(lvwPlayerOverview);
            Controls.Add(menuStrip1);
            Margin=new Padding(2);
            Name="PlayerOverview";
            Text="PlayerOverview";
            Load+=PlayerOverview_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private ListView lvwPlayerOverview;
    }
}