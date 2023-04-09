using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropSimulator
{
    public partial class SetSampleForm : Form
    {
        public int SampleSize { get; set; }
        public SetSampleForm()
        {
            InitializeComponent();
        }

        private void SetSampleForm_Load(object sender, EventArgs e)
        {
            SampleSizeTextBox.Text = SampleSize.ToString();
        }

        private void SampleSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl != sender) return;

            int temp;

            if (!int.TryParse(ActiveControl.Text, out temp) || temp == 0 || temp >= 10000)
            {
                ActiveControl.BackColor = Color.Red;
                return;
            }
            ActiveControl.BackColor = SystemColors.Window;

            SampleSize = temp;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.SetSampleSize(SampleSize);
            this.Dispose();
        }
    }
}
