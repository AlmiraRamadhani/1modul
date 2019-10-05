namespace Modul1
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
            this.pbInput = new System.Windows.Forms.PictureBox();
            this.pbOutput = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpanSebagaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarAplikasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligthnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessAndContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbInput
            // 
            this.pbInput.Location = new System.Drawing.Point(12, 39);
            this.pbInput.Name = "pbInput";
            this.pbInput.Size = new System.Drawing.Size(500, 350);
            this.pbInput.TabIndex = 0;
            this.pbInput.TabStop = false;
            // 
            // pbOutput
            // 
            this.pbOutput.Location = new System.Drawing.Point(518, 39);
            this.pbOutput.Name = "pbOutput";
            this.pbOutput.Size = new System.Drawing.Size(500, 350);
            this.pbOutput.TabIndex = 1;
            this.pbOutput.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.brightnessToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bukaToolStripMenuItem,
            this.simpanSebagaiToolStripMenuItem,
            this.keluarAplikasiToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // bukaToolStripMenuItem
            // 
            this.bukaToolStripMenuItem.Name = "bukaToolStripMenuItem";
            this.bukaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bukaToolStripMenuItem.Text = "Buka";
            this.bukaToolStripMenuItem.Click += new System.EventHandler(this.BukaToolStripMenuItem_Click);
            // 
            // simpanSebagaiToolStripMenuItem
            // 
            this.simpanSebagaiToolStripMenuItem.Name = "simpanSebagaiToolStripMenuItem";
            this.simpanSebagaiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.simpanSebagaiToolStripMenuItem.Text = "Simpan Sebagai";
            this.simpanSebagaiToolStripMenuItem.Click += new System.EventHandler(this.SimpanSebagaiToolStripMenuItem_Click);
            // 
            // keluarAplikasiToolStripMenuItem
            // 
            this.keluarAplikasiToolStripMenuItem.Name = "keluarAplikasiToolStripMenuItem";
            this.keluarAplikasiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.keluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi";
            this.keluarAplikasiToolStripMenuItem.Click += new System.EventHandler(this.KeluarAplikasiToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greyScaleToolStripMenuItem,
            this.brightnessAndContrastToolStripMenuItem});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.colourToolStripMenuItem.Text = "Colors";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.ColourToolStripMenuItem_Click);
            // 
            // greyScaleToolStripMenuItem
            // 
            this.greyScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageToolStripMenuItem,
            this.ligthnessToolStripMenuItem,
            this.luminanceToolStripMenuItem});
            this.greyScaleToolStripMenuItem.Name = "greyScaleToolStripMenuItem";
            this.greyScaleToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.greyScaleToolStripMenuItem.Text = "GreyScale";
            // 
            // averageToolStripMenuItem
            // 
            this.averageToolStripMenuItem.Name = "averageToolStripMenuItem";
            this.averageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.averageToolStripMenuItem.Text = "Average";
            // 
            // ligthnessToolStripMenuItem
            // 
            this.ligthnessToolStripMenuItem.Name = "ligthnessToolStripMenuItem";
            this.ligthnessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ligthnessToolStripMenuItem.Text = "Ligthness";
            // 
            // luminanceToolStripMenuItem
            // 
            this.luminanceToolStripMenuItem.Name = "luminanceToolStripMenuItem";
            this.luminanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.luminanceToolStripMenuItem.Text = "Luminance";
            // 
            // brightnessAndContrastToolStripMenuItem
            // 
            this.brightnessAndContrastToolStripMenuItem.Name = "brightnessAndContrastToolStripMenuItem";
            this.brightnessAndContrastToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.brightnessAndContrastToolStripMenuItem.Text = "Brightness and Contrast";
            this.brightnessAndContrastToolStripMenuItem.Click += new System.EventHandler(this.BrightnessAndContrastToolStripMenuItem_Click);
            // 
            // brightnessToolStripMenuItem
            // 
            this.brightnessToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contrastToolStripMenuItem});
            this.brightnessToolStripMenuItem.Name = "brightnessToolStripMenuItem";
            this.brightnessToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.brightnessToolStripMenuItem.Text = "Brightness";
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.ContrastToolStripMenuItem_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(417, 426);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(328, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbOutput);
            this.Controls.Add(this.pbInput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Garuda Image Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pbInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutput)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbInput;
        private System.Windows.Forms.PictureBox pbOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpanSebagaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarAplikasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligthnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessAndContrastToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

