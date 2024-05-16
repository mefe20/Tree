namespace TreeApp
{
    partial class AddTreeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.hitsRequiredTextBox = new System.Windows.Forms.TextBox();
            this.hitsRemainingTextBox = new System.Windows.Forms.TextBox();
            this.numberOfFruitsTextBox = new System.Windows.Forms.TextBox();
            this.daysUntilSpellEndsTextBox = new System.Windows.Forms.TextBox();
            this.plantingDateTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.hitsRequiredLabel = new System.Windows.Forms.Label();
            this.hitsRemainingLabel = new System.Windows.Forms.Label();
            this.numberOfFruitsLabel = new System.Windows.Forms.Label();
            this.daysUntilSpellEndsLabel = new System.Windows.Forms.Label();
            this.plantingDateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(160, 20);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(160, 50);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(200, 22);
            this.countryTextBox.TabIndex = 1;
            // 
            // hitsRequiredTextBox
            // 
            this.hitsRequiredTextBox.Location = new System.Drawing.Point(160, 80);
            this.hitsRequiredTextBox.Name = "hitsRequiredTextBox";
            this.hitsRequiredTextBox.Size = new System.Drawing.Size(200, 22);
            this.hitsRequiredTextBox.TabIndex = 2;
            // 
            // hitsRemainingTextBox
            // 
            this.hitsRemainingTextBox.Location = new System.Drawing.Point(160, 110);
            this.hitsRemainingTextBox.Name = "hitsRemainingTextBox";
            this.hitsRemainingTextBox.Size = new System.Drawing.Size(200, 22);
            this.hitsRemainingTextBox.TabIndex = 3;
            // 
            // numberOfFruitsTextBox
            // 
            this.numberOfFruitsTextBox.Location = new System.Drawing.Point(160, 140);
            this.numberOfFruitsTextBox.Name = "numberOfFruitsTextBox";
            this.numberOfFruitsTextBox.Size = new System.Drawing.Size(200, 22);
            this.numberOfFruitsTextBox.TabIndex = 4;
            // 
            // daysUntilSpellEndsTextBox
            // 
            this.daysUntilSpellEndsTextBox.Location = new System.Drawing.Point(160, 170);
            this.daysUntilSpellEndsTextBox.Name = "daysUntilSpellEndsTextBox";
            this.daysUntilSpellEndsTextBox.Size = new System.Drawing.Size(200, 22);
            this.daysUntilSpellEndsTextBox.TabIndex = 5;
            // 
            // plantingDateTextBox
            // 
            this.plantingDateTextBox.Location = new System.Drawing.Point(160, 200);
            this.plantingDateTextBox.Name = "plantingDateTextBox";
            this.plantingDateTextBox.Size = new System.Drawing.Size(200, 22);
            this.plantingDateTextBox.TabIndex = 6;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(160, 240);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 30);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(285, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(20, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(20, 53);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(61, 17);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Country:";
            // 
            // hitsRequiredLabel
            // 
            this.hitsRequiredLabel.AutoSize = true;
            this.hitsRequiredLabel.Location = new System.Drawing.Point(20, 83);
            this.hitsRequiredLabel.Name = "hitsRequiredLabel";
            this.hitsRequiredLabel.Size = new System.Drawing.Size(98, 17);
            this.hitsRequiredLabel.TabIndex = 11;
            this.hitsRequiredLabel.Text = "Hits Required:";
            // 
            // hitsRemainingLabel
            // 
            this.hitsRemainingLabel.AutoSize = true;
            this.hitsRemainingLabel.Location = new System.Drawing.Point(20, 113);
            this.hitsRemainingLabel.Name = "hitsRemainingLabel";
            this.hitsRemainingLabel.Size = new System.Drawing.Size(107, 17);
            this.hitsRemainingLabel.TabIndex = 12;
            this.hitsRemainingLabel.Text = "Hits Remaining:";
            // 
            // numberOfFruitsLabel
            // 
            this.numberOfFruitsLabel.AutoSize = true;
            this.numberOfFruitsLabel.Location = new System.Drawing.Point(20, 143);
            this.numberOfFruitsLabel.Name = "numberOfFruitsLabel";
            this.numberOfFruitsLabel.Size = new System.Drawing.Size(114, 17);
            this.numberOfFruitsLabel.TabIndex = 13;
            this.numberOfFruitsLabel.Text = "Number of Fruits:";
            // 
            // daysUntilSpellEndsLabel
            // 
            this.daysUntilSpellEndsLabel.AutoSize = true;
            this.daysUntilSpellEndsLabel.Location = new System.Drawing.Point(20, 173);
            this.daysUntilSpellEndsLabel.Name = "daysUntilSpellEndsLabel";
            this.daysUntilSpellEndsLabel.Size = new System.Drawing.Size(135, 17);
            this.daysUntilSpellEndsLabel.TabIndex = 14;
            this.daysUntilSpellEndsLabel.Text = "Days Until Spell Ends:";
            // 
            // plantingDateLabel
            // 
            this.plantingDateLabel.AutoSize = true;
            this.plantingDateLabel.Location = new System.Drawing.Point(20, 203);
            this.plantingDateLabel.Name = "plantingDateLabel";
            this.plantingDateLabel.Size = new System.Drawing.Size(98, 17);
            this.plantingDateLabel.TabIndex = 15;
            this.plantingDateLabel.Text = "Planting Date:";
            // 
            // AddTreeForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.plantingDateLabel);
            this.Controls.Add(this.daysUntilSpellEndsLabel);
            this.Controls.Add(this.numberOfFruitsLabel);
            this.Controls.Add(this.hitsRemainingLabel);
            this.Controls.Add(this.hitsRequiredLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.plantingDateTextBox);
            this.Controls.Add(this.daysUntilSpellEndsTextBox);
            this.Controls.Add(this.numberOfFruitsTextBox);
            this.Controls.Add(this.hitsRemainingTextBox);
            this.Controls.Add(this.hitsRequiredTextBox);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "AddTreeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Tree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox hitsRequiredTextBox;
        private System.Windows.Forms.TextBox hitsRemainingTextBox;
        private System.Windows.Forms.TextBox numberOfFruitsTextBox;
        private System.Windows.Forms.TextBox daysUntilSpellEndsTextBox;
        private System.Windows.Forms.TextBox plantingDateTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label hitsRequiredLabel;
        private System.Windows.Forms.Label hitsRemainingLabel;
        private System.Windows.Forms.Label numberOfFruitsLabel;
        private System.Windows.Forms.Label daysUntilSpellEndsLabel;
        private System.Windows.Forms.Label plantingDateLabel;
    }
}
