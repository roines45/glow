namespace Glow.glow_tools
{
    partial class GlowHSAuditorTool
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
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Panel_IOMMU = new Glow.TSCustomPanel();
            this.PB_IOMMU = new System.Windows.Forms.PictureBox();
            this.Panel_IOMMU_Status = new Glow.TSCustomPanel();
            this.Label_IOMMU = new System.Windows.Forms.Label();
            this.Label_IOMMU_V = new System.Windows.Forms.Label();
            this.Panel_HVCI = new Glow.TSCustomPanel();
            this.PB_HVCI = new System.Windows.Forms.PictureBox();
            this.Panel_HVCI_Status = new Glow.TSCustomPanel();
            this.Label_HVCI = new System.Windows.Forms.Label();
            this.Label_HVCI_V = new System.Windows.Forms.Label();
            this.Panel_VBS = new Glow.TSCustomPanel();
            this.PB_VBS = new System.Windows.Forms.PictureBox();
            this.Panel_VBS_Status = new Glow.TSCustomPanel();
            this.Label_VBS = new System.Windows.Forms.Label();
            this.Label_VBS_V = new System.Windows.Forms.Label();
            this.Panel_TPM = new Glow.TSCustomPanel();
            this.PB_TPM = new System.Windows.Forms.PictureBox();
            this.Panel_TPM_Status = new Glow.TSCustomPanel();
            this.Label_TPM = new System.Windows.Forms.Label();
            this.Label_TPM_V = new System.Windows.Forms.Label();
            this.Panel_UEFISecureBoot = new Glow.TSCustomPanel();
            this.PB_UEFISecureBoot = new System.Windows.Forms.PictureBox();
            this.Panel_UEFISecureBoot_Status = new Glow.TSCustomPanel();
            this.Label_UEFISecureBoot = new System.Windows.Forms.Label();
            this.Label_UEFISecureBoot_V = new System.Windows.Forms.Label();
            this.Button_Check = new Glow.TSCustomButton();
            this.Panel_OS = new Glow.TSCustomPanel();
            this.PB_OS = new System.Windows.Forms.PictureBox();
            this.Panel_OS_Status = new Glow.TSCustomPanel();
            this.Label_OS = new System.Windows.Forms.Label();
            this.Label_OS_V = new System.Windows.Forms.Label();
            this.Button_Export = new Glow.TSCustomButton();
            this.Panel_IOMMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IOMMU)).BeginInit();
            this.Panel_HVCI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_HVCI)).BeginInit();
            this.Panel_VBS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VBS)).BeginInit();
            this.Panel_TPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TPM)).BeginInit();
            this.Panel_UEFISecureBoot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UEFISecureBoot)).BeginInit();
            this.Panel_OS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_OS)).BeginInit();
            this.SuspendLayout();
            // 
            // MainToolTip
            // 
            this.MainToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainToolTip.ForeColor = System.Drawing.Color.White;
            this.MainToolTip.OwnerDraw = true;
            this.MainToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MainToolTip_Draw);
            // 
            // Panel_IOMMU
            // 
            this.Panel_IOMMU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_IOMMU.BackColor = System.Drawing.Color.White;
            this.Panel_IOMMU.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_IOMMU.BorderRadius = 10;
            this.Panel_IOMMU.BorderSize = 0;
            this.Panel_IOMMU.Controls.Add(this.PB_IOMMU);
            this.Panel_IOMMU.Controls.Add(this.Panel_IOMMU_Status);
            this.Panel_IOMMU.Controls.Add(this.Label_IOMMU);
            this.Panel_IOMMU.Controls.Add(this.Label_IOMMU_V);
            this.Panel_IOMMU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_IOMMU.Location = new System.Drawing.Point(10, 360);
            this.Panel_IOMMU.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_IOMMU.Name = "Panel_IOMMU";
            this.Panel_IOMMU.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_IOMMU.Size = new System.Drawing.Size(539, 60);
            this.Panel_IOMMU.TabIndex = 5;
            this.Panel_IOMMU.DoubleClick += new System.EventHandler(this.Panel_IOMMU_DoubleClick);
            // 
            // PB_IOMMU
            // 
            this.PB_IOMMU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_IOMMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_IOMMU.Location = new System.Drawing.Point(504, 19);
            this.PB_IOMMU.Name = "PB_IOMMU";
            this.PB_IOMMU.Size = new System.Drawing.Size(22, 22);
            this.PB_IOMMU.TabIndex = 1;
            this.PB_IOMMU.TabStop = false;
            // 
            // Panel_IOMMU_Status
            // 
            this.Panel_IOMMU_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_IOMMU_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_IOMMU_Status.BorderRadius = 3;
            this.Panel_IOMMU_Status.BorderSize = 0;
            this.Panel_IOMMU_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_IOMMU_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_IOMMU_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_IOMMU_Status.Name = "Panel_IOMMU_Status";
            this.Panel_IOMMU_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_IOMMU_Status.TabIndex = 0;
            // 
            // Label_IOMMU
            // 
            this.Label_IOMMU.AutoSize = true;
            this.Label_IOMMU.BackColor = System.Drawing.Color.Transparent;
            this.Label_IOMMU.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_IOMMU.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_IOMMU.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_IOMMU.Location = new System.Drawing.Point(16, 10);
            this.Label_IOMMU.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_IOMMU.Name = "Label_IOMMU";
            this.Label_IOMMU.Size = new System.Drawing.Size(60, 19);
            this.Label_IOMMU.TabIndex = 1;
            this.Label_IOMMU.Text = "IOMMU";
            // 
            // Label_IOMMU_V
            // 
            this.Label_IOMMU_V.AutoSize = true;
            this.Label_IOMMU_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_IOMMU_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_IOMMU_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_IOMMU_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_IOMMU_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_IOMMU_V.Location = new System.Drawing.Point(16, 31);
            this.Label_IOMMU_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_IOMMU_V.Name = "Label_IOMMU_V";
            this.Label_IOMMU_V.Size = new System.Drawing.Size(35, 19);
            this.Label_IOMMU_V.TabIndex = 2;
            this.Label_IOMMU_V.Text = "N/A";
            this.Label_IOMMU_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_HVCI
            // 
            this.Panel_HVCI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_HVCI.BackColor = System.Drawing.Color.White;
            this.Panel_HVCI.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_HVCI.BorderRadius = 10;
            this.Panel_HVCI.BorderSize = 0;
            this.Panel_HVCI.Controls.Add(this.PB_HVCI);
            this.Panel_HVCI.Controls.Add(this.Panel_HVCI_Status);
            this.Panel_HVCI.Controls.Add(this.Label_HVCI);
            this.Panel_HVCI.Controls.Add(this.Label_HVCI_V);
            this.Panel_HVCI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_HVCI.Location = new System.Drawing.Point(10, 290);
            this.Panel_HVCI.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_HVCI.Name = "Panel_HVCI";
            this.Panel_HVCI.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_HVCI.Size = new System.Drawing.Size(539, 60);
            this.Panel_HVCI.TabIndex = 4;
            this.Panel_HVCI.DoubleClick += new System.EventHandler(this.Panel_HVCI_DoubleClick);
            // 
            // PB_HVCI
            // 
            this.PB_HVCI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_HVCI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_HVCI.Location = new System.Drawing.Point(504, 19);
            this.PB_HVCI.Name = "PB_HVCI";
            this.PB_HVCI.Size = new System.Drawing.Size(22, 22);
            this.PB_HVCI.TabIndex = 1;
            this.PB_HVCI.TabStop = false;
            // 
            // Panel_HVCI_Status
            // 
            this.Panel_HVCI_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_HVCI_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_HVCI_Status.BorderRadius = 3;
            this.Panel_HVCI_Status.BorderSize = 0;
            this.Panel_HVCI_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_HVCI_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_HVCI_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_HVCI_Status.Name = "Panel_HVCI_Status";
            this.Panel_HVCI_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_HVCI_Status.TabIndex = 0;
            // 
            // Label_HVCI
            // 
            this.Label_HVCI.AutoSize = true;
            this.Label_HVCI.BackColor = System.Drawing.Color.Transparent;
            this.Label_HVCI.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_HVCI.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_HVCI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_HVCI.Location = new System.Drawing.Point(16, 10);
            this.Label_HVCI.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_HVCI.Name = "Label_HVCI";
            this.Label_HVCI.Size = new System.Drawing.Size(41, 19);
            this.Label_HVCI.TabIndex = 1;
            this.Label_HVCI.Text = "HVCI";
            // 
            // Label_HVCI_V
            // 
            this.Label_HVCI_V.AutoSize = true;
            this.Label_HVCI_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_HVCI_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_HVCI_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_HVCI_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_HVCI_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_HVCI_V.Location = new System.Drawing.Point(16, 31);
            this.Label_HVCI_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_HVCI_V.Name = "Label_HVCI_V";
            this.Label_HVCI_V.Size = new System.Drawing.Size(35, 19);
            this.Label_HVCI_V.TabIndex = 2;
            this.Label_HVCI_V.Text = "N/A";
            this.Label_HVCI_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_VBS
            // 
            this.Panel_VBS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_VBS.BackColor = System.Drawing.Color.White;
            this.Panel_VBS.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_VBS.BorderRadius = 10;
            this.Panel_VBS.BorderSize = 0;
            this.Panel_VBS.Controls.Add(this.PB_VBS);
            this.Panel_VBS.Controls.Add(this.Panel_VBS_Status);
            this.Panel_VBS.Controls.Add(this.Label_VBS);
            this.Panel_VBS.Controls.Add(this.Label_VBS_V);
            this.Panel_VBS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_VBS.Location = new System.Drawing.Point(10, 220);
            this.Panel_VBS.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_VBS.Name = "Panel_VBS";
            this.Panel_VBS.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_VBS.Size = new System.Drawing.Size(539, 60);
            this.Panel_VBS.TabIndex = 3;
            this.Panel_VBS.DoubleClick += new System.EventHandler(this.Panel_VBS_DoubleClick);
            // 
            // PB_VBS
            // 
            this.PB_VBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_VBS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_VBS.Location = new System.Drawing.Point(504, 19);
            this.PB_VBS.Name = "PB_VBS";
            this.PB_VBS.Size = new System.Drawing.Size(22, 22);
            this.PB_VBS.TabIndex = 1;
            this.PB_VBS.TabStop = false;
            // 
            // Panel_VBS_Status
            // 
            this.Panel_VBS_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_VBS_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_VBS_Status.BorderRadius = 3;
            this.Panel_VBS_Status.BorderSize = 0;
            this.Panel_VBS_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_VBS_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_VBS_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_VBS_Status.Name = "Panel_VBS_Status";
            this.Panel_VBS_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_VBS_Status.TabIndex = 0;
            // 
            // Label_VBS
            // 
            this.Label_VBS.AutoSize = true;
            this.Label_VBS.BackColor = System.Drawing.Color.Transparent;
            this.Label_VBS.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_VBS.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_VBS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_VBS.Location = new System.Drawing.Point(16, 10);
            this.Label_VBS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_VBS.Name = "Label_VBS";
            this.Label_VBS.Size = new System.Drawing.Size(34, 19);
            this.Label_VBS.TabIndex = 1;
            this.Label_VBS.Text = "VBS";
            // 
            // Label_VBS_V
            // 
            this.Label_VBS_V.AutoSize = true;
            this.Label_VBS_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_VBS_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_VBS_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_VBS_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_VBS_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_VBS_V.Location = new System.Drawing.Point(16, 31);
            this.Label_VBS_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_VBS_V.Name = "Label_VBS_V";
            this.Label_VBS_V.Size = new System.Drawing.Size(35, 19);
            this.Label_VBS_V.TabIndex = 2;
            this.Label_VBS_V.Text = "N/A";
            this.Label_VBS_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_TPM
            // 
            this.Panel_TPM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_TPM.BackColor = System.Drawing.Color.White;
            this.Panel_TPM.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_TPM.BorderRadius = 10;
            this.Panel_TPM.BorderSize = 0;
            this.Panel_TPM.Controls.Add(this.PB_TPM);
            this.Panel_TPM.Controls.Add(this.Panel_TPM_Status);
            this.Panel_TPM.Controls.Add(this.Label_TPM);
            this.Panel_TPM.Controls.Add(this.Label_TPM_V);
            this.Panel_TPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_TPM.Location = new System.Drawing.Point(10, 150);
            this.Panel_TPM.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_TPM.Name = "Panel_TPM";
            this.Panel_TPM.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_TPM.Size = new System.Drawing.Size(539, 60);
            this.Panel_TPM.TabIndex = 2;
            this.Panel_TPM.DoubleClick += new System.EventHandler(this.Panel_TPM_DoubleClick);
            // 
            // PB_TPM
            // 
            this.PB_TPM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_TPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_TPM.Location = new System.Drawing.Point(504, 19);
            this.PB_TPM.Name = "PB_TPM";
            this.PB_TPM.Size = new System.Drawing.Size(22, 22);
            this.PB_TPM.TabIndex = 1;
            this.PB_TPM.TabStop = false;
            // 
            // Panel_TPM_Status
            // 
            this.Panel_TPM_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_TPM_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_TPM_Status.BorderRadius = 3;
            this.Panel_TPM_Status.BorderSize = 0;
            this.Panel_TPM_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_TPM_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_TPM_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_TPM_Status.Name = "Panel_TPM_Status";
            this.Panel_TPM_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_TPM_Status.TabIndex = 0;
            // 
            // Label_TPM
            // 
            this.Label_TPM.AutoSize = true;
            this.Label_TPM.BackColor = System.Drawing.Color.Transparent;
            this.Label_TPM.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_TPM.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_TPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_TPM.Location = new System.Drawing.Point(16, 10);
            this.Label_TPM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_TPM.Name = "Label_TPM";
            this.Label_TPM.Size = new System.Drawing.Size(38, 19);
            this.Label_TPM.TabIndex = 1;
            this.Label_TPM.Text = "TPM";
            // 
            // Label_TPM_V
            // 
            this.Label_TPM_V.AutoSize = true;
            this.Label_TPM_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_TPM_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_TPM_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_TPM_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_TPM_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_TPM_V.Location = new System.Drawing.Point(16, 31);
            this.Label_TPM_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_TPM_V.Name = "Label_TPM_V";
            this.Label_TPM_V.Size = new System.Drawing.Size(35, 19);
            this.Label_TPM_V.TabIndex = 2;
            this.Label_TPM_V.Text = "N/A";
            this.Label_TPM_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_UEFISecureBoot
            // 
            this.Panel_UEFISecureBoot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_UEFISecureBoot.BackColor = System.Drawing.Color.White;
            this.Panel_UEFISecureBoot.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_UEFISecureBoot.BorderRadius = 10;
            this.Panel_UEFISecureBoot.BorderSize = 0;
            this.Panel_UEFISecureBoot.Controls.Add(this.PB_UEFISecureBoot);
            this.Panel_UEFISecureBoot.Controls.Add(this.Panel_UEFISecureBoot_Status);
            this.Panel_UEFISecureBoot.Controls.Add(this.Label_UEFISecureBoot);
            this.Panel_UEFISecureBoot.Controls.Add(this.Label_UEFISecureBoot_V);
            this.Panel_UEFISecureBoot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_UEFISecureBoot.Location = new System.Drawing.Point(10, 80);
            this.Panel_UEFISecureBoot.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_UEFISecureBoot.Name = "Panel_UEFISecureBoot";
            this.Panel_UEFISecureBoot.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_UEFISecureBoot.Size = new System.Drawing.Size(539, 60);
            this.Panel_UEFISecureBoot.TabIndex = 1;
            this.Panel_UEFISecureBoot.DoubleClick += new System.EventHandler(this.Panel_UEFISecureBoot_DoubleClick);
            // 
            // PB_UEFISecureBoot
            // 
            this.PB_UEFISecureBoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_UEFISecureBoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_UEFISecureBoot.Location = new System.Drawing.Point(504, 19);
            this.PB_UEFISecureBoot.Name = "PB_UEFISecureBoot";
            this.PB_UEFISecureBoot.Size = new System.Drawing.Size(22, 22);
            this.PB_UEFISecureBoot.TabIndex = 1;
            this.PB_UEFISecureBoot.TabStop = false;
            // 
            // Panel_UEFISecureBoot_Status
            // 
            this.Panel_UEFISecureBoot_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_UEFISecureBoot_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_UEFISecureBoot_Status.BorderRadius = 3;
            this.Panel_UEFISecureBoot_Status.BorderSize = 0;
            this.Panel_UEFISecureBoot_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_UEFISecureBoot_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_UEFISecureBoot_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_UEFISecureBoot_Status.Name = "Panel_UEFISecureBoot_Status";
            this.Panel_UEFISecureBoot_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_UEFISecureBoot_Status.TabIndex = 0;
            // 
            // Label_UEFISecureBoot
            // 
            this.Label_UEFISecureBoot.AutoSize = true;
            this.Label_UEFISecureBoot.BackColor = System.Drawing.Color.Transparent;
            this.Label_UEFISecureBoot.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_UEFISecureBoot.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_UEFISecureBoot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_UEFISecureBoot.Location = new System.Drawing.Point(16, 10);
            this.Label_UEFISecureBoot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_UEFISecureBoot.Name = "Label_UEFISecureBoot";
            this.Label_UEFISecureBoot.Size = new System.Drawing.Size(116, 19);
            this.Label_UEFISecureBoot.TabIndex = 1;
            this.Label_UEFISecureBoot.Text = "UEFI Secure Boot";
            // 
            // Label_UEFISecureBoot_V
            // 
            this.Label_UEFISecureBoot_V.AutoSize = true;
            this.Label_UEFISecureBoot_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_UEFISecureBoot_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_UEFISecureBoot_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_UEFISecureBoot_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_UEFISecureBoot_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_UEFISecureBoot_V.Location = new System.Drawing.Point(16, 31);
            this.Label_UEFISecureBoot_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_UEFISecureBoot_V.Name = "Label_UEFISecureBoot_V";
            this.Label_UEFISecureBoot_V.Size = new System.Drawing.Size(35, 19);
            this.Label_UEFISecureBoot_V.TabIndex = 2;
            this.Label_UEFISecureBoot_V.Text = "N/A";
            this.Label_UEFISecureBoot_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Check
            // 
            this.Button_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Button_Check.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Button_Check.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button_Check.BorderRadius = 10;
            this.Button_Check.BorderSize = 0;
            this.Button_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Check.FlatAppearance.BorderSize = 0;
            this.Button_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Check.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.Button_Check.ForeColor = System.Drawing.Color.White;
            this.Button_Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Check.Location = new System.Drawing.Point(10, 430);
            this.Button_Check.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Button_Check.Name = "Button_Check";
            this.Button_Check.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Button_Check.Size = new System.Drawing.Size(539, 37);
            this.Button_Check.TabIndex = 6;
            this.Button_Check.Text = "Check";
            this.Button_Check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Check.TextColor = System.Drawing.Color.White;
            this.Button_Check.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Check.UseVisualStyleBackColor = false;
            this.Button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // Panel_OS
            // 
            this.Panel_OS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_OS.BackColor = System.Drawing.Color.White;
            this.Panel_OS.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_OS.BorderRadius = 10;
            this.Panel_OS.BorderSize = 0;
            this.Panel_OS.Controls.Add(this.PB_OS);
            this.Panel_OS.Controls.Add(this.Panel_OS_Status);
            this.Panel_OS.Controls.Add(this.Label_OS);
            this.Panel_OS.Controls.Add(this.Label_OS_V);
            this.Panel_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_OS.Location = new System.Drawing.Point(10, 10);
            this.Panel_OS.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Panel_OS.Name = "Panel_OS";
            this.Panel_OS.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Panel_OS.Size = new System.Drawing.Size(539, 60);
            this.Panel_OS.TabIndex = 0;
            this.Panel_OS.DoubleClick += new System.EventHandler(this.Panel_OS_DoubleClick);
            // 
            // PB_OS
            // 
            this.PB_OS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_OS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PB_OS.Location = new System.Drawing.Point(504, 19);
            this.PB_OS.Name = "PB_OS";
            this.PB_OS.Size = new System.Drawing.Size(22, 22);
            this.PB_OS.TabIndex = 1;
            this.PB_OS.TabStop = false;
            // 
            // Panel_OS_Status
            // 
            this.Panel_OS_Status.BackColor = System.Drawing.Color.Green;
            this.Panel_OS_Status.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Panel_OS_Status.BorderRadius = 3;
            this.Panel_OS_Status.BorderSize = 0;
            this.Panel_OS_Status.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_OS_Status.Location = new System.Drawing.Point(0, 10);
            this.Panel_OS_Status.Margin = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Panel_OS_Status.Name = "Panel_OS_Status";
            this.Panel_OS_Status.Size = new System.Drawing.Size(6, 40);
            this.Panel_OS_Status.TabIndex = 0;
            // 
            // Label_OS
            // 
            this.Label_OS.AutoSize = true;
            this.Label_OS.BackColor = System.Drawing.Color.Transparent;
            this.Label_OS.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_OS.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_OS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_OS.Location = new System.Drawing.Point(16, 10);
            this.Label_OS.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.Label_OS.Name = "Label_OS";
            this.Label_OS.Size = new System.Drawing.Size(121, 19);
            this.Label_OS.TabIndex = 1;
            this.Label_OS.Text = "Operating System";
            // 
            // Label_OS_V
            // 
            this.Label_OS_V.AutoSize = true;
            this.Label_OS_V.BackColor = System.Drawing.Color.Transparent;
            this.Label_OS_V.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_OS_V.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.Label_OS_V.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Label_OS_V.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Label_OS_V.Location = new System.Drawing.Point(16, 31);
            this.Label_OS_V.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.Label_OS_V.Name = "Label_OS_V";
            this.Label_OS_V.Size = new System.Drawing.Size(35, 19);
            this.Label_OS_V.TabIndex = 2;
            this.Label_OS_V.Text = "N/A";
            this.Label_OS_V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Export
            // 
            this.Button_Export.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Button_Export.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(95)))), ((int)(((byte)(146)))));
            this.Button_Export.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Button_Export.BorderRadius = 10;
            this.Button_Export.BorderSize = 0;
            this.Button_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Export.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Export.FlatAppearance.BorderSize = 0;
            this.Button_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Export.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.Button_Export.ForeColor = System.Drawing.Color.White;
            this.Button_Export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Export.Location = new System.Drawing.Point(10, 477);
            this.Button_Export.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Button_Export.Name = "Button_Export";
            this.Button_Export.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Button_Export.Size = new System.Drawing.Size(539, 37);
            this.Button_Export.TabIndex = 7;
            this.Button_Export.Text = "Export";
            this.Button_Export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Export.TextColor = System.Drawing.Color.White;
            this.Button_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_Export.UseVisualStyleBackColor = false;
            this.Button_Export.Click += new System.EventHandler(this.Button_Export_Click);
            // 
            // GlowHSAuditorTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(559, 524);
            this.Controls.Add(this.Button_Export);
            this.Controls.Add(this.Panel_IOMMU);
            this.Controls.Add(this.Panel_HVCI);
            this.Controls.Add(this.Panel_VBS);
            this.Controls.Add(this.Panel_TPM);
            this.Controls.Add(this.Panel_UEFISecureBoot);
            this.Controls.Add(this.Button_Check);
            this.Controls.Add(this.Panel_OS);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::Glow.Properties.Resources.GlowLogo;
            this.MaximizeBox = false;
            this.Name = "GlowHSAuditorTool";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlowHSAuditorTool";
            this.Load += new System.EventHandler(this.GlowHSAuditorTool_Load);
            this.Panel_IOMMU.ResumeLayout(false);
            this.Panel_IOMMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IOMMU)).EndInit();
            this.Panel_HVCI.ResumeLayout(false);
            this.Panel_HVCI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_HVCI)).EndInit();
            this.Panel_VBS.ResumeLayout(false);
            this.Panel_VBS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VBS)).EndInit();
            this.Panel_TPM.ResumeLayout(false);
            this.Panel_TPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TPM)).EndInit();
            this.Panel_UEFISecureBoot.ResumeLayout(false);
            this.Panel_UEFISecureBoot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_UEFISecureBoot)).EndInit();
            this.Panel_OS.ResumeLayout(false);
            this.Panel_OS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_OS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TSCustomPanel Panel_OS;
        internal System.Windows.Forms.Label Label_OS;
        internal System.Windows.Forms.Label Label_OS_V;
        private TSCustomPanel Panel_OS_Status;
        private System.Windows.Forms.PictureBox PB_OS;
        private TSCustomButton Button_Check;
        private TSCustomPanel Panel_UEFISecureBoot;
        private System.Windows.Forms.PictureBox PB_UEFISecureBoot;
        private TSCustomPanel Panel_UEFISecureBoot_Status;
        internal System.Windows.Forms.Label Label_UEFISecureBoot;
        internal System.Windows.Forms.Label Label_UEFISecureBoot_V;
        private TSCustomPanel Panel_TPM;
        private System.Windows.Forms.PictureBox PB_TPM;
        private TSCustomPanel Panel_TPM_Status;
        internal System.Windows.Forms.Label Label_TPM;
        internal System.Windows.Forms.Label Label_TPM_V;
        private TSCustomPanel Panel_VBS;
        private System.Windows.Forms.PictureBox PB_VBS;
        private TSCustomPanel Panel_VBS_Status;
        internal System.Windows.Forms.Label Label_VBS;
        internal System.Windows.Forms.Label Label_VBS_V;
        private TSCustomPanel Panel_HVCI;
        private System.Windows.Forms.PictureBox PB_HVCI;
        private TSCustomPanel Panel_HVCI_Status;
        internal System.Windows.Forms.Label Label_HVCI;
        internal System.Windows.Forms.Label Label_HVCI_V;
        private TSCustomPanel Panel_IOMMU;
        private System.Windows.Forms.PictureBox PB_IOMMU;
        private TSCustomPanel Panel_IOMMU_Status;
        internal System.Windows.Forms.Label Label_IOMMU;
        internal System.Windows.Forms.Label Label_IOMMU_V;
        private System.Windows.Forms.ToolTip MainToolTip;
        private TSCustomButton Button_Export;
    }
}