namespace Gwynwhyvaar.TextAdventure.UI
{
    partial class CreatePlayerForm
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
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            playerPortraitComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            playerNameTextBox = new TextBox();
            previewGroupBox = new GroupBox();
            fullProfileImage = new PictureBox();
            portraitImage = new PictureBox();
            plsyerDescriptionLabel = new Label();
            label3 = new Label();
            fullPlayerProfileComboBox = new ComboBox();
            groupBox1 = new GroupBox();
            playerBiographyTextBox = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            previewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fullProfileImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)portraitImage).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(906, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fullPlayerProfileComboBox);
            panel1.Controls.Add(previewGroupBox);
            panel1.Controls.Add(playerNameTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(playerPortraitComboBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 709);
            panel1.TabIndex = 1;
            // 
            // playerPortraitComboBox
            // 
            playerPortraitComboBox.FormattingEnabled = true;
            playerPortraitComboBox.Location = new Point(177, 58);
            playerPortraitComboBox.Name = "playerPortraitComboBox";
            playerPortraitComboBox.Size = new Size(259, 28);
            playerPortraitComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(61, 66);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Player Portrait";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(73, 32);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Player Name";
            // 
            // playerNameTextBox
            // 
            playerNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            playerNameTextBox.Location = new Point(177, 25);
            playerNameTextBox.Name = "playerNameTextBox";
            playerNameTextBox.Size = new Size(259, 27);
            playerNameTextBox.TabIndex = 3;
            // 
            // previewGroupBox
            // 
            previewGroupBox.Controls.Add(plsyerDescriptionLabel);
            previewGroupBox.Controls.Add(portraitImage);
            previewGroupBox.Controls.Add(fullProfileImage);
            previewGroupBox.Location = new Point(453, 19);
            previewGroupBox.Name = "previewGroupBox";
            previewGroupBox.Size = new Size(440, 663);
            previewGroupBox.TabIndex = 4;
            previewGroupBox.TabStop = false;
            previewGroupBox.Text = "Preview";
            // 
            // fullProfileImage
            // 
            fullProfileImage.BorderStyle = BorderStyle.FixedSingle;
            fullProfileImage.Location = new Point(6, 26);
            fullProfileImage.Name = "fullProfileImage";
            fullProfileImage.Size = new Size(410, 412);
            fullProfileImage.TabIndex = 0;
            fullProfileImage.TabStop = false;
            // 
            // portraitImage
            // 
            portraitImage.BorderStyle = BorderStyle.FixedSingle;
            portraitImage.Location = new Point(22, 299);
            portraitImage.Name = "portraitImage";
            portraitImage.Size = new Size(143, 121);
            portraitImage.TabIndex = 1;
            portraitImage.TabStop = false;
            // 
            // plsyerDescriptionLabel
            // 
            plsyerDescriptionLabel.AutoSize = true;
            plsyerDescriptionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            plsyerDescriptionLabel.Location = new Point(22, 459);
            plsyerDescriptionLabel.Name = "plsyerDescriptionLabel";
            plsyerDescriptionLabel.Size = new Size(0, 20);
            plsyerDescriptionLabel.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(40, 95);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 6;
            label3.Text = "Full Player Profile";
            // 
            // fullPlayerProfileComboBox
            // 
            fullPlayerProfileComboBox.FormattingEnabled = true;
            fullPlayerProfileComboBox.Location = new Point(177, 92);
            fullPlayerProfileComboBox.Name = "fullPlayerProfileComboBox";
            fullPlayerProfileComboBox.Size = new Size(259, 28);
            fullPlayerProfileComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(playerBiographyTextBox);
            groupBox1.Location = new Point(11, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 324);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Player Biography";
            // 
            // playerBiographyTextBox
            // 
            playerBiographyTextBox.BackColor = Color.LemonChiffon;
            playerBiographyTextBox.Dock = DockStyle.Fill;
            playerBiographyTextBox.Location = new Point(3, 23);
            playerBiographyTextBox.Multiline = true;
            playerBiographyTextBox.Name = "playerBiographyTextBox";
            playerBiographyTextBox.ScrollBars = ScrollBars.Both;
            playerBiographyTextBox.Size = new Size(419, 298);
            playerBiographyTextBox.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(14, 667);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreatePlayerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 734);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "CreatePlayerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Player Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            previewGroupBox.ResumeLayout(false);
            previewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fullProfileImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)portraitImage).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel1;
        private Label label1;
        private ComboBox playerPortraitComboBox;
        private TextBox playerNameTextBox;
        private Label label2;
        private GroupBox previewGroupBox;
        private PictureBox portraitImage;
        private PictureBox fullProfileImage;
        private GroupBox groupBox1;
        private TextBox playerBiographyTextBox;
        private Label label3;
        private ComboBox fullPlayerProfileComboBox;
        private Label plsyerDescriptionLabel;
        private Button button1;
    }
}