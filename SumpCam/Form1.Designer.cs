namespace SumpCam
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
            this.boxPicture = new System.Windows.Forms.PictureBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnIntialise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boxPicture
            // 
            this.boxPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boxPicture.Location = new System.Drawing.Point(27, 12);
            this.boxPicture.Name = "boxPicture";
            this.boxPicture.Size = new System.Drawing.Size(1087, 622);
            this.boxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxPicture.TabIndex = 0;
            this.boxPicture.TabStop = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.Location = new System.Drawing.Point(1131, 525);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(188, 109);
            this.btnPicture.TabIndex = 1;
            this.btnPicture.Text = "Click";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnIntialise
            // 
            this.btnIntialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntialise.Location = new System.Drawing.Point(1162, 379);
            this.btnIntialise.Name = "btnIntialise";
            this.btnIntialise.Size = new System.Drawing.Size(128, 50);
            this.btnIntialise.TabIndex = 2;
            this.btnIntialise.Text = "Intialise";
            this.btnIntialise.UseVisualStyleBackColor = true;
            this.btnIntialise.Click += new System.EventHandler(this.btnIntialise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 695);
            this.Controls.Add(this.btnIntialise);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.boxPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxPicture;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnIntialise;
    }
}

