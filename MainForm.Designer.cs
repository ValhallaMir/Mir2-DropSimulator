namespace DropSimulator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            InputTextBox = new TextBox();
            panel1 = new Panel();
            BottomStrip = new StatusStrip();
            SampleSizeLabel = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            SelectedFileLabel = new ToolStripStatusLabel();
            MainSplitContainer = new SplitContainer();
            OutputTextBox = new TextBox();
            TopStrip = new MenuStrip();
            ControlsButton = new ToolStripMenuItem();
            LoadDropFileButton = new ToolStripMenuItem();
            SaveOutputFileButton = new ToolStripMenuItem();
            SetSampleSizeButton = new ToolStripMenuItem();
            SimulateButton = new ToolStripMenuItem();
            panel1.SuspendLayout();
            BottomStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).BeginInit();
            MainSplitContainer.Panel1.SuspendLayout();
            MainSplitContainer.Panel2.SuspendLayout();
            MainSplitContainer.SuspendLayout();
            TopStrip.SuspendLayout();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Dock = DockStyle.Top;
            InputTextBox.Location = new Point(0, 0);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.ScrollBars = ScrollBars.Vertical;
            InputTextBox.Size = new Size(459, 364);
            InputTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(BottomStrip);
            panel1.Controls.Add(MainSplitContainer);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 386);
            panel1.TabIndex = 1;
            // 
            // BottomStrip
            // 
            BottomStrip.Items.AddRange(new ToolStripItem[] { SampleSizeLabel, toolStripStatusLabel2, SelectedFileLabel });
            BottomStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            BottomStrip.Location = new Point(0, 364);
            BottomStrip.Name = "BottomStrip";
            BottomStrip.Size = new Size(965, 22);
            BottomStrip.SizingGrip = false;
            BottomStrip.TabIndex = 2;
            BottomStrip.Text = "statusStrip1";
            // 
            // SampleSizeLabel
            // 
            SampleSizeLabel.Name = "SampleSizeLabel";
            SampleSizeLabel.Size = new Size(102, 17);
            SampleSizeLabel.Text = "Sample Size : 1000";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(10, 17);
            toolStripStatusLabel2.Text = "|";
            // 
            // SelectedFileLabel
            // 
            SelectedFileLabel.Name = "SelectedFileLabel";
            SelectedFileLabel.Size = new Size(78, 17);
            SelectedFileLabel.Text = "Selected File :";
            // 
            // MainSplitContainer
            // 
            MainSplitContainer.Dock = DockStyle.Fill;
            MainSplitContainer.IsSplitterFixed = true;
            MainSplitContainer.Location = new Point(0, 0);
            MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            MainSplitContainer.Panel1.Controls.Add(InputTextBox);
            // 
            // MainSplitContainer.Panel2
            // 
            MainSplitContainer.Panel2.Controls.Add(OutputTextBox);
            MainSplitContainer.Size = new Size(965, 386);
            MainSplitContainer.SplitterDistance = 459;
            MainSplitContainer.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Dock = DockStyle.Top;
            OutputTextBox.Location = new Point(0, 0);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.ScrollBars = ScrollBars.Vertical;
            OutputTextBox.Size = new Size(502, 364);
            OutputTextBox.TabIndex = 1;
            // 
            // TopStrip
            // 
            TopStrip.Items.AddRange(new ToolStripItem[] { ControlsButton, SimulateButton });
            TopStrip.Location = new Point(0, 0);
            TopStrip.Name = "TopStrip";
            TopStrip.Size = new Size(965, 24);
            TopStrip.TabIndex = 2;
            TopStrip.Text = "menuStrip1";
            // 
            // ControlsButton
            // 
            ControlsButton.DropDownItems.AddRange(new ToolStripItem[] { LoadDropFileButton, SaveOutputFileButton, SetSampleSizeButton });
            ControlsButton.Name = "ControlsButton";
            ControlsButton.Size = new Size(64, 20);
            ControlsButton.Text = "Controls";
            // 
            // LoadDropFileButton
            // 
            LoadDropFileButton.Name = "LoadDropFileButton";
            LoadDropFileButton.Size = new Size(160, 22);
            LoadDropFileButton.Text = "Load Drop File";
            LoadDropFileButton.Click += LoadDropFileButton_Click;
            // 
            // SaveOutputFileButton
            // 
            SaveOutputFileButton.Name = "SaveOutputFileButton";
            SaveOutputFileButton.Size = new Size(160, 22);
            SaveOutputFileButton.Text = "Save Output File";
            SaveOutputFileButton.Click += SaveOutputFileButton_Click;
            // 
            // SetSampleSizeButton
            // 
            SetSampleSizeButton.Name = "SetSampleSizeButton";
            SetSampleSizeButton.Size = new Size(160, 22);
            SetSampleSizeButton.Text = "Set Sample Size";
            SetSampleSizeButton.Click += SetSampleSizeButton_Click;
            // 
            // SimulateButton
            // 
            SimulateButton.Name = "SimulateButton";
            SimulateButton.Size = new Size(65, 20);
            SimulateButton.Text = "Simulate";
            SimulateButton.Click += SimulateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 410);
            Controls.Add(panel1);
            Controls.Add(TopStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = TopStrip;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crystal Drop Simulator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            BottomStrip.ResumeLayout(false);
            BottomStrip.PerformLayout();
            MainSplitContainer.Panel1.ResumeLayout(false);
            MainSplitContainer.Panel1.PerformLayout();
            MainSplitContainer.Panel2.ResumeLayout(false);
            MainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainSplitContainer).EndInit();
            MainSplitContainer.ResumeLayout(false);
            TopStrip.ResumeLayout(false);
            TopStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Panel panel1;
        private MenuStrip TopStrip;
        private ToolStripMenuItem ControlsButton;
        private ToolStripMenuItem LoadDropFileButton;
        private ToolStripMenuItem SaveOutputFileButton;
        private ToolStripMenuItem SetSampleSizeButton;
        private ToolStripMenuItem SimulateButton;
        private SplitContainer MainSplitContainer;
        private TextBox OutputTextBox;
        private StatusStrip BottomStrip;
        private ToolStripStatusLabel SelectedFileLabel;
        private ToolStripStatusLabel SampleSizeLabel;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}