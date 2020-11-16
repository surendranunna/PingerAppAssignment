using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace PingerAssignment
{
    public partial class PingerApp : Form
    {
        public PingerApp()
        {
            InitializeComponent();
        }

        private void PingerApp_Load(object sender, EventArgs e)
        {

            WebsitePanel.Visible = false;
            RemoteServerPanel.Visible = false;
            RemoteDbPanel.Visible = false;
            SettingsPanel.Visible = false;

            TxtUrl.Visible = false;
            TxtSepartedEmails.Visible = false;
            BtnAddUrl.Visible = false;
            BtnCancel.Visible = false;
            BtnOutput.Visible = false;

            TxtIp.Visible = false;
            TxtSeparetedEmails.Visible = false;
            BtnRsAddUrl.Visible = false;
            BtnRsCancel.Visible = false;
            BtnRsOutput.Visible = false;

            TxtRdbIp.Visible = false;
            TxtRdbSeparetedEmails.Visible = false;
            BtnRdbAddIp.Visible = false;
            BtnRdbCancel.Visible = false;
            BtnRdbOutput.Visible = false;
            LblUpdates.Visible = false;

        }


        private void InfoLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/KishoreIthadi/Pinger/blob/master/README.md");
        }

        private void BtnWebsite_Click(object sender, EventArgs e)
        {

            WebsitePanel.Visible = true;
            RemoteServerPanel.Visible = false;
            RemoteDbPanel.Visible = false;
            SettingsPanel.Visible = false;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            TxtUrl.Visible = true;
            TxtSepartedEmails.Visible = true;
            BtnAddUrl.Visible = true;
            BtnCancel.Visible = true;

        }



        private void BtnRemoteServer_Click(object sender, EventArgs e)
        {
            RemoteServerPanel.Visible = true;
            WebsitePanel.Visible = false;
            RemoteDbPanel.Visible = false;
            SettingsPanel.Visible = false;
        }

        private void BtnRsAdd_Click(object sender, EventArgs e)
        {
            TxtIp.Visible = true;
            TxtSeparetedEmails.Visible = true;
            BtnRsAddUrl.Visible = true;
            BtnRsCancel.Visible = true;

        }





        private void BtnRemoteDb_Click(object sender, EventArgs e)
        {
            RemoteServerPanel.Visible = false;
            WebsitePanel.Visible = false;
            RemoteDbPanel.Visible = true;
            SettingsPanel.Visible = false;

        }
        private void BtnRdbAdd_Click(object sender, EventArgs e)
        {
            TxtRdbIp.Visible = true;
            TxtRdbSeparetedEmails.Visible = true;
            BtnRdbAddIp.Visible = true;
            BtnRdbCancel.Visible = true;


        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SettingsPanel.Visible = true;
            RemoteServerPanel.Visible = false;
            WebsitePanel.Visible = false;
            RemoteDbPanel.Visible = false;
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtUrl.Visible = false;
            TxtSepartedEmails.Visible = false;
            BtnAddUrl.Visible = false;
            BtnCancel.Visible = false;
            BtnOutput.Visible = false;
        }

        private void BtnRsCancel_Click(object sender, EventArgs e)
        {
            TxtIp.Visible = false;
            TxtSeparetedEmails.Visible = false;
            BtnRsAddUrl.Visible = false;
            BtnRsCancel.Visible = false;
            BtnRsOutput.Visible = false;
        }



        private void BtnRdbCancel_Click(object sender, EventArgs e)
        {
            TxtRdbIp.Visible = false;
            TxtRdbSeparetedEmails.Visible = false;
            BtnRdbAddIp.Visible = false;
            BtnRdbCancel.Visible = false;
            BtnRdbOutput.Visible = false;
        }


        private void BtnCancel_Click_1(object sender, EventArgs e)
        {

            TxtUrl.Visible = false;
            TxtSepartedEmails.Visible = false;
            BtnAddUrl.Visible = false;
            BtnCancel.Visible = false;
            BtnOutput.Visible = false;
        }

        private void BtnAddUrl_Click_1(object sender, EventArgs e)
        {
            string url = TxtUrl.Text;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    BtnOutput.Visible = true;
                    BtnOutput.Text = "✔";
                    BtnOutput.BackColor = Color.Green;
                    // TxtUrl.Text = myHttpWebResponse.StatusDescription;
                    myHttpWebResponse.Close();
                }
            }
            catch (WebException)
            {

                BtnOutput.Text = "!";
                BtnOutput.BackColor = Color.Goldenrod;
                BtnOutput.Visible = true;
            }

            catch (Exception)
            {

                BtnOutput.Text = "❌";
                BtnOutput.BackColor = Color.Red;
                BtnOutput.Visible = true;

            }



        }

        private void BtnRsCancel_Click_1(object sender, EventArgs e)
        {
            TxtIp.Visible = false;
            TxtSeparetedEmails.Visible = false;
            BtnRsAddUrl.Visible = false;
            BtnRsCancel.Visible = false;
            BtnRsOutput.Visible = false;
        }

        private void BtnRsAddUrl_Click_1(object sender, EventArgs e)
        {
            string rsIp = TxtIp.Text;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(rsIp);

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    BtnRsOutput.Visible = true;
                    BtnRsOutput.Text = "✔";
                    BtnRsOutput.BackColor = Color.Green;
                    // TxtUrl.Text = myHttpWebResponse.StatusDescription;
                    myHttpWebResponse.Close();
                }
            }
            catch (WebException)
            {

                BtnRsOutput.Text = "!";
                BtnRsOutput.BackColor = Color.Goldenrod;
                BtnRsOutput.Visible = true;
            }

            catch (Exception)
            {

                BtnRsOutput.Text = "❌";
                BtnRsOutput.BackColor = Color.Red;
                BtnRsOutput.Visible = true;

            }



        }

        private void BtnRdbAddIp_Click_1(object sender, EventArgs e)
        {
            string rdbIp = TxtIp.Text;
            try
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(rdbIp);

                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    BtnRdbOutput.Visible = true;
                    BtnRdbOutput.Text = "✔";
                    BtnRdbOutput.BackColor = Color.Green;
                    // TxtUrl.Text = myHttpWebResponse.StatusDescription;
                    myHttpWebResponse.Close();
                }
            }
            catch (WebException)
            {

                BtnRdbOutput.Text = "!";
                BtnRdbOutput.BackColor = Color.Goldenrod;
                BtnRdbOutput.Visible = true;
            }

            catch (Exception)
            {

                BtnRdbOutput.Text = "❌";
                BtnRdbOutput.BackColor = Color.Red;
                BtnRdbOutput.Visible = true;

            }



        }

        private void BtnRdbCancel_Click_1(object sender, EventArgs e)
        {
            TxtRdbIp.Visible = false;
            TxtRdbSeparetedEmails.Visible = false;
            BtnRdbAddIp.Visible = false;
            BtnRdbCancel.Visible = false;
            BtnRdbOutput.Visible = false;
        }

        private void TxtUrl_Enter(object sender, EventArgs e)
        {
            if (TxtUrl.Text == "  URL or IP")
            {
                TxtUrl.Text = "";
                TxtUrl.ForeColor = Color.Black;
            }
        }

        private void TxtUrl_Leave(object sender, EventArgs e)
        {
            if (TxtUrl.Text == "")
            {
                TxtUrl.Text = "  URL or IP";
                TxtUrl.ForeColor = Color.Silver;
            }
        }

        private void TxtSepartedEmails_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails.Text == "  , separted emails")
            {
                TxtSepartedEmails.Text = "";
                TxtSepartedEmails.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails.Text == "")
            {
                TxtSepartedEmails.Text = "  , separted emails";
                TxtSepartedEmails.ForeColor = Color.Silver;
            }
        }

        private void TxtIp_Enter(object sender, EventArgs e)
        {
            if (TxtIp.Text == "  IP:port")
            {
                TxtIp.Text = "";
                TxtIp.ForeColor = Color.Black;
            }
        }

        private void TxtIp_Leave(object sender, EventArgs e)
        {
            if (TxtIp.Text == "")
            {
                TxtIp.Text = "  IP:port";
                TxtIp.ForeColor = Color.Silver;
            }

        }

        private void TxtRdbIp_Enter(object sender, EventArgs e)
        {
            if (TxtRdbIp.Text == "  IP:port")
            {
                TxtRdbIp.Text = "";
                TxtRdbIp.ForeColor = Color.Black;
            }
        }



        private void TxtRdbIp_Leave(object sender, EventArgs e)
        {
            if (TxtRdbIp.Text == "")
            {
                TxtRdbIp.Text = "  IP:port";
                TxtRdbIp.ForeColor = Color.Silver;
            }
        }

        private void TxtRdbSeparetedEmails_Enter(object sender, EventArgs e)
        {
            if (TxtRdbSeparetedEmails.Text == "  , separted emails")
            {
                TxtRdbSeparetedEmails.Text = "";
                TxtRdbSeparetedEmails.ForeColor = Color.Black;
            }
        }

        private void TxtRdbSeparetedEmails_Leave(object sender, EventArgs e)
        {
            if (TxtRdbSeparetedEmails.Text == "")
            {
                TxtRdbSeparetedEmails.Text = "  , separted emails";
                TxtRdbSeparetedEmails.ForeColor = Color.Silver;
            }
        }

        private void TxtSeparetedEmails_Enter(object sender, EventArgs e)
        {
            if (TxtSeparetedEmails.Text == "  , separted emails")
            {
                TxtSeparetedEmails.Text = "";
                TxtSeparetedEmails.ForeColor = Color.Black;
            }
        }

        private void TxtSeparetedEmails_Leave(object sender, EventArgs e)
        {
            if (TxtSeparetedEmails.Text == "")
            {
                TxtSeparetedEmails.Text = "  , separted emails";
                TxtSeparetedEmails.ForeColor = Color.Black;
            }
        }

        private void TxtGlobalEmail_Enter(object sender, EventArgs e)
        {
            if (TxtGlobalEmail.Text == "  Multiple emails separeted by ,")
            {
                TxtGlobalEmail.Text = "";
                TxtGlobalEmail.ForeColor = Color.Black;
            }
        }

        private void NumericIntervals_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtGlobalEmail_Leave(object sender, EventArgs e)
        {
            if (TxtGlobalEmail.Text == "")
            {
                TxtGlobalEmail.Text = "  Multiple emails separeted by ,";
                TxtGlobalEmail.ForeColor = Color.Silver;
            }

        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            LblUpdates.Visible = true;
        }
    }
}





