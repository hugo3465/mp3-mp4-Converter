using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EdgeJs;

namespace mp3Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {

            if (cb_multipleDowloads.Checked == true)
            {
                var numItems= listBox1.Items.Count;
                progressBarMP3.Maximum = 0;
                progressBarMP3.Maximum = numItems;

                for (int i=0; i<numItems; i++)
                {
                    var CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                    var apiDirectory = CurrentDirectory.Replace("bin\\Debug", "Converter");

                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden; // Esconder o CMD
                    System.Environment.CurrentDirectory = apiDirectory;
                    startInfo.FileName = "CMD.exe";
                    startInfo.Arguments = $"/c node index.js mp3 --url=\"{(string)listBox1.Items[i]}\" --path=\"{txt_folderEntry.Text}\"";
                    process.StartInfo = startInfo;
                    process.Start();

                    // Progress Bar
                    progressBarMP3.Value = i+1;

                    process.WaitForExit(); // Serve para não fazer os dowloads todos de uma vez só

                }
            }
            else
            {
                if (tb_url.Text == "")
                {
                    lbl_erro.Text = "Insira um Url primeiro!";
                    return;
                }
                var CurrentDirectory = System.IO.Directory.GetCurrentDirectory();
                var apiDirectory = CurrentDirectory.Replace("bin\\Debug", "Converter");

                /* Abrir o cmd no diretório especificado acima*/
                System.Environment.CurrentDirectory = apiDirectory;
                System.Diagnostics.Process.Start("CMD.exe", $"/c node index.js mp3 --url=\"{tb_url.Text}\" --path=\"{txt_folderEntry.Text}\"");
            }
        }

        private void cb_multipleDowloads_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_multipleDowloads.Checked==false)
            {
                btn_add.Visible = false;
                listBox1.Visible = false;
                progressBarMP3.Visible = false;
            }
            else
            {
                btn_add.Visible = true;
                listBox1.Visible = true;
                progressBarMP3.Visible = true;
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(tb_url.Text);
            tb_url.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_delete.Visible = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            { 
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                btn_delete.Visible = false;
            }
            catch (Exception Ex)
            {
                lbl_erro.Text = "Inválido";
            }
                
        }

        private void btn_fileEntry_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_folderEntry.Text = folder.SelectedPath;
                tb_url.ReadOnly = false;
            }
            else
            {
                txt_folderEntry.Text = "";
                tb_url.ReadOnly = true;
            }
                
        }
    }
}