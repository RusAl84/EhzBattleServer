
namespace ClienWF5
{
  partial class LoginForm
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
      this.loginButton = new System.Windows.Forms.Button();
      this.loginTextBox = new System.Windows.Forms.TextBox();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // loginButton
      // 
      this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginButton.Location = new System.Drawing.Point(380, 186);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(168, 69);
      this.loginButton.TabIndex = 0;
      this.loginButton.Text = "Войти";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // loginTextBox
      // 
      this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginTextBox.Location = new System.Drawing.Point(12, 67);
      this.loginTextBox.MaxLength = 20;
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.Size = new System.Drawing.Size(312, 43);
      this.loginTextBox.TabIndex = 1;
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.passwordTextBox.Location = new System.Drawing.Point(12, 208);
      this.passwordTextBox.MaxLength = 20;
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.PasswordChar = '*';
      this.passwordTextBox.Size = new System.Drawing.Size(312, 43);
      this.passwordTextBox.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(12, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 38);
      this.label1.TabIndex = 3;
      this.label1.Text = "Логин:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(13, 156);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 38);
      this.label2.TabIndex = 4;
      this.label2.Text = "Пароль:";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // linkLabel1
      // 
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.linkLabel1.Location = new System.Drawing.Point(13, 299);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(208, 37);
      this.linkLabel1.TabIndex = 5;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "Забыли пароль";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.linkLabel2.Location = new System.Drawing.Point(377, 299);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(171, 37);
      this.linkLabel2.TabIndex = 6;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Регистрация";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 350);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.loginButton);
      this.Name = "LoginForm";
      this.Text = "Вход в систему";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button loginButton;
    private System.Windows.Forms.TextBox loginTextBox;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
  }
}

