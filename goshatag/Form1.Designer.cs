namespace goshatag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_tag = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_content = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.ac = new System.Windows.Forms.GroupBox();
            this.btn_aboutus = new System.Windows.Forms.Button();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.btn_template = new System.Windows.Forms.Button();
            this.lbl_msgs = new System.Windows.Forms.Label();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tag
            // 
            this.btn_tag.Location = new System.Drawing.Point(13, 13);
            this.btn_tag.Name = "btn_tag";
            this.btn_tag.Size = new System.Drawing.Size(160, 23);
            this.btn_tag.TabIndex = 0;
            this.btn_tag.Text = "browse tag file";
            this.btn_tag.UseVisualStyleBackColor = true;
            this.btn_tag.Click += new System.EventHandler(this.btn_tag_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 338);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(494, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // btn_content
            // 
            this.btn_content.Location = new System.Drawing.Point(196, 13);
            this.btn_content.Name = "btn_content";
            this.btn_content.Size = new System.Drawing.Size(160, 23);
            this.btn_content.TabIndex = 3;
            this.btn_content.Text = "browse tag content";
            this.btn_content.UseVisualStyleBackColor = true;
            this.btn_content.Click += new System.EventHandler(this.btn_content_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(6, 29);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(109, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // ac
            // 
            this.ac.Controls.Add(this.btn_aboutus);
            this.ac.Controls.Add(this.btn_help);
            this.ac.Controls.Add(this.btn_export);
            this.ac.Controls.Add(this.btn_template);
            this.ac.Controls.Add(this.btn_start);
            this.ac.Location = new System.Drawing.Point(362, 13);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(121, 319);
            this.ac.TabIndex = 6;
            this.ac.TabStop = false;
            this.ac.Text = "action";
            // 
            // btn_aboutus
            // 
            this.btn_aboutus.Location = new System.Drawing.Point(6, 145);
            this.btn_aboutus.Name = "btn_aboutus";
            this.btn_aboutus.Size = new System.Drawing.Size(109, 23);
            this.btn_aboutus.TabIndex = 9;
            this.btn_aboutus.Text = "about us";
            this.btn_aboutus.UseVisualStyleBackColor = true;
            this.btn_aboutus.Click += new System.EventHandler(this.btn_aboutus_Click);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(6, 116);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(109, 23);
            this.btn_help.TabIndex = 8;
            this.btn_help.Text = "help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(6, 87);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(109, 23);
            this.btn_export.TabIndex = 7;
            this.btn_export.Text = "open export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // btn_template
            // 
            this.btn_template.Location = new System.Drawing.Point(6, 58);
            this.btn_template.Name = "btn_template";
            this.btn_template.Size = new System.Drawing.Size(109, 23);
            this.btn_template.TabIndex = 6;
            this.btn_template.Text = "browse template";
            this.btn_template.UseVisualStyleBackColor = true;
            this.btn_template.Click += new System.EventHandler(this.btn_template_Click);
            // 
            // lbl_msgs
            // 
            this.lbl_msgs.Location = new System.Drawing.Point(1, 354);
            this.lbl_msgs.Name = "lbl_msgs";
            this.lbl_msgs.Size = new System.Drawing.Size(494, 25);
            this.lbl_msgs.TabIndex = 7;
            this.lbl_msgs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tag,
            this.content,
            this.crow});
            this.dgv_data.Location = new System.Drawing.Point(13, 42);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(343, 290);
            this.dgv_data.TabIndex = 8;
            // 
            // tag
            // 
            this.tag.HeaderText = "tag";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // content
            // 
            this.content.HeaderText = "tag content";
            this.content.Name = "content";
            this.content.ReadOnly = true;
            // 
            // crow
            // 
            this.crow.HeaderText = "content row";
            this.crow.Name = "crow";
            this.crow.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 359);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.lbl_msgs);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.btn_content);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btn_tag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "goshatag";
            this.ac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_tag;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_content;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.GroupBox ac;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_template;
        private System.Windows.Forms.Label lbl_msgs;
        private System.Windows.Forms.Button btn_aboutus;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn crow;
    }
}

