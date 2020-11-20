namespace InventoryManager
{
    partial class SearchForItem
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
            this.searchItemPrompt = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.searchItemTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchItemPrompt
            // 
            this.searchItemPrompt.AutoSize = true;
            this.searchItemPrompt.BackColor = System.Drawing.Color.PaleGreen;
            this.searchItemPrompt.ForeColor = System.Drawing.Color.ForestGreen;
            this.searchItemPrompt.Location = new System.Drawing.Point(85, 121);
            this.searchItemPrompt.Name = "searchItemPrompt";
            this.searchItemPrompt.Size = new System.Drawing.Size(595, 25);
            this.searchItemPrompt.TabIndex = 3;
            this.searchItemPrompt.Text = "Please Input the Item\'s name to remove it from the inventory: ";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.itemNameLabel.Location = new System.Drawing.Point(200, 228);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(126, 25);
            this.itemNameLabel.TabIndex = 7;
            this.itemNameLabel.Text = "Item Name: ";
            // 
            // searchItemTextBox
            // 
            this.searchItemTextBox.Location = new System.Drawing.Point(384, 225);
            this.searchItemTextBox.Name = "searchItemTextBox";
            this.searchItemTextBox.Size = new System.Drawing.Size(208, 31);
            this.searchItemTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Pink;
            this.searchButton.Location = new System.Drawing.Point(421, 295);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(171, 47);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Location = new System.Drawing.Point(316, 640);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 53);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SearchForItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchItemTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.searchItemPrompt);
            this.Name = "SearchForItem";
            this.Text = "SearchForItem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchItemPrompt;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox searchItemTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button backButton;
    }
}