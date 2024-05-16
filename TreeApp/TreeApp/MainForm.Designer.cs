namespace TreeApp
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.treeListBox = new System.Windows.Forms.ListBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.sortLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(20, 50);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 30);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Tree";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(250, 55);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(200, 24);
            this.sortComboBox.TabIndex = 1;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.sortComboBox_SelectedIndexChanged);
            // 
            // treeListBox
            // 
            this.treeListBox.FormattingEnabled = true;
            this.treeListBox.ItemHeight = 16;
            this.treeListBox.Location = new System.Drawing.Point(20, 100);
            this.treeListBox.Name = "treeListBox";
            this.treeListBox.Size = new System.Drawing.Size(430, 260);
            this.treeListBox.TabIndex = 2;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(375, 380);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 30);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // sortLabel
            // 
            this.sortLabel.AutoSize = true;
            this.sortLabel.Location = new System.Drawing.Point(150, 60);
            this.sortLabel.Name = "sortLabel";
            this.sortLabel.Size = new System.Drawing.Size(94, 16);
            this.sortLabel.TabIndex = 4;
            this.sortLabel.Text = "Sort by criteria:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(20, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(216, 31);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Tree Management";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 430);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.sortLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.treeListBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.addButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tree Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.ListBox treeListBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label sortLabel;
        private System.Windows.Forms.Label titleLabel;
    }
}
