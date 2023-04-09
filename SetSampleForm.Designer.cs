namespace DropSimulator
{
    partial class SetSampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SampleLabel = new Label();
            SampleSizeTextBox = new TextBox();
            AcceptButton = new Button();
            SuspendLayout();
            // 
            // SampleLabel
            // 
            SampleLabel.AutoSize = true;
            SampleLabel.Location = new Point(12, 9);
            SampleLabel.Name = "SampleLabel";
            SampleLabel.Size = new Size(75, 15);
            SampleLabel.TabIndex = 0;
            SampleLabel.Text = "Sample Size :";
            // 
            // SampleSizeTextBox
            // 
            SampleSizeTextBox.Location = new Point(93, 6);
            SampleSizeTextBox.MaxLength = 5;
            SampleSizeTextBox.Name = "SampleSizeTextBox";
            SampleSizeTextBox.Size = new Size(100, 23);
            SampleSizeTextBox.TabIndex = 1;
            SampleSizeTextBox.TextChanged += SampleSizeTextBox_TextChanged;
            // 
            // AcceptButton
            // 
            AcceptButton.Location = new Point(199, 6);
            AcceptButton.Name = "AcceptButton";
            AcceptButton.Size = new Size(37, 23);
            AcceptButton.TabIndex = 2;
            AcceptButton.Text = "Set";
            AcceptButton.UseVisualStyleBackColor = true;
            AcceptButton.Click += AcceptButton_Click;
            // 
            // SetSampleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 37);
            Controls.Add(AcceptButton);
            Controls.Add(SampleSizeTextBox);
            Controls.Add(SampleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SetSampleForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Sample Size";
            Load += SetSampleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SampleLabel;
        private TextBox SampleSizeTextBox;
        private Button AcceptButton;
    }
}