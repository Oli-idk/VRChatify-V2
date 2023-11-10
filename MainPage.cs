using VRChatify;

namespace VRChatify
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Dashboard";
            PnlFormLoader.Controls.Clear();
            FrmDashboard frmDashboard = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            PnlFormLoader.Controls.Add(frmDashboard);
            frmDashboard.Visible = true;

            LblUser.Text = Utils.version;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnDashboard.Height;
            PnlNav.Top = BtnDashboard.Top;
            PnlNav.Left = BtnDashboard.Left;
            BtnDashboard.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Dashboard";
            PnlFormLoader.Controls.Clear();
            FrmDashboard frmDashboard = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            PnlFormLoader.Controls.Add(frmDashboard);
            frmDashboard.Visible = true;

        }

        private void BtnDashboard_Leave(object sender, EventArgs e)
        {
            BtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMessages_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnMessages.Height;
            PnlNav.Top = BtnMessages.Top;
            PnlNav.Left = BtnMessages.Left;
            BtnMessages.BackColor = Color.FromArgb(46, 51, 73);

            LblTitle.Text = "Messages";
            PnlFormLoader.Controls.Clear();
            FrmMessages frmMessages = new()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            PnlFormLoader.Controls.Add(frmMessages);
            frmMessages.Visible = true;
        }

        private void BtnMessages_Leave(object sender, EventArgs e)
        {
            BtnMessages.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (ToggleButton.Checked)
            {
                Status.ForeColor = Color.Green;
                Status.Text = "Running";
            }
            else
            {
                Status.ForeColor = Color.Red;
                Status.Text = "Stopped";
            }
            Program.toggle = ToggleButton.Checked;
        }
    }
}