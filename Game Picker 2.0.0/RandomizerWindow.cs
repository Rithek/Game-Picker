using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Picker_2._0._0
{
    public partial class RandomizerWindow : UserControl
    {
        public BindingList<Game> Games { get; set; }
        public event EventHandler CloseClicked;

        public RandomizerWindow()
        {
            InitializeComponent();
            checkedListBox1.ItemCheck += checkedListBox_ItemCheck;
            checkedListBox2.ItemCheck += checkedListBox_ItemCheck;
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

        private void btn_Randomizer_Close_Click(object sender, EventArgs e)
        {
            CloseClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ClearControls()
        {
            foreach (int i in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in checkedListBox2.CheckedIndices)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBox1.SelectedIndex = -1;
            checkedListBox2.SelectedIndex = -1;
            checkedListBox1.SetItemChecked(0, true);
            checkedListBox2.SetItemChecked(0, true);
            cbx_Rand_Speedrun.Checked = false;

        }


        public void SetGames(BindingList<Game> games)
        {
            Games = games;
        }
        private void btn_Randomize_Click(object sender, EventArgs e)
        {
            //var selectedPlatforms = checkedListBox2.CheckedItems.Cast<string>().ToList();
            //var selectedStatuses = checkedListBox1.CheckedItems.Cast<string>().ToList();

            //// Check if "Any" is selected for platforms and statuses
            //bool anyPlatform = selectedPlatforms.Contains("Any");
            //bool anyStatus = selectedStatuses.Contains("Any");

            //var filteredGames = Games.Where(game =>
            //    (anyPlatform || selectedPlatforms.Contains(game.Platform)) &&
            //    (anyStatus || selectedStatuses.Contains(game.Status))).ToList();

            //if (filteredGames.Count == 0)
            //{
            //    lbl_SelectedGame.Text = "No matching games found.";
            //    return;
            //}

            //var random = new Random();
            //int randomIndex = random.Next(filteredGames.Count);
            //var selectedGame = filteredGames[randomIndex];

            //lbl_SelectedGame.Text = selectedGame.GameName;

            //int gameNameLength = selectedGame.GameName.Length;
            //if (gameNameLength < 25)
            //{
            //    lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 24);
            //}
            //else if (gameNameLength < 34)
            //{
            //    lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 20);
            //}
            //else if (gameNameLength < 50)
            //{
            //    lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 16);
            //}
            //else
            //{
            //    lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 12);
            //}

            var platforms = checkedListBox2.CheckedItems.Cast<string>().ToList();
            var statuses = checkedListBox1.CheckedItems.Cast<string>().ToList();
            var includeSpeedrunsOnly = cbx_Rand_Speedrun.Checked;

            var filteredGames = Games.Where(game =>
                (platforms.Contains("Any") || platforms.Contains(game.Platform)) &&
                (statuses.Contains("Any") || statuses.Contains(game.Status)) &&
                (!includeSpeedrunsOnly || game.IsSpeedrun)).ToList();

            if (filteredGames.Count == 0)
            {
                MessageBox.Show("No games match the selected criteria.");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(filteredGames.Count);
            Game selectedGame = filteredGames[randomIndex];

            lbl_SelectedGame.Text = selectedGame.GameName;

            int gameNameLength = selectedGame.GameName.Length;
            if (gameNameLength < 25)
            {
                lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 24);
            }
            else if (gameNameLength < 34)
            {
                lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 20);
            }
            else if (gameNameLength < 50)
            {
                lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 16);
            }
            else
            {
                lbl_SelectedGame.Font = new Font(lbl_SelectedGame.Font.FontFamily, 12);
            }


        }


        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedListBox = sender as CheckedListBox;
            if (checkedListBox == null) return;

            checkedListBox.ItemCheck -= checkedListBox_ItemCheck;

            // When another item is selected while "Any" is selected
            if (e.NewValue == CheckState.Checked && checkedListBox.GetItemCheckState(0) == CheckState.Checked)
            {
                checkedListBox.SetItemCheckState(0, CheckState.Unchecked);
            }
            // When "Any" is selected
            else if (e.Index == 0 && e.NewValue == CheckState.Checked)
            {
                for (int i = 1; i < checkedListBox.Items.Count; i++)
                {
                    checkedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            // When unselecting an item and no other items are selected, select "Any"
            else if (e.NewValue == CheckState.Unchecked && checkedListBox.CheckedItems.Count == 1)
            {
                e.NewValue = CheckState.Checked; // Keep the current item checked to avoid flickering
                checkedListBox.SetItemCheckState(0, CheckState.Checked);
            }

            checkedListBox.ItemCheck += checkedListBox_ItemCheck;
        }
    }
}

