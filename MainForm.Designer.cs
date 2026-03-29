namespace WeldingScoreboard
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            fullScreenToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            grpLeaderBoard = new GroupBox();
            lstLeaderBoard = new ListBox();
            grpScoreBox = new GroupBox();
            lblActiveNotes = new Label();
            lblActiveScore = new Label();
            lblActiveSchool = new Label();
            lblActiveName = new Label();
            lblScoreBoxNotes = new Label();
            lblScoreBoxScore = new Label();
            lblScoreBoxSchool = new Label();
            lblScoreBoxName = new Label();
            lblNotesScoreBox = new Label();
            lblScoreScoreBox = new Label();
            lblSchoolScoreBox = new Label();
            lblNameScoreBox = new Label();
            grpCompetitorEntry = new GroupBox();
            btnFind = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnRecordScore = new Button();
            btnRegister = new Button();
            lblNotes = new Label();
            lblScore = new Label();
            nudScore = new NumericUpDown();
            lblSchool = new Label();
            txtNotes = new TextBox();
            lblName = new Label();
            txtSchool = new TextBox();
            txtName = new TextBox();
            grpContestants = new GroupBox();
            dgvContestants = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSchool = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colScore = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            btnFullScreen = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1.SuspendLayout();
            grpLeaderBoard.SuspendLayout();
            grpScoreBox.SuspendLayout();
            grpCompetitorEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).BeginInit();
            grpContestants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContestants).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2093, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, loadToolStripMenuItem, saveToolStripMenuItem, printToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(100, 22);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "&Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(100, 22);
            printToolStripMenuItem.Text = "&Print";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, clearToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(101, 22);
            findToolStripMenuItem.Text = "&Find";
            findToolStripMenuItem.Click += findToolStripMenuItem_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(101, 22);
            clearToolStripMenuItem.Text = "Clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fullScreenToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // fullScreenToolStripMenuItem
            // 
            fullScreenToolStripMenuItem.Checked = true;
            fullScreenToolStripMenuItem.CheckState = CheckState.Checked;
            fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            fullScreenToolStripMenuItem.Size = new Size(131, 22);
            fullScreenToolStripMenuItem.Text = "F&ull Screen";
            fullScreenToolStripMenuItem.Click += fullScreenToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(107, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // grpLeaderBoard
            // 
            grpLeaderBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grpLeaderBoard.Controls.Add(lstLeaderBoard);
            grpLeaderBoard.Location = new Point(1562, 27);
            grpLeaderBoard.Name = "grpLeaderBoard";
            grpLeaderBoard.Size = new Size(519, 851);
            grpLeaderBoard.TabIndex = 1;
            grpLeaderBoard.TabStop = false;
            grpLeaderBoard.Text = "Leader Board";
            // 
            // lstLeaderBoard
            // 
            lstLeaderBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstLeaderBoard.BackColor = SystemColors.ActiveCaption;
            lstLeaderBoard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstLeaderBoard.FormattingEnabled = true;
            lstLeaderBoard.Location = new Point(6, 22);
            lstLeaderBoard.Name = "lstLeaderBoard";
            lstLeaderBoard.Size = new Size(507, 804);
            lstLeaderBoard.TabIndex = 0;
            // 
            // grpScoreBox
            // 
            grpScoreBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpScoreBox.BackColor = SystemColors.ActiveCaption;
            grpScoreBox.Controls.Add(lblActiveNotes);
            grpScoreBox.Controls.Add(lblActiveScore);
            grpScoreBox.Controls.Add(lblActiveSchool);
            grpScoreBox.Controls.Add(lblActiveName);
            grpScoreBox.Controls.Add(lblScoreBoxNotes);
            grpScoreBox.Controls.Add(lblScoreBoxScore);
            grpScoreBox.Controls.Add(lblScoreBoxSchool);
            grpScoreBox.Controls.Add(lblScoreBoxName);
            grpScoreBox.Controls.Add(lblNotesScoreBox);
            grpScoreBox.Controls.Add(lblScoreScoreBox);
            grpScoreBox.Controls.Add(lblSchoolScoreBox);
            grpScoreBox.Controls.Add(lblNameScoreBox);
            grpScoreBox.Location = new Point(816, 27);
            grpScoreBox.Name = "grpScoreBox";
            grpScoreBox.Size = new Size(740, 465);
            grpScoreBox.TabIndex = 3;
            grpScoreBox.TabStop = false;
            grpScoreBox.Text = "Score Box";
            // 
            // lblActiveNotes
            // 
            lblActiveNotes.AutoSize = true;
            lblActiveNotes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveNotes.Location = new Point(133, 306);
            lblActiveNotes.Name = "lblActiveNotes";
            lblActiveNotes.Size = new Size(44, 32);
            lblActiveNotes.TabIndex = 17;
            lblActiveNotes.Text = "---";
            // 
            // lblActiveScore
            // 
            lblActiveScore.AutoSize = true;
            lblActiveScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveScore.Location = new Point(133, 228);
            lblActiveScore.Name = "lblActiveScore";
            lblActiveScore.Size = new Size(44, 32);
            lblActiveScore.TabIndex = 16;
            lblActiveScore.Text = "---";
            lblActiveScore.Click += lblActiveScore_Click;
            // 
            // lblActiveSchool
            // 
            lblActiveSchool.AutoSize = true;
            lblActiveSchool.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveSchool.Location = new Point(133, 143);
            lblActiveSchool.Name = "lblActiveSchool";
            lblActiveSchool.Size = new Size(44, 32);
            lblActiveSchool.TabIndex = 15;
            lblActiveSchool.Text = "---";
            // 
            // lblActiveName
            // 
            lblActiveName.AutoSize = true;
            lblActiveName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblActiveName.Location = new Point(128, 70);
            lblActiveName.Name = "lblActiveName";
            lblActiveName.Size = new Size(281, 32);
            lblActiveName.TabIndex = 14;
            lblActiveName.Text = "No Contestant Selected";
            // 
            // lblScoreBoxNotes
            // 
            lblScoreBoxNotes.AutoSize = true;
            lblScoreBoxNotes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreBoxNotes.Location = new Point(128, 320);
            lblScoreBoxNotes.Name = "lblScoreBoxNotes";
            lblScoreBoxNotes.Size = new Size(0, 21);
            lblScoreBoxNotes.TabIndex = 13;
            // 
            // lblScoreBoxScore
            // 
            lblScoreBoxScore.AutoSize = true;
            lblScoreBoxScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreBoxScore.Location = new Point(128, 231);
            lblScoreBoxScore.Name = "lblScoreBoxScore";
            lblScoreBoxScore.Size = new Size(0, 32);
            lblScoreBoxScore.TabIndex = 12;
            // 
            // lblScoreBoxSchool
            // 
            lblScoreBoxSchool.AutoSize = true;
            lblScoreBoxSchool.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreBoxSchool.Location = new Point(128, 157);
            lblScoreBoxSchool.Name = "lblScoreBoxSchool";
            lblScoreBoxSchool.Size = new Size(0, 30);
            lblScoreBoxSchool.TabIndex = 11;
            // 
            // lblScoreBoxName
            // 
            lblScoreBoxName.AutoSize = true;
            lblScoreBoxName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScoreBoxName.Location = new Point(128, 84);
            lblScoreBoxName.Name = "lblScoreBoxName";
            lblScoreBoxName.Size = new Size(0, 30);
            lblScoreBoxName.TabIndex = 10;
            // 
            // lblNotesScoreBox
            // 
            lblNotesScoreBox.AutoSize = true;
            lblNotesScoreBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotesScoreBox.Location = new Point(40, 306);
            lblNotesScoreBox.Name = "lblNotesScoreBox";
            lblNotesScoreBox.Size = new Size(88, 32);
            lblNotesScoreBox.TabIndex = 9;
            lblNotesScoreBox.Text = "Notes:";
            // 
            // lblScoreScoreBox
            // 
            lblScoreScoreBox.AutoSize = true;
            lblScoreScoreBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScoreScoreBox.Location = new Point(43, 228);
            lblScoreScoreBox.Name = "lblScoreScoreBox";
            lblScoreScoreBox.Size = new Size(84, 32);
            lblScoreScoreBox.TabIndex = 8;
            lblScoreScoreBox.Text = "Score:";
            // 
            // lblSchoolScoreBox
            // 
            lblSchoolScoreBox.AutoSize = true;
            lblSchoolScoreBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSchoolScoreBox.Location = new Point(31, 143);
            lblSchoolScoreBox.Name = "lblSchoolScoreBox";
            lblSchoolScoreBox.Size = new Size(97, 32);
            lblSchoolScoreBox.TabIndex = 6;
            lblSchoolScoreBox.Text = "School:";
            // 
            // lblNameScoreBox
            // 
            lblNameScoreBox.AutoSize = true;
            lblNameScoreBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameScoreBox.Location = new Point(39, 70);
            lblNameScoreBox.Name = "lblNameScoreBox";
            lblNameScoreBox.Size = new Size(88, 32);
            lblNameScoreBox.TabIndex = 4;
            lblNameScoreBox.Text = "Name:";
            // 
            // grpCompetitorEntry
            // 
            grpCompetitorEntry.BackColor = SystemColors.ActiveCaption;
            grpCompetitorEntry.Controls.Add(btnFind);
            grpCompetitorEntry.Controls.Add(txtSearch);
            grpCompetitorEntry.Controls.Add(lblSearch);
            grpCompetitorEntry.Controls.Add(btnRecordScore);
            grpCompetitorEntry.Controls.Add(btnRegister);
            grpCompetitorEntry.Controls.Add(lblNotes);
            grpCompetitorEntry.Controls.Add(lblScore);
            grpCompetitorEntry.Controls.Add(nudScore);
            grpCompetitorEntry.Controls.Add(lblSchool);
            grpCompetitorEntry.Controls.Add(txtNotes);
            grpCompetitorEntry.Controls.Add(lblName);
            grpCompetitorEntry.Controls.Add(txtSchool);
            grpCompetitorEntry.Controls.Add(txtName);
            grpCompetitorEntry.Location = new Point(12, 27);
            grpCompetitorEntry.Name = "grpCompetitorEntry";
            grpCompetitorEntry.Size = new Size(798, 465);
            grpCompetitorEntry.TabIndex = 4;
            grpCompetitorEntry.TabStop = false;
            grpCompetitorEntry.Text = "Competitor Entry";
            // 
            // btnFind
            // 
            btnFind.Location = new Point(577, 306);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(185, 23);
            btnFind.TabIndex = 13;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(99, 306);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(438, 23);
            txtSearch.TabIndex = 12;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(13, 299);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 30);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search:";
            // 
            // btnRecordScore
            // 
            btnRecordScore.Location = new Point(577, 169);
            btnRecordScore.Name = "btnRecordScore";
            btnRecordScore.Size = new Size(185, 42);
            btnRecordScore.TabIndex = 10;
            btnRecordScore.Text = "New Score";
            btnRecordScore.UseVisualStyleBackColor = true;
            btnRecordScore.Click += btnRecordScore_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(577, 51);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(185, 80);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register and Record Score";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotes.Location = new Point(95, 217);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(82, 32);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Notes:";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(99, 160);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(78, 32);
            lblScore.TabIndex = 7;
            lblScore.Text = "Score:";
            // 
            // nudScore
            // 
            nudScore.Location = new Point(183, 169);
            nudScore.Name = "nudScore";
            nudScore.Size = new Size(120, 23);
            nudScore.TabIndex = 6;
            // 
            // lblSchool
            // 
            lblSchool.AutoSize = true;
            lblSchool.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSchool.Location = new Point(86, 99);
            lblSchool.Name = "lblSchool";
            lblSchool.Size = new Size(91, 32);
            lblSchool.TabIndex = 5;
            lblSchool.Text = "School:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(183, 228);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(354, 23);
            txtNotes.TabIndex = 4;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(94, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 32);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // txtSchool
            // 
            txtSchool.Location = new Point(183, 108);
            txtSchool.Name = "txtSchool";
            txtSchool.Size = new Size(354, 23);
            txtSchool.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(354, 23);
            txtName.TabIndex = 0;
            // 
            // grpContestants
            // 
            grpContestants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpContestants.Controls.Add(dgvContestants);
            grpContestants.Location = new Point(12, 498);
            grpContestants.Name = "grpContestants";
            grpContestants.Size = new Size(798, 380);
            grpContestants.TabIndex = 5;
            grpContestants.TabStop = false;
            grpContestants.Text = "Contestants";
            // 
            // dgvContestants
            // 
            dgvContestants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvContestants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContestants.Columns.AddRange(new DataGridViewColumn[] { colID, colSchool, colName, colScore, colNotes });
            dgvContestants.Location = new Point(13, 22);
            dgvContestants.Name = "dgvContestants";
            dgvContestants.RowHeadersVisible = false;
            dgvContestants.Size = new Size(779, 352);
            dgvContestants.TabIndex = 7;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.Width = 43;
            // 
            // colSchool
            // 
            colSchool.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSchool.HeaderText = "School";
            colSchool.Name = "colSchool";
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.HeaderText = "Name";
            colName.Name = "colName";
            // 
            // colScore
            // 
            colScore.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colScore.HeaderText = "Score";
            colScore.Name = "colScore";
            // 
            // colNotes
            // 
            colNotes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            // 
            // btnFullScreen
            // 
            btnFullScreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFullScreen.BackgroundImage = (Image)resources.GetObject("btnFullScreen.BackgroundImage");
            btnFullScreen.BackgroundImageLayout = ImageLayout.Zoom;
            btnFullScreen.Location = new Point(816, 498);
            btnFullScreen.Name = "btnFullScreen";
            btnFullScreen.Size = new Size(740, 380);
            btnFullScreen.TabIndex = 6;
            btnFullScreen.UseVisualStyleBackColor = true;
            btnFullScreen.Click += btnFullScreen_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(2093, 890);
            Controls.Add(btnFullScreen);
            Controls.Add(grpContestants);
            Controls.Add(grpCompetitorEntry);
            Controls.Add(grpScoreBox);
            Controls.Add(grpLeaderBoard);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "WeldingScoreboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grpLeaderBoard.ResumeLayout(false);
            grpScoreBox.ResumeLayout(false);
            grpScoreBox.PerformLayout();
            grpCompetitorEntry.ResumeLayout(false);
            grpCompetitorEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudScore).EndInit();
            grpContestants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvContestants).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem fullScreenToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox grpLeaderBoard;
        private GroupBox grpScoreBox;
        private GroupBox grpCompetitorEntry;
        private GroupBox grpContestants;
        private TextBox txtSchool;
        private TextBox txtName;
        private Button btnFullScreen;
        private Label lblName;
        private Label lblSchool;
        private TextBox txtNotes;
        private Button btnRegister;
        private Label lblNotes;
        private Label lblScore;
        private NumericUpDown nudScore;
        private Button btnRecordScore;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnFind;
        private EventHandler textBox2_TextChanged;
        private EventHandler btnFullScreen_Click;
        private EventHandler label1_Click_1;
        private EventHandler label2_Click;
        private EventHandler label5_Click;
        private PopupEventHandler toolTipToggleFullscreen_Popup;
        private ToolTip toolTip1;
        private DataGridView dgvContestants;
        private Label lblNotesScoreBox;
        private Label lblScoreScoreBox;
        private Label lblSchoolScoreBox;
        private Label lblNameScoreBox;
        private Label lblScoreBoxSchool;
        private Label lblScoreBoxName;
        private Label lblScoreBoxNotes;
        private Label lblScoreBoxScore;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ListBox lstLeaderBoard;
        private Label lblActiveName;
        private Label lblActiveNotes;
        private Label lblActiveScore;
        private Label lblActiveSchool;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSchool;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colScore;
        private DataGridViewTextBoxColumn colNotes;
        private ToolStripMenuItem clearToolStripMenuItem;

        public EventHandler MainForm_Load { get; private set; }
    }
}
