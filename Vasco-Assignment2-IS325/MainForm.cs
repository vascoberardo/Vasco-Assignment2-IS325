using System.Diagnostics.Eventing.Reader;

namespace Vasco_Assignment2_IS325
{

    public partial class MainForm : Form
    {
        public string color;
        public enum VehicleColor
        {
            Blue,
            Black,
            White,
            Yellow
        }

        public string ChooseColor(VehicleColor color)
        {
            switch (color)
            {
                case VehicleColor.Blue:
                    return "Blue";
                case VehicleColor.Black:
                    return "Black";
                case VehicleColor.White:
                    return "White";
                case VehicleColor.Yellow:
                    return "Yellow";
                default:
                    return "Invalid color selection.";
            }
        }
        public MainForm()
        {
            InitializeComponent();

        }


        private void btnPurchase_Click(object sender, EventArgs e)
        {
         

            if (lstMakeModel.SelectedIndex == -1)
            {
                lblOutput.Text = "Please select a make and model before purchasing.";
                lblOutput.ForeColor = Color.Red;
            }
            else if (!int.TryParse(txtYear.Text, out int year))
            {
                lblOutput.Text = "Please enter a valid year.";
                lblOutput.ForeColor = Color.Red;
            }
            else if (!radBlue.Checked && !radBlack.Checked && !radWhite.Checked && !radYellow.Checked)
            {
                lblOutput.Text = ("Please select a color.");
                lblOutput.ForeColor = Color.Red;
            }
            else
            {
                string features = "";
                if (chkAC.Checked)
                {
                    features += ", AC";
                }
                if (chkPowerWindows.Checked)
                {
                    features += ", Power Windows";
                }
                if (chkSiriusRadio.Checked)
                {
                    features += ", Sirius Radio";
                }
                if (chkLaneAssist.Checked)
                {
                    features += ", Lane Assistance";
                }
                features.Substring(1);
                string selectedVehicle = lstMakeModel.SelectedItem.ToString();
                lblOutput.Text = $"You have purchased a {selectedVehicle}, in {color}, from {txtYear.Text}, with the features {features} .";
                lblOutput.ForeColor = Color.Black;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            color = ChooseColor(VehicleColor.Blue);
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            color = ChooseColor(VehicleColor.Black);
        }

        private void radWhite_CheckedChanged(object sender, EventArgs e)
        {
            color = ChooseColor(VehicleColor.White);
        }

        private void radYellow_CheckedChanged(object sender, EventArgs e)
        {
            color = ChooseColor(VehicleColor.Yellow);
        }
    }
}
