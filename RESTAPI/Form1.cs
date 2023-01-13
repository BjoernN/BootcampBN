using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTAPIService;

namespace RESTAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            var restAPI = new RESTAPIService.RESTAPIService();

            tbFirstname.Text = string.Empty;
            tbLastname.Text = string.Empty;
            tbLanguage.Text = string.Empty;

            try
            {
                var user = restAPI.GetData(tbAccessToken.Text, tbUserId.Text);
                tbFirstname.Text = user.firstName;
                tbLastname.Text = user.lastName;

                if (user.config != null && !string.IsNullOrWhiteSpace(user.config.locale))
                {
                    tbLanguage.Text = new CultureInfo(user.config?.locale).TwoLetterISOLanguageName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
