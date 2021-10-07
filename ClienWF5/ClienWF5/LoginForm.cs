using EhzClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienWF5
{
  public partial class LoginForm : Form
  {
    public LoginForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      LoginClass lg = new LoginClass();
      MessageBox.Show("GHb");
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      RegForm rf = new RegForm();
      rf.ShowDialog();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MessageBox.Show("Спроси Михалыча;)");
    }
  }
}
