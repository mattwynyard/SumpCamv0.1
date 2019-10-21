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
            this.btnIntialise = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // boxPicture
            // 
            this.boxPicture.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boxPicture.Location = new System.Drawing.Point(27, 12);
            this.boxPicture.Name = "boxPicture";
            this.boxPicture.Size = new System.Drawing.Size(640, 480);
            this.boxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.boxPicture.TabIndex = 0;
            this.boxPicture.TabStop = false;
            // 
            // btnIntialise
            // 
            this.btnIntialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntialise.Location = new System.Drawing.Point(705, 12);
            this.btnIntialise.Name = "btnIntialise";
            this.btnIntialise.Size = new System.Drawing.Size(128, 50);
            this.btnIntialise.TabIndex = 2;
            this.btnIntialise.Text = "Intialise";
            this.btnIntialise.UseVisualStyleBackColor = true;
            this.btnIntialise.Click += new System.EventHandler(this.btnIntialise_Click);
            // 
            // btnClick
            // 
            this.btnClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.Location = new System.Drawing.Point(702, 437);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(131, 55);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.BtnClick_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(728, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Image De-npoising";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 541);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnIntialise);
            this.Controls.Add(this.boxPicture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.boxPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxPicture;
        private System.Windows.Forms.Button btnIntialise;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

