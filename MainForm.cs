using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DropSimulator
{
    public partial class Form1 : Form
    {

        #region Variables
        public int SampleSize = 10;
        public List<DropInfo> DropInfoList = new List<DropInfo>();

        public RandomProvider Random = new RandomProvider();
        #endregion

        #region Setup Form
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar.Value = 0;
            SampleSizeLabel.Text = $"Sample Size : {SampleSize}";
        }
        #endregion

        #region Load File
        private void LoadDropFileButton_Click(object sender, EventArgs e)
        {
            LoadFile();
        }
        private void LoadFile()
        {
            InputTextBox.Clear();
            OutputTextBox.Clear();

            string Path;
            string drops;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            ofd.ShowDialog();

            if (ofd.FileName == string.Empty) return;

            Path = ofd.FileName;

            using (var sr = new StreamReader(Path))
            {
                drops = sr.ReadToEnd();
            }

            var lines = drops.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            ProgressBar.Maximum = lines.Length;

            foreach (var line in lines)
            {
                InputTextBox.Text += line + Environment.NewLine;
                DropInfo Drop = DropInfo.FromLine(line);
                if (Drop == null) continue;
                DropInfoList.Add(Drop);
                ProgressBar.Value++;
            }
        }
        #endregion

        #region Save File
        private void SaveOutputFileButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {

        }
        #endregion

        #region SampleSize
        private void SetSampleSizeButton_Click(object sender, EventArgs e)
        {
            OpenSampleSizeForm();
        }
        private void OpenSampleSizeForm()
        {
            Form SetSampleForm = new SetSampleForm() { SampleSize = SampleSize };
            SetSampleForm.Show();
        }
        public void SetSampleSize(int sampleSize)
        {
            SampleSize = sampleSize;
            SampleSizeLabel.Text = $"Sample Size : {SampleSize}";
        }
        #endregion

        #region Simulation
        private void SimulateButton_Click(object sender, EventArgs e)
        {
            BeginSimulation();
        }
        private void BeginSimulation()
        {
            ProgressBar.Value = 0;
            OutputTextBox.Clear();
            ProgressBar.Maximum = DropInfoList.Count * SampleSize;

            List<string> droppedItems = new List<string>();

            foreach (DropInfo drop in DropInfoList)
            {
                if (drop == null) continue;
                for (int i = 0; i < SampleSize; i++)
                {
                    if (Random.Next(drop.Chance) == 0)
                    {
                        droppedItems.Add(drop.Name);
                    }
                    ProgressBar.Value++;
                }
            }

            CountRepeatedValues(droppedItems);
        }
        #endregion

        void CountRepeatedValues(List<string> stringList)
        {
            var groupedStrings = stringList.GroupBy(s => s);

            foreach (var group in groupedStrings)
            {
                OutputTextBox.Text += (group.Key + "\t" + group.Count()) + Environment.NewLine;
            }
        }
    }
}