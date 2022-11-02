namespace CRCMDB_3._0
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
            this.ManageMoviesButton = new System.Windows.Forms.Button();
            this.ManageActorsButton = new System.Windows.Forms.Button();
            this.ManageGenresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManageMoviesButton
            // 
            this.ManageMoviesButton.Location = new System.Drawing.Point(12, 32);
            this.ManageMoviesButton.Name = "ManageMoviesButton";
            this.ManageMoviesButton.Size = new System.Drawing.Size(93, 23);
            this.ManageMoviesButton.TabIndex = 0;
            this.ManageMoviesButton.Text = "Manage Movies";
            this.ManageMoviesButton.UseVisualStyleBackColor = true;
            this.ManageMoviesButton.Click += new System.EventHandler(this.ManageMoviesButton_Click);
            // 
            // ManageActorsButton
            // 
            this.ManageActorsButton.Location = new System.Drawing.Point(111, 32);
            this.ManageActorsButton.Name = "ManageActorsButton";
            this.ManageActorsButton.Size = new System.Drawing.Size(93, 23);
            this.ManageActorsButton.TabIndex = 1;
            this.ManageActorsButton.Text = "Manage Actors";
            this.ManageActorsButton.UseVisualStyleBackColor = true;
            // 
            // ManageGenresButton
            // 
            this.ManageGenresButton.Location = new System.Drawing.Point(210, 32);
            this.ManageGenresButton.Name = "ManageGenresButton";
            this.ManageGenresButton.Size = new System.Drawing.Size(93, 23);
            this.ManageGenresButton.TabIndex = 2;
            this.ManageGenresButton.Text = "Manage Genres";
            this.ManageGenresButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 98);
            this.Controls.Add(this.ManageGenresButton);
            this.Controls.Add(this.ManageActorsButton);
            this.Controls.Add(this.ManageMoviesButton);
            this.Name = "Form1";
            this.Text = "CRCMDB";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManageMoviesButton;
        private System.Windows.Forms.Button ManageActorsButton;
        private System.Windows.Forms.Button ManageGenresButton;
    }
}

