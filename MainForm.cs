namespace WeldingScoreboard

{
    using System.IO;
    using System.Text.Json;
    public partial class MainForm : Form

    {
        private List<Contestant> contestants = new List<Contestant>();
        private int nextContestantId = 1;
        private string filenm = "";

        public MainForm()
        {
            InitializeComponent();

            dgvContestants.AllowUserToAddRows = false;
            dgvContestants.RowHeadersVisible = false;
            dgvContestants.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContestants.MultiSelect = false;
            dgvContestants.ReadOnly = true;
        }

        private void RefreshContestantsGrid()
        {
            dgvContestants.Rows.Clear();

            foreach (var contestant in contestants)
            {
                dgvContestants.Rows.Add(
                    contestant.Id,
                    contestant.School,
                    contestant.Name,
                    contestant.Score,
                    contestant.Notes
                );
            }
        }

        private void ResetFormFields()
        {
            filenm = string.Empty;
            txtName.Clear();
            txtSchool.Clear();
            txtNotes.Clear();
            txtSearch.Clear();
            nudScore.Value = 0;

            contestants.Clear();
            nextContestantId = 1;

            RefreshContestantsGrid();
            RefreshLeaderBoard();
            ShowContestantInScoreBox(null);
        }

        private void RefreshLeaderBoard()
        {
            lstLeaderBoard.Items.Clear();

            var sortedContestants = contestants
                .OrderByDescending(c => c.Score)
                .ThenBy(c => c.Name)
                .ToList();

            for (int i = 0; i < sortedContestants.Count; i++)
            {
                var contestant = sortedContestants[i];
                lstLeaderBoard.Items.Add($"{i + 1}. {contestant.Name} - {contestant.Score}");
            }
        }

        private void SaveContestantsToFile(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(contestants, options);
            File.WriteAllText(filePath, json);

            filenm = filePath;
        }

        private void LoadContestantsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("The selected file does not exist.");
                return;
            }

            string json = File.ReadAllText(filePath);

            var loadedContestants = JsonSerializer.Deserialize<List<Contestant>>(json);

            if (loadedContestants == null)
            {
                MessageBox.Show("Unable to load contestant data.");
                return;
            }

            contestants = loadedContestants;

            if (contestants.Count > 0)
                nextContestantId = contestants.Max(c => c.Id) + 1;
            else
                nextContestantId = 1;

            filenm = filePath;

            RefreshContestantsGrid();
            RefreshLeaderBoard();
            ShowContestantInScoreBox(null);
        }

        private void ClearEntryFields()
        {
            txtName.Clear();
            txtSchool.Clear();
            nudScore.Value = 0;
            txtNotes.Clear();
            txtName.Focus();
        }

        private void ShowContestantInScoreBox(Contestant? contestant)
        {
            if (contestant == null)
            {
                lblActiveName.Text = "---";
                lblActiveSchool.Text = "---";
                lblActiveScore.Text = "0";
                lblActiveNotes.Text = "No Contestant Selected";
                return;
            }

            lblActiveName.Text = contestant.Name;
            lblActiveSchool.Text = contestant.School;
            lblActiveScore.Text = contestant.Score.ToString();
            lblActiveNotes.Text = string.IsNullOrWhiteSpace(contestant.Notes)
                ? "---"
                : contestant.Notes;
        }

        private Contestant? GetSelectedContestant()
        {
            if (dgvContestants.CurrentRow == null)
                return null;

            if (dgvContestants.CurrentRow.Index < 0)
                return null;

            object? cellValue = dgvContestants.CurrentRow.Cells[0].Value;

            if (cellValue == null)
                return null;

            int id = Convert.ToInt32(cellValue);

            return contestants.FirstOrDefault(c => c.Id == id);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string school = txtSchool.Text.Trim();
            int score = (int)nudScore.Value;
            string notes = txtNotes.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a contestant name.");
                return;
            }

            bool duplicateExists = contestants.Any(c =>
                c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (duplicateExists)
            {
                MessageBox.Show("That contestant name already exists.");
                return;
            }

            Contestant contestant = new Contestant
            {
                Id = nextContestantId++,
                Name = name,
                School = school,
                Score = score,
                Notes = notes
            };

            contestants.Add(contestant);

            RefreshContestantsGrid();
            RefreshLeaderBoard();
            ShowContestantInScoreBox(contestant);
            ClearEntryFields();
        }

        private void btnRecordScore_Click(object sender, EventArgs e)
        {
            Contestant? selectedContestant = GetSelectedContestant();

            if (selectedContestant == null)
            {
                MessageBox.Show("Please select a contestant from the Contestants list first.");
                return;
            }

            selectedContestant.Score = (int)nudScore.Value;
            selectedContestant.Notes = txtNotes.Text.Trim();

            RefreshContestantsGrid();
            RefreshLeaderBoard();
            ShowContestantInScoreBox(selectedContestant);
            ClearEntryFields();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Enter a name or school to search for.");
                return;
            }

            var match = contestants.FirstOrDefault(c =>
                c.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                c.School.Contains(searchText, StringComparison.OrdinalIgnoreCase));

            if (match == null)
            {
                MessageBox.Show("No matching contestant found.");
                return;
            }

            foreach (DataGridViewRow row in dgvContestants.Rows)
            {
                if (row.Cells[0].Value != null &&
                    Convert.ToInt32(row.Cells[0].Value) == match.Id)
                {
                    row.Selected = true;
                    dgvContestants.CurrentCell = row.Cells[0];
                    break;
                }
            }

            ShowContestantInScoreBox(match);
        }

        private void btnFullScreen_Click_1(object sender, EventArgs e)
        {
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by Robert Hurley" + Environment.NewLine + "Welding Scoreboard 1.0.0" + Environment.NewLine + "March 29, 2026", "About");
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle != FormBorderStyle.None)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFind_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult yOrN;

            yOrN = MessageBox.Show("Creating a new file will lose any unsaved data. Are you sure" +
                    " that you want to create a new file?", "New List?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (yOrN == DialogResult.Yes)
            {
                ResetFormFields();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.Title = "Load Contestants";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LoadContestantsFromFile(openFileDialog.FileName);
                        MessageBox.Show("Contestants loaded successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading file: " + ex.Message);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(filenm))
                {
                    SaveContestantsToFile(filenm);
                    MessageBox.Show("Contestants saved successfully.");
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                    saveFileDialog.Title = "Save Contestants";
                    saveFileDialog.FileName = "contestants.json";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveContestantsToFile(saveFileDialog.FileName);
                        MessageBox.Show("Contestants saved successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file: " + ex.Message);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveScore_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        $"{lblActiveName.Text}'s score is {lblActiveScore.Text}.",
        "Current Score",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
        }

        private void dgvContestants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Contestant? selectedContestant = GetSelectedContestant();
            ShowContestantInScoreBox(selectedContestant);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetFormFields();
        }
    }
}