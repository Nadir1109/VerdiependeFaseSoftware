namespace FIfaWithJSON
{
    partial class AllPlayers
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
            lvwAllPlayersOverview=new ListView();
            SuspendLayout();
            // 
            // lvwAllPlayersOverview
            // 
            lvwAllPlayersOverview.Location=new Point(56, 42);
            lvwAllPlayersOverview.Name="lvwAllPlayersOverview";
            lvwAllPlayersOverview.Size=new Size(940, 289);
            lvwAllPlayersOverview.TabIndex=0;
            lvwAllPlayersOverview.UseCompatibleStateImageBehavior=false;
            // 
            // AllPlayers
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1159, 581);
            Controls.Add(lvwAllPlayersOverview);
            Name="AllPlayers";
            Text="AllPlayers";
            Load+=AllPlayers_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lvwAllPlayersOverview;
    }
}