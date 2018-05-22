namespace Yazilim_Yapimi_Proje
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgScrumTable = new System.Windows.Forms.DataGridView();
            this.Story = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Not_Started = new System.Windows.Forms.DataGridViewButtonColumn();
            this.In_Progress = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Done = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnStoryEkle = new System.Windows.Forms.Button();
            this.txtStory = new System.Windows.Forms.TextBox();
            this.cmboStory = new System.Windows.Forms.ComboBox();
            this.btnTaskEkle = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.txtYapacakKisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStorySec = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblYapacakKisi = new System.Windows.Forms.Label();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblBitis = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.sistemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgScrumTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgScrumTable
            // 
            this.dtgScrumTable.BackgroundColor = System.Drawing.Color.Yellow;
            this.dtgScrumTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgScrumTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgScrumTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Story,
            this.Not_Started,
            this.In_Progress,
            this.Done});
            this.dtgScrumTable.Location = new System.Drawing.Point(0, -1);
            this.dtgScrumTable.Name = "dtgScrumTable";
            this.dtgScrumTable.Size = new System.Drawing.Size(506, 518);
            this.dtgScrumTable.TabIndex = 0;
            this.dtgScrumTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgScrumTable_CellContentClick);
            // 
            // Story
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Story.DefaultCellStyle = dataGridViewCellStyle9;
            this.Story.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Story.HeaderText = "Story";
            this.Story.Name = "Story";
            this.Story.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Not_Started
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Not_Started.DefaultCellStyle = dataGridViewCellStyle10;
            this.Not_Started.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Not_Started.HeaderText = "Not Started";
            this.Not_Started.Name = "Not_Started";
            this.Not_Started.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // In_Progress
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.In_Progress.DefaultCellStyle = dataGridViewCellStyle11;
            this.In_Progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.In_Progress.HeaderText = "In Progress";
            this.In_Progress.Name = "In_Progress";
            this.In_Progress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Done
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.Done.DefaultCellStyle = dataGridViewCellStyle12;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnStoryEkle
            // 
            this.btnStoryEkle.Location = new System.Drawing.Point(788, 153);
            this.btnStoryEkle.Name = "btnStoryEkle";
            this.btnStoryEkle.Size = new System.Drawing.Size(75, 23);
            this.btnStoryEkle.TabIndex = 1;
            this.btnStoryEkle.Text = "Story Ekle";
            this.btnStoryEkle.UseVisualStyleBackColor = true;
            this.btnStoryEkle.Click += new System.EventHandler(this.btnStoryEkle_Click);
            // 
            // txtStory
            // 
            this.txtStory.Location = new System.Drawing.Point(759, 58);
            this.txtStory.Multiline = true;
            this.txtStory.Name = "txtStory";
            this.txtStory.Size = new System.Drawing.Size(151, 77);
            this.txtStory.TabIndex = 2;
            // 
            // cmboStory
            // 
            this.cmboStory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboStory.FormattingEnabled = true;
            this.cmboStory.Location = new System.Drawing.Point(862, 255);
            this.cmboStory.Name = "cmboStory";
            this.cmboStory.Size = new System.Drawing.Size(121, 21);
            this.cmboStory.TabIndex = 3;
            this.cmboStory.SelectedIndexChanged += new System.EventHandler(this.cmboStory_SelectedIndexChanged);
            // 
            // btnTaskEkle
            // 
            this.btnTaskEkle.Location = new System.Drawing.Point(788, 459);
            this.btnTaskEkle.Name = "btnTaskEkle";
            this.btnTaskEkle.Size = new System.Drawing.Size(75, 23);
            this.btnTaskEkle.TabIndex = 4;
            this.btnTaskEkle.Text = "Task Ekle";
            this.btnTaskEkle.UseVisualStyleBackColor = true;
            this.btnTaskEkle.Click += new System.EventHandler(this.btnTaskEkle_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(738, 293);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(151, 72);
            this.txtTask.TabIndex = 5;
            // 
            // txtYapacakKisi
            // 
            this.txtYapacakKisi.Location = new System.Drawing.Point(684, 381);
            this.txtYapacakKisi.Name = "txtYapacakKisi";
            this.txtYapacakKisi.Size = new System.Drawing.Size(100, 20);
            this.txtYapacakKisi.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(702, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Story";
            // 
            // lblStorySec
            // 
            this.lblStorySec.AutoSize = true;
            this.lblStorySec.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStorySec.Location = new System.Drawing.Point(814, 255);
            this.lblStorySec.Name = "lblStorySec";
            this.lblStorySec.Size = new System.Drawing.Size(31, 13);
            this.lblStorySec.TabIndex = 8;
            this.lblStorySec.Text = "Story";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTask.Location = new System.Drawing.Point(681, 293);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(31, 13);
            this.lblTask.TabIndex = 9;
            this.lblTask.Text = "Task";
            // 
            // lblYapacakKisi
            // 
            this.lblYapacakKisi.AutoSize = true;
            this.lblYapacakKisi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYapacakKisi.Location = new System.Drawing.Point(609, 388);
            this.lblYapacakKisi.Name = "lblYapacakKisi";
            this.lblYapacakKisi.Size = new System.Drawing.Size(69, 13);
            this.lblYapacakKisi.TabIndex = 10;
            this.lblYapacakKisi.Text = "Yapacak Kişi";
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Location = new System.Drawing.Point(710, 419);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtBitisTarihi.TabIndex = 11;
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBitis.Location = new System.Drawing.Point(646, 419);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(55, 13);
            this.lblBitis.TabIndex = 12;
            this.lblBitis.Text = "Bitis Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(818, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Durum";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Not Started",
            "In Progress",
            "Done"});
            this.cmbDurum.Location = new System.Drawing.Point(862, 380);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 15;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.Gray;
            this.btnTamam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTamam.Location = new System.Drawing.Point(512, 184);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 16;
            this.btnTamam.Text = "TAMAM";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Visible = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // sistemBindingSource1
            // 
            this.sistemBindingSource1.DataSource = typeof(Yazilim_Yapimi_Proje.Sistem);
            // 
            // storyBindingSource
            // 
            this.storyBindingSource.DataSource = typeof(Yazilim_Yapimi_Proje.Story);
            // 
            // sistemBindingSource
            // 
            this.sistemBindingSource.DataSource = typeof(Yazilim_Yapimi_Proje.Sistem);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Gray;
            this.btnSil.Location = new System.Drawing.Point(512, 213);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Visible = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(996, 512);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.dtBitisTarihi);
            this.Controls.Add(this.lblYapacakKisi);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblStorySec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYapacakKisi);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnTaskEkle);
            this.Controls.Add(this.cmboStory);
            this.Controls.Add(this.txtStory);
            this.Controls.Add(this.btnStoryEkle);
            this.Controls.Add(this.dtgScrumTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgScrumTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgScrumTable;
        private System.Windows.Forms.Button btnStoryEkle;
        private System.Windows.Forms.TextBox txtStory;
        private System.Windows.Forms.ComboBox cmboStory;
        private System.Windows.Forms.Button btnTaskEkle;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.TextBox txtYapacakKisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStorySec;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblYapacakKisi;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.BindingSource storyBindingSource;
        private System.Windows.Forms.BindingSource sistemBindingSource1;
        private System.Windows.Forms.BindingSource sistemBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridViewButtonColumn Story;
        private System.Windows.Forms.DataGridViewButtonColumn Not_Started;
        private System.Windows.Forms.DataGridViewButtonColumn In_Progress;
        private System.Windows.Forms.DataGridViewButtonColumn Done;
        private System.Windows.Forms.Button btnSil;
    }
}

