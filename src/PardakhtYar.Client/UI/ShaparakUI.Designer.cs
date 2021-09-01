
namespace PardakhtYar.Client.UI
{
    partial class ShaparakUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShaparakUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShaparakSend = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShaparakBaseUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabShaparakBody = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtShaparakBody = new FastColoredTextBoxNS.FastColoredTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtShaparakResponse = new FastColoredTextBoxNS.FastColoredTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnShaprakMenu = new System.Windows.Forms.Button();
            this.menuServices = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLoadSampleJson = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMethods = new System.Windows.Forms.ComboBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabShaparakBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShaparakBody)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtShaparakResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShaparakSend);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtShaparakBaseUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // btnShaparakSend
            // 
            this.btnShaparakSend.Location = new System.Drawing.Point(510, 42);
            this.btnShaparakSend.Name = "btnShaparakSend";
            this.btnShaparakSend.Size = new System.Drawing.Size(93, 33);
            this.btnShaparakSend.TabIndex = 2;
            this.btnShaparakSend.Text = "&Send";
            this.btnShaparakSend.UseVisualStyleBackColor = true;
            this.btnShaparakSend.Click += new System.EventHandler(this.btnShaparakSend_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(343, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(126, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(343, 23);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Username :";
            // 
            // txtShaparakBaseUrl
            // 
            this.txtShaparakBaseUrl.Location = new System.Drawing.Point(126, 42);
            this.txtShaparakBaseUrl.Name = "txtShaparakBaseUrl";
            this.txtShaparakBaseUrl.Size = new System.Drawing.Size(343, 23);
            this.txtShaparakBaseUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Base URL :";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabShaparakBody);
            this.tabControl2.Location = new System.Drawing.Point(0, 265);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(841, 251);
            this.tabControl2.TabIndex = 3;
            // 
            // tabShaparakBody
            // 
            this.tabShaparakBody.Controls.Add(this.splitContainer1);
            this.tabShaparakBody.Location = new System.Drawing.Point(4, 24);
            this.tabShaparakBody.Name = "tabShaparakBody";
            this.tabShaparakBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabShaparakBody.Size = new System.Drawing.Size(833, 223);
            this.tabShaparakBody.TabIndex = 0;
            this.tabShaparakBody.Text = "Request";
            this.tabShaparakBody.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(827, 217);
            this.splitContainer1.SplitterDistance = 377;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtShaparakBody);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 217);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Body";
            // 
            // txtShaparakBody
            // 
            this.txtShaparakBody.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtShaparakBody.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtShaparakBody.BackBrush = null;
            this.txtShaparakBody.CharHeight = 14;
            this.txtShaparakBody.CharWidth = 8;
            this.txtShaparakBody.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShaparakBody.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtShaparakBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShaparakBody.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtShaparakBody.IsReplaceMode = false;
            this.txtShaparakBody.Location = new System.Drawing.Point(3, 19);
            this.txtShaparakBody.Name = "txtShaparakBody";
            this.txtShaparakBody.Paddings = new System.Windows.Forms.Padding(0);
            this.txtShaparakBody.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtShaparakBody.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtShaparakBody.ServiceColors")));
            this.txtShaparakBody.Size = new System.Drawing.Size(371, 195);
            this.txtShaparakBody.TabIndex = 0;
            this.txtShaparakBody.Zoom = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtShaparakResponse);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 217);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response";
            // 
            // txtShaparakResponse
            // 
            this.txtShaparakResponse.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtShaparakResponse.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.txtShaparakResponse.BackBrush = null;
            this.txtShaparakResponse.CharHeight = 14;
            this.txtShaparakResponse.CharWidth = 8;
            this.txtShaparakResponse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShaparakResponse.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtShaparakResponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShaparakResponse.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtShaparakResponse.IsReplaceMode = false;
            this.txtShaparakResponse.Location = new System.Drawing.Point(3, 19);
            this.txtShaparakResponse.Name = "txtShaparakResponse";
            this.txtShaparakResponse.Paddings = new System.Windows.Forms.Padding(0);
            this.txtShaparakResponse.ReadOnly = true;
            this.txtShaparakResponse.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtShaparakResponse.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtShaparakResponse.ServiceColors")));
            this.txtShaparakResponse.Size = new System.Drawing.Size(439, 195);
            this.txtShaparakResponse.TabIndex = 1;
            this.txtShaparakResponse.Zoom = 100;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnShaprakMenu);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cboMethods);
            this.groupBox4.Location = new System.Drawing.Point(3, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(838, 93);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Services";
            // 
            // btnShaprakMenu
            // 
            this.btnShaprakMenu.ContextMenuStrip = this.menuServices;
            this.btnShaprakMenu.Location = new System.Drawing.Point(123, 51);
            this.btnShaprakMenu.Name = "btnShaprakMenu";
            this.btnShaprakMenu.Size = new System.Drawing.Size(75, 23);
            this.btnShaprakMenu.TabIndex = 2;
            this.btnShaprakMenu.Text = "&Menu";
            this.btnShaprakMenu.UseVisualStyleBackColor = true;
            this.btnShaprakMenu.Click += new System.EventHandler(this.btnShaprakMenu_Click);
            // 
            // menuServices
            // 
            this.menuServices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoadSampleJson});
            this.menuServices.Name = "menuServices";
            this.menuServices.Size = new System.Drawing.Size(222, 26);
            // 
            // mnuLoadSampleJson
            // 
            this.mnuLoadSampleJson.Name = "mnuLoadSampleJson";
            this.mnuLoadSampleJson.Size = new System.Drawing.Size(221, 22);
            this.mnuLoadSampleJson.Text = "Load Method\'s Sample Json";
            this.mnuLoadSampleJson.Click += new System.EventHandler(this.mnuLoadSampleJson_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Method :";
            // 
            // cboMethods
            // 
            this.cboMethods.FormattingEnabled = true;
            this.cboMethods.Location = new System.Drawing.Point(123, 22);
            this.cboMethods.Name = "cboMethods";
            this.cboMethods.Size = new System.Drawing.Size(343, 23);
            this.cboMethods.TabIndex = 0;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // ShaparakUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "ShaparakUI";
            this.Size = new System.Drawing.Size(841, 516);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabShaparakBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShaparakBody)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtShaparakResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuServices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShaparakSend;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShaparakBaseUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabShaparakBody;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FastColoredTextBoxNS.FastColoredTextBox txtShaparakBody;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMethods;
        private System.Windows.Forms.Button btnShaprakMenu;
        private System.Windows.Forms.ContextMenuStrip menuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuLoadSampleJson;
        private FastColoredTextBoxNS.FastColoredTextBox txtShaparakResponse;
    }
}
