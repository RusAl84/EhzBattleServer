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
  public partial class MainForm : Form
  {
    public string token;
    public string baseUrl;
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      label8.Text = token;
      string url = baseUrl + "/api/GetData";
      var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
      request.AutomaticDecompression = DecompressionMethods.GZip;
      string jsonString = "";
      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
      using (Stream stream = response.GetResponseStream())
      using (StreamReader reader = new StreamReader(stream))
      {
        jsonString = reader.ReadToEnd();
      }

      roundTimeLabel.Text = jsonString;


    }
  }
}
