namespace FIfa.Pages
{
    partial class CreatePlayer
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
            txbName=new TextBox();
            numAttack=new NumericUpDown();
            numControl=new NumericUpDown();
            numDefend=new NumericUpDown();
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            label6=new Label();
            label7=new Label();
            cmbxPosition=new ComboBox();
            btnSavePlayer=new Button();
            txbNationality=new TextBox();
            txbRating=new TextBox();
            ((System.ComponentModel.ISupportInitialize)numAttack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDefend).BeginInit();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Location=new Point(279, 107);
            txbName.Name="txbName";
            txbName.Size=new Size(125, 27);
            txbName.TabIndex=0;
            // 
            // numAttack
            // 
            numAttack.Location=new Point(279, 140);
            numAttack.Name="numAttack";
            numAttack.Size=new Size(125, 27);
            numAttack.TabIndex=8;
            // 
            // numControl
            // 
            numControl.Location=new Point(279, 173);
            numControl.Name="numControl";
            numControl.Size=new Size(125, 27);
            numControl.TabIndex=9;
            // 
            // numDefend
            // 
            numDefend.Location=new Point(279, 206);
            numDefend.Name="numDefend";
            numDefend.Size=new Size(125, 27);
            numDefend.TabIndex=10;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(201, 114);
            label1.Name="label1";
            label1.Size=new Size(49, 20);
            label1.TabIndex=11;
            label1.Text="Name";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(201, 147);
            label2.Name="label2";
            label2.Size=new Size(51, 20);
            label2.TabIndex=12;
            label2.Text="Attack";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(201, 180);
            label3.Name="label3";
            label3.Size=new Size(58, 20);
            label3.TabIndex=13;
            label3.Text="Control";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(201, 208);
            label4.Name="label4";
            label4.Size=new Size(58, 20);
            label4.TabIndex=14;
            label4.Text="Defend";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(201, 244);
            label5.Name="label5";
            label5.Size=new Size(61, 20);
            label5.TabIndex=15;
            label5.Text="Position";
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Location=new Point(198, 275);
            label6.Name="label6";
            label6.Size=new Size(82, 20);
            label6.TabIndex=16;
            label6.Text="Nationality";
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Location=new Point(201, 312);
            label7.Name="label7";
            label7.Size=new Size(52, 20);
            label7.TabIndex=17;
            label7.Text="Rating";
            // 
            // cmbxPosition
            // 
            cmbxPosition.FormattingEnabled=true;
            cmbxPosition.Items.AddRange(new object[] { "Doelman (Keeper)", "Rechtsback (Right back)", "Centrale verdediger (Centrale verdediger)", "Centrale verdediger (Centrale verdediger)", "Linksback (Left back)", "Rechtshalf (Right midfielder)", "Centrale middenvelder (Centrale middenvelder)", "Centrale middenvelder (Centrale middenvelder)", "Linkshalf (Left midfielder)", "Aanvallende middenvelder (Attacking midfielder)", "Spits (Striker)" });
            cmbxPosition.Location=new Point(278, 239);
            cmbxPosition.Name="cmbxPosition";
            cmbxPosition.Size=new Size(127, 28);
            cmbxPosition.TabIndex=19;
            // 
            // btnSavePlayer
            // 
            btnSavePlayer.Location=new Point(209, 362);
            btnSavePlayer.Name="btnSavePlayer";
            btnSavePlayer.Size=new Size(196, 29);
            btnSavePlayer.TabIndex=20;
            btnSavePlayer.Text="Opslaan";
            btnSavePlayer.UseVisualStyleBackColor=true;
            btnSavePlayer.Click+=btnSavePlayer_Click;
            // 
            // txbNationality
            // 
            txbNationality.Location=new Point(278, 273);
            txbNationality.Name="txbNationality";
            txbNationality.Size=new Size(125, 27);
            txbNationality.TabIndex=21;
            // 
            // txbRating
            // 
            txbRating.Location=new Point(278, 312);
            txbRating.Name="txbRating";
            txbRating.Size=new Size(125, 27);
            txbRating.TabIndex=22;
            // 
            // CreatePlayer
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1100, 528);
            Controls.Add(txbRating);
            Controls.Add(txbNationality);
            Controls.Add(btnSavePlayer);
            Controls.Add(cmbxPosition);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numDefend);
            Controls.Add(numControl);
            Controls.Add(numAttack);
            Controls.Add(txbName);
            Name="CreatePlayer";
            Text="CreatePlayer";
            ((System.ComponentModel.ISupportInitialize)numAttack).EndInit();
            ((System.ComponentModel.ISupportInitialize)numControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDefend).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbName;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private NumericUpDown numAttack;
        private NumericUpDown numControl;
        private NumericUpDown numDefend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbxPosition;
        private Button btnSavePlayer;
        private TextBox txbNationality;
        private TextBox txbRating;
    }
}