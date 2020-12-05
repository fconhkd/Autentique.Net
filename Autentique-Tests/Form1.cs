using Autentique.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace Autentique_Tests
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
