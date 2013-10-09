namespace BookStore
{
    partial class UtilityDetails
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
            this.btnAddParty = new System.Windows.Forms.Button();
            this.btnEditParty = new System.Windows.Forms.Button();
            this.btnDeleteParty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddParty
            // 
            this.btnAddParty.Location = new System.Drawing.Point(20, 69);
            this.btnAddParty.Name = "btnAddParty";
            this.btnAddParty.Size = new System.Drawing.Size(75, 23);
            this.btnAddParty.TabIndex = 0;
            this.btnAddParty.Text = "Add Party";
            this.btnAddParty.UseVisualStyleBackColor = true;
            this.btnAddParty.Click += new System.EventHandler(this.btnAddParty_Click);
            // 
            // btnEditParty
            // 
            this.btnEditParty.Location = new System.Drawing.Point(101, 69);
            this.btnEditParty.Name = "btnEditParty";
            this.btnEditParty.Size = new System.Drawing.Size(75, 23);
            this.btnEditParty.TabIndex = 1;
            this.btnEditParty.Text = "Edit Party";
            this.btnEditParty.UseVisualStyleBackColor = true;
            this.btnEditParty.Click += new System.EventHandler(this.btnEditParty_Click);
            // 
            // btnDeleteParty
            // 
            this.btnDeleteParty.Location = new System.Drawing.Point(182, 69);
            this.btnDeleteParty.Name = "btnDeleteParty";
            this.btnDeleteParty.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteParty.TabIndex = 2;
            this.btnDeleteParty.Text = "Delete Party";
            this.btnDeleteParty.UseVisualStyleBackColor = true;
            this.btnDeleteParty.Click += new System.EventHandler(this.btnDeleteParty_Click);
            // 
            // UtilityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDeleteParty);
            this.Controls.Add(this.btnEditParty);
            this.Controls.Add(this.btnAddParty);
            this.Name = "UtilityDetails";
            this.Text = "UtilityDetails";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddParty;
        private System.Windows.Forms.Button btnEditParty;
        private System.Windows.Forms.Button btnDeleteParty;
    }
}