namespace SSE_Fallout_4_Sound_Music_Converter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.audioList = new System.Windows.Forms.DataGridView();
            this.AudioName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Looped = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btstart = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btadddir = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.WAVXWM = new System.Windows.Forms.CheckBox();
            this.credit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.audioList)).BeginInit();
            this.SuspendLayout();
            // 
            // audioList
            // 
            this.audioList.AllowDrop = true;
            this.audioList.AllowUserToAddRows = false;
            this.audioList.AllowUserToOrderColumns = true;
            this.audioList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audioList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AudioName,
            this.Looped});
            this.audioList.Location = new System.Drawing.Point(3, 4);
            this.audioList.Name = "audioList";
            this.audioList.Size = new System.Drawing.Size(644, 378);
            this.audioList.TabIndex = 56;
            this.audioList.DragDrop += new System.Windows.Forms.DragEventHandler(this.audioList_DragDrop);
            this.audioList.DragEnter += new System.Windows.Forms.DragEventHandler(this.audioList_DragEnter);
            // 
            // AudioName
            // 
            this.AudioName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AudioName.HeaderText = "Audio Name";
            this.AudioName.Name = "AudioName";
            this.AudioName.ReadOnly = true;
            // 
            // Looped
            // 
            this.Looped.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Looped.HeaderText = "Looped";
            this.Looped.Name = "Looped";
            // 
            // btstart
            // 
            this.btstart.AutoSize = true;
            this.btstart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btstart.Location = new System.Drawing.Point(653, 120);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(128, 23);
            this.btstart.TabIndex = 53;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // btClear
            // 
            this.btClear.AutoSize = true;
            this.btClear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btClear.Location = new System.Drawing.Point(653, 62);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(128, 23);
            this.btClear.TabIndex = 52;
            this.btClear.Text = "Purge list";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btadddir
            // 
            this.btadddir.AutoSize = true;
            this.btadddir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadddir.Location = new System.Drawing.Point(653, 33);
            this.btadddir.Name = "btadddir";
            this.btadddir.Size = new System.Drawing.Size(128, 23);
            this.btadddir.TabIndex = 51;
            this.btadddir.Text = "Add Directory(s)";
            this.btadddir.UseVisualStyleBackColor = true;
            this.btadddir.Click += new System.EventHandler(this.btadddir_Click);
            // 
            // btadd
            // 
            this.btadd.AutoSize = true;
            this.btadd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btadd.Location = new System.Drawing.Point(653, 4);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(128, 23);
            this.btadd.TabIndex = 50;
            this.btadd.Text = "Add File(s)";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // WAVXWM
            // 
            this.WAVXWM.AutoSize = true;
            this.WAVXWM.Checked = true;
            this.WAVXWM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WAVXWM.Location = new System.Drawing.Point(653, 191);
            this.WAVXWM.Name = "WAVXWM";
            this.WAVXWM.Size = new System.Drawing.Size(91, 30);
            this.WAVXWM.TabIndex = 57;
            this.WAVXWM.Text = "Delete WAV\r\nafter patching";
            this.WAVXWM.UseVisualStyleBackColor = true;
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Location = new System.Drawing.Point(653, 91);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(128, 23);
            this.credit.TabIndex = 55;
            this.credit.Text = "Credits";
            this.credit.UseVisualStyleBackColor = true;
            this.credit.Click += new System.EventHandler(this.credit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(653, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(128, 23);
            this.progressBar1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(653, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 387);
            this.Controls.Add(this.audioList);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btadddir);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.WAVXWM);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "SSE/Fallout 4 Sound-Music Converter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.audioList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView audioList;
        private System.Windows.Forms.DataGridViewTextBoxColumn AudioName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Looped;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btadddir;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox WAVXWM;
        private System.Windows.Forms.Button credit;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

