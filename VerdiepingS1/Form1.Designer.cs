namespace VerdiepingS1
{
    partial class frmBookstore
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
            btnAddBooks=new Button();
            txbTtitle=new TextBox();
            txbAuthor=new TextBox();
            label1=new Label();
            label2=new Label();
            txbPrice=new Label();
            lbxBooks=new ListBox();
            SuspendLayout();
            // 
            // btnAddBooks
            // 
            btnAddBooks.Location=new Point(104, 256);
            btnAddBooks.Name="btnAddBooks";
            btnAddBooks.Size=new Size(157, 40);
            btnAddBooks.TabIndex=0;
            btnAddBooks.Text="Boek toevoegen";
            btnAddBooks.UseVisualStyleBackColor=true;
            btnAddBooks.Click+=btnAddBooks_Click;
            // 
            // txbTtitle
            // 
            txbTtitle.Location=new Point(104, 104);
            txbTtitle.Name="txbTtitle";
            txbTtitle.Size=new Size(125, 27);
            txbTtitle.TabIndex=1;
            // 
            // txbAuthor
            // 
            txbAuthor.Location=new Point(104, 148);
            txbAuthor.Name="txbAuthor";
            txbAuthor.Size=new Size(125, 27);
            txbAuthor.TabIndex=3;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(104, 81);
            label1.Name="label1";
            label1.Size=new Size(35, 20);
            label1.TabIndex=4;
            label1.Text="titel";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(104, 134);
            label2.Name="label2";
            label2.Size=new Size(54, 20);
            label2.TabIndex=5;
            label2.Text="Author";
            // 
            // txbPrice
            // 
            txbPrice.AutoSize=true;
            txbPrice.Location=new Point(104, 178);
            txbPrice.Name="txbPrice";
            txbPrice.Size=new Size(0, 20);
            txbPrice.TabIndex=6;
            // 
            // lbxBooks
            // 
            lbxBooks.FormattingEnabled=true;
            lbxBooks.ItemHeight=20;
            lbxBooks.Location=new Point(384, 59);
            lbxBooks.Name="lbxBooks";
            lbxBooks.Size=new Size(359, 264);
            lbxBooks.TabIndex=7;
            // 
            // frmBookstore
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(lbxBooks);
            Controls.Add(txbPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbAuthor);
            Controls.Add(txbTtitle);
            Controls.Add(btnAddBooks);
            Name="frmBookstore";
            Text="Bookstore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBooks;
        private TextBox txbTtitle;
        private TextBox txbAuthor;
        private Label label1;
        private Label label2;
        private Label txbPrice;
        private ListBox lbxBooks;
    }
}