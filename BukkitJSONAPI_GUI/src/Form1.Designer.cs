namespace BukkitJSONAPI_GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.MethodDropDown = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.HostAddressTextBox = new System.Windows.Forms.TextBox();
            this.HostPortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaltTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MethodDescription = new System.Windows.Forms.TextBox();
            this.Arg0TextBox = new System.Windows.Forms.TextBox();
            this.Arg1TextBox = new System.Windows.Forms.TextBox();
            this.Arg2TextBox = new System.Windows.Forms.TextBox();
            this.Arg3TextBox = new System.Windows.Forms.TextBox();
            this.Arg4TextBox = new System.Windows.Forms.TextBox();
            this.Arg5TextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Arg5DescTextBox = new System.Windows.Forms.TextBox();
            this.Arg4DescTextBox = new System.Windows.Forms.TextBox();
            this.Arg3DescTextBox = new System.Windows.Forms.TextBox();
            this.Arg2DescTextBox = new System.Windows.Forms.TextBox();
            this.Arg1DescTextBox = new System.Windows.Forms.TextBox();
            this.Arg0DescTextBox = new System.Windows.Forms.TextBox();
            this.ArgType5Label = new System.Windows.Forms.Label();
            this.ArgType4Label = new System.Windows.Forms.Label();
            this.ArgType3Label = new System.Windows.Forms.Label();
            this.ArgType2Label = new System.Windows.Forms.Label();
            this.ArgType1Label = new System.Windows.Forms.Label();
            this.ArgType0Label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AdvancedArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TreeViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.HidePromptCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TreeViewContextMenuStrip.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 114);
            this.button1.TabIndex = 13;
            this.button1.Text = "Run Command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MethodDropDown
            // 
            this.MethodDropDown.FormattingEnabled = true;
            this.MethodDropDown.Location = new System.Drawing.Point(6, 221);
            this.MethodDropDown.Name = "MethodDropDown";
            this.MethodDropDown.Size = new System.Drawing.Size(265, 24);
            this.MethodDropDown.Sorted = true;
            this.MethodDropDown.TabIndex = 5;
            this.MethodDropDown.SelectedIndexChanged += new System.EventHandler(this.MethodDropDown_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reload methods.json";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HostAddressTextBox
            // 
            this.HostAddressTextBox.Location = new System.Drawing.Point(78, 35);
            this.HostAddressTextBox.Name = "HostAddressTextBox";
            this.HostAddressTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HostAddressTextBox.Size = new System.Drawing.Size(94, 22);
            this.HostAddressTextBox.TabIndex = 0;
            this.HostAddressTextBox.Text = "127.0.0.1";
            this.HostAddressTextBox.TextChanged += new System.EventHandler(this.HostAddressTextBox_TextChanged);
            // 
            // HostPortTextBox
            // 
            this.HostPortTextBox.Location = new System.Drawing.Point(78, 63);
            this.HostPortTextBox.Name = "HostPortTextBox";
            this.HostPortTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HostPortTextBox.Size = new System.Drawing.Size(94, 22);
            this.HostPortTextBox.TabIndex = 1;
            this.HostPortTextBox.Text = "1337";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SaltTextBox);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.UsernameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HostPortTextBox);
            this.groupBox1.Controls.Add(this.HostAddressTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server JSONAPI Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Salt:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Username:";
            // 
            // SaltTextBox
            // 
            this.SaltTextBox.Location = new System.Drawing.Point(271, 91);
            this.SaltTextBox.Name = "SaltTextBox";
            this.SaltTextBox.Size = new System.Drawing.Size(278, 22);
            this.SaltTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(271, 63);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(168, 22);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(271, 33);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(168, 22);
            this.UsernameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address:";
            // 
            // MethodDescription
            // 
            this.MethodDescription.Enabled = false;
            this.MethodDescription.Location = new System.Drawing.Point(6, 251);
            this.MethodDescription.Multiline = true;
            this.MethodDescription.Name = "MethodDescription";
            this.MethodDescription.ReadOnly = true;
            this.MethodDescription.Size = new System.Drawing.Size(265, 163);
            this.MethodDescription.TabIndex = 8;
            // 
            // Arg0TextBox
            // 
            this.Arg0TextBox.Location = new System.Drawing.Point(6, 15);
            this.Arg0TextBox.Name = "Arg0TextBox";
            this.Arg0TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg0TextBox.TabIndex = 6;
            // 
            // Arg1TextBox
            // 
            this.Arg1TextBox.Location = new System.Drawing.Point(6, 45);
            this.Arg1TextBox.Name = "Arg1TextBox";
            this.Arg1TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg1TextBox.TabIndex = 7;
            // 
            // Arg2TextBox
            // 
            this.Arg2TextBox.Location = new System.Drawing.Point(6, 73);
            this.Arg2TextBox.Name = "Arg2TextBox";
            this.Arg2TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg2TextBox.TabIndex = 8;
            // 
            // Arg3TextBox
            // 
            this.Arg3TextBox.Location = new System.Drawing.Point(6, 101);
            this.Arg3TextBox.Name = "Arg3TextBox";
            this.Arg3TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg3TextBox.TabIndex = 9;
            // 
            // Arg4TextBox
            // 
            this.Arg4TextBox.Location = new System.Drawing.Point(6, 129);
            this.Arg4TextBox.Name = "Arg4TextBox";
            this.Arg4TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg4TextBox.TabIndex = 10;
            // 
            // Arg5TextBox
            // 
            this.Arg5TextBox.Location = new System.Drawing.Point(6, 157);
            this.Arg5TextBox.Name = "Arg5TextBox";
            this.Arg5TextBox.Size = new System.Drawing.Size(102, 22);
            this.Arg5TextBox.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(277, 181);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 233);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Arg5DescTextBox);
            this.tabPage1.Controls.Add(this.Arg4DescTextBox);
            this.tabPage1.Controls.Add(this.Arg3DescTextBox);
            this.tabPage1.Controls.Add(this.Arg2DescTextBox);
            this.tabPage1.Controls.Add(this.Arg1DescTextBox);
            this.tabPage1.Controls.Add(this.Arg0DescTextBox);
            this.tabPage1.Controls.Add(this.ArgType5Label);
            this.tabPage1.Controls.Add(this.ArgType4Label);
            this.tabPage1.Controls.Add(this.ArgType3Label);
            this.tabPage1.Controls.Add(this.ArgType2Label);
            this.tabPage1.Controls.Add(this.ArgType1Label);
            this.tabPage1.Controls.Add(this.ArgType0Label);
            this.tabPage1.Controls.Add(this.Arg0TextBox);
            this.tabPage1.Controls.Add(this.Arg5TextBox);
            this.tabPage1.Controls.Add(this.Arg4TextBox);
            this.tabPage1.Controls.Add(this.Arg1TextBox);
            this.tabPage1.Controls.Add(this.Arg3TextBox);
            this.tabPage1.Controls.Add(this.Arg2TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Arg5DescTextBox
            // 
            this.Arg5DescTextBox.Enabled = false;
            this.Arg5DescTextBox.Location = new System.Drawing.Point(192, 157);
            this.Arg5DescTextBox.Multiline = true;
            this.Arg5DescTextBox.Name = "Arg5DescTextBox";
            this.Arg5DescTextBox.ReadOnly = true;
            this.Arg5DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg5DescTextBox.TabIndex = 26;
            // 
            // Arg4DescTextBox
            // 
            this.Arg4DescTextBox.Enabled = false;
            this.Arg4DescTextBox.Location = new System.Drawing.Point(192, 129);
            this.Arg4DescTextBox.Multiline = true;
            this.Arg4DescTextBox.Name = "Arg4DescTextBox";
            this.Arg4DescTextBox.ReadOnly = true;
            this.Arg4DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg4DescTextBox.TabIndex = 25;
            // 
            // Arg3DescTextBox
            // 
            this.Arg3DescTextBox.Enabled = false;
            this.Arg3DescTextBox.Location = new System.Drawing.Point(192, 101);
            this.Arg3DescTextBox.Multiline = true;
            this.Arg3DescTextBox.Name = "Arg3DescTextBox";
            this.Arg3DescTextBox.ReadOnly = true;
            this.Arg3DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg3DescTextBox.TabIndex = 24;
            // 
            // Arg2DescTextBox
            // 
            this.Arg2DescTextBox.Enabled = false;
            this.Arg2DescTextBox.Location = new System.Drawing.Point(192, 73);
            this.Arg2DescTextBox.Multiline = true;
            this.Arg2DescTextBox.Name = "Arg2DescTextBox";
            this.Arg2DescTextBox.ReadOnly = true;
            this.Arg2DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg2DescTextBox.TabIndex = 23;
            // 
            // Arg1DescTextBox
            // 
            this.Arg1DescTextBox.Enabled = false;
            this.Arg1DescTextBox.Location = new System.Drawing.Point(192, 43);
            this.Arg1DescTextBox.Multiline = true;
            this.Arg1DescTextBox.Name = "Arg1DescTextBox";
            this.Arg1DescTextBox.ReadOnly = true;
            this.Arg1DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg1DescTextBox.TabIndex = 22;
            // 
            // Arg0DescTextBox
            // 
            this.Arg0DescTextBox.Enabled = false;
            this.Arg0DescTextBox.Location = new System.Drawing.Point(192, 15);
            this.Arg0DescTextBox.Multiline = true;
            this.Arg0DescTextBox.Name = "Arg0DescTextBox";
            this.Arg0DescTextBox.ReadOnly = true;
            this.Arg0DescTextBox.Size = new System.Drawing.Size(606, 22);
            this.Arg0DescTextBox.TabIndex = 14;
            // 
            // ArgType5Label
            // 
            this.ArgType5Label.AutoSize = true;
            this.ArgType5Label.Location = new System.Drawing.Point(114, 160);
            this.ArgType5Label.Name = "ArgType5Label";
            this.ArgType5Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType5Label.TabIndex = 21;
            this.ArgType5Label.Text = "type";
            // 
            // ArgType4Label
            // 
            this.ArgType4Label.AutoSize = true;
            this.ArgType4Label.Location = new System.Drawing.Point(114, 132);
            this.ArgType4Label.Name = "ArgType4Label";
            this.ArgType4Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType4Label.TabIndex = 20;
            this.ArgType4Label.Text = "type";
            // 
            // ArgType3Label
            // 
            this.ArgType3Label.AutoSize = true;
            this.ArgType3Label.Location = new System.Drawing.Point(114, 104);
            this.ArgType3Label.Name = "ArgType3Label";
            this.ArgType3Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType3Label.TabIndex = 19;
            this.ArgType3Label.Text = "type";
            // 
            // ArgType2Label
            // 
            this.ArgType2Label.AutoSize = true;
            this.ArgType2Label.Location = new System.Drawing.Point(114, 76);
            this.ArgType2Label.Name = "ArgType2Label";
            this.ArgType2Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType2Label.TabIndex = 18;
            this.ArgType2Label.Text = "type";
            // 
            // ArgType1Label
            // 
            this.ArgType1Label.AutoSize = true;
            this.ArgType1Label.Location = new System.Drawing.Point(114, 48);
            this.ArgType1Label.Name = "ArgType1Label";
            this.ArgType1Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType1Label.TabIndex = 17;
            this.ArgType1Label.Text = "type";
            // 
            // ArgType0Label
            // 
            this.ArgType0Label.AutoSize = true;
            this.ArgType0Label.Location = new System.Drawing.Point(114, 18);
            this.ArgType0Label.Name = "ArgType0Label";
            this.ArgType0Label.Size = new System.Drawing.Size(35, 17);
            this.ArgType0Label.TabIndex = 16;
            this.ArgType0Label.Text = "type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AdvancedArgumentsTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AdvancedArgumentsTextBox
            // 
            this.AdvancedArgumentsTextBox.Location = new System.Drawing.Point(6, 15);
            this.AdvancedArgumentsTextBox.Name = "AdvancedArgumentsTextBox";
            this.AdvancedArgumentsTextBox.Size = new System.Drawing.Size(650, 22);
            this.AdvancedArgumentsTextBox.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(0, 0);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(350, 159);
            this.ResultTextBox.TabIndex = 15;
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.TreeViewContextMenuStrip;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(350, 159);
            this.treeView1.TabIndex = 16;
            // 
            // TreeViewContextMenuStrip
            // 
            this.TreeViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collapseAllToolStripMenuItem,
            this.expandAllToolStripMenuItem});
            this.TreeViewContextMenuStrip.Name = "TreeViewContextMenuStrip";
            this.TreeViewContextMenuStrip.Size = new System.Drawing.Size(158, 52);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(728, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(361, 188);
            this.tabControl2.TabIndex = 17;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ResultTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(353, 159);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Text";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(353, 159);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "JSON";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // HidePromptCheckBox
            // 
            this.HidePromptCheckBox.AutoSize = true;
            this.HidePromptCheckBox.Location = new System.Drawing.Point(567, 154);
            this.HidePromptCheckBox.Name = "HidePromptCheckBox";
            this.HidePromptCheckBox.Size = new System.Drawing.Size(108, 21);
            this.HidePromptCheckBox.TabIndex = 18;
            this.HidePromptCheckBox.Text = "Hide Prompt";
            this.HidePromptCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 444);
            this.Controls.Add(this.HidePromptCheckBox);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.MethodDescription);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MethodDropDown);
            this.Name = "Form1";
            this.Text = "BukkitJSONAPI GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TreeViewContextMenuStrip.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox MethodDropDown;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox HostAddressTextBox;
        private System.Windows.Forms.TextBox HostPortTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox SaltTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MethodDescription;
        private System.Windows.Forms.TextBox Arg0TextBox;
        private System.Windows.Forms.TextBox Arg1TextBox;
        private System.Windows.Forms.TextBox Arg2TextBox;
        private System.Windows.Forms.TextBox Arg3TextBox;
        private System.Windows.Forms.TextBox Arg4TextBox;
        private System.Windows.Forms.TextBox Arg5TextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label ArgType5Label;
        private System.Windows.Forms.Label ArgType4Label;
        private System.Windows.Forms.Label ArgType3Label;
        private System.Windows.Forms.Label ArgType2Label;
        private System.Windows.Forms.Label ArgType1Label;
        private System.Windows.Forms.Label ArgType0Label;
        private System.Windows.Forms.TextBox Arg0DescTextBox;
        private System.Windows.Forms.TextBox Arg1DescTextBox;
        private System.Windows.Forms.TextBox Arg5DescTextBox;
        private System.Windows.Forms.TextBox Arg4DescTextBox;
        private System.Windows.Forms.TextBox Arg3DescTextBox;
        private System.Windows.Forms.TextBox Arg2DescTextBox;
        private System.Windows.Forms.TextBox AdvancedArgumentsTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox HidePromptCheckBox;
        private System.Windows.Forms.ContextMenuStrip TreeViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
    }
}

