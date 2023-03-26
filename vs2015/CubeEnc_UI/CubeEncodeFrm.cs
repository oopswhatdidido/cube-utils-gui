using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ookii.Dialogs.WinForms;

namespace CubeEnc_UI
{
    public partial class CubeEncodeFrm : Form
    {
        public CubeEncodeFrm()
        {
            InitializeComponent();
            FilePathTB.Text = Properties.Settings.Default.LastFileLocation;
            OutputFolderTB.Text = Properties.Settings.Default.LastOutputPath;
            EncoderPath.Text = Properties.Settings.Default.EncoderPath;
            FilenameCB.Checked = Properties.Settings.Default.SameFileCB;
            FolderCB.Checked = Properties.Settings.Default.SameFolderCB;

            if (FolderCB.Checked && FilenameCB.Checked)
            {
                OutputBtn.Enabled = false;
                OutputFolderTB.Enabled = false;
            }
            else
            {
                OutputBtn.Enabled = true;
                OutputFolderTB.Enabled = true;
            }
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "BFB files (*.bfb)|*.bfb|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTB.Text = openFileDialog.FileName;
            }
        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FilePathTB.Text))
            {
                MessageBox.Show("File not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(EncoderPath.Text))
            {
                MessageBox.Show("Encoder not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = EncoderPath.Text;
            if (!FilenameCB.Checked && Path.GetFileName(OutputFolderTB.Text).Equals(""))
            {
                MessageBox.Show("Missing Filename!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FilenameCB.Checked && FolderCB.Checked)
            {
                startInfo.Arguments = "\"" + FilePathTB.Text + "\"";
                OutputFolderTB.Text = Path.GetDirectoryName(FilePathTB.Text) + "\\" + Path.GetFileNameWithoutExtension(FilePathTB.Text) + ".cubepro";
            }
            else
            {
                if (!Directory.Exists(Path.GetDirectoryName(OutputFolderTB.Text)))
                {
                    MessageBox.Show("Output folder not found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OutputFolderTB.Text = (FolderCB.Checked ? Path.GetDirectoryName(FilePathTB.Text) : Path.GetDirectoryName(OutputFolderTB.Text)) + "\\" + (FilenameCB.Checked ? Path.GetFileNameWithoutExtension(FilePathTB.Text) + ".cubepro" : Path.GetFileName(OutputFolderTB.Text));
                startInfo.Arguments = "\"" + FilePathTB.Text + "\" \"" + OutputFolderTB.Text + "\"";
            }
            process.StartInfo = startInfo;
            process.Start();
            System.Diagnostics.Process.Start(startInfo.FileName, startInfo.Arguments);
            process.WaitForExit();
            Debug.Print(process.ExitCode.ToString());
            switch (process.ExitCode)
            {
                case 0:
                    MessageBox.Show("Done!", "Done!", MessageBoxButtons.OK);
                    break;
                case 2:
                    MessageBox.Show("Unable to open input file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 3:
                    MessageBox.Show("Unable to determine size of input file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 4:
                    MessageBox.Show("Unable to allocate memory for output file name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 5:
                    MessageBox.Show("Unable to read the whole input file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 6:
                    MessageBox.Show("Unable to open output file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 7:
                    MessageBox.Show("Unable to write the whole output file", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Unknown Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void OutputBtn_Click(object sender, EventArgs e)
        {
            if (!FilenameCB.Checked)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "cubepro files (*.cubepro)|*.cubepro|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    OutputFolderTB.Text = saveFileDialog1.FileName;
                }
            }
            else
            {
                Ookii.Dialogs.WinForms.VistaFolderBrowserDialog _sampleVistaFolderBrowserDialog = new VistaFolderBrowserDialog();
                if (!VistaFolderBrowserDialog.IsVistaFolderDialogSupported)
                    MessageBox.Show(this, "Because you are not using Windows Vista or later, the regular folder browser dialog will be used. Please use Windows Vista to see the new dialog.", "Sample folder browser dialog");
                if (_sampleVistaFolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
                    OutputFolderTB.Text = _sampleVistaFolderBrowserDialog.SelectedPath;
            }
        }

        private void EncoderSelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EncoderPath.Text = openFileDialog.FileName;
            }
        }

        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.LastOutputPath = OutputFolderTB.Text;
            Properties.Settings.Default.LastFileLocation = FilePathTB.Text;
            Properties.Settings.Default.EncoderPath = EncoderPath.Text;
            Properties.Settings.Default.SameFileCB = FilenameCB.Checked;
            Properties.Settings.Default.SameFolderCB = FolderCB.Checked;
            Properties.Settings.Default.Save();

        }

        private void FileCBChg(object sender, EventArgs e)
        {
            if (FolderCB.Checked && FilenameCB.Checked)
            {
                OutputBtn.Enabled = false;
                OutputFolderTB.Enabled = false;
            }
            else
            {
                OutputBtn.Enabled = true;
                OutputFolderTB.Enabled = true;
            }
        }
    }
}
