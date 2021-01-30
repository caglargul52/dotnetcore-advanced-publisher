using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleImpersonation;

namespace DotnetCoreAdvancedPublisher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            m_labelVersion.Text = Application.ProductVersion;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var publishType = Properties.Settings.Default.PublishType;
            var targetPlatform = Properties.Settings.Default.TargetPlatform;
            var runtimeIdentifier = Properties.Settings.Default.RuntimeIdentifier;

            if(string.IsNullOrEmpty(targetPlatform))
            {
                m_comboBoxTargetPlatform.SelectedIndex = 0;
            }
            else
            {
                m_comboBoxTargetPlatform.Text = Properties.Settings.Default.TargetPlatform;
            }

            if (string.IsNullOrEmpty(publishType))
            {
                m_comboBoxPublishType.SelectedIndex = 0;
            }
            else
            {
                m_comboBoxPublishType.Text = Properties.Settings.Default.PublishType;
            }

            if (string.IsNullOrEmpty(runtimeIdentifier))
            {
                m_comboBoxRID.SelectedIndex = 0;
            }
            else
            {
                m_comboBoxRID.Text = Properties.Settings.Default.RuntimeIdentifier;
            }

            m_checkBoxSingleFile.Checked = Properties.Settings.Default.IsSingleFile;
            m_checkBoxReadyToRun.Checked = Properties.Settings.Default.IsReadyToRun;
            m_checkBoxPublishTrimmer.Checked = Properties.Settings.Default.IsPublishTrimmer;

            m_textBoxLocalFolder.Text = Properties.Settings.Default.OutputPath;
            m_textBoxProjectPath.Text = Properties.Settings.Default.ProjectPath;

            m_textBoxNetworkPath.Text = Properties.Settings.Default.NetworkPath;
            m_textBoxUsername.Text = Properties.Settings.Default.Username;
            m_textBoxPassword.Text = Properties.Settings.Default.Password;

            m_radioButtonLocal.Checked = Properties.Settings.Default.IsLocalPath;

            if (m_radioButtonLocal.Checked)
            {
                m_radioButtonLocal.PerformClick();
            }
            else
            {
                m_radioButtonRemote.PerformClick();
            }
        }

        private void m_buttonPublish_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_textBoxProjectPath.Text))
            {
                MessageBox.Show("Please fill in the path of the project path.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(m_fbdOutputFolder.SelectedPath.Contains(" "))
            {
                MessageBox.Show(@"There cannot be a space character in the folder path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rid = m_comboBoxRID.Text;
            string workingDirectory = Path.GetDirectoryName(m_textBoxProjectPath.Text);

            Task.Run(() =>
            {
                m_buttonPublish.Enabled = false;
                m_buttonPublish.Text = "Publishing...";
                try
                {
                    bool isSelfContained = m_comboBoxPublishType.Text == "Self-Contained" ? true : false;

                    bool isTrimmer = m_checkBoxPublishTrimmer.Enabled == false ? false : m_checkBoxPublishTrimmer.Checked;

                    string outputPath = string.Empty;

                    var prefix = "publish_" + Path.GetFileNameWithoutExtension(m_textBoxProjectPath.Text) + "_" + m_comboBoxRID.Text;

                    if(m_radioButtonRemote.Checked)
                    {
                        SmbContainer smb = new SmbContainer(m_textBoxNetworkPath.Text, m_textBoxUsername.Text, m_textBoxPassword.Text);

                        if(!smb.Connect())
                        {
                            MessageBox.Show("Could not connect to the network!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            m_buttonPublish.Enabled = true;
                            m_buttonPublish.Text = "Publish";
                            return;
                        }

                        outputPath = m_textBoxNetworkPath.Text + "\\" + prefix;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(m_textBoxLocalFolder.Text))
                        {
                            MessageBox.Show("Please fill in the path of the local folder path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            m_buttonPublish.Enabled = true;
                            m_buttonPublish.Text = "Publish";
                            return;
                        }

                        outputPath = m_textBoxLocalFolder.Text + "\\" + prefix;
                    }

                    Publisher.Execute(
                        workingDirectory,
                        isSelfContained,
                        m_checkBoxReadyToRun.Checked,
                        m_checkBoxSingleFile.Checked,
                        isTrimmer,
                        rid,
                        outputPath);

                    Properties.Settings.Default.ProjectPath = m_textBoxProjectPath.Text;
                    Properties.Settings.Default.OutputPath = m_textBoxLocalFolder.Text;
                    Properties.Settings.Default.PublishType = m_comboBoxPublishType.Text;
                    Properties.Settings.Default.TargetPlatform = m_comboBoxTargetPlatform.Text;
                    Properties.Settings.Default.RuntimeIdentifier = m_comboBoxRID.Text;
                    Properties.Settings.Default.IsReadyToRun = m_checkBoxReadyToRun.Checked;
                    Properties.Settings.Default.IsSingleFile = m_checkBoxSingleFile.Checked;
                    Properties.Settings.Default.IsPublishTrimmer = m_checkBoxPublishTrimmer.Checked;
                    Properties.Settings.Default.IsLocalPath = m_radioButtonLocal.Checked;
                    Properties.Settings.Default.NetworkPath = m_textBoxNetworkPath.Text;
                    Properties.Settings.Default.Username = m_textBoxUsername.Text;
                    Properties.Settings.Default.Password = m_textBoxPassword.Text;
                    Properties.Settings.Default.Save();

                    Thread.Sleep(2000);

                    MessageBox.Show("Publish successful.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                m_buttonPublish.Enabled = true;
                m_buttonPublish.Text = "Publish";

            });
        }

        private void m_comboBoxTargetPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_comboBoxRID.Items.Clear();

            if (m_comboBoxTargetPlatform.SelectedIndex == 0)
            {
                m_checkBoxReadyToRun.Enabled = true;

                m_comboBoxRID.Items.AddRange(RuntimeIdentifier.GetWindowsRids().ToArray());
            }

            else if (m_comboBoxTargetPlatform.SelectedIndex == 1)
            {
                m_checkBoxReadyToRun.Enabled = false;
                m_comboBoxRID.Items.AddRange(RuntimeIdentifier.GetLinuxRids().ToArray());
            }

            else if (m_comboBoxTargetPlatform.SelectedIndex == 2)
            {
                m_checkBoxReadyToRun.Enabled = false;

                m_comboBoxRID.Items.AddRange(RuntimeIdentifier.GetMacOsRids().ToArray());
            }

            m_comboBoxRID.SelectedIndex = 0;
        }

        private void m_textBoxProjectPath_Click(object sender, EventArgs e)
        {
            m_ofdSelectProject.Filter = @"CSPROJ File (*.csproj)|*.csproj";
            m_ofdSelectProject.Title = @"Please select an CSPROJ File.";

            DialogResult result = m_ofdSelectProject.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = m_ofdSelectProject.FileName;

                m_textBoxProjectPath.Text = fileName;
            }
        }

        private void m_comboBoxPublishType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FrameworkDependent ise
            if (m_comboBoxPublishType.SelectedIndex == 0)
            {
                m_checkBoxPublishTrimmer.Enabled = false;
            }
            else
            {
                m_checkBoxPublishTrimmer.Enabled = true;
            }
        }

        private void m_pictureBoxGithubLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/caglargul52/dotnetcore-advanced-publisher");
        }

        private void m_textBoxProjectPath_DragEnter(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 1)
            {
                if (Path.GetExtension(files[0])?.ToLower() == ".csproj")
                {
                    if (e.Data.GetDataPresent(DataFormats.FileDrop))
                        e.Effect = DragDropEffects.Copy;

                    return;
                }
            }

            e.Effect = DragDropEffects.None;
        }

        private void m_textBoxProjectPath_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);

            m_textBoxProjectPath.Text = files[0];
        }

        private void m_textBoxLocalFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = m_fbdOutputFolder.ShowDialog();

            if(result == DialogResult.OK)
            {
                m_textBoxLocalFolder.Text = m_fbdOutputFolder.SelectedPath;
            }
        }


        private void m_radioButtonLocal_Click(object sender, EventArgs e)
        {
            m_radioButtonRemote.Checked = false;
            m_textBoxNetworkPath.Enabled = false;
            m_textBoxUsername.Enabled = false;
            m_textBoxPassword.Enabled = false;
            m_textBoxLocalFolder.Enabled = true;

        }

        private void m_radioButtonRemote_Click(object sender, EventArgs e)
        {
            m_radioButtonLocal.Checked = false;

            m_textBoxLocalFolder.Enabled = false;

            m_textBoxNetworkPath.Enabled = true;
            m_textBoxUsername.Enabled = true;
            m_textBoxPassword.Enabled = true;
        }

        private void m_textBoxLocalFolder_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
