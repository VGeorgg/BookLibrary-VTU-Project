namespace BookLibrary
{
    partial class LibraryNonUser
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
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.DownloadTextBox = new System.Windows.Forms.TextBox();
            this.DownloadLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.AuthorsTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.AuthorsLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LibraryLabel = new System.Windows.Forms.Label();
            this.RegisterLinkButton = new System.Windows.Forms.LinkLabel();
            this.LoginLinkButton = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookGridView
            // 
            this.BookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.Location = new System.Drawing.Point(412, 21);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.RowTemplate.Height = 25;
            this.BookGridView.Size = new System.Drawing.Size(780, 326);
            this.BookGridView.TabIndex = 22;
            this.BookGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookGridView_RowHeaderMouseClick_1);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(233, 313);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(87, 34);
            this.DownloadButton.TabIndex = 21;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // DownloadTextBox
            // 
            this.DownloadTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownloadTextBox.Location = new System.Drawing.Point(154, 313);
            this.DownloadTextBox.Name = "DownloadTextBox";
            this.DownloadTextBox.Size = new System.Drawing.Size(73, 34);
            this.DownloadTextBox.TabIndex = 20;
            // 
            // DownloadLabel
            // 
            this.DownloadLabel.AutoSize = true;
            this.DownloadLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DownloadLabel.Location = new System.Drawing.Point(19, 313);
            this.DownloadLabel.Name = "DownloadLabel";
            this.DownloadLabel.Size = new System.Drawing.Size(106, 28);
            this.DownloadLabel.TabIndex = 19;
            this.DownloadLabel.Text = "Download:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(154, 196);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(166, 104);
            this.DescriptionTextBox.TabIndex = 18;
            // 
            // AuthorsTextBox
            // 
            this.AuthorsTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorsTextBox.Location = new System.Drawing.Point(154, 139);
            this.AuthorsTextBox.Name = "AuthorsTextBox";
            this.AuthorsTextBox.Size = new System.Drawing.Size(166, 34);
            this.AuthorsTextBox.TabIndex = 17;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.Location = new System.Drawing.Point(154, 82);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(166, 34);
            this.TitleTextBox.TabIndex = 16;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(9, 199);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(116, 28);
            this.DescriptionLabel.TabIndex = 15;
            this.DescriptionLabel.Text = "Description:";
            // 
            // AuthorsLabel
            // 
            this.AuthorsLabel.AutoSize = true;
            this.AuthorsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorsLabel.Location = new System.Drawing.Point(40, 142);
            this.AuthorsLabel.Name = "AuthorsLabel";
            this.AuthorsLabel.Size = new System.Drawing.Size(85, 28);
            this.AuthorsLabel.TabIndex = 14;
            this.AuthorsLabel.Text = "Authors:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(72, 82);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(53, 28);
            this.TitleLabel.TabIndex = 13;
            this.TitleLabel.Text = "Title:";
            // 
            // LibraryLabel
            // 
            this.LibraryLabel.AutoSize = true;
            this.LibraryLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LibraryLabel.Location = new System.Drawing.Point(165, 9);
            this.LibraryLabel.Name = "LibraryLabel";
            this.LibraryLabel.Size = new System.Drawing.Size(143, 54);
            this.LibraryLabel.TabIndex = 12;
            this.LibraryLabel.Text = "Library";
            // 
            // RegisterLinkButton
            // 
            this.RegisterLinkButton.AutoSize = true;
            this.RegisterLinkButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterLinkButton.Location = new System.Drawing.Point(424, 376);
            this.RegisterLinkButton.Name = "RegisterLinkButton";
            this.RegisterLinkButton.Size = new System.Drawing.Size(338, 28);
            this.RegisterLinkButton.TabIndex = 23;
            this.RegisterLinkButton.TabStop = true;
            this.RegisterLinkButton.Text = "Don\'t have an account? Register here.";
            this.RegisterLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkButton_LinkClicked);
            // 
            // LoginLinkButton
            // 
            this.LoginLinkButton.AutoSize = true;
            this.LoginLinkButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginLinkButton.Location = new System.Drawing.Point(422, 413);
            this.LoginLinkButton.Name = "LoginLinkButton";
            this.LoginLinkButton.Size = new System.Drawing.Size(340, 28);
            this.LoginLinkButton.TabIndex = 24;
            this.LoginLinkButton.TabStop = true;
            this.LoginLinkButton.Text = "Already have an account? Log in here.";
            this.LoginLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkButton_LinkClicked);
            // 
            // LibraryNonUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 450);
            this.Controls.Add(this.LoginLinkButton);
            this.Controls.Add(this.RegisterLinkButton);
            this.Controls.Add(this.BookGridView);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.DownloadTextBox);
            this.Controls.Add(this.DownloadLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.AuthorsTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.AuthorsLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.LibraryLabel);
            this.Name = "LibraryNonUser";
            this.Text = "LibraryNonUser Form";
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView BookGridView;
        private Button DownloadButton;
        private TextBox DownloadTextBox;
        private Label DownloadLabel;
        private TextBox DescriptionTextBox;
        private TextBox AuthorsTextBox;
        private TextBox TitleTextBox;
        private Label DescriptionLabel;
        private Label AuthorsLabel;
        private Label TitleLabel;
        private Label LibraryLabel;
        private LinkLabel RegisterLinkButton;
        private LinkLabel LoginLinkButton;
    }
}