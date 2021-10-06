using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientWF
{
  public partial class LoginForm : Form
  {
    public string token;
    public LoginForm()
    {
      InitializeComponent();
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MessageBox.Show("Обратись за помощью к Михалычу;)");
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      RegForm rf = new RegForm();
      rf.ShowDialog();
      //rf.lg = this;
      //this.Hide();
    }

    private void LoginForm_Load(object sender, EventArgs e)
    {
      token = "";
    }
  }
}
