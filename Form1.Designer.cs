
namespace mp3Converter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.url = new System.Windows.Forms.TabPage();
            this.btn_delete = new System.Windows.Forms.Button();
            this.informativeUrl = new System.Windows.Forms.Label();
            this.progressBarMP3 = new System.Windows.Forms.ProgressBar();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cb_multipleDowloads = new System.Windows.Forms.CheckBox();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_folderEntry = new System.Windows.Forms.TextBox();
            this.btn_folderEntry = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.url.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.url);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 444);
            this.tabControl1.TabIndex = 0;
            // 
            // url
            // 
            this.url.Controls.Add(this.btn_folderEntry);
            this.url.Controls.Add(this.txt_folderEntry);
            this.url.Controls.Add(this.btn_delete);
            this.url.Controls.Add(this.informativeUrl);
            this.url.Controls.Add(this.progressBarMP3);
            this.url.Controls.Add(this.btn_add);
            this.url.Controls.Add(this.listBox1);
            this.url.Controls.Add(this.cb_multipleDowloads);
            this.url.Controls.Add(this.lbl_erro);
            this.url.Controls.Add(this.btn_convert);
            this.url.Controls.Add(this.tb_url);
            this.url.Location = new System.Drawing.Point(4, 22);
            this.url.Name = "url";
            this.url.Padding = new System.Windows.Forms.Padding(3);
            this.url.Size = new System.Drawing.Size(786, 418);
            this.url.TabIndex = 0;
            this.url.Text = ".mp3";
            this.url.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(512, 153);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(39, 28);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "X";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // informativeUrl
            // 
            this.informativeUrl.AutoSize = true;
            this.informativeUrl.Location = new System.Drawing.Point(48, 44);
            this.informativeUrl.Name = "informativeUrl";
            this.informativeUrl.Size = new System.Drawing.Size(23, 13);
            this.informativeUrl.TabIndex = 8;
            this.informativeUrl.Text = "Url:";
            // 
            // progressBarMP3
            // 
            this.progressBarMP3.Location = new System.Drawing.Point(51, 101);
            this.progressBarMP3.Name = "progressBarMP3";
            this.progressBarMP3.Size = new System.Drawing.Size(286, 23);
            this.progressBarMP3.TabIndex = 7;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_add.Location = new System.Drawing.Point(343, 51);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(36, 35);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Visible = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(220, 153);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 160);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // cb_multipleDowloads
            // 
            this.cb_multipleDowloads.AutoSize = true;
            this.cb_multipleDowloads.Location = new System.Drawing.Point(51, 19);
            this.cb_multipleDowloads.Name = "cb_multipleDowloads";
            this.cb_multipleDowloads.Size = new System.Drawing.Size(112, 17);
            this.cb_multipleDowloads.TabIndex = 3;
            this.cb_multipleDowloads.Text = "Multiple Dowlaods";
            this.cb_multipleDowloads.UseVisualStyleBackColor = true;
            this.cb_multipleDowloads.CheckedChanged += new System.EventHandler(this.cb_multipleDowloads_CheckedChanged);
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(163, 339);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 17);
            this.lbl_erro.TabIndex = 2;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(488, 44);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(110, 42);
            this.btn_convert.TabIndex = 1;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(51, 60);
            this.tb_url.Name = "tb_url";
            this.tb_url.ReadOnly = true;
            this.tb_url.Size = new System.Drawing.Size(286, 20);
            this.tb_url.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = ".mp4";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // txt_folderEntry
            // 
            this.txt_folderEntry.Location = new System.Drawing.Point(418, 359);
            this.txt_folderEntry.Name = "txt_folderEntry";
            this.txt_folderEntry.ReadOnly = true;
            this.txt_folderEntry.Size = new System.Drawing.Size(170, 20);
            this.txt_folderEntry.TabIndex = 10;
            // 
            // btn_folderEntry
            // 
            this.btn_folderEntry.Location = new System.Drawing.Point(594, 359);
            this.btn_folderEntry.Name = "btn_folderEntry";
            this.btn_folderEntry.Size = new System.Drawing.Size(76, 20);
            this.btn_folderEntry.TabIndex = 11;
            this.btn_folderEntry.Text = "Folder";
            this.btn_folderEntry.UseVisualStyleBackColor = true;
            this.btn_folderEntry.Click += new System.EventHandler(this.btn_fileEntry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(815, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.url.ResumeLayout(false);
            this.url.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage url;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox cb_multipleDowloads;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBarMP3;
        private System.Windows.Forms.Label informativeUrl;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_folderEntry;
        private System.Windows.Forms.TextBox txt_folderEntry;
    }
}

