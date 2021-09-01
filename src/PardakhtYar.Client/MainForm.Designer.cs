
namespace PardakhtYar.Client
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Pages = new System.Windows.Forms.TabControl();
            this.tabShaparak = new System.Windows.Forms.TabPage();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.Pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pages
            // 
            this.Pages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pages.Controls.Add(this.tabShaparak);
            this.Pages.Location = new System.Drawing.Point(12, 12);
            this.Pages.Name = "Pages";
            this.Pages.SelectedIndex = 0;
            this.Pages.Size = new System.Drawing.Size(910, 526);
            this.Pages.TabIndex = 0;
            // 
            // tabShaparak
            // 
            this.tabShaparak.Location = new System.Drawing.Point(4, 24);
            this.tabShaparak.Name = "tabShaparak";
            this.tabShaparak.Padding = new System.Windows.Forms.Padding(3);
            this.tabShaparak.Size = new System.Drawing.Size(902, 498);
            this.tabShaparak.TabIndex = 0;
            this.tabShaparak.Text = "Shaparak";
            this.tabShaparak.UseVisualStyleBackColor = true;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 541);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(924, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 563);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.Pages);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MainForm";
            this.Text = "PardakhtYar Client";
            this.Pages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl Pages;
        private System.Windows.Forms.TabPage tabShaparak;
        private System.Windows.Forms.StatusStrip statusBar;
    }
}

