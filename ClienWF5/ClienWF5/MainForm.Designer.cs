
namespace ClienWF5
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.ezhListBox = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.label2 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.label4 = new System.Windows.Forms.Label();
      this.roundTimeLabel = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(374, 103);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(252, 254);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // ezhListBox
      // 
      this.ezhListBox.FormattingEnabled = true;
      this.ezhListBox.ItemHeight = 20;
      this.ezhListBox.Location = new System.Drawing.Point(854, 36);
      this.ezhListBox.Name = "ezhListBox";
      this.ezhListBox.Size = new System.Drawing.Size(265, 484);
      this.ezhListBox.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(854, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "Список ёжиков:";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(345, 505);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(113, 30);
      this.button1.TabIndex = 3;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.ItemHeight = 20;
      this.listBox2.Location = new System.Drawing.Point(12, 293);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(234, 224);
      this.listBox2.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(326, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(362, 37);
      this.label2.TabIndex = 5;
      this.label2.Text = "Время до следующего хода:";
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 270);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(61, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "Рюкзак:";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(12, 36);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(234, 224);
      this.listBox1.TabIndex = 7;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 13);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 20);
      this.label4.TabIndex = 8;
      this.label4.Text = "Взять вещь:";
      // 
      // roundTimeLabel
      // 
      this.roundTimeLabel.AutoSize = true;
      this.roundTimeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.roundTimeLabel.Location = new System.Drawing.Point(474, 46);
      this.roundTimeLabel.Name = "roundTimeLabel";
      this.roundTimeLabel.Size = new System.Drawing.Size(45, 54);
      this.roundTimeLabel.TabIndex = 9;
      this.roundTimeLabel.Text = "0";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(369, 394);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(89, 20);
      this.label5.TabIndex = 10;
      this.label5.Text = "Имя ёжика:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(474, 394);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(61, 20);
      this.label6.TabIndex = 11;
      this.label6.Text = "Рюкзак:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(374, 360);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(89, 20);
      this.label7.TabIndex = 12;
      this.label7.Text = "Имя ёжика:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(469, 360);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(50, 20);
      this.label8.TabIndex = 13;
      this.label8.Text = "label8";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1131, 547);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.roundTimeLabel);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.ezhListBox);
      this.Controls.Add(this.pictureBox1);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ListBox ezhListBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label roundTimeLabel;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
  }
}