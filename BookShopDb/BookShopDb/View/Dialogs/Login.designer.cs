namespace BookShopDb
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
            this.usertextBox1 = new System.Windows.Forms.TextBox();
            this.pwtextBox2 = new System.Windows.Forms.TextBox();
            this.Userlabel1 = new System.Windows.Forms.Label();
            this.pwlabel1 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usertextBox1
            // 
            this.usertextBox1.Location = new System.Drawing.Point(196, 38);
            this.usertextBox1.Name = "usertextBox1";
            this.usertextBox1.Size = new System.Drawing.Size(100, 20);
            this.usertextBox1.TabIndex = 0;
            // 
            // pwtextBox2
            // 
            this.pwtextBox2.Location = new System.Drawing.Point(196, 65);
            this.pwtextBox2.Name = "pwtextBox2";
            this.pwtextBox2.Size = new System.Drawing.Size(100, 20);
            this.pwtextBox2.TabIndex = 1;
            // 
            // Userlabel1
            // 
            this.Userlabel1.AutoSize = true;
            this.Userlabel1.Location = new System.Drawing.Point(103, 41);
            this.Userlabel1.Name = "Userlabel1";
            this.Userlabel1.Size = new System.Drawing.Size(55, 13);
            this.Userlabel1.TabIndex = 2;
            this.Userlabel1.Text = "Username";
            // 
            // pwlabel1
            // 
            this.pwlabel1.AutoSize = true;
            this.pwlabel1.Location = new System.Drawing.Point(103, 68);
            this.pwlabel1.Name = "pwlabel1";
            this.pwlabel1.Size = new System.Drawing.Size(53, 13);
            this.pwlabel1.TabIndex = 3;
            this.pwlabel1.Text = "Password";
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Silver;
            this.signInButton.Location = new System.Drawing.Point(106, 91);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(190, 23);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "&Sign in";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Location = new System.Drawing.Point(260, 129);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(45, 13);
            this.signUpLinkLabel.TabIndex = 5;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Sign Up";
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Location = new System.Drawing.Point(95, 129);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(159, 13);
            this.signUpLabel.TabIndex = 6;
            this.signUpLabel.Text = "Don\'t you have an account yet?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(407, 164);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.pwlabel1);
            this.Controls.Add(this.Userlabel1);
            this.Controls.Add(this.pwtextBox2);
            this.Controls.Add(this.usertextBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usertextBox1;
		private System.Windows.Forms.TextBox pwtextBox2;
		private System.Windows.Forms.Label Userlabel1;
		private System.Windows.Forms.Label pwlabel1;
		private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.Label signUpLabel;
    }
}

