using CoreOSC;
using System.Configuration;
using static WindowsMediaController.MediaManager;

namespace VRChatify
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            Program.mediaManagement.GetMediaManager().OnAnySessionClosed += UpdateSourceButtons;
            Program.mediaManagement.GetMediaManager().OnAnySessionOpened += UpdateSourceButtons;
            InitializeComponent();
            UpdateSourceButtons(null);
        }

        private void ChatBoxMessage_TextChanged(object sender, EventArgs e)
        {
            Config.SetConfig("ChatBoxMessage", ChatBoxMessage.Text);
            Program.oscText = ChatBoxMessage.Text;
        }

        private void ManualSend_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Program.oscSender1!.Send(new OscMessage("/chatbox/input", Utils.ParsePlaceholders(Program.oscText), true, true));
                Program.oscSender2!.Send(new OscMessage("/chatbox/input", Utils.ParsePlaceholders(Program.oscText), true, true));
                Program.oscSender3!.Send(new OscMessage("/chatbox/input", Utils.ParsePlaceholders(Program.oscText), true, true));
            });

        }

        public static void CenterLabelHorizontally(Label label)
        {
            int newX = (label.Parent.Width - label.Width) / 2;
            label.Location = new Point(newX, label.Location.Y);
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            ChatBoxMessage.Text = Program.oscText;
        }

        private void UpdateSourceButtons(MediaSession? mediaSession)
        {
            var sessions = Program.mediaManagement.GetMediaManager().CurrentMediaSessions.Values.ToList();
            MediaSession session = Program.mediaManagement.GetCurrentSession()!;
            string sessionName = session == null ? "Unknown" : session.Id;
            if (InvokeRequired)
            {
                Invoke(new Action(() => SessionName.Text = Program.mediaManagement.GetCurrentSession()?.Id.Replace(".exe", "")));
                Invoke(new Action(() => SessionCount.Text = $"{sessions.IndexOf(session) + 1}/{sessions.Count}"));
            }
            else
            {
                SessionCount.Text = $"{sessions.IndexOf(session) + 1}/{sessions.Count}";
                SessionName.Text = sessionName.Replace(".exe", "");
            }
            CenterLabelHorizontally(SessionName);
            CenterLabelHorizontally(SessionCount);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (Program.mediaManagement!.GetMediaManager().CurrentMediaSessions.Count <= 1) return;
            Program.mediaManagement!.NextSession();
            UpdateSourceButtons(null);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (Program.mediaManagement!.GetMediaManager().CurrentMediaSessions.Count <= 1) return;
            Program.mediaManagement!.PreviousSession();
            UpdateSourceButtons(null);

        }
    }
}
