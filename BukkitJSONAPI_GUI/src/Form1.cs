using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using Newtonsoft;
using CommonData;

using System.Xml;
using System.Globalization;

namespace BukkitJSONAPI_GUI
{
    public partial class Form1 : Form
    {
        string m_MethodsJSONFile = string.Empty;
        MethodsJSONFileStructure m_Methods;

        TextBox[] m_ArgTextboxes = new TextBox[6];
        Label[] m_ArgTypeLabels = new Label[6];
        TextBox[] m_ArgDescTextBoxes = new TextBox[6];

        string m_SettingsFile = "..\\settings.json";
        string m_UpdaterPath = "BukkitJSONAPI_Updater.exe";
        bool m_DoUpdate = true;

        public Form1( string[] _Args )
        {
            foreach (string _Arg in _Args)
            {
                if (_Arg == "noupdate")
                {
                    m_DoUpdate = false;
                    break;
                }
            }

            InitializeComponent();

            m_ArgTextboxes[0] = Arg0TextBox;
            m_ArgTextboxes[1] = Arg1TextBox;
            m_ArgTextboxes[2] = Arg2TextBox;
            m_ArgTextboxes[3] = Arg3TextBox;
            m_ArgTextboxes[4] = Arg4TextBox;
            m_ArgTextboxes[5] = Arg5TextBox;
            m_ArgTypeLabels[0] = ArgType0Label;
            m_ArgTypeLabels[1] = ArgType1Label;
            m_ArgTypeLabels[2] = ArgType2Label;
            m_ArgTypeLabels[3] = ArgType3Label;
            m_ArgTypeLabels[4] = ArgType4Label;
            m_ArgTypeLabels[5] = ArgType5Label;
            m_ArgDescTextBoxes[0] = Arg0DescTextBox;
            m_ArgDescTextBoxes[1] = Arg1DescTextBox;
            m_ArgDescTextBoxes[2] = Arg2DescTextBox;
            m_ArgDescTextBoxes[3] = Arg3DescTextBox;
            m_ArgDescTextBoxes[4] = Arg4DescTextBox;
            m_ArgDescTextBoxes[5] = Arg5DescTextBox;

            this.FormClosing += this.Form1_Closing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodsJSONListStructure SelectedItem = (MethodsJSONListStructure)MethodDropDown.SelectedItem;
            ResultTextBox.Clear();
            treeView1.Nodes.Clear();

            if (SelectedItem == null)
            {
                SetStatus("Invalid method name");
                return;                  
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "python";
            startInfo.Arguments =   "InteractWithServer.py " + 
                                    HostAddressTextBox.Text + " " + 
                                    HostPortTextBox.Text + " " +
                                    UsernameTextBox.Text + " " +
                                    PasswordTextBox.Text + " " +
                                    SaltTextBox.Text + " " + 
                                    SelectedItem.name;

            if (SelectedItem.args != null)
            {
                if (tabControl1.SelectedIndex == 0)
                {
                    for (int i = 0; i < SelectedItem.args.Length; ++i)
                    {
                        if (m_ArgTextboxes[i].Text != string.Empty)
                        {
                            startInfo.Arguments += " \"" + m_ArgTextboxes[i].Text + "\"";
                        }
                    }
                }
                else if (tabControl1.SelectedIndex == 1 && AdvancedArgumentsTextBox.Text != string.Empty)
                {
                    startInfo.Arguments += " " + AdvancedArgumentsTextBox.Text;
                }
            }

            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = HidePromptCheckBox.Checked;

            // TODO: MethodArgs.
            process.StartInfo = startInfo;
            process.Start();

            ResultTextBox.Clear();
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                SetStatus("RESULT: " + line);// do something with line.
                line = line.Replace("True", "true");
                line = line.Replace("False", "false");
                line = line.Replace("None", "null");

                if (line.Length > 0)
                {
                    if (line[0] == '[') line = line.Remove(0, 1);
                    if (line[line.Length - 1] == ']') line = line.Remove(line.Length - 1, 1);

                    //                 Type CSharpType = SelectedItem.cSharpType;
                    //                 if (CSharpType != null)
                    //                 {
                    //                     
                    //                     //object obj = Newtonsoft.Json.JsonConvert.DeserializeObject(line, CSharpType);
                    //                     //line = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
                    //                 }

                    if (line[0] == '[' || line[0] == '{')
                    {
                        // Construct XML treeview.
                        try
                        {
                            treeView1.Nodes.Clear();

                            // SECTION 1. Create a DOM Document and load the XML data into it.
                            XmlDocument dom = Newtonsoft.Json.JsonConvert.DeserializeXmlNode(line, "Root");

                            // SECTION 2. Initialize the TreeView control.
                            treeView1.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                            TreeNode tNode = new TreeNode();
                            tNode = treeView1.Nodes[0];

                            // SECTION 3. Populate the TreeView with the DOM nodes.
                            AddNode(dom.DocumentElement, tNode);
                            treeView1.CollapseAll();
                            if (treeView1.Nodes.Count > 0)
                            {
                                treeView1.Nodes[0].Expand();
                            }
                            treeView1.Sort();
                        }
                        catch (XmlException xmlEx)
                        {
                            MessageBox.Show(xmlEx.Message);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                ResultTextBox.Text += line + "\r\n";
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }


        private void MethodDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUIElementsForMethodSelection();
        }

        private void UpdateUIElementsForMethodSelection()
        {
            MethodsJSONListStructure SelectedItem = (MethodsJSONListStructure)MethodDropDown.SelectedItem;
            MethodDescription.Text = (SelectedItem).desc;

            if (SelectedItem.args != null)
            {
                for (int i = 0; i < m_ArgTextboxes.Length && i < SelectedItem.args.Length; ++i)
                {
                    m_ArgTextboxes[i].Enabled = true;
                    m_ArgTextboxes[i].Clear();
                    m_ArgTypeLabels[i].Text = SelectedItem.args[i][0];
                    m_ArgDescTextBoxes[i].Text = SelectedItem.args[i][1];
                }
                if (SelectedItem.args.Length < m_ArgTextboxes.Length)
                {
                    for (int i = m_ArgTextboxes.Length - 1; i > SelectedItem.args.Length - 1; --i)
                    {
                        m_ArgTextboxes[i].Enabled = false;
                        m_ArgTypeLabels[i].Text = "type";
                        m_ArgDescTextBoxes[i].Clear();
                    }
                }
            }
            else
            {
                for (int i = 0; i < m_ArgTextboxes.Length; ++i)
                {
                    m_ArgTextboxes[i].Enabled = false;
                    m_ArgTextboxes[i].Clear();
                    m_ArgTypeLabels[i].Text = "type";
                    m_ArgDescTextBoxes[i].Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReloadMethodsDotJSONFile();
        }

        private void ReloadMethodsDotJSONFile()
        {
            try
            {
                m_MethodsJSONFile = File.ReadAllText("..\\methods.json");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                SetStatus("Could not find methods.json file");
                return;
            }
            if (!TryDeserializeMethodsJSONString())
            {
                SetStatus("Attempting to fix methods.json string (Physical file will remain intact)...");
                TryFixMethodsJSONString();
                if (!TryDeserializeMethodsJSONString())
                {
                    return;
                }
            }
            RepopulateMethodDropdown();
            SetStatus("Loaded methods.json file.");
        }

        private bool TryDeserializeMethodsJSONString()
        {
            try
            {
                m_Methods = Newtonsoft.Json.JsonConvert.DeserializeObject<MethodsJSONFileStructure>(m_MethodsJSONFile);

//                 foreach (MethodsJSONListStructure data in m_Methods.methods)
//                 {
//                     Type T = Type.GetType(data.name);
//                     if (T != null)
//                     {
//                         data.cSharpType = T;
//                     }
//                 }
                
            }
            catch (Newtonsoft.Json.JsonSerializationException ex)
            {
                SetStatus("An exception occured while deserializing: " + ex.Message);
                return false;
            }
            return true;
        }

        private void TryFixMethodsJSONString()
        {
            // This fix exists because there is ONE line (at the time of writing) of text in methods.json that does not conform to the rest of the file format.
            // The fix is easy though, and can be performed manually if desired. However, this code fixes the internal string (not the physical file), so that
            // it can be used in the program.
            m_MethodsJSONFile = m_MethodsJSONFile.Replace(  "\"Returns true if player one was successfully teleported. False if one or more players is offline.\",",
                                                            "[\"boolean\", \"Returns true if player one was successfully teleported. False if one or more players is offline.\"],");
        }

        private void RepopulateMethodDropdown()
        {
            MethodDropDown.DataSource = m_Methods.methods;
            MethodDropDown.DisplayMember = "name";
            return;
//             MethodDropDown.Items.Clear();
//             foreach (MethodsJSONListStructure data in m_Methods.methods)
//             {
//                 MethodDropDown.Items.Add(data);
//             }
        }

        private void HostAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            SettingsObject settings = new SettingsObject();
            settings.hostaddress = HostAddressTextBox.Text;
            settings.hostport = System.Convert.ToInt32(HostPortTextBox.Text);
            settings.username = UsernameTextBox.Text;
            settings.password = PasswordTextBox.Text;
            settings.salt = SaltTextBox.Text;
            settings.hidePrompt = HidePromptCheckBox.Checked;
            File.WriteAllText(m_SettingsFile, SerializeSettings(settings));
        }

        private void LoadSettings()
        {
            string FileContent = File.ReadAllText(m_SettingsFile);
            SettingsObject settings = DeserializeSettings(FileContent);
            if (settings != null)
            {
                HostAddressTextBox.Text = settings.hostaddress;
                HostPortTextBox.Text = settings.hostport.ToString();
                UsernameTextBox.Text = settings.username;
                PasswordTextBox.Text = settings.password;
                SaltTextBox.Text = settings.salt;
                HidePromptCheckBox.Checked = settings.hidePrompt;
            }
        }

        private string SerializeSettings( SettingsObject _Settings )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(_Settings, Newtonsoft.Json.Formatting.Indented);
        }

        private SettingsObject DeserializeSettings( string _Serialized )
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SettingsObject>(_Serialized);
        }

        private void SetStatus( string _Status )
        {
            Console.Write(_Status + "\r\n");
            StatusLabel.Text = _Status;
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void LoadUpdatesDotJSONFile()
        {
            string updatesFile = File.ReadAllText("..\\updates.json");
            if (updatesFile != null && updatesFile != string.Empty)
            {
                UpdatesObject updates = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdatesObject>(updatesFile);
                this.Text += " v" + updates.version.ToString("0.0####", CultureInfo.InvariantCulture);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (m_DoUpdate)
            {
                // Search for updater application.
                if (File.Exists(m_UpdaterPath))
                {
                    // Run updater application.
                    Process UpdaterProcess = System.Diagnostics.Process.Start(m_UpdaterPath);

                    // Terminate this application. (Updater will launch with 'noupdate' command line flag)
                    this.Close();
                }
            }

            LoadSettings();

            LoadUpdatesDotJSONFile();

            ReloadMethodsDotJSONFile();

            UpdateUIElementsForMethodSelection();
        }

    }
}
