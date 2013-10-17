namespace BookStore
{
    partial class EstimateBill
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wholesaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtlist = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColMRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtScheme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCustName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wholesaleToolStripMenuItem,
            this.retailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wholesaleToolStripMenuItem
            // 
            this.wholesaleToolStripMenuItem.Name = "wholesaleToolStripMenuItem";
            this.wholesaleToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.wholesaleToolStripMenuItem.Text = "Wholesale";
            this.wholesaleToolStripMenuItem.Click += new System.EventHandler(this.wholesaleToolStripMenuItem_Click);
            // 
            // retailToolStripMenuItem
            // 
            this.retailToolStripMenuItem.Name = "retailToolStripMenuItem";
            this.retailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.retailToolStripMenuItem.Text = "Retail";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.cmbPaymentType);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbCustName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblBillNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 347);
            this.panel1.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(713, 292);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.produtlist,
            this.ColMRP,
            this.ColQTY,
            this.ColRate,
            this.txtScheme,
            this.ColTotal});
            this.dataGridView1.Location = new System.Drawing.Point(45, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            // 
            // produtlist
            // 
            this.produtlist.HeaderText = "Item";
            this.produtlist.Name = "produtlist";
            // 
            // ColMRP
            // 
            this.ColMRP.HeaderText = "MRP";
            this.ColMRP.Name = "ColMRP";
            // 
            // ColQTY
            // 
            this.ColQTY.HeaderText = "Qty";
            this.ColQTY.Name = "ColQTY";
            // 
            // ColRate
            // 
            this.ColRate.HeaderText = "Rate";
            this.ColRate.Name = "ColRate";
            // 
            // txtScheme
            // 
            this.txtScheme.HeaderText = "Scheme";
            this.txtScheme.Name = "txtScheme";
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Amount";
            this.ColTotal.Name = "ColTotal";
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbPaymentType.Location = new System.Drawing.Point(124, 60);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentType.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment type";
            // 
            // cmbCustName
            // 
            this.cmbCustName.FormattingEnabled = true;
            this.cmbCustName.Location = new System.Drawing.Point(124, 28);
            this.cmbCustName.Name = "cmbCustName";
            this.cmbCustName.Size = new System.Drawing.Size(121, 21);
            this.cmbCustName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Party Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(162, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // lblBillNo
            // 
            this.lblBillNo.AutoSize = true;
            this.lblBillNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBillNo.Location = new System.Drawing.Point(58, 9);
            this.lblBillNo.Name = "lblBillNo";
            this.lblBillNo.Size = new System.Drawing.Size(12, 15);
            this.lblBillNo.TabIndex = 1;
            this.lblBillNo.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill No.";
            // 
            // EstimateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EstimateBill";
            this.Text = "EstimateBill";
            this.Load += new System.EventHandler(this.EstimateBill_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wholesaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retailToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCustName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn produtlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtScheme;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.Button btnPrint;
    }
}