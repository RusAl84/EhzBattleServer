using EhzClassLibrary;
using Newtonsoft.Json;
using System;
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

namespace ClienWF5
{
  public partial class LoginForm : Form
  {
    public string baseUrl = "http://localhost:5000";

    public LoginForm()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string url = baseUrl + "/api/login";
      var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
      httpWebRequest.ContentType = "application/json";
      httpWebRequest.Method = "POST";
      using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
      {
        LoginClass lg = new LoginClass();
        lg.login = loginTextBox.Text.ToLower();
        lg.password = CryptClass.GetSHA256(passwordTextBox.Text);
        string jsonString = JsonConvert.SerializeObject(lg, Formatting.Indented);
        streamWriter.Write(jsonString);
      }

      var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
      string strdata="";
      using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
      {
         strdata = streamReader.ReadToEnd();
      }
      //MessageBox.Show(strdata);
      MainForm mf = new MainForm();
      mf.token = strdata;
      this.Hide();
      mf.ShowDialog();
      this.Show();
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      RegForm rf = new RegForm();
      rf.baseUrl = this.baseUrl;
      this.Hide();
      rf.ShowDialog();
      this.Show();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      MessageBox.Show("Спроси Михалыча;)");
    }
  }
}
