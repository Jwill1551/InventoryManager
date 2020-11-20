namespace InventoryManager
{
    partial class DisplayItems
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
            this.DisplayAllitemPrompt = new System.Windows.Forms.Label();
            this.displayAllitemsButton = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayAllitemPrompt
            // 
            this.DisplayAllitemPrompt.AutoSize = true;
            this.DisplayAllitemPrompt.BackColor = System.Drawing.Color.SaddleBrown;
            this.DisplayAllitemPrompt.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DisplayAllitemPrompt.Location = new System.Drawing.Point(97, 66);
            this.DisplayAllitemPrompt.Name = "DisplayAllitemPrompt";
            this.DisplayAllitemPrompt.Size = new System.Drawing.Size(607, 25);
            this.DisplayAllitemPrompt.TabIndex = 3;
            this.DisplayAllitemPrompt.Text = "Click the button below to display all the items in the Inventory: ";
            // 
            // displayAllitemsButton
            // 
            this.displayAllitemsButton.BackColor = System.Drawing.Color.Pink;
            this.displayAllitemsButton.Location = new System.Drawing.Point(304, 128);
            this.displayAllitemsButton.Name = "displayAllitemsButton";
            this.displayAllitemsButton.Size = new System.Drawing.Size(197, 61);
            this.displayAllitemsButton.TabIndex = 7;
            this.displayAllitemsButton.Text = "Display All Items";
            this.displayAllitemsButton.UseVisualStyleBackColor = false;
            this.displayAllitemsButton.Click += new System.EventHandler(this.displayAllitemsButton_Click);
            // 
            // displayBox
            // 
            this.displayBox.Location = new System.Drawing.Point(102, 226);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(602, 372);
            this.displayBox.TabIndex = 8;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Pink;
            this.backButton.Location = new System.Drawing.Point(330, 685);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(148, 53);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(800, 786);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.displayAllitemsButton);
            this.Controls.Add(this.DisplayAllitemPrompt);
            this.Name = "DisplayItems";
            this.Text = "Display-All-Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayAllitemPrompt;
        private System.Windows.Forms.Button displayAllitemsButton;
        private System.Windows.Forms.TextBox displayBox;
        private System.Windows.Forms.Button backButton;
    }
}