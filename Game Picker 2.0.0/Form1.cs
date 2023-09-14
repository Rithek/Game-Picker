using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Xml;
using System.Security.Cryptography;
using Game_Picker_2._0._0;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Game_Picker_2._0._0
{
    public partial class Form1 : Form
    {
        private BindingList<Game> _gamesList;
        private BindingSource _bindingSource = new BindingSource();
        private bool isFormDragged = false;
        private bool isLabelDragged = false;
        private Point formStartPosition;
        private Point labelStartPosition;


        public Form1()
        {
            InitializeComponent();
            InitializeGameData();

            this.StartPosition = FormStartPosition.CenterScreen;

            addEditMode.SaveClicked += AddEditMode_SaveClicked;
            addEditMode.CloseClicked += AddEditMode_CloseClicked;
            addEditMode.NewPlatformAdded += AddEditMode_NewPlatformAdded;
            addEditMode.NewStatusAdded += AddEditMode_NewStatusAdded;
            cmb_Sortby.SelectedIndexChanged += cbx_Sortby_SelectedIndexChanged;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            randomizerWindow.CloseClicked += RandomizerW_CloseClicked;

            dtp_DateRangeHigh.MouseWheel += dateTimePicker_MouseWheel;
            dtp_DateRangeLow.MouseWheel += dateTimePicker_MouseWheel;


            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            _bindingSource.DataSource = _gamesList;
            dataGridView1.DataSource = _bindingSource;


            dataGridView1.Columns["IsSpeedrun"].Visible = false; // Hide the IsSpeedrun column
            dataGridView1.Columns["Tags"].Visible = false; // Hide the IsSpeedrun column
            cmb_Sortby.SelectedIndex = 0;


            this.Paint += Form1_Paint;
        }






        private void ShowAddEditMode(Game gameToEdit = null)
        {
            addEditMode.GameData = gameToEdit;
            addEditMode.PopulateControls();
            addEditMode.Visible = true;
            DisableMainModeControls();
        }




        private void btnAddGame_Click(object sender, EventArgs e)
        {
            addEditMode.ResetControl();
            ShowAddEditMode();
        }




        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Game selectedGame = dataGridView1.SelectedRows[0].DataBoundItem as Game;
                ShowAddEditMode(selectedGame);
            }
        }



        private void AddEditMode_SaveClicked(object sender, EventArgs e)
        {


            // Add the new game to the list if it's a new game
            if (!_gamesList.Contains(addEditMode.GameData))
            {
                _gamesList.Add(addEditMode.GameData);
            }


            ApplyFilters(); // Apply filters after saving or editing a game

            // Hide the UserControl
            addEditMode.Visible = false;
            EnableMainModeControls();

            // Reset the filters
            btn_ResetSearch_Click(sender, e);

            SaveGameData(_gamesList);

        }

        private void AddEditMode_CloseClicked(object sender, EventArgs e)
        {
            // Hide the UserControl
            addEditMode.Visible = false;
            EnableMainModeControls();
        }
        private void RandomizerW_CloseClicked(object sender, EventArgs e)
        {
            // Hide the UserControl
            randomizerWindow.Visible = false;
            EnableMainModeControls();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate cmb_AddEdit_Platform with platforms from the existing game list
            foreach (Game game in _gamesList)
            {
                addEditMode.AddPlatform(game.Platform);
            }

            // Populate the cmb_Platform ComboBox with platforms from the games list
            cmb_Platform.Items.Insert(0, "Any");
            cmb_Platform.SelectedIndex = 0;

            foreach (Game game in _gamesList)
            {
                AddPlatform(game.Platform);
            }


            // Populate cmb_AddEdit_Status with status values from the existing game list
            foreach (Game game in _gamesList)
            {
                addEditMode.AddStatus(game.Status);
            }

            // Populate the cmb_Status ComboBox with status values from the games list
            cmb_Status.Items.Insert(0, "Any");
            cmb_Status.SelectedIndex = 0;

            foreach (Game game in _gamesList)
            {
                AddStatus(game.Status);
            }


            //Default Control Values
            cmb_Rating.SelectedIndex = 0;
            cmb_DateSetting.SelectedIndex = 0;
            cmb_Status.SelectedIndex = 0;
            dtp_DateRangeLow.Value = DateTime.Today.AddMonths(-6);

            // Subscribe to the GotFocus and LostFocus events of the main form
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;



            this.MouseDown += Form1_MouseDown;
            lblAppTitle.MouseDown += LblAppTitle_MouseDown;
            lblAppTitle.MouseMove += LblAppTitle_MouseMove;
            lblAppTitle.MouseUp += LblAppTitle_MouseUp;
        }


        private void AddPlatform(string platform)
        {
            if (!cmb_Platform.Items.Contains(platform))
            {
                cmb_Platform.Items.Add(platform);
            }
        }


        private void AddStatus(string status)
        {
            if (!cmb_Status.Items.Contains(status))
            {
                cmb_Status.Items.Add(status);
            }
        }


        private void AddEditMode_NewPlatformAdded(object sender, string platformName)
        {
            if (!cmb_Platform.Items.Contains(platformName))
            {
                cmb_Platform.Items.Add(platformName);
            }
        }


        private void AddEditMode_NewStatusAdded(object sender, string statusName)
        {
            if (!cmb_Status.Items.Contains(statusName))
            {
                cmb_Status.Items.Add(statusName);
            }
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            //Reset Search Controls
            cmb_Platform.SelectedIndex = 0;
            cmb_Rating.SelectedIndex = 0;
            cmb_DateSetting.SelectedIndex = 0;
            cmb_Status.SelectedIndex = 0;
            cbx_ShowSpeedrunsOnly.Checked = false;
            textBox1.Text = string.Empty;
            dtp_DateRangeLow.Value = DateTime.Today.AddMonths(-3);
            dtp_DateRangeHigh.Value = DateTime.Today;
            cmb_Sortby.SelectedIndex = 0;
        }

        private void cmb_DateSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enable or disable Date pickers for search
            if (cmb_DateSetting.SelectedIndex == 0)
            {
                dtp_DateRangeLow.Enabled = false;
                dtp_DateRangeHigh.Enabled = false;
            }
            else
            {
                dtp_DateRangeLow.Enabled = true;
                dtp_DateRangeHigh.Enabled = true;
            }
            ApplyFilters();
        }

        private void DisableMainModeControls()
        {

            textBox1.Enabled = false;
            cmb_Platform.Enabled = false;
            cmb_Rating.Enabled = false;
            cmb_Status.Enabled = false;
            cbx_ShowSpeedrunsOnly.Enabled = false;
            cmb_DateSetting.Enabled = false;
            dtp_DateRangeLow.Enabled = false;
            dtp_DateRangeHigh.Enabled = false;
            btnAddGame.Enabled = false;
            dataGridView1.Enabled = false;
            btn_ResetSearch.Enabled = false;
            cmb_Sortby.Enabled = false;
            btn_BackupData.Enabled = false;
        }

        private void EnableMainModeControls()
        {
            textBox1.Enabled = true;
            cmb_Platform.Enabled = true;
            cmb_Rating.Enabled = true;
            cmb_Status.Enabled = true;
            cbx_ShowSpeedrunsOnly.Enabled = true;
            cmb_DateSetting.Enabled = true;
            btnAddGame.Enabled = true;
            dataGridView1.Enabled = true;
            btn_ResetSearch.Enabled = true;
            cmb_Sortby.Enabled = true;
            btn_BackupData.Enabled = true;


            if (cmb_DateSetting.SelectedIndex == 0)
            {
                dtp_DateRangeLow.Enabled = false;
                dtp_DateRangeHigh.Enabled = false;
            }
            else
            {
                dtp_DateRangeLow.Enabled = true;
                dtp_DateRangeHigh.Enabled = true;
            }

        }




        private void ApplyFilters()
        {

            string searchText = textBox1.Text;
            string selectedPlatform = cmb_Platform.SelectedItem?.ToString() ?? "Any";
            string selectedRating = cmb_Rating.SelectedItem?.ToString() ?? "Any";
            string selectedStatus = cmb_Status.SelectedItem?.ToString() ?? "Any";
            string dateSettingFilter = cmb_DateSetting.SelectedItem != null ? cmb_DateSetting.SelectedItem.ToString() : "Any Date";

            bool showSpeedrunsOnly = cbx_ShowSpeedrunsOnly.Checked;

            DateTime dateRangeLow = dtp_DateRangeLow.Value.Date;
            DateTime dateRangeHigh = dtp_DateRangeHigh.Value.Date;


            var filteredGames = _gamesList.Where(game =>
    (string.IsNullOrEmpty(searchText) || game.GameName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) &&
    (selectedPlatform == "Any" || game.Platform == selectedPlatform) &&
    (selectedRating == "Any" || game.Rating.ToString() == selectedRating) &&
    (selectedStatus == "Any" || game.Status == selectedStatus) &&
    (!showSpeedrunsOnly || game.IsSpeedrun) &&
    (dateSettingFilter == "Any Date" ||
     (dateSettingFilter == "Last Played" && game.LastPlayed.Date >= dateRangeLow && game.LastPlayed.Date <= dateRangeHigh) ||
     (dateSettingFilter == "Completion Date" && game.CompletionDate.Date >= dateRangeLow && game.CompletionDate.Date <= dateRangeHigh))
).ToList();
            // Add sorting functionality here
            switch (cmb_Sortby.SelectedItem?.ToString() ?? "Default")
            {
                case "":
                    break;
                case "Game Name (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.GameName).ToList();
                    break;
                case "Game Name (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.GameName).ToList();
                    break;
                case "Platform (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.Platform).ToList();
                    break;
                case "Platform (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.Platform).ToList();
                    break;
                case "Rating (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.Rating).ToList();
                    break;
                case "Rating (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.Rating).ToList();
                    break;
                case "Status (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.Status).ToList();
                    break;
                case "Status (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.Status).ToList();
                    break;
                case "Last Played (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.LastPlayed).ToList();
                    break;
                case "Last Played (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.LastPlayed).ToList();
                    break;
                case "Completion Date (Asc)":
                    filteredGames = filteredGames.OrderBy(g => g.CompletionDate).ToList();
                    break;
                case "Completion Date (Desc)":
                    filteredGames = filteredGames.OrderByDescending(g => g.CompletionDate).ToList();
                    break;


                // Add more cases for other sorting options as needed
                default:
                    break;
            }
            _bindingSource.DataSource = new BindingList<Game>(filteredGames);

        }

        // APPLY FILTERS STARt
            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }
            private void cmb_Platform_SelectedIndexChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

            private void cmb_Rating_SelectedIndexChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

            private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

            private void cbx_ShowSpeedrunsOnly_CheckedChanged(object sender, EventArgs e)
            {
                ApplyFilters();
            }

        // APPLY FILTERS END

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there's a selected row in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the first selected row
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Get the Game object from the row
                Game game = row.DataBoundItem as Game;

                if (game != null)
                {
                    // Set the game data in the AddEditMode control
                    addEditMode.GameData = game;

                    // Populate the AddEditMode control's input fields with the game data
                    addEditMode.PopulateControls();

                    // Show the AddEditMode control
                    addEditMode.Visible = true;

                    // Set the main form's state as needed
                    DisableMainModeControls();
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there are any selected rows in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show a confirmation dialog with the number of items to be deleted
                DialogResult result = MessageBox.Show($"{dataGridView1.SelectedRows.Count} items will be deleted, are you sure you want to proceed?",
                                                      "Confirm Delete",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                // If the user confirms the deletion
                if (result == DialogResult.Yes)
                {
                    // Loop through the selected rows in reverse order to avoid issues when removing items
                    for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = dataGridView1.SelectedRows[i];
                        if (row.DataBoundItem is Game game)
                        {
                            // Remove the game from the data source
                            _gamesList.Remove(game);
                            SaveGameData(_gamesList);

                        }
                    }

                    // Refresh the DataGridView
                    dataGridView1.Refresh();
                    ApplyFilters();
                }
            }
        }

        private void setLastPlayedToTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if there are any selected rows in the DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Show a confirmation dialog only when more than 1 game is selected
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    DialogResult result = MessageBox.Show($"You are about to set the 'Last Played' date on {dataGridView1.SelectedRows.Count} game(s). Are you sure you want to continue?", "Confirm Set Last Played", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }
                }

                // Set the LastPlayed date to today for each selected game
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Game game = row.DataBoundItem as Game;
                    if (game != null)
                    {
                        game.LastPlayed = DateTime.Today;
                        SaveGameData(_gamesList);
                    }
                }
                ApplyFilters();
            }
        }

        private void setCompletionDateToTodayToolStripMenuItem_Click(object sender, EventArgs e)
        {


            int selectedRowCount = dataGridView1.SelectedRows.Count;

            if (selectedRowCount > 1)
            {
                DialogResult result = MessageBox.Show($"You are about to set the 'Completion Date' to today for {selectedRowCount} games. Are you sure you want to continue?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Game game = row.DataBoundItem as Game;
                if (game != null)
                {
                    game.CompletionDate = DateTime.Today;
                    if (game.Status != "100% Completed")
                    {

                        game.Status = "Completed";
                    }
                    SaveGameData(_gamesList);

                }
            }

            ApplyFilters();
        }



        private void dtp_DateRangeLow_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dtp_DateRangeHigh_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Dictionary<string, string> dataPropertyNameToDisplayName = new Dictionary<string, string>
    {
        { "GameName", "Game Name" },
        { "Platform", "Platform" },
        { "Rating", "Rating" },
        { "Status", "Status" },
        { "LastPlayed", "Last Played" },
        { "CompletionDate", "Completion Date" }
    };

            string dataPropertyName = dataGridView1.Columns[e.ColumnIndex].DataPropertyName;
            string displayName = dataPropertyNameToDisplayName.ContainsKey(dataPropertyName) ? dataPropertyNameToDisplayName[dataPropertyName] : dataPropertyName;
            string currentItem = cmb_Sortby.SelectedItem?.ToString() ?? "";

            string[] sortOptions = new string[] { $"{displayName} (Desc)", $"{displayName} (Asc)", "" };

            int index = Array.IndexOf(sortOptions, currentItem);
            index = (index + 1) % sortOptions.Length;

            cmb_Sortby.SelectedItem = sortOptions[index];
        }

        private void cbx_Sortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }





        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked and the location is within the draggable area (top 50 pixels)
            if (e.Button == MouseButtons.Left && e.Location.Y <= 50 && e.Location.X >= 0 && e.Location.X <= 900)
            {
                isFormDragged = true;
                formStartPosition = e.Location;
            }
            else
            {
                // If the mouse is not in the form's draggable area, reset the label dragging
                isLabelDragged = false;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // If the form is being dragged and the left mouse button is pressed, update its location
            if (isFormDragged && e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.Location.X - formStartPosition.X;
                newLocation.Y += e.Location.Y - formStartPosition.Y;
                this.Location = newLocation;
            }

            // If the label is being dragged and the left mouse button is pressed, update its location
            if (isLabelDragged && e.Button == MouseButtons.Left)
            {
                Point newLocation = lblAppTitle.Location;
                newLocation.X += e.Location.X - labelStartPosition.X;
                newLocation.Y += e.Location.Y - labelStartPosition.Y;
                lblAppTitle.Location = newLocation;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset the flags when the mouse button is released
            isFormDragged = false;
            isLabelDragged = false;
        }

        private void LblAppTitle_MouseDown(object sender, MouseEventArgs e)
        {
            // Check if the left mouse button is clicked on the label
            if (e.Button == MouseButtons.Left)
            {
                isLabelDragged = true;
                labelStartPosition = e.Location;
            }
        }


        private void LblAppTitle_MouseMove(object sender, MouseEventArgs e)
        {
            // If the label is being dragged and the left mouse button is pressed, update its location
            if (isLabelDragged && e.Button == MouseButtons.Left)
            {
                Point newLocation = this.Location;
                newLocation.X += e.Location.X - labelStartPosition.X;
                newLocation.Y += e.Location.Y - labelStartPosition.Y;
                this.Location = newLocation;
            }
        }

        private void LblAppTitle_MouseUp(object sender, MouseEventArgs e)
        {
            // Reset the flag when the mouse button is released
            isLabelDragged = false;
        }




        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private string GetFolderPath()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            return Path.Combine(documentsPath, "Game Picker 2");
        }

        private string GetFilePath()
        {
            return Path.Combine(GetFolderPath(), "GamePicker2Data.json");
        }

        private void InitializeGameData()
        {
            string folderPath = GetFolderPath();
            string filePath = GetFilePath();

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                // Create a new empty JSON file
                File.WriteAllText(filePath, "[]");
            }

            // Load game data from the JSON file
            string jsonData = File.ReadAllText(filePath);
            _gamesList = JsonConvert.DeserializeObject<BindingList<Game>>(jsonData);
            // Do something with the loaded games
        }

        private void SaveGameData(BindingList<Game> games)
        {
            string filePath = GetFilePath();
            string jsonData = JsonConvert.SerializeObject(games, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
        }
        private void BackupGameData(BindingList<Game> games)
        {
            string folderPath = GetFolderPath();
            string dateString = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string backupFileName = $"Backup GamePicker2Data ({dateString}).json";
            string backupFilePath = Path.Combine(folderPath, backupFileName);

            string jsonData = JsonConvert.SerializeObject(games, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(backupFilePath, jsonData);
        }

        private void btn_BackupData_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to create a backup of the game data?", "Backup Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                BackupGameData(_gamesList);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void btn_Randomizer_Click(object sender, EventArgs e)
        {
            randomizerWindow.Visible = true;
            randomizerWindow.Games = _gamesList;
            DisableMainModeControls();
            randomizerWindow.ClearControls();
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Draw a 1px black border around the form
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1));
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            lblAppTitle.ForeColor = Color.Black;
            btn_Minimize.ForeColor = Color.Black;
            btn_Close.ForeColor = Color.Black;
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            lblAppTitle.ForeColor = Color.Gray;
            btn_Minimize.ForeColor = Color.Gray;
            btn_Close.ForeColor = Color.Gray;
        }

    }


}







