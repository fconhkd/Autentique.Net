using Autentique.Service;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Autentique.Net.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAccessToken.Text = ConfigurationManager.AppSettings.Get("AccessToken");
        }

        private void btnListDocuments_Click(object sender, EventArgs e)
        {
            var autentiqueService = new AutentiqueService();
            var listDocumentsResult = autentiqueService.ListDocuments(txtAccessToken.Text);
            if (listDocumentsResult.Success)
            {
                string output = JsonConvert.SerializeObject(listDocumentsResult.Result);
                txtResults.Text = output;
            }
            else
            {
                txtResults.Text = listDocumentsResult.Message;
                return;
            }
        }
    }
}
