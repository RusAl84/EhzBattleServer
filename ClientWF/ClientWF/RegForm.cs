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
  public partial class RegForm : Form
  {
    public LoginForm lg;
    public RegForm()
    {
      InitializeComponent();
    }

    private void RegForm_Load(object sender, EventArgs e)
    {

    }

    private void RegForm_FormClosed(object sender, FormClosedEventArgs e)
    {
      //lg.Show();
      //Close();
      
    }
  }
}
