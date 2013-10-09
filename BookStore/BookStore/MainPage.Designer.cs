namespace BookStore
{
    partial class MainPage
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnListing = new System.Windows.Forms.Button();
            this.btnUtilities = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 48);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&Add New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnListing
            // 
            this.btnListing.Location = new System.Drawing.Point(87, 48);
            this.btnListing.Name = "btnListing";
            this.btnListing.Size = new System.Drawing.Size(75, 23);
            this.btnListing.TabIndex = 1;
            this.btnListing.Text = "&Listing";
            this.btnListing.UseVisualStyleBackColor = true;
            this.btnListing.Click += new System.EventHandler(this.btnListing_Click);
            // 
            // btnUtilities
            // 
            this.btnUtilities.Location = new System.Drawing.Point(168, 48);
            this.btnUtilities.Name = "btnUtilities";
            this.btnUtilities.Size = new System.Drawing.Size(75, 23);
            this.btnUtilities.TabIndex = 2;
            this.btnUtilities.Text = "&Utilities";
            this.btnUtilities.UseVisualStyleBackColor = true;
            this.btnUtilities.Click += new System.EventHandler(this.btnUtilities_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnUtilities);
            this.groupBox1.Controls.Add(this.btnListing);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Option";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 222);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnListing;
        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}