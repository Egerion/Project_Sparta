
namespace Sparta_Project
{
    partial class Form_Interface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Interface));
            this.ListBox_BackgroundProcs = new System.Windows.Forms.ListBox();
            this.Label_BackgroundTasks = new System.Windows.Forms.Label();
            this.ListBox_InstalledApps = new System.Windows.Forms.ListBox();
            this.Label_InstalledApplications = new System.Windows.Forms.Label();
            this.Button_ProcRefresh = new System.Windows.Forms.Button();
            this.PictureBox_SpartaLogo = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button_ProFullPath = new System.Windows.Forms.Button();
            this.Button_ProcName = new System.Windows.Forms.Button();
            this.ListBox_LastOpenedApps = new System.Windows.Forms.ListBox();
            this.Label_LastOpenedApps = new System.Windows.Forms.Label();
            this.LinkLabel_Contact = new System.Windows.Forms.LinkLabel();
            this.TextBox_ProcessFilter = new System.Windows.Forms.TextBox();
            this.TextBox_FilterInstalledApps = new System.Windows.Forms.TextBox();
            this.Label_Filter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Ad1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SpartaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox_BackgroundProcs
            // 
            this.ListBox_BackgroundProcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_BackgroundProcs.FormattingEnabled = true;
            this.ListBox_BackgroundProcs.ItemHeight = 25;
            this.ListBox_BackgroundProcs.Location = new System.Drawing.Point(26, 354);
            this.ListBox_BackgroundProcs.Name = "ListBox_BackgroundProcs";
            this.ListBox_BackgroundProcs.Size = new System.Drawing.Size(431, 579);
            this.ListBox_BackgroundProcs.TabIndex = 0;
            this.ListBox_BackgroundProcs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_BackgroundProcs_DrawItem);
            this.ListBox_BackgroundProcs.SelectedIndexChanged += new System.EventHandler(this.ListBox_BackgroundProcs_SelectedIndexChanged);
            // 
            // Label_BackgroundTasks
            // 
            this.Label_BackgroundTasks.AutoSize = true;
            this.Label_BackgroundTasks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_BackgroundTasks.Location = new System.Drawing.Point(26, 237);
            this.Label_BackgroundTasks.Name = "Label_BackgroundTasks";
            this.Label_BackgroundTasks.Size = new System.Drawing.Size(299, 30);
            this.Label_BackgroundTasks.TabIndex = 1;
            this.Label_BackgroundTasks.Text = "Background Tasks (Processes)";
            // 
            // ListBox_InstalledApps
            // 
            this.ListBox_InstalledApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_InstalledApps.FormattingEnabled = true;
            this.ListBox_InstalledApps.ItemHeight = 25;
            this.ListBox_InstalledApps.Location = new System.Drawing.Point(494, 354);
            this.ListBox_InstalledApps.Name = "ListBox_InstalledApps";
            this.ListBox_InstalledApps.Size = new System.Drawing.Size(431, 579);
            this.ListBox_InstalledApps.TabIndex = 2;
            // 
            // Label_InstalledApplications
            // 
            this.Label_InstalledApplications.AutoSize = true;
            this.Label_InstalledApplications.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_InstalledApplications.Location = new System.Drawing.Point(494, 237);
            this.Label_InstalledApplications.Name = "Label_InstalledApplications";
            this.Label_InstalledApplications.Size = new System.Drawing.Size(216, 30);
            this.Label_InstalledApplications.TabIndex = 3;
            this.Label_InstalledApplications.Text = "Installed Applications";
            // 
            // Button_ProcRefresh
            // 
            this.Button_ProcRefresh.Location = new System.Drawing.Point(345, 314);
            this.Button_ProcRefresh.Name = "Button_ProcRefresh";
            this.Button_ProcRefresh.Size = new System.Drawing.Size(112, 34);
            this.Button_ProcRefresh.TabIndex = 4;
            this.Button_ProcRefresh.Text = "Refresh";
            this.Button_ProcRefresh.UseVisualStyleBackColor = true;
            this.Button_ProcRefresh.Click += new System.EventHandler(this.Button_ProcRefresh_Click);
            // 
            // PictureBox_SpartaLogo
            // 
            this.PictureBox_SpartaLogo.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_SpartaLogo.Image")));
            this.PictureBox_SpartaLogo.Location = new System.Drawing.Point(618, 12);
            this.PictureBox_SpartaLogo.Name = "PictureBox_SpartaLogo";
            this.PictureBox_SpartaLogo.Size = new System.Drawing.Size(179, 153);
            this.PictureBox_SpartaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_SpartaLogo.TabIndex = 6;
            this.PictureBox_SpartaLogo.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Button_ProFullPath
            // 
            this.Button_ProFullPath.Location = new System.Drawing.Point(26, 314);
            this.Button_ProFullPath.Name = "Button_ProFullPath";
            this.Button_ProFullPath.Size = new System.Drawing.Size(112, 34);
            this.Button_ProFullPath.TabIndex = 7;
            this.Button_ProFullPath.Text = "Full Path";
            this.Button_ProFullPath.UseVisualStyleBackColor = true;
            this.Button_ProFullPath.Visible = false;
            this.Button_ProFullPath.Click += new System.EventHandler(this.Button_ProFullPath_Click);
            // 
            // Button_ProcName
            // 
            this.Button_ProcName.Location = new System.Drawing.Point(144, 314);
            this.Button_ProcName.Name = "Button_ProcName";
            this.Button_ProcName.Size = new System.Drawing.Size(112, 34);
            this.Button_ProcName.TabIndex = 8;
            this.Button_ProcName.Text = "Proc. Name";
            this.Button_ProcName.UseVisualStyleBackColor = true;
            this.Button_ProcName.Visible = false;
            this.Button_ProcName.Click += new System.EventHandler(this.Button_ProcName_Click);
            // 
            // ListBox_LastOpenedApps
            // 
            this.ListBox_LastOpenedApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_LastOpenedApps.ColumnWidth = 10;
            this.ListBox_LastOpenedApps.FormattingEnabled = true;
            this.ListBox_LastOpenedApps.ItemHeight = 25;
            this.ListBox_LastOpenedApps.Location = new System.Drawing.Point(960, 354);
            this.ListBox_LastOpenedApps.MultiColumn = true;
            this.ListBox_LastOpenedApps.Name = "ListBox_LastOpenedApps";
            this.ListBox_LastOpenedApps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ListBox_LastOpenedApps.Size = new System.Drawing.Size(431, 354);
            this.ListBox_LastOpenedApps.TabIndex = 9;
            this.ListBox_LastOpenedApps.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox_LastOpenedApps_DrawItem);
            // 
            // Label_LastOpenedApps
            // 
            this.Label_LastOpenedApps.AutoSize = true;
            this.Label_LastOpenedApps.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_LastOpenedApps.Location = new System.Drawing.Point(960, 237);
            this.Label_LastOpenedApps.Name = "Label_LastOpenedApps";
            this.Label_LastOpenedApps.Size = new System.Drawing.Size(258, 30);
            this.Label_LastOpenedApps.TabIndex = 10;
            this.Label_LastOpenedApps.Text = "Last Opened Applications";
            // 
            // LinkLabel_Contact
            // 
            this.LinkLabel_Contact.AutoSize = true;
            this.LinkLabel_Contact.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabel_Contact.LinkColor = System.Drawing.Color.Red;
            this.LinkLabel_Contact.Location = new System.Drawing.Point(26, 23);
            this.LinkLabel_Contact.Name = "LinkLabel_Contact";
            this.LinkLabel_Contact.Size = new System.Drawing.Size(87, 30);
            this.LinkLabel_Contact.TabIndex = 11;
            this.LinkLabel_Contact.TabStop = true;
            this.LinkLabel_Contact.Text = "Contact";
            this.LinkLabel_Contact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_Contact_LinkClicked);
            // 
            // TextBox_ProcessFilter
            // 
            this.TextBox_ProcessFilter.Location = new System.Drawing.Point(227, 277);
            this.TextBox_ProcessFilter.Name = "TextBox_ProcessFilter";
            this.TextBox_ProcessFilter.Size = new System.Drawing.Size(230, 31);
            this.TextBox_ProcessFilter.TabIndex = 12;
            this.TextBox_ProcessFilter.TextChanged += new System.EventHandler(this.TextBox_ProcessFilter_TextChanged);
            // 
            // TextBox_FilterInstalledApps
            // 
            this.TextBox_FilterInstalledApps.Location = new System.Drawing.Point(695, 280);
            this.TextBox_FilterInstalledApps.Name = "TextBox_FilterInstalledApps";
            this.TextBox_FilterInstalledApps.Size = new System.Drawing.Size(230, 31);
            this.TextBox_FilterInstalledApps.TabIndex = 13;
            this.TextBox_FilterInstalledApps.TextChanged += new System.EventHandler(this.TextBox_FilterInstalledApps_TextChanged);
            // 
            // Label_Filter
            // 
            this.Label_Filter.AutoSize = true;
            this.Label_Filter.Location = new System.Drawing.Point(90, 280);
            this.Label_Filter.Name = "Label_Filter";
            this.Label_Filter.Size = new System.Drawing.Size(131, 25);
            this.Label_Filter.TabIndex = 14;
            this.Label_Filter.Text = "Filter Search ->";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filter Search ->";
            // 
            // Label_Ad1
            // 
            this.Label_Ad1.AutoSize = true;
            this.Label_Ad1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Ad1.ForeColor = System.Drawing.Color.Red;
            this.Label_Ad1.Location = new System.Drawing.Point(426, 168);
            this.Label_Ad1.Name = "Label_Ad1";
            this.Label_Ad1.Size = new System.Drawing.Size(600, 48);
            this.Label_Ad1.TabIndex = 16;
            this.Label_Ad1.Text = "We\'re Protecting The Future, Today...";
            // 
            // Form_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1416, 954);
            this.Controls.Add(this.Label_Ad1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Filter);
            this.Controls.Add(this.TextBox_FilterInstalledApps);
            this.Controls.Add(this.TextBox_ProcessFilter);
            this.Controls.Add(this.LinkLabel_Contact);
            this.Controls.Add(this.Label_LastOpenedApps);
            this.Controls.Add(this.ListBox_LastOpenedApps);
            this.Controls.Add(this.Button_ProcName);
            this.Controls.Add(this.Button_ProFullPath);
            this.Controls.Add(this.PictureBox_SpartaLogo);
            this.Controls.Add(this.Button_ProcRefresh);
            this.Controls.Add(this.Label_InstalledApplications);
            this.Controls.Add(this.ListBox_InstalledApps);
            this.Controls.Add(this.Label_BackgroundTasks);
            this.Controls.Add(this.ListBox_BackgroundProcs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1438, 1010);
            this.MinimumSize = new System.Drawing.Size(1438, 1010);
            this.Name = "Form_Interface";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparta_Project_v0";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_SpartaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox_BackgroundProcs;
        private System.Windows.Forms.Label Label_BackgroundTasks;
        private System.Windows.Forms.ListBox ListBox_InstalledApps;
        private System.Windows.Forms.Label Label_InstalledApplications;
        private System.Windows.Forms.Button Button_ProcRefresh;
        private System.Windows.Forms.PictureBox PictureBox_SpartaLogo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Button_ProFullPath;
        private System.Windows.Forms.Button Button_ProcName;
        private System.Windows.Forms.ListBox ListBox_LastOpenedApps;
        private System.Windows.Forms.Label Label_LastOpenedApps;
        private System.Windows.Forms.LinkLabel LinkLabel_Contact;
        private System.Windows.Forms.TextBox TextBox_ProcessFilter;
        private System.Windows.Forms.TextBox TextBox_FilterInstalledApps;
        private System.Windows.Forms.Label Label_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Ad1;
    }
}

