using System.Text;

namespace UTF8_Converter
{
    public partial class mainForm : Form
    {
        private string filePath = "";

        public mainForm()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt;*.yml;*.json";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd.FileName))
                {
                    filePath = ofd.FileName;
                    label1.Text = "File selected.";
                }
                else
                {
                    label1.Text = "File was not found.";
                }
            }
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
            {
                label1.Text = "Converting...";

                try
                {

                    string[] lines = File.ReadAllLines(filePath);

                    File.WriteAllText(filePath, string.Empty);

                    using (StreamWriter sw = new StreamWriter(File.Open(filePath, FileMode.Create), Encoding.UTF8))
                    {
                        foreach (var line in lines)
                        {
                            sw.WriteLine(line);
                        }
                    }

                    label1.Text = "Finished.";
                }
                catch
                {
                    label1.Text = "Error occurred while converting.";
                }
            }
            else
            {
                label1.Text = "Please select file...";
            }
        }
    }
}