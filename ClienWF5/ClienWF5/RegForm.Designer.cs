
namespace ClienWF5
{
  partial class RegForm
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.loginTextBox = new System.Windows.Forms.TextBox();
      this.loginButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(9, 105);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 38);
      this.label2.TabIndex = 11;
      this.label2.Text = "Пароль:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(9, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 38);
      this.label1.TabIndex = 10;
      this.label1.Text = "Логин:";
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.passwordTextBox.Location = new System.Drawing.Point(12, 146);
      this.passwordTextBox.MaxLength = 20;
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.PasswordChar = '*';
      this.passwordTextBox.Size = new System.Drawing.Size(312, 43);
      this.passwordTextBox.TabIndex = 9;
      // 
      // loginTextBox
      // 
      this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginTextBox.Location = new System.Drawing.Point(12, 59);
      this.loginTextBox.MaxLength = 20;
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.Size = new System.Drawing.Size(312, 43);
      this.loginTextBox.TabIndex = 8;
      // 
      // loginButton
      // 
      this.loginButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.loginButton.Location = new System.Drawing.Point(349, 120);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(226, 69);
      this.loginButton.TabIndex = 7;
      this.loginButton.Text = "Регистрация";
      this.loginButton.UseVisualStyleBackColor = false;
      this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
      // 
      // RegForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(581, 252);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.loginButton);
      this.Name = "RegForm";
      this.Text = "ЁжБаттлеМультиплей: Регистрация";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.TextBox loginTextBox;
    private System.Windows.Forms.Button loginButton;
  }
}