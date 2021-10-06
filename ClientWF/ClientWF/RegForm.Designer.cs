
namespace ClientWF
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
      this.passwordTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.loginTextBox = new System.Windows.Forms.TextBox();
      this.loginButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // passwordTextBox
      // 
      this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.passwordTextBox.Location = new System.Drawing.Point(26, 182);
      this.passwordTextBox.Name = "passwordTextBox";
      this.passwordTextBox.Size = new System.Drawing.Size(329, 38);
      this.passwordTextBox.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(20, 148);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(142, 31);
      this.label2.TabIndex = 11;
      this.label2.Text = "Password:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(20, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(88, 31);
      this.label1.TabIndex = 10;
      this.label1.Text = "Login:";
      // 
      // loginTextBox
      // 
      this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loginTextBox.Location = new System.Drawing.Point(26, 72);
      this.loginTextBox.Name = "loginTextBox";
      this.loginTextBox.Size = new System.Drawing.Size(329, 38);
      this.loginTextBox.TabIndex = 9;
      // 
      // loginButton
      // 
      this.loginButton.Location = new System.Drawing.Point(386, 156);
      this.loginButton.Name = "loginButton";
      this.loginButton.Size = new System.Drawing.Size(129, 64);
      this.loginButton.TabIndex = 8;
      this.loginButton.Text = "Регистрация";
      this.loginButton.UseVisualStyleBackColor = true;
      // 
      // RegForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(537, 238);
      this.Controls.Add(this.passwordTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.loginTextBox);
      this.Controls.Add(this.loginButton);
      this.Name = "RegForm";
      this.Text = "Регистрация";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegForm_FormClosed);
      this.Load += new System.EventHandler(this.RegForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TextBox passwordTextBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox loginTextBox;
    private System.Windows.Forms.Button loginButton;
  }
}