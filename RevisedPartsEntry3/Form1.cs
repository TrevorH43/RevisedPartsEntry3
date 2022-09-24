using System.ComponentModel;
using System.Text;

namespace RevisedPartsEntry3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Part Number: {this.partNumberTextBox.Text}");
                sb.AppendLine($"Part Description: {this.partDescriptionTextBox.Text}");
                sb.AppendLine($"Item Class: {this.itemClassTextBox.Text}");
                sb.AppendLine($"Units On Hand: {this.unitsOnHandTextBox.Text}");
                sb.AppendLine($"Unit Cost: {Convert.ToDouble(this.unitPriceTextBox.Text):C2}");
                MessageBox.Show(sb.ToString(), "Text Entry");
            }
            else
            {
                MessageBox.Show("Please correct entry errors.", "Entry Errors",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {  
                partNumberTextBox.Clear();
                partDescriptionTextBox.Clear();
                itemClassTextBox.Clear();
                unitsOnHandTextBox.Clear();
                unitPriceTextBox.Clear();
                partDescriptionTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void partNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (partNumberTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partNumberTextBox, "Part Number is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partNumberTextBox, "");
                e.Cancel = false;
            }
        }

        private void partDescriptionTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (partDescriptionTextBox.Text.Length == 0)
            {
                errorProvider.SetError(partDescriptionTextBox, "Part Description is required.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(partDescriptionTextBox, "");
                e.Cancel = false;
            }
        }


        private void itemClassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (itemClassTextBox.Text.Length == 0)
            {
                errorProvider.SetError(itemClassTextBox, "Item Class is required.");
                e.Cancel = true;
            }
            else if (!(itemClassTextBox.Text == "A" || itemClassTextBox.Text == "P" || itemClassTextBox.Text == "T"))
            {
                errorProvider.SetError(itemClassTextBox, "Item Class must be A, P, or T.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(itemClassTextBox, "");
                e.Cancel = false;
            }
        }

        private void unitsOnHandTextBox_Validating(object sender, CancelEventArgs e)
        {
            double? unitsOnHand = 0;
            ValidateNumericTextBoxes(unitsOnHandTextBox, "Units On Hand", out unitsOnHand, e);
        }

        private void unitPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            double? unitPrice;
            if (ValidateNumericTextBoxes(unitPriceTextBox, "Unit Price", out unitPrice, e))
            {
                if (unitPrice.HasValue)
                {
                    MessageBox.Show("Unit Price is " + unitPrice.Value);
                }
            }
        }


        private bool ValidateNumericTextBoxes(TextBox textBox, string fieldIdentifier, out double? outValue, CancelEventArgs e)
        {
            outValue = null;
            double doubleVal = 0;
            bool valid = false;

            if (textBox.Text.Length == 0)
            {
                errorProvider.SetError(textBox, $"{fieldIdentifier} is required.");
                e.Cancel = true;
            }
            else if (double.TryParse(textBox.Text, out doubleVal))
            {
                outValue = doubleVal;
                errorProvider.SetError(textBox, "");
                e.Cancel = false;
                valid = true;
            }
            else
            {
                errorProvider.SetError(textBox, $"{fieldIdentifier} must be numeric.");
                e.Cancel = true;
            }

            return valid;
        }
    }
}