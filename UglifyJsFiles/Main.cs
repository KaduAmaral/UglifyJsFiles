using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UglifyJsFiles
{
    public partial class MainForm : Form
    {
        private UglifySettings ugsettingsForm;

        public MainForm()
        {
            InitializeComponent();
            ugsettingsForm = new UglifySettings();
        }

        private void btnPickFolder_Click(object sender, EventArgs e)
        {

            if (lstSelectedFiles.Items.Count > 0)
            {
                DialogResult res = MessageBox.Show(
                    "Alguns arquivos já foram selecionados, deseja continuar?\n\n" +
                    "Isso removerá todos os arquivos.",
                    "Alterar pasta?",
                    MessageBoxButtons.YesNo
                );

                if (res == DialogResult.No)
                {
                    return;
                }
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {

                lstDirFiles.Items.Clear();
                lstSelectedFiles.Items.Clear();

                txtDirPath.Text = fbd.SelectedPath;

                ArrayList allfiles = new ArrayList();

                allfiles.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.js"));
                allfiles.AddRange(Directory.GetFiles(fbd.SelectedPath, "*.json"));

                string[] files = (string[])allfiles.ToArray(typeof(string));

                // System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

                if (files.Count() > 0)
                {
                    foreach (var file in files)
                    {
                        string filename = file.Replace(fbd.SelectedPath, "").TrimStart('\\');

                        lstDirFiles.Items.Add(filename);
                    }
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja fechar a aplicação?", "Fechar", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAllRight_Click(object sender, EventArgs e)
        {
            if (lstDirFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser selecionado.");
                return;
            }

            foreach (var item in lstDirFiles.Items)
            {
                lstSelectedFiles.Items.Add(item);
            }

            lstDirFiles.Items.Clear();
        }

        private void btnAllLeft_Click(object sender, EventArgs e)
        {
            if (lstSelectedFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser selecionado.");
                return;
            }

            foreach (var item in lstSelectedFiles.Items)
            {
                int id = lstSelectedFiles.Items.IndexOf(item);

                lstDirFiles.Items.Add(item);
            }

            lstSelectedFiles.Items.Clear();
        }

        private void btnOneRight_Click(object sender, EventArgs e)
        {
            if (lstDirFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser selecionado.");
                return;
            }

            if (lstDirFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um arquivo!");
                return;
            }

            List<string> items = new List<string>();

            foreach (string item in lstDirFiles.SelectedItems)
            {
                lstSelectedFiles.Items.Add(item);
                items.Add(item);
            }

            foreach (var item in items)
            {
                lstDirFiles.Items.RemoveAt(lstDirFiles.Items.IndexOf(item));
            }
            
        }

        private void btnOneLeft_Click(object sender, EventArgs e)
        {
            if (lstSelectedFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser selecionado.");
                return;
            }

            if (lstSelectedFiles.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um arquivo!");
                return;
            }

            List<string> items = new List<string>();

            foreach (string item in lstSelectedFiles.SelectedItems)
            {
                lstDirFiles.Items.Add(item);
                items.Add(item);
            }

            foreach (var item in items)
            {
                lstSelectedFiles.Items.RemoveAt(lstSelectedFiles.Items.IndexOf(item));
            }
        }

        private void btnUnifiedFolder_Click(object sender, EventArgs e)
        {
            if (lstSelectedFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser unificado.");
                return;
            }

            
            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = lstSelectedFiles.Items[0].ToString();
            // set filters - this can be done in properties as well
            savefile.Filter = "Javascript (*.js)|*.js";

            savefile.InitialDirectory = txtDirPath.Text;

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                txtPathUnified.Text = savefile.FileName;

                txtPathMinified.Text = savefile.FileName.Replace(".js",".min.js");

                //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                //{
                //    sw.WriteLine("Hello World!");
                //}
            }
        }

        private void btnMinifiedFolder_Click(object sender, EventArgs e)
        {
            if (lstSelectedFiles.Items.Count == 0)
            {
                MessageBox.Show("Nenhum arquivo a ser minificado.");
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = lstSelectedFiles.Items[0].ToString().Replace(".js", ".min.js");

            // set filters - this can be done in properties as well
            savefile.Filter = "Javascript (*.js)|*.js";

            savefile.InitialDirectory = txtDirPath.Text;

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                txtPathMinified.Text = savefile.FileName;

                //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                //{
                //    sw.WriteLine("Hello World!");
                //}
            }
        }

        private void btnGoTop_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }

        private void btnGoDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }

        public void MoveItem(int direction)
        {

            // Checking selected item
            if (lstSelectedFiles.SelectedItem == null || lstSelectedFiles.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Checking multi selection
            if (lstSelectedFiles.SelectedItems.Count > 1)
                return; // Most than one item selected

            // Calculate new index using move direction
            int newIndex = lstSelectedFiles.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lstSelectedFiles.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lstSelectedFiles.SelectedItem;

            // Removing removable element
            lstSelectedFiles.Items.Remove(selected);
            // Insert it in new position
            lstSelectedFiles.Items.Insert(newIndex, selected);
            // Restore selection
            lstSelectedFiles.SetSelected(newIndex, true);
        }

        public string GenUnifyCode()
        {
            string command = "/C TYPE ";


            string items = "";
            foreach (string item in lstSelectedFiles.Items)
            {
                items += item + " ";
            }

            command += items + "> " + txtPathUnified.Text;

            return command;
        }

        public string GenMinifyCode()
        {
            string items = "";
            foreach (string item in lstSelectedFiles.Items)
            {
                items += item + " ";
            }

            string parameters = "";

            if (ugsettingsForm.chkSupportIE8.Checked)
                parameters += "--support-ie8 ";

            if (ugsettingsForm.chkScrewIE8.Checked)
                parameters += "--screw-ie8 ";

            if (ugsettingsForm.chkMangle.Checked)
                parameters += "--mangle ";

            if (ugsettingsForm.chkCompress.Checked)
                parameters += "--compress ";

            string command = "/C uglifyjs " + items + parameters + " --output " + txtPathMinified.Text + " -m -c";

            return command;
        }

        private void ExecuteCommand(string command)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = txtDirPath.Text;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = command;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void btnMinify_Click(object sender, EventArgs e)
        {

            if (lstSelectedFiles.Items.Count > 1 && (txtPathUnified.Text == null || txtPathUnified.Text == ""))
            {
                MessageBox.Show("Informe o nome do arquivo a ser unificado.");
                return;
            }
            else
            {
                string command = GenUnifyCode();
                //MessageBox.Show(command);
                ExecuteCommand(command);
            }


            if (txtPathMinified.Text == null || txtPathMinified.Text == "")
            {
                MessageBox.Show("Informe o nome do arquivo a ser minificado.");
                return;
            }
            else
            {
                string command = GenMinifyCode();
                //MessageBox.Show(command);

                ExecuteCommand(command);
                MessageBox.Show("Minificação concluída.");
            }


        }

        private void btnUgSettings_Click(object sender, EventArgs e)
        {
            ugsettingsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ugsettingsForm.Close();
        }
    }
}
