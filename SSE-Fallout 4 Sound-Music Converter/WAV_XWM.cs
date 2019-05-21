using System;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SSE_Fallout_4_Sound_Music_Converter
{
    public partial class WAV_XWM : Form
    {
        private List<string> filePaths = new List<string>();

        public WAV_XWM()
        {
            InitializeComponent();
        }

        private void WAV_XWM_Load(object sender, EventArgs e)
        {
            ///this will create the working dirtory
            Directory.CreateDirectory("wav");
            /// thse are what you see when you hover over the buttons
            toolTip1.SetToolTip(this.btadd, "This is to add them one by one");
            toolTip1.SetToolTip(this.btadddir, "This is for adding a dirtory");
            toolTip1.SetToolTip(this.btClear, "this will purge the list");
            toolTip1.SetToolTip(this.credit, "This will open the credit");
            toolTip1.SetToolTip(this.btstart, "this will start the ");
            /// this will check to see if the at9tool is present
            if (File.Exists("data\\at9tool.exe"))
            {

            }
            else
            {
                MessageBox.Show("at9tool.exe is missing please put it in the data folder");
            }
            /// this will check to see if xWMAEncode.exe is present
            if (File.Exists("Data\\xWMAEncode.exe"))
            {

            }
            else
            {
                MessageBox.Show("xWMAEncode.exe is missing please put it in the data folder");
            }
            /// this is going to show the Mesagebox that give the warning if anything is missing it might now work like its suppost to
            MessageBox.Show("if any other required tools are missing this will not work right", ("Warning"));
            MessageBox.Show("Due to legail reasons i can't include the required tools you will need to find them yourself", ("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            /// this is the for the labal to "None to be converted" on startup
            label1.Text = " None to be converted ";
        }

        private string getFileName(string path)
        {
            path = path.Replace("\\", ",");
            string[] pathSplit = path.Split(',');
            return pathSplit[pathSplit.Length - 1];
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            /// this adds the files selected via add files button to the list
            OpenFileDialog files = new OpenFileDialog();
            files.Multiselect = true;
            files.ShowDialog();
            filePaths.AddRange(files.FileNames);
            for (int i = 0; i < filePaths.Count; i++)
            {
                audioList.Rows.Add(files.SafeFileNames[i]);
            }
            /// this adds the amount and "To be converted"
            ///IE "5 To be converted"
            label1.Text = audioList.Rows.Count + " To be converted ";
        }

        private void btadddir_Click(object sender, EventArgs e)
        {
            /// this is going to add all files via the add dir to the listbox
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Select the texture Folder";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(FBD.SelectedPath, "*.wav", SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    if (!filePaths.Contains(file))
                    {
                        audioList.Rows.Add(Path.GetFileName(file));
                        filePaths.Add(file);
                        label1.Text = audioList.Rows.Count + " To be converted ";
                    }
                }
                files = Directory.GetFiles(FBD.SelectedPath, "*.xwm", SearchOption.AllDirectories);
                foreach (string xwmfiles in files)
                {
                    if (!filePaths.Contains(xwmfiles))
                    {
                        audioList.Rows.Add(Path.GetFileName(xwmfiles));
                        filePaths.Add(xwmfiles);
                        label1.Text = audioList.Rows.Count + " To be converted ";
                    }
                }
            }
            /// this is going to tell the system that label is the count of the listbox and the " To be converted "
            /// IE, "5 To be converted "
            label1.Text = audioList.Rows.Count + " To be converted ";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            /// this is going to clear the list box
            audioList.Rows.Clear();
            /// this is going to refresh the listbox
            audioList.Refresh();
            /// this is going to clear the list of file that where in the listbox
            filePaths.Clear();
            /// this is going to make the progress bar know how many files there are so it can move the bar acordingly
            progressBar1.Maximum = audioList.Rows.Count;
            /// this is going to tell the system that label is the count of the listbox and the " To be converted "
            /// IE, "5 To be converted "
            label1.Text = audioList.Rows.Count + " To be converted ";
        }

        private void audioList_DragDrop(object sender, DragEventArgs e)
        {
            string[] array = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string text in array)
            {
                if ((Path.GetExtension(text) == ".wav" || Path.GetExtension(text) == ".xwm" || Path.GetExtension(text) == ".WAV" || Path.GetExtension(text) == ".XWM") && !filePaths.Contains(text))
                {
                    audioList.Rows.Add(Path.GetFileName(text));
                    filePaths.Add(text);
                    label1.Text = audioList.Rows.Count + " To be converted ";
                }
                if (Directory.Exists(text))
                {
                    string[] files = Directory.GetFiles(text, "*.wav", SearchOption.AllDirectories);
                    foreach (string dds in files)
                    {
                        if (!filePaths.Contains(dds))
                        {
                            audioList.Rows.Add(Path.GetFileName(dds));
                            filePaths.Add(dds);
                            label1.Text = audioList.Rows.Count + " To be converted ";
                        }
                    }
                    files = Directory.GetFiles(text, "*.xwm", SearchOption.AllDirectories);
                    foreach (string tga in files)
                    {
                        if (!filePaths.Contains(tga))
                        {
                            audioList.Rows.Add(Path.GetFileName(tga));
                            filePaths.Add(tga);
                            label1.Text = audioList.Rows.Count + " To be converted ";
                        }
                    }
                }
            }
        }

        private void audioList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void credit_Click(object sender, EventArgs e)
        {
            /// this opens the credits window
            if (Application.OpenForms["Credits"] == null)
            {

                Credits form = new Credits();
                form.Show();
            }
        }

        private void btstart_Click(object sender, EventArgs e)
        {
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\wav\\");
            FileInfo[] files = info.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            for (int i = 0; i < filePaths.Count; i++)
            {
                if (!filePaths[i].Contains(".wav"))
                {
                    Process process4 = new Process();
                    process4.StartInfo.FileName = "cmd.exe";
                    process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process4.StartInfo.Arguments = "/c Data\\xWMAEncode \"" + filePaths[i] + "\" \"" + Application.StartupPath + "\\wav\\" + audioList.Rows[i].Cells[0].Value.ToString().Replace(".xwm", ".wav") + "\"";
                    process4.Start();
                    process4.WaitForExit();
                    Process process3 = new Process();
                    process3.StartInfo.FileName = "cmd.exe";
                    process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    if (Convert.ToBoolean(audioList.Rows[i].Cells[1].EditedFormattedValue))
                    {
                        /// this is for bitrate 144 kbps + holeloop
                        process3.StartInfo.Arguments = "/c Data\\at9tool.exe -e -br 144 -wholeloop \"" + Application.StartupPath + "\\wav\\" + audioList.Rows[i].Cells[0].Value.ToString().Replace(".xwm", ".wav") + "\" \"" + filePaths[i].ToString().Replace(".xwm", ".at9") + "\"";
                    }
                    else
                    {
                        /// this is for bitrate 144 kbps
                        process3.StartInfo.Arguments = "/c Data\\at9tool.exe -e -br 144 \"" + Application.StartupPath + "\\wav\\" + audioList.Rows[i].Cells[0].Value.ToString().Replace(".xwm", ".wav") + "\" \"" + filePaths[i].ToString().Replace(".xwm", ".at9") + "\"";
                    }
                    process3.Start();
                    process3.WaitForExit();
                }
                else
                {
                    Process process3 = new Process();
                    process3.StartInfo.FileName = "cmd.exe";
                    process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    if (Convert.ToBoolean(audioList.Rows[i].Cells[1].EditedFormattedValue))
                    {
                        /// this is for bitrate 144 kbps + holeloop
                        process3.StartInfo.Arguments = "/c Data\\at9tool.exe -e -br 144 -wholeloop \"" + filePaths[i] + "\" \"" + filePaths[i].ToString().Replace(".wav", ".at9") + "\"";
                    }
                    else
                    {
                        /// this is for bitrate 144 kbps
                        process3.StartInfo.Arguments = "/c Data\\at9tool.exe -e -br 144 \"" + filePaths[i] + "\" \"" + filePaths[i].ToString().Replace(".wav", ".at9") + "\"";
                    }
                    process3.Start();
                    process3.WaitForExit();
                }
                /// this is for cleaning up the audio 
                if (WAVXWM.Checked)
                {
                    ///start
                    /// this is to delete the files for wav
                    System.IO.File.Delete(filePaths[i]);
                    /// this is for XWM
                    /// this replaces the filepaths for it to know to delete the XWM
                    filePaths[i].ToString().Replace(".at9", ".xwm");
                    //this is to delete
                    System.IO.File.Delete(filePaths[i]);
                    ///emding
                }
                progressBar1.Maximum = audioList.Rows.Count;
                System.GC.Collect();
                progressBar1.Value++;
            }

            /// this is what shows the messege after the converion is done
            if (progressBar1.Value == progressBar1.Maximum)
            {
                MessageBox.Show("Your Voice Dialouge is converted!", "Finished!");
            }
        }

        private void WAV_XWM_FormClosed(object sender, FormClosedEventArgs e)
        {
            /// this cleans and deletes the working directory
            /// it cleans it as it will have wav files left over form XWM to wav
            DirectoryInfo info = new DirectoryInfo(Application.StartupPath + "\\wav\\");
            FileInfo[] files = info.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            System.IO.Directory.Delete("wav");
        }
    }
}
