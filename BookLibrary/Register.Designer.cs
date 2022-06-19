namespace BookLibrary
{
    partial class Register
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
            this.TextLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.RepeatPasswordInput = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginLinkButton = new System.Windows.Forms.LinkLabel();
            this.LibraryNonUserButton = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.Location = new System.Drawing.Point(312, 9);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(167, 54);
            this.TextLabel.TabIndex = 0;
            this.TextLabel.Text = "Register";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(132, 122);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(142, 37);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(140, 192);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(134, 37);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(51, 265);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(223, 37);
            this.RepeatPasswordLabel.TabIndex = 3;
            this.RepeatPasswordLabel.Text = "Repeat Password:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameInput.Location = new System.Drawing.Point(312, 126);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(215, 34);
            this.UsernameInput.TabIndex = 4;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(312, 196);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(215, 34);
            this.PasswordInput.TabIndex = 5;
            // 
            // RepeatPasswordInput
            // 
            this.RepeatPasswordInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordInput.Location = new System.Drawing.Point(312, 268);
            this.RepeatPasswordInput.Name = "RepeatPasswordInput";
            this.RepeatPasswordInput.Size = new System.Drawing.Size(215, 34);
            this.RepeatPasswordInput.TabIndex = 6;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(312, 330);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(172, 52);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginLinkButton
            // 
            this.LoginLinkButton.AutoSize = true;
            this.LoginLinkButton.Location = new System.Drawing.Point(312, 400);
            this.LoginLinkButton.Name = "LoginLinkButton";
            this.LoginLinkButton.Size = new System.Drawing.Size(233, 15);
            this.LoginLinkButton.TabIndex = 8;
            this.LoginLinkButton.TabStop = true;
            this.LoginLinkButton.Text = "If you already have an account, log in here.";
            this.LoginLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinkButton_LinkClicked);
            // 
            // LibraryNonUserButton
            // 
            this.LibraryNonUserButton.AutoSize = true;
            this.LibraryNonUserButton.Location = new System.Drawing.Point(312, 426);
            this.LibraryNonUserButton.Name = "LibraryNonUserButton";
            this.LibraryNonUserButton.Size = new System.Drawing.Size(150, 15);
            this.LibraryNonUserButton.TabIndex = 9;
            this.LibraryNonUserButton.TabStop = true;
            this.LibraryNonUserButton.Text = "Go back to the home page.";
            this.LibraryNonUserButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LibraryNonUserButton_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibraryNonUserButton);
            this.Controls.Add(this.LoginLinkButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RepeatPasswordInput);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TextLabel);
            this.Name = "Register";
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TextLabel;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label RepeatPasswordLabel;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private TextBox RepeatPasswordInput;
        private Button RegisterButton;
        private LinkLabel LoginLinkButton;
        private LinkLabel LibraryNonUserButton;
    }
}