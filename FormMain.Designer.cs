namespace wallpaper_reminder
{
    partial class FormMain
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
            this.bSetWallpaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbResW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSetWallpaper
            // 
            this.bSetWallpaper.Location = new System.Drawing.Point(130, 61);
            this.bSetWallpaper.Name = "bSetWallpaper";
            this.bSetWallpaper.Size = new System.Drawing.Size(142, 23);
            this.bSetWallpaper.TabIndex = 0;
            this.bSetWallpaper.Text = "Set as wallpaper";
            this.bSetWallpaper.UseVisualStyleBackColor = true;
            this.bSetWallpaper.Click += new System.EventHandler(this.bSetWallpaper_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reminder text";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 24);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(260, 20);
            this.tbText.TabIndex = 2;
            this.tbText.Text = "Do cool things";
            // 
            // tbResW
            // 
            this.tbResW.Location = new System.Drawing.Point(12, 63);
            this.tbResW.Name = "tbResW";
            this.tbResW.Size = new System.Drawing.Size(31, 20);
            this.tbResW.TabIndex = 3;
            this.tbResW.Text = "w";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resolution";
            // 
            // tbResH
            // 
            this.tbResH.Location = new System.Drawing.Point(68, 63);
            this.tbResH.Name = "tbResH";
            this.tbResH.Size = new System.Drawing.Size(31, 20);
            this.tbResH.TabIndex = 5;
            this.tbResH.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "×";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 98);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbResH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbResW);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSetWallpaper);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Wallpaper Reminder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSetWallpaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbResW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbResH;
        private System.Windows.Forms.Label label3;
    }
}

