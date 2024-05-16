using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TreeApp
{
    public partial class MainForm : Form
    {
        private List<Tree> treeList = new List<Tree>();

        public MainForm()
        {
            InitializeComponent();
            sortComboBox.Items.AddRange(new string[] { "Age Ascending", "Age Descending", "Fruits Ascending", "Fruits Descending", "Hits Ascending", "Hits Descending" });
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddTreeForm addTreeForm = new AddTreeForm();
            if (addTreeForm.ShowDialog() == DialogResult.OK)
            {
                treeList.Add(addTreeForm.NewTree);
                UpdateTreeList();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortComboBox.SelectedItem.ToString())
            {
                case "Age Ascending":
                    treeList.Sort((x, y) => x.Age.CompareTo(y.Age));
                    break;
                case "Age Descending":
                    treeList.Sort((x, y) => y.Age.CompareTo(x.Age));
                    break;
                case "Fruits Ascending":
                    treeList.Sort((x, y) => x.NumberOfFruits.CompareTo(y.NumberOfFruits));
                    break;
                case "Fruits Descending":
                    treeList.Sort((x, y) => y.NumberOfFruits.CompareTo(x.NumberOfFruits));
                    break;
                case "Hits Ascending":
                    treeList.Sort((x, y) => x.HitsRemaining.CompareTo(y.HitsRemaining));
                    break;
                case "Hits Descending":
                    treeList.Sort((x, y) => y.HitsRemaining.CompareTo(x.HitsRemaining));
                    break;
            }
            UpdateTreeList();
        }

        private void UpdateTreeList()
        {
            treeListBox.Items.Clear();
            foreach (var tree in treeList)
            {
                treeListBox.Items.Add(tree.ToString());
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            treeList.Clear();
            UpdateTreeList();
        }
    }
}
