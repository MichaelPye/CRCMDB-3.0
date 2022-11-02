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
            this.ManageMoviesButton.Location = new System.Drawing.Point(16, 39);
            this.ManageMoviesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManageMoviesButton.Name = "ManageMoviesButton";
            this.ManageMoviesButton.Size = new System.Drawing.Size(124, 28);
            this.ManageMoviesButton.TabIndex = 0;
            this.ManageMoviesButton.Text = "Manage Movies";
            this.ManageMoviesButton.UseVisualStyleBackColor = true;
            this.ManageMoviesButton.Click += new System.EventHandler(this.ManageMoviesButton_Click);
            // 
            // ManageActorsButton
            // 
            this.ManageActorsButton.Location = new System.Drawing.Point(148, 39);
            this.ManageActorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManageActorsButton.Name = "ManageActorsButton";
            this.ManageActorsButton.Size = new System.Drawing.Size(124, 28);
            this.ManageActorsButton.TabIndex = 1;
            this.ManageActorsButton.Text = "Manage Actors";
            this.ManageActorsButton.UseVisualStyleBackColor = true;
            this.ManageActorsButton.Click += new System.EventHandler(this.ManageActorsButton_Click);
            // 
            // ManageGenresButton
            // 
            this.ManageGenresButton.Location = new System.Drawing.Point(280, 39);
            this.ManageGenresButton.Margin = new System.Windows.Forms.Padding(4);
            this.ManageGenresButton.Name = "ManageGenresButton";
            this.ManageGenresButton.Size = new System.Drawing.Size(124, 28);
            this.ManageGenresButton.TabIndex = 2;
            this.ManageGenresButton.Text = "Manage Genres";
            this.ManageGenresButton.UseVisualStyleBackColor = true;
            this.ManageGenresButton.Click += new System.EventHandler(this.ManageGenresButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 121);
            this.Controls.Add(this.ManageGenresButton);
            this.Controls.Add(this.ManageActorsButton);
            this.Controls.Add(this.ManageMoviesButton);
            this.Margin = new System.Windows.Forms.Padding(4);
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

