namespace InventoryManager
{
    partial class RemoveItemForm
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
            this.removeItemPrompt = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.removeItemTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeItemPrompt
            // 
            this.removeItemPrompt.AutoSize = true;
            this.removeItemPrompt.BackColor = System.Drawing.Color.LightSalmon;
            this.removeItemPrompt.ForeColor = System.Drawing.Color.Maroon;
            this.removeItemPrompt.Location = new System.Drawing.Point(86, 132);
            this.removeItemPrompt.Name = "removeItemPrompt";
            this.removeItemPrompt.Size = new System.Drawing.Size(595, 25);
            this.removeItemPrompt.TabIndex = 1;
            this.removeItemPrompt.Text = "Please Input the Item\'s name to remove it from the inventory: ";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.itemNameLabel.Location = new System.Drawing.Point(192, 260);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(126, 25);
            this.itemNameLabel.TabIndex = 2;
            this.itemNameLabel.Text = "Item Name: ";
            // 
            // removeItemTextBox
            // 
            this.removeItemTextBox.Location = new System.Drawing.Point(356, 260);
            this.removeItemTextBox.Name = "removeItemTextBox";
            this.removeItemTextBox.Size = new System.Drawing.Size(208, 31);
            this.removeItemTextBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Pink;
            this.removeButton.Location = new System.Drawing.Point(393, 325);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(171, 47);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Location = new System.Drawing.Point(356, 695);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 53);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // RemoveItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(826, 805);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeItemTextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.removeItemPrompt);
            this.Name = "RemoveItemForm";
            this.Text = "Remove Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label removeItemPrompt;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox removeItemTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button backButton;
    }
}