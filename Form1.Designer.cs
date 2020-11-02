namespace Radio_Internetowe
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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonRmf = new System.Windows.Forms.Button();
            this.buttonMaxx = new System.Windows.Forms.Button();
            this.buttonKrakow = new System.Windows.Forms.Button();
            this.buttonMansfield = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSmooth = new System.Windows.Forms.Button();
            this.buttonCapital = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(54, 91);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(53, 52);
            this.axWindowsMediaPlayer1.TabIndex = 2;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // buttonRmf
            // 
            this.buttonRmf.Location = new System.Drawing.Point(385, 191);
            this.buttonRmf.Name = "buttonRmf";
            this.buttonRmf.Size = new System.Drawing.Size(63, 23);
            this.buttonRmf.TabIndex = 5;
            this.buttonRmf.Text = "rmf fm";
            this.buttonRmf.UseVisualStyleBackColor = true;
            this.buttonRmf.Click += new System.EventHandler(this.buttonRmf_Click);
            // 
            // buttonMaxx
            // 
            this.buttonMaxx.Location = new System.Drawing.Point(451, 191);
            this.buttonMaxx.Name = "buttonMaxx";
            this.buttonMaxx.Size = new System.Drawing.Size(63, 23);
            this.buttonMaxx.TabIndex = 7;
            this.buttonMaxx.Text = "rmf maxx";
            this.buttonMaxx.UseVisualStyleBackColor = true;
            this.buttonMaxx.Click += new System.EventHandler(this.buttonMaxx_Click);
            // 
            // buttonKrakow
            // 
            this.buttonKrakow.Location = new System.Drawing.Point(385, 220);
            this.buttonKrakow.Name = "buttonKrakow";
            this.buttonKrakow.Size = new System.Drawing.Size(63, 23);
            this.buttonKrakow.TabIndex = 8;
            this.buttonKrakow.Text = "Kraków";
            this.buttonKrakow.UseVisualStyleBackColor = true;
            this.buttonKrakow.Click += new System.EventHandler(this.buttonKrakow_Click);
            // 
            // buttonMansfield
            // 
            this.buttonMansfield.Location = new System.Drawing.Point(451, 220);
            this.buttonMansfield.Name = "buttonMansfield";
            this.buttonMansfield.Size = new System.Drawing.Size(63, 23);
            this.buttonMansfield.TabIndex = 9;
            this.buttonMansfield.Text = "Mansfield";
            this.buttonMansfield.UseVisualStyleBackColor = true;
            this.buttonMansfield.Click += new System.EventHandler(this.buttonMansfield_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("OCR-B 10 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(385, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 58);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSmooth
            // 
            this.buttonSmooth.Location = new System.Drawing.Point(385, 249);
            this.buttonSmooth.Name = "buttonSmooth";
            this.buttonSmooth.Size = new System.Drawing.Size(63, 23);
            this.buttonSmooth.TabIndex = 12;
            this.buttonSmooth.Text = "Smooth";
            this.buttonSmooth.UseVisualStyleBackColor = true;
            this.buttonSmooth.Click += new System.EventHandler(this.buttonSmooth_Click);
            // 
            // buttonCapital
            // 
            this.buttonCapital.Location = new System.Drawing.Point(451, 249);
            this.buttonCapital.Name = "buttonCapital";
            this.buttonCapital.Size = new System.Drawing.Size(63, 23);
            this.buttonCapital.TabIndex = 13;
            this.buttonCapital.Text = "CapitalFM";
            this.buttonCapital.UseVisualStyleBackColor = true;
            this.buttonCapital.Click += new System.EventHandler(this.buttonCapital_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 387);
            this.Controls.Add(this.buttonCapital);
            this.Controls.Add(this.buttonSmooth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMansfield);
            this.Controls.Add(this.buttonKrakow);
            this.Controls.Add(this.buttonMaxx);
            this.Controls.Add(this.buttonRmf);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio internetowe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonRmf;
        private System.Windows.Forms.Button buttonMaxx;
        private System.Windows.Forms.Button buttonKrakow;
        private System.Windows.Forms.Button buttonMansfield;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSmooth;
        private System.Windows.Forms.Button buttonCapital;
    }
}

