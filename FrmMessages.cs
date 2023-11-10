using Newtonsoft.Json;

namespace VRChatify
{
    public partial class FrmMessages : Form
    {

        private System.Windows.Forms.Timer saveTimer;

        public FrmMessages()
        {
            InitializeComponent();
            saveTimer = new System.Windows.Forms.Timer();
            saveTimer.Interval = 1000;
            saveTimer.Tick += SaveTimer_Tick;
            LoadDataFromJsonFile(); // Load data from JSON on form load

            saveTimer.Start();
        }

        private void LoadDataFromJsonFile()
        {
            if (File.Exists("data.json"))
            {
                string jsonData = File.ReadAllText("data.json");
                Program.textBoxData = JsonConvert.DeserializeObject<Dictionary<int, string>>(jsonData);

                // Update the MessageCounter to match the count of loaded data
                MessageCounter.Value = Program.textBoxData.Count;

                // Update the text of existing text boxes based on the loaded data
                foreach (var kvp in Program.textBoxData)
                {
                    int key = kvp.Key;
                    string value = kvp.Value;

                    // Find the existing TextBox by its name and update its text
                    TextBox textBox = PnlMessages.Controls.Find($"textBox{key}", true).FirstOrDefault() as TextBox;
                    if (textBox != null)
                    {
                        textBox.Text = value;
                    }
                }
            }
        }


        private void MessageCounter_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            int newValue = (int)numericUpDown.Value;
            int previousValue = GetPreviousNumericValue();

            if (newValue > previousValue)
            {
                for (int i = previousValue + 1; i <= newValue; i++)
                {
                    AddTextBox(i, "");
                }
            }
            else if (newValue < previousValue)
            {
                for (int i = previousValue; i > newValue; i--)
                {
                    RemoveTextBox(i);
                }
            }

            SetPreviousNumericValue(newValue);
        }

        private int previousNumericValue = 0;

        private int GetPreviousNumericValue()
        {
            return previousNumericValue;
        }

        private void SetPreviousNumericValue(int value)
        {
            previousNumericValue = value;
        }


        private void AddTextBox(int number, string text)
        {
            TextBox textBox = new()
            {
                Text = text,
                Width = 194,
                Height = 23,
                Name = $"textBox{number}"
            };

            textBox.TextChanged += TextBox_TextChanged;

            PnlMessages.Controls.Add(textBox);
        }


        private void RemoveTextBox(int number)
        {
            Control controlToRemove = PnlMessages.Controls.Find($"textBox{number}", true).FirstOrDefault();
            if (controlToRemove != null)
            {
                PnlMessages.Controls.Remove(controlToRemove);
                controlToRemove.Dispose();

                if (Program.textBoxData.ContainsKey(number))
                {
                    Program.textBoxData.Remove(number);
                }

                SaveDataToJsonFile();
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (int.TryParse(textBox.Name.Substring(7), out int number))
                {
                    Program.textBoxData[number] = textBox.Text;
                    saveTimer.Stop();
                    saveTimer.Start();
                }
            }
        }



        private void SaveDataToJsonFile()
        {
            string jsonData = JsonConvert.SerializeObject(Program.textBoxData, Formatting.Indented);
            File.WriteAllText("data.json", jsonData);
        }

        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            SaveDataToJsonFile();
            saveTimer.Stop(); // Stop the timer after saving
        }

        private void PnlMessages_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
