using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Picker_2._0._0
{
    public partial class AddEditMode : UserControl
    {
        public Game GameData { get; set; }
        // Create an event for notifying the main form
        public event EventHandler SaveClicked;
        public event EventHandler CloseClicked;
        public event EventHandler<string> NewPlatformAdded;
        public event EventHandler<string> NewStatusAdded;


        public AddEditMode()
        {

            InitializeComponent();
            dateTimePicker1_AddEdit.MouseWheel += dateTimePicker_MouseWheel;
            dateTimePicker2_AddEdit.MouseWheel += dateTimePicker_MouseWheel;
        }

        private void btn_AddEdit_Save_Click(object sender, EventArgs e)
        {
            // Validate the input
            if (!ValidateInput())
            {
                return;
            }

            // Get the platform name from the ComboBox, whether it's a selected item or typed text
            string platformName = cmb_AddEdit_Platform.SelectedItem != null ? cmb_AddEdit_Platform.SelectedItem.ToString() : cmb_AddEdit_Platform.Text;
            string statusName = cmb_AddEdit_Status.SelectedItem != null ? cmb_AddEdit_Status.SelectedItem.ToString() : cmb_AddEdit_Status.Text;

            // Update the GameData property with the new values
            if (GameData == null)
            {
                GameData = new Game();
            }
            GameData.GameName = txb_GameName.Text;
            GameData.Platform = platformName;
            GameData.Rating = GetRatingFromComboBox();
            GameData.Status = statusName;
            GameData.IsSpeedrun = cbx_AddEdit_IsSpeedrun.Checked;
            GameData.LastPlayed = dateTimePicker1_AddEdit.Checked ? dateTimePicker1_AddEdit.Value.Date : DateTime.MinValue;
            GameData.CompletionDate = dateTimePicker2_AddEdit.Checked ? dateTimePicker2_AddEdit.Value.Date : DateTime.MinValue;


            // ... and so on for the other properties

            // Add the new platform to the ComboBox if it's not already there
            AddPlatform(platformName);
            AddStatus(statusName);

            // Raise the NewPlatformAdded event
            NewPlatformAdded?.Invoke(this, platformName);

            // Raise the NewStatusAdded event
            NewStatusAdded?.Invoke(this, statusName);

            // Raise the SaveClicked event
            SaveClicked?.Invoke(this, EventArgs.Empty);

        }

        private void btn_AddEdit_Close_Click(object sender, EventArgs e)
        {
            // Trigger the CloseClicked event
            CloseClicked?.Invoke(this, EventArgs.Empty);
        }


        // Create a public method to populate the input controls
        public void PopulateControls()
        {
            if (GameData != null)
            {
                // Populate the input controls with the data from GameData
                txb_GameName.Text = GameData.GameName;
                cmb_AddEdit_Platform.SelectedItem = GameData.Platform;
                SetRatingComboBox(GameData.Rating);
                cmb_AddEdit_Status.SelectedItem = GameData.Status;
                cbx_AddEdit_IsSpeedrun.Checked = GameData.IsSpeedrun;


                if (GameData.LastPlayed != DateTime.MinValue)
                {
                    dateTimePicker1_AddEdit.Value = GameData.LastPlayed;
                    dateTimePicker1_AddEdit.Checked = true;
                }
                else
                {
                    dateTimePicker1_AddEdit.Checked = false;
                }



                if (GameData.CompletionDate != DateTime.MinValue)
                {
                    dateTimePicker2_AddEdit.Value = GameData.CompletionDate;
                    dateTimePicker2_AddEdit.Checked = true;
                }
                else
                {
                    dateTimePicker2_AddEdit.Checked = false;
                }


                // ... and so on for the other properties
            }
            else
            {


                dateTimePicker1_AddEdit.Value = DateTime.Today;
                dateTimePicker2_AddEdit.Value = DateTime.Today;
                dateTimePicker1_AddEdit.Checked = false;
                dateTimePicker2_AddEdit.Checked = false;
            }
        }


        public void AddPlatform(string platform)
        {
            if (!cmb_AddEdit_Platform.Items.Contains(platform))
            {
                cmb_AddEdit_Platform.Items.Add(platform);
            }
        }


        public void AddStatus(string status)
        {
            if (!cmb_AddEdit_Status.Items.Contains(status))
            {
                cmb_AddEdit_Status.Items.Add(status);
            }
        }

        private void SetRatingComboBox(int? rating)
        {

            if (rating.HasValue)
            {
                if (rating.Value == 0)
                {
                    cmb_AddEdit_Rating.SelectedIndex = 11;
                }
                else
                {
                    cmb_AddEdit_Rating.SelectedIndex = 11 - rating.Value;
                }
            }
            else
            {
                cmb_AddEdit_Rating.SelectedIndex = 0; // Select "Not Rated"
            }


        }


        private int? GetRatingFromComboBox()
        {
            if (cmb_AddEdit_Rating.SelectedIndex == 0)
            {
                return null; // Not Rated
            }
            else if (cmb_AddEdit_Rating.SelectedIndex == 11)
            {
                return 0;
            }
            else
            {
                return 11 - cmb_AddEdit_Rating.SelectedIndex;
            }
        }


        public void ResetControl()
        {
            GameData = null;
            txb_GameName.Clear();
            cmb_AddEdit_Platform.SelectedIndex = 0;
            cmb_AddEdit_Rating.SelectedIndex = 0;
            cmb_AddEdit_Status.SelectedIndex = 0;
            cbx_AddEdit_IsSpeedrun.Checked = false;
            dateTimePicker1_AddEdit.Checked = false;
            dateTimePicker2_AddEdit.Checked = false;
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txb_GameName.Text))
            {
                MessageBox.Show("Game name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string platformName = cmb_AddEdit_Platform.SelectedItem != null ? cmb_AddEdit_Platform.SelectedItem.ToString() : cmb_AddEdit_Platform.Text;

            if (string.IsNullOrWhiteSpace(platformName))
            {
                MessageBox.Show("Platform name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmb_AddEdit_Status.Text))
            {
                MessageBox.Show("Please enter or select a status.", "Status Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            // Add more validation checks here as needed

            return true;
        }

        private void AddEditMode_Load(object sender, EventArgs e)
        {
            //Default Control Values
            cmb_AddEdit_Platform.SelectedIndex = 0;
        }

        private void dateTimePicker_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                System.Windows.Forms.SendKeys.Send("{UP}");
            }
            else
            {
                System.Windows.Forms.SendKeys.Send("{DOWN}");
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Set the border color and width
            Color borderColor = Color.Black;
            int borderWidth = 1;

            using (Pen borderPen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.ClientSize.Width - borderWidth, this.ClientSize.Height - borderWidth);
            }
        }

    }
}
