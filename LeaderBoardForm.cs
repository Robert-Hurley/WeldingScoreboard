using System.Text;

namespace WeldingScoreboard
{
    public partial class LeaderBoardForm : Form
    {
        public LeaderBoardForm(List<Contestant> contestants)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.Black;
            this.ForeColor = System.Drawing.Color.White;
            this.TopMost = true;

            Label lblFullScreenLeaderBoard = new Label();
            lblFullScreenLeaderBoard.Dock = DockStyle.Fill;
            lblFullScreenLeaderBoard.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            lblFullScreenLeaderBoard.BackColor = System.Drawing.Color.Black;
            lblFullScreenLeaderBoard.ForeColor = System.Drawing.Color.White;
            lblFullScreenLeaderBoard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            var sortedContestants = contestants
                .OrderByDescending(c => c.Score)
                .ThenBy(c => c.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sortedContestants.Count; i++)
            {
                var contestant = sortedContestants[i];
                sb.AppendLine($"{i + 1}. {contestant.Name} - {contestant.Score}");
            }

            lblFullScreenLeaderBoard.Text = sb.ToString();

            this.Controls.Add(lblFullScreenLeaderBoard);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
