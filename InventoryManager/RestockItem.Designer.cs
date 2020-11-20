namespace InventoryManager
{
    partial class RestockItem
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
            this.restockItemPrompt = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.restockItemTextBox = new System.Windows.Forms.TextBox();
            this.restockButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // restockItemPrompt
            // 
            this.restockItemPrompt.AutoSize = true;
            this.restockItemPrompt.BackColor = System.Drawing.Color.Lavender;
            this.restockItemPrompt.ForeColor = System.Drawing.Color.Indigo;
            this.restockItemPrompt.Location = new System.Drawing.Point(91, 140);
            this.restockItemPrompt.Name = "restockItemPrompt";
            this.restockItemPrompt.Size = new System.Drawing.Size(595, 25);
            this.restockItemPrompt.TabIndex = 2;
            this.restockItemPrompt.Text = "Please Input the Item\'s name to remove it from the inventory: ";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.itemNameLabel.Location = new System.Drawing.Point(191, 245);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(126, 25);
            this.itemNameLabel.TabIndex = 6;
            this.itemNameLabel.Text = "Item Name: ";
            // 
            // restockItemTextBox
            // 
            this.restockItemTextBox.Location = new System.Drawing.Point(352, 245);
            this.restockItemTextBox.Name = "restockItemTextBox";
            this.restockItemTextBox.Size = new System.Drawing.Size(208, 31);
            this.restockItemTextBox.TabIndex = 6;
            // 
            // restockButton
            // 
            this.restockButton.BackColor = System.Drawing.Color.Pink;
            this.restockButton.Location = new System.Drawing.Point(389, 309);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(171, 47);
            this.restockButton.TabIndex = 6;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = false;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Location = new System.Drawing.Point(352, 678);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 53);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RestockItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 790);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.restockItemTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.restockItemPrompt);
            this.Name = "RestockItem";
            this.Text = "Re-Stock Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label restockItemPrompt;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox restockItemTextBox;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button backButton;
    }
}