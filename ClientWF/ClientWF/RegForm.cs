using System;
using EhzClassLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
    }

    private void loginButton_Click(object sender, EventArgs e)
    {

      WebRequest request = WebRequest.Create("http://localhost:5000/api/reg");
      request.Method = "POST";
      string sName = "word=ЕЖИК";
      


      byte[] byteArray = Encoding.UTF8.GetBytes(sName);
      request.ContentType = "application/x-www-form-urlencoded";
      request.ContentLength = byteArray.Length;

      using (Stream dataStream = request.GetRequestStream())
      {
        dataStream.Write(byteArray, 0, byteArray.Length);
      }
      string strdata = "";
      WebResponse response =  request.GetResponse();
      using (Stream stream = response.GetResponseStream())
      {
        using (StreamReader reader = new StreamReader(stream))
        {
          strdata = reader.ReadToEnd();
        }
      }
      response.Close();

      MessageBox.Show(strdata);
      //object jsondata = JsonConvert.SerializeObject(strdata);


      Close();
    }
  }
}
