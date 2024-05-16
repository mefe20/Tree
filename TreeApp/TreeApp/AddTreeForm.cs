using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TreeApp
{
    public partial class AddTreeForm : Form
    {
        public Tree NewTree { get; private set; }

        public AddTreeForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string country = countryTextBox.Text;
            int hitsRequired;
            int hitsRemaining;
            int numberOfFruits;
            int daysUntilSpellEnds;
            DateTime plantingDate;

            if (!Regex.IsMatch(name, @"\S"))
            {
                MessageBox.Show("Name cannot be empty.");
                return;
            }

            if (!Regex.IsMatch(country, @"^([A-Z][a-z]+(?:[-\s][A-Z][a-z]+)*)$"))
            {
                MessageBox.Show("Country name is invalid.");
                return;
            }

            if (!int.TryParse(hitsRequiredTextBox.Text, out hitsRequired) || hitsRequired <= 0)
            {
                MessageBox.Show("Hits required must be a positive integer.");
                return;
            }

            if (!int.TryParse(hitsRemainingTextBox.Text, out hitsRemaining) || hitsRemaining < 0)
            {
                MessageBox.Show("Hits remaining must be a non-negative integer.");
                return;
            }

            if (!int.TryParse(numberOfFruitsTextBox.Text, out numberOfFruits) || numberOfFruits < 0)
            {
                MessageBox.Show("Number of fruits must be a non-negative integer.");
                return;
            }

            if (!int.TryParse(daysUntilSpellEndsTextBox.Text, out daysUntilSpellEnds) || daysUntilSpellEnds < 0)
            {
                MessageBox.Show("Days until spell ends must be a non-negative integer.");
                return;
            }

            if (!DateTime.TryParseExact(plantingDateTextBox.Text, new string[] { "dd MMMM yyyy", "dd:MM:yyyy", "dd:MM:yy", "dd.MM.yyyy", "dd.MM.yy" }, null, System.Globalization.DateTimeStyles.None, out plantingDate))
            {
                MessageBox.Show("Planting date is invalid.");
                return;
            }

            NewTree = new Tree(name, country, hitsRequired, hitsRemaining, numberOfFruits, daysUntilSpellEnds, plantingDate);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
