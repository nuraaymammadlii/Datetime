namespace WinFormsApp4
{
    partial class Form1
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
            this.baku_button = new System.Windows.Forms.Button();
            this.london_button = new System.Windows.Forms.Button();
            this.baku_photo = new System.Windows.Forms.PictureBox();
            this.london_photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.baku_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.london_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // baku_button
            // 
            this.baku_button.Location = new System.Drawing.Point(140, 91);
            this.baku_button.Name = "baku_button";
            this.baku_button.Size = new System.Drawing.Size(108, 63);
            this.baku_button.TabIndex = 0;
            this.baku_button.Text = "Baku";
            this.baku_button.UseVisualStyleBackColor = true;
            this.baku_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // london_button
            // 
            this.london_button.Location = new System.Drawing.Point(522, 91);
            this.london_button.Name = "london_button";
            this.london_button.Size = new System.Drawing.Size(108, 63);
            this.london_button.TabIndex = 1;
            this.london_button.Text = "London";
            this.london_button.UseVisualStyleBackColor = true;
            this.london_button.Click += new System.EventHandler(this.london_button_Click);
            // 
            // baku_photo
            // 
            this.baku_photo.Image = global::WinFormsApp4.Properties.Resources.cities_baku_azerbaijan_wallpaper_preview;
            this.baku_photo.Location = new System.Drawing.Point(0, 1);
            this.baku_photo.Name = "baku_photo";
            this.baku_photo.Size = new System.Drawing.Size(800, 455);
            this.baku_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.baku_photo.TabIndex = 2;
            this.baku_photo.TabStop = false;
            this.baku_photo.Visible = false;
            // 
            // london_photo
            // 
            this.london_photo.Image = global::WinFormsApp4.Properties.Resources.istockphoto_1294454411_170667a;
            this.london_photo.Location = new System.Drawing.Point(0, 1);
            this.london_photo.Name = "london_photo";
            this.london_photo.Size = new System.Drawing.Size(799, 455);
            this.london_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.london_photo.TabIndex = 3;
            this.london_photo.TabStop = false;
            this.london_photo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.london_button);
            this.Controls.Add(this.baku_button);
            this.Controls.Add(this.baku_photo);
            this.Controls.Add(this.london_photo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.baku_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.london_photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button baku_button;
        private Button london_button;
        private PictureBox baku_photo;
        private PictureBox london_photo;
    }
}