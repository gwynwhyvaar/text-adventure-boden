using System.ComponentModel;

namespace Gwynwhyvaar.TextAdventure.UI;

partial class Demo
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        applicationTabControl = new TabControl();
        homeTab = new TabPage();
        panel3 = new Panel();
        button1 = new Button();
        toolStrip1 = new ToolStrip();
        settingsTab = new TabPage();
        scenarioTab = new TabPage();
        panel1 = new Panel();
        toolStrip2 = new ToolStrip();
        panel2 = new Panel();
        nodeTreeView = new TreeView();
        scenarioCompnentTab = new TabPage();
        applicationTabControl.SuspendLayout();
        homeTab.SuspendLayout();
        panel3.SuspendLayout();
        scenarioTab.SuspendLayout();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // applicationTabControl
        // 
        applicationTabControl.Controls.Add(homeTab);
        applicationTabControl.Controls.Add(settingsTab);
        applicationTabControl.Controls.Add(scenarioTab);
        applicationTabControl.Controls.Add(scenarioCompnentTab);
        applicationTabControl.Dock = DockStyle.Fill;
        applicationTabControl.Location = new Point(0, 0);
        applicationTabControl.Multiline = true;
        applicationTabControl.Name = "applicationTabControl";
        applicationTabControl.SelectedIndex = 0;
        applicationTabControl.ShowToolTips = true;
        applicationTabControl.Size = new Size(1252, 1070);
        applicationTabControl.TabIndex = 0;
        // 
        // homeTab
        // 
        homeTab.BackColor = Color.Transparent;
        homeTab.BorderStyle = BorderStyle.FixedSingle;
        homeTab.Controls.Add(panel3);
        homeTab.Controls.Add(toolStrip1);
        homeTab.Location = new Point(4, 29);
        homeTab.Name = "homeTab";
        homeTab.Padding = new Padding(3);
        homeTab.Size = new Size(1244, 1037);
        homeTab.TabIndex = 0;
        homeTab.Text = "Start";
        homeTab.ToolTipText = "Start";
        // 
        // panel3
        // 
        panel3.Controls.Add(button1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(3, 28);
        panel3.Name = "panel3";
        panel3.Size = new Size(1236, 1004);
        panel3.TabIndex = 1;
        // 
        // button1
        // 
        button1.Location = new Point(13, 17);
        button1.Name = "button1";
        button1.Size = new Size(202, 29);
        button1.TabIndex = 0;
        button1.Text = "Create Player";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // toolStrip1
        // 
        toolStrip1.ImageScalingSize = new Size(20, 20);
        toolStrip1.Location = new Point(3, 3);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(1236, 25);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // settingsTab
        // 
        settingsTab.Location = new Point(4, 29);
        settingsTab.Name = "settingsTab";
        settingsTab.Padding = new Padding(3);
        settingsTab.Size = new Size(1001, 853);
        settingsTab.TabIndex = 1;
        settingsTab.Text = "Settings";
        settingsTab.UseVisualStyleBackColor = true;
        // 
        // scenarioTab
        // 
        scenarioTab.Controls.Add(panel1);
        scenarioTab.Location = new Point(4, 29);
        scenarioTab.Name = "scenarioTab";
        scenarioTab.Padding = new Padding(3);
        scenarioTab.Size = new Size(1001, 853);
        scenarioTab.TabIndex = 2;
        scenarioTab.Text = "Scenarios";
        scenarioTab.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = Color.Gainsboro;
        panel1.Controls.Add(toolStrip2);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(3, 3);
        panel1.Name = "panel1";
        panel1.Size = new Size(995, 847);
        panel1.TabIndex = 0;
        // 
        // toolStrip2
        // 
        toolStrip2.ImageScalingSize = new Size(20, 20);
        toolStrip2.Location = new Point(0, 0);
        toolStrip2.Name = "toolStrip2";
        toolStrip2.Size = new Size(995, 25);
        toolStrip2.TabIndex = 1;
        toolStrip2.Text = "toolStrip2";
        // 
        // panel2
        // 
        panel2.BackColor = Color.Gray;
        panel2.BorderStyle = BorderStyle.FixedSingle;
        panel2.Controls.Add(nodeTreeView);
        panel2.Location = new Point(5, 28);
        panel2.Name = "panel2";
        panel2.Size = new Size(516, 793);
        panel2.TabIndex = 0;
        // 
        // nodeTreeView
        // 
        nodeTreeView.Dock = DockStyle.Fill;
        nodeTreeView.Location = new Point(0, 0);
        nodeTreeView.Name = "nodeTreeView";
        nodeTreeView.Size = new Size(514, 791);
        nodeTreeView.TabIndex = 0;
        // 
        // scenarioCompnentTab
        // 
        scenarioCompnentTab.BorderStyle = BorderStyle.FixedSingle;
        scenarioCompnentTab.Location = new Point(4, 29);
        scenarioCompnentTab.Name = "scenarioCompnentTab";
        scenarioCompnentTab.Size = new Size(1001, 853);
        scenarioCompnentTab.TabIndex = 3;
        scenarioCompnentTab.Text = "Scenario Components";
        scenarioCompnentTab.UseVisualStyleBackColor = true;
        // 
        // Demo
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1252, 1070);
        Controls.Add(applicationTabControl);
        Name = "Demo";
        Opacity = 0.9D;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Demo Config UI";
        applicationTabControl.ResumeLayout(false);
        homeTab.ResumeLayout(false);
        homeTab.PerformLayout();
        panel3.ResumeLayout(false);
        scenarioTab.ResumeLayout(false);
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TreeView nodeTreeView;

    private System.Windows.Forms.Panel panel2;

    private System.Windows.Forms.Panel panel1;

    private System.Windows.Forms.TabPage homeTab;

    private System.Windows.Forms.TabPage scenarioTab;

    private System.Windows.Forms.TabControl applicationTabControl;
    private System.Windows.Forms.TabPage scenarioCompnentTab;
    private System.Windows.Forms.TabPage settingsTab;

    #endregion

    private Panel panel3;
    private ToolStrip toolStrip1;
    private ToolStrip toolStrip2;
    private Button button1;
}