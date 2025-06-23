/*
 * Zachary Scharton
 * CST-150
 * Activity 2
 * 6/22/2025
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Activity2
{
    public partial class FrmSeconds : Form
    {
        public FrmSeconds()
        {
            InitializeComponent();
            lblResults.Visible = false; // Hide result label by default
        }

        /// <summary>
        /// Event handler for Apply Seconds button.
        /// Validates and converts seconds into minutes, hours, or days.
        /// </summary>
        private void ManageSecondsEventHandler(object sender, EventArgs e)
        {
            // === Constants ===
            const int SecondsInMinute = 60;
            const int SecondsInHour = 3600;
            const int SecondsInDay = 86400;

            // Reset result label
            lblResults.Visible = true;
            lblResults.ForeColor = Color.Black;

            // === TryParse Validation ===
            bool valid = int.TryParse(txtUserEntry.Text, out int secondsEntered);

            if (!valid || secondsEntered < 0)
            {
                lblResults.Text = "Please enter a valid positive integer.";
                lblResults.ForeColor = Color.Red;
                return;
            }

            // === Nested If Logic ===
            if (secondsEntered >= SecondsInDay)
            {
                double days = (double)secondsEntered / SecondsInDay;
                lblResults.Text = $"{secondsEntered:N0} seconds is approximately {days:N2} day(s).";
            }
            else if (secondsEntered >= SecondsInHour)
            {
                double hours = (double)secondsEntered / SecondsInHour;
                lblResults.Text = $"{secondsEntered:N0} seconds is approximately {hours:N2} hour(s).";
            }
            else if (secondsEntered >= SecondsInMinute)
            {
                double minutes = (double)secondsEntered / SecondsInMinute;
                lblResults.Text = $"{secondsEntered:N0} seconds is approximately {minutes:N2} minute(s).";
            }
            else
            {
                lblResults.Text = $"{secondsEntered:N0} second(s) is less than a minute.";
            }
        }
    }
}

