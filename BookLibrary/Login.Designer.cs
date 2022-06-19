namespace BookLibrary
{
    partial class Login
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
            this.RegisterLinkButton = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.LibraryNonUserButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // RegisterLinkButton
            // 
            this.RegisterLinkButton.AutoSize = true;
            this.RegisterLinkButton.Location = new System.Drawing.Point(313, 338);
            this.RegisterLinkButton.Name = "RegisterLinkButton";
            this.RegisterLinkButton.Size = new System.Drawing.Size(232, 15);
            this.RegisterLinkButton.TabIndex = 17;
            this.RegisterLinkButton.TabStop = true;
            this.RegisterLinkButton.Text = "If you don\'t have an account, register here.";
            this.RegisterLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkButton_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(331, 266);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(172, 52);
            this.LoginButton.TabIndex = 16;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(331, 196);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(215, 34);
            this.PasswordInput.TabIndex = 14;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameInput.Location = new System.Drawing.Point(331, 126);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(215, 34);
            this.UsernameInput.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(159, 192);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(134, 37);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(151, 122);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 37);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username:";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.Location = new System.Drawing.Point(331, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(122, 54);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.Text = "Login";
            // 
            // LibraryNonUserButton
            // 
            this.LibraryNonUserButton.AutoSize = true;
            this.LibraryNonUserButton.Location = new System.Drawing.Point(313, 376);
            this.LibraryNonUserButton.Name = "LibraryNonUserButton";
            this.LibraryNonUserButton.Size = new System.Drawing.Size(150, 15);
            this.LibraryNonUserButton.TabIndex = 18;
            this.LibraryNonUserButton.TabStop = true;
            this.LibraryNonUserButton.Text = "Go back to the home page.";
            this.LibraryNonUserButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibraryNonUserButton_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibraryNonUserButton);
            this.Controls.Add(this.RegisterLinkButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TextLabel);
            this.Name = "Login";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel RegisterLinkButton;
        private Button LoginButton;
        private TextBox PasswordInput;
        private TextBox UsernameInput;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private Label TextLabel;
        private LinkLabel LibraryNonUserButton;
    }
}