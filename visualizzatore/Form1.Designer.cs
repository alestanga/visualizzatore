namespace visualizzatore
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
            this.textRicerca = new System.Windows.Forms.TextBox();
            this.pictureImaggine = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dwgbox = new AxACCTRLLib.AxAcCtrl();
            this.loadingPicture = new System.Windows.Forms.PictureBox();
            this.labelerrore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImaggine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwgbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // textRicerca
            // 
            this.textRicerca.Dock = System.Windows.Forms.DockStyle.Top;
            this.textRicerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRicerca.Location = new System.Drawing.Point(0, 0);
            this.textRicerca.Name = "textRicerca";
            this.textRicerca.Size = new System.Drawing.Size(1082, 47);
            this.textRicerca.TabIndex = 4;
            this.textRicerca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRicerca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRicerca_KeyPress_1);
            // 
            // pictureImaggine
            // 
            this.pictureImaggine.Location = new System.Drawing.Point(357, 57);
            this.pictureImaggine.Name = "pictureImaggine";
            this.pictureImaggine.Size = new System.Drawing.Size(312, 206);
            this.pictureImaggine.TabIndex = 5;
            this.pictureImaggine.TabStop = false;
            this.pictureImaggine.Visible = false;
            // 
            // dwgbox
            // 
            this.dwgbox.Enabled = true;
            this.dwgbox.Location = new System.Drawing.Point(22, 57);
            this.dwgbox.Name = "dwgbox";
            this.dwgbox.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("dwgbox.OcxState")));
            this.dwgbox.Size = new System.Drawing.Size(329, 206);
            this.dwgbox.TabIndex = 6;
            this.dwgbox.Visible = false;
            // 
            // loadingPicture
            // 
            this.loadingPicture.Location = new System.Drawing.Point(22, 269);
            this.loadingPicture.Name = "loadingPicture";
            this.loadingPicture.Size = new System.Drawing.Size(426, 217);
            this.loadingPicture.TabIndex = 7;
            this.loadingPicture.TabStop = false;
            this.loadingPicture.Visible = false;
            // 
            // labelerrore
            // 
            this.labelerrore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerrore.ForeColor = System.Drawing.Color.Red;
            this.labelerrore.Location = new System.Drawing.Point(308, 328);
            this.labelerrore.Name = "labelerrore";
            this.labelerrore.Size = new System.Drawing.Size(662, 71);
            this.labelerrore.TabIndex = 8;
            this.labelerrore.Text = "CODICE NON TROVATO";
            this.labelerrore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelerrore.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 757);
            this.Controls.Add(this.labelerrore);
            this.Controls.Add(this.loadingPicture);
            this.Controls.Add(this.dwgbox);
            this.Controls.Add(this.pictureImaggine);
            this.Controls.Add(this.textRicerca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizzatore";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureImaggine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dwgbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textRicerca;
        private System.Windows.Forms.PictureBox pictureImaggine;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxACCTRLLib.AxAcCtrl dwgbox;
        private System.Windows.Forms.PictureBox loadingPicture;
        private System.Windows.Forms.Label labelerrore;

    }
}

