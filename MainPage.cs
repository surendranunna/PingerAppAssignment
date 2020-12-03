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
using System.Net.Mail;
using System.Reflection;

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

            LblUrlWarning.Visible = false;
            LblServerWarning.Visible = false;
            LblDatabaseWarning.Visible = false;

            tableLayoutPanel1.Visible = false;
            tableLayoutPanel2.Visible = false;
            tableLayoutPanel3.Visible = false;
            tableLayoutPanel4.Visible = false;
            tableLayoutPanel5.Visible = false;
            tableLayoutPanel6.Visible = false;
            tableLayoutPanel7.Visible = false;
            tableLayoutPanel8.Visible = false;
            tableLayoutPanel9.Visible = false;
            tableLayoutPanel10.Visible = false;

            LblUrlWarning.Visible = false;
            LblUrlWarning2.Visible = false;
            LblUrlWarning3.Visible = false;
            LblUrlWarning4.Visible = false;
            LblUrlWarning5.Visible = false;
            LblUrlWarning6.Visible = false;
            LblUrlWarning7.Visible = false;
            LblUrlWarning8.Visible = false;
            LblUrlWarning9.Visible = false;
            LblUrlWarning10.Visible = false;

            PictureOutput.Visible = false;
            PictureOutput2.Visible = false;
            PictureOutput3.Visible = false;
            PictureOutput4.Visible = false;
            PictureOutput5.Visible = false;
            PictureOutput6.Visible = false;
            PictureOutput7.Visible = false;
            PictureOutput8.Visible = false;
            PictureOutput9.Visible = false;
            PictureOutput10.Visible = false;



            //Text= Properties.Settings.Default.TxtUrlValue;
            //TxtUrl.ForeColor = Color.Black;
            Timer mytimer = new Timer();
            mytimer.Interval = Decimal.ToInt32(1000 *60*NumericIntervals.Value);
            mytimer.Tick += new EventHandler(BtnAddUrl_Click_1);
            mytimer.Tick += new EventHandler(BtnAddUrl2_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl3_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl4_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl5_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl6_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl7_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl8_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl9_Click);
            mytimer.Tick += new EventHandler(BtnAddUrl10_Click);




            mytimer.Start();



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
            tableLayoutPanel1.Visible = true;
            BtnAdd1.Enabled = false;
            BtnAdd.Visible = false;
            
           
           // PictureOutput.Visible =false;
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
            PictureOutput.Visible = false;
        }

        private void BtnRsCancel_Click(object sender, EventArgs e)
        {
            TxtIp.Visible = false;
            TxtSeparetedEmails.Visible = false;
            BtnRsAddUrl.Visible = false;
            BtnRsCancel.Visible = false;
            BtnRsOutput.Visible = false;
            TxtIp.Text = "";
        }



        private void BtnRdbCancel_Click(object sender, EventArgs e)
        {
            TxtRdbIp.Visible = false;
            TxtRdbSeparetedEmails.Visible = false;
            BtnRdbAddIp.Visible = false;
            BtnRdbCancel.Visible = false;
            BtnRdbOutput.Visible = false;
            TxtRdbIp.Text = "  IP:port";
        }


        private void BtnCancel_Click_1(object sender, EventArgs e)
        {

            TxtUrl.Text = "  URL or IP";
            TxtSepartedEmails.Text = "  , separted emails";
            tableLayoutPanel1.Visible = false;
            BtnAdd.Visible = true;
            BtnAdd.Enabled = true;
            PictureOutput.Visible = false;

            //TxtUrl.Text = Properties.Settings.Default.TxtUrlValue;



        }

        public void InitTimer()
        {
           
        }

        private void BtnAddUrl_Click_1(object sender, EventArgs e)
        {

            Image succeeded = Image.FromFile(@"C:\Users\personal\Desktop\succeeded.png");
            Image loader = Image.FromFile(@"C:\Users\personal\Desktop\loader.gif");
            Image unableToRetrive = Image.FromFile(@"C:\Users\personal\Desktop\UnableToRetrive.jpg");
            Image failed = Image.FromFile(@"C:\Users\personal\Desktop\failed.png");
           

           
            

            string url = TxtUrl.Text;
            string substring1 = "https://";
            if (url.Contains(substring1))
            {
                url = TxtUrl.Text;
            }
            else
            {
                url = "https://" + TxtUrl.Text;
            }


            string emailBody1;

            if (TxtUrl.Text == "  URL or IP")
            {
                LblUrlWarning.Visible = true;
              

            }
            else
            {
               
                LblUrlWarning.Visible = false;

                try
                    
                {

                    PictureOutput.Visible = true;
                    PictureOutput.Image = loader;
                    BtnAdd1.Enabled = true;
                   

                    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                    if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    {

                        PictureOutput.Image = succeeded;
                        emailBody1 = TxtUrl.Text + " this server is up";
                        Email(emailBody1, TxtSepartedEmails);
                        myHttpWebResponse.Close();
                    }
                }
                catch (WebException)
                {
                    emailBody1 = TxtUrl.Text + " this server is down";
                    Email(emailBody1,TxtSepartedEmails);

                    PictureOutput.Image =unableToRetrive;
                }

                catch (Exception)
                {


                    emailBody1 = TxtUrl.Text + " this server is down";
                    Email(emailBody1, TxtSepartedEmails);
                    PictureOutput.Image = failed;
                }

                

            }
            
            {

               /* BtnAddUrl.Cursor = Cursors.No;
                TxtUrl.Cursor = Cursors.No;
                TxtSepartedEmails.Cursor = Cursors.No;
                */
                
                
            }

        }

        private void BtnRsCancel_Click_1(object sender, EventArgs e)
        {
            TxtIp.Visible = false;
            TxtSeparetedEmails.Visible = false;
            BtnRsAddUrl.Visible = false;
            BtnRsCancel.Visible = false;
            BtnRsOutput.Visible = false;
            TxtIp.Text = "  IP:port";


        }

        private void BtnRsAddUrl_Click_1(object sender, EventArgs e)
        {
           

        }

        private void BtnRdbAddIp_Click_1(object sender, EventArgs e)
        {
           

        }

        private void BtnRdbCancel_Click_1(object sender, EventArgs e)
        {
            TxtRdbIp.Visible = false;
            TxtRdbSeparetedEmails.Visible = false;
            BtnRdbAddIp.Visible = false;
            BtnRdbCancel.Visible = false;
            BtnRdbOutput.Visible = false;
            TxtRdbIp.Text = "  IP:port";
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
            this.NumericIntervals.TabIndex = 5;
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

           /* TxtGlobalEmail.BorderStyle = BorderStyle.None;
            Pen p = new Pen(Color.Red);
            Graphics g = e.Graphics;

            g.DrawRectangle(p, new Rectangle(TxtGlobalEmail.Location.X  -1, TxtGlobalEmail.Location.Y - 1, TxtGlobalEmail.Width + 2, TxtGlobalEmail.Height + 2));
            */

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
          
            int a;
            a = Decimal.ToInt32(NumericIntervals.Value);

            if (a>=1 && a<=180)
            {

                if (TxtGlobalEmail.Text == "  Multiple emails separeted by ,")
                {

                    LblUpdates.Text = "Updated Sucessfully";
                    LblUpdates.ForeColor = Color.Green;
                    LblUpdates.Visible = true;
                }

                else if (TxtGlobalEmail.Text.Contains("@gmail.com"))
                {
                    TxtSepartedEmails.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails2.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails3.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails4.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails5.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails6.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails7.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails8.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails9.Text = TxtGlobalEmail.Text;
                    TxtSepartedEmails10.Text = TxtGlobalEmail.Text;

                    TxtSepartedEmails.ForeColor = Color.Black;
                    TxtRdbSeparetedEmails.Text = TxtGlobalEmail.Text;
                    TxtRdbSeparetedEmails.ForeColor = Color.Black;
                    TxtSeparetedEmails.Text = TxtGlobalEmail.Text;
                    TxtSeparetedEmails.ForeColor = Color.Black;





                    LblUpdates.Text = "Updated Sucessfully";
                    LblUpdates.ForeColor = Color.Green;
                }
               
                else 
                {
                    
                    LblUpdates.Text = "Invalid email";
                    LblUpdates.ForeColor = Color.Red;
                }


            }
            else
            {
                LblUpdates.Text = "interval should be between 5 and 180";
                LblUpdates.ForeColor = Color.Red;
                LblUpdates.Visible = true;

            }


             
           



        }

        private void TxtRdbIp_BindingContextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

      

       
        public void Email(string email,System.Windows.Forms.TextBox t)
        {
            try
            {
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.gmail.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new NetworkCredential("surendranunna98@gmail.com","Suri@123");

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("surendranunna98@gmail.com");
                mailDetails.To.Add(t.Text.Trim());
                mailDetails.Subject = "Pinger status";
                mailDetails.Body = email;

                clientDetails.Send(mailDetails);
              //  MessageBox.Show("your email has been sent");
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


        }

        private void TxtUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUrl_MouseHover(object sender, EventArgs e)
        {
            if (TxtUrl.Text == "  URL or IP")
            
         { 
            toolTip1.Show("https://google.com", TxtUrl);
            toolTip1.OwnerDraw = true;
            toolTip1.BackColor = Color.Black;
            toolTip1.ForeColor = Color.White;
          }

            else
            {
                toolTip1.Show(TxtUrl.Text, TxtUrl);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }
        private void TxtSepartedEmails_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails);
               
            }

            else
            {
                toolTip1.Show(TxtSepartedEmails.Text,TxtSepartedEmails);
                
            }


        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
           
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
          


        }



        private void RemoteServerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtSepartedEmails_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureOutput_Click(object sender, EventArgs e)
        {
           

        }

        private void PictureOutput_MouseHover(object sender, EventArgs e)
        {

            Image succeeded = Image.FromFile(@"C:\Users\personal\Desktop\succeeded.png");
            Image loader = Image.FromFile(@"C:\Users\personal\Desktop\loader.gif");
            Image unableToRetrive = Image.FromFile(@"C:\Users\personal\Desktop\UnableToRetrive.jpg");
            Image failed = Image.FromFile(@"C:\Users\personal\Desktop\failed.png");

            Double d = Decimal.ToDouble(NumericIntervals.Value);
            if (d >= 1 && d <= 180)
            {

            //  if (PictureOutput.Image == succeeded)
              //  {


                    toolTip1.Show("status: is alive nextRunAt " + DateTime.Now.AddMinutes(d), PictureOutput);
                    toolTip1.OwnerDraw = true;
                    toolTip1.BackColor = Color.Black;
                    toolTip1.ForeColor = Color.White;
               //}
             }

            /*else if(PictureOutput.Image == unableToRetrive)
            {
                toolTip1.Show("status: is unable To Retrive" +
                    " nextrun at" + DateTime.Today, PictureOutput);
               
            }*/

           /*else if (PictureOutput.Image == failed)
            {
                toolTip1.Show("status: is Dead" +
                    " nextrun at" + DateTime.Today, PictureOutput);
              }*/ 
          




        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetPinger rs = new ResetPinger();
            rs.Show();
        }

        private void TxtGlobalEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void PingerApp_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void WebsitePanel_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void BtnAdd1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Visible = true;
            BtnAdd1.Visible = false;
            BtnAdd2.Enabled = false;


        }

        private void BtnAdd2_Click(object sender, EventArgs e)
        {
            BtnAdd2.Visible = false;
            tableLayoutPanel3.Visible = true;
            BtnAdd3.Enabled = false;

        }

        private void BtnAdd3_Click(object sender, EventArgs e)
        {
            BtnAdd3.Visible = false;
            tableLayoutPanel4.Visible = true;
            BtnAdd4.Enabled = false;


        }

        private void BtnAdd4_Click(object sender, EventArgs e)
        {
            BtnAdd4.Visible = false;
            tableLayoutPanel5.Visible = true;
            BtnAdd5.Enabled = false;

        }

        private void BtnAdd5_Click(object sender, EventArgs e)
        {
            BtnAdd5.Visible = false;
            tableLayoutPanel6.Visible = true;
            BtnAdd6.Enabled = false;
        }

        private void BtnAdd6_Click(object sender, EventArgs e)
        {
            BtnAdd6.Visible = false;
            tableLayoutPanel7.Visible = true;
            BtnAdd7.Enabled = false;

        }

        private void BtnAdd7_Click(object sender, EventArgs e)
        {
            BtnAdd7.Visible = false;
            tableLayoutPanel8.Visible = true;
            BtnAdd8.Enabled = false;

        }

        private void BtnAdd8_Click(object sender, EventArgs e)
        {
            BtnAdd8.Visible = false;
            tableLayoutPanel9.Visible = true;
            BtnAdd9.Enabled = false;

        }

        private void BtnAdd9_Click(object sender, EventArgs e)
        {
            BtnAdd9.Visible = false;
            tableLayoutPanel10.Visible = true;
            BtnAdd10.Enabled = false;

        }

        private void BtnAdd10_Click(object sender, EventArgs e)
        {
            LblUrlWarning10.Visible = true;
            LblUrlWarning10.Text = "Maximum of 10 sites are allowed";
           
        }
        public void output(System.Windows.Forms.TextBox tburl, System.Windows.Forms.PictureBox p, System.Windows.Forms.Label L,System.Windows.Forms.Button b
            , System.Windows.Forms.TextBox tb)
        {
            Image succeeded = Image.FromFile(@"C:\Users\personal\Desktop\succeeded.png");
            Image loader = Image.FromFile(@"C:\Users\personal\Desktop\loader.gif");
            Image unableToRetrive = Image.FromFile(@"C:\Users\personal\Desktop\UnableToRetrive.jpg");
            Image failed = Image.FromFile(@"C:\Users\personal\Desktop\failed.png");
            string url1 = tburl.Text;
            string separtedEmail = tb.Text;
            string emailBody;

            string substring1 = "https://";
            if (url1.Contains(substring1))
            {
                url1 = url1;

            }
            else
            {
                url1 = "https://" + url1;

            }


              if ((url1.Contains("  URL or IP")) && !(separtedEmail.Contains("@gmail.com")) && !(separtedEmail.Contains("  , separted emails")))
            {
                L.Text = "Enter website details, Invalid email";
                L.Visible = true;

            }
           else if ((url1.Contains("  URL or IP")) && (separtedEmail.Contains("@gmail.com")) || (separtedEmail.Contains("  , separted emails")))
            {
                L.Text = "Enter website details";
                L.Visible = true;
            }
           
              else if(!(separtedEmail.Contains("@gmail.com")) || (separtedEmail.Contains("  , separted emails")))
            {
                L.Text = "Invalid email";
                L.Visible = true;
            }
            else
            {
                L.Visible = false;

                try
                {
                   
                    p.Visible = true;
                    p.Image = loader;
                    b.Enabled = true;

                    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url1);

                    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                    if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    {
                      
                        p.Image = succeeded;
                        emailBody = url1 + " this server is up";
                        Email(emailBody,tb);


                        myHttpWebResponse.Close();
                    }
                }
                catch (WebException)
                {
                    p.Image = unableToRetrive;
                    emailBody = url1 + " this server is down";
                    Email(emailBody,tb);

                }

                catch (Exception)
                {
                    p.Image = failed;

                    emailBody = url1 + " this server is down";
                    Email(emailBody,tb);
                }

            }
        }

        private void BtnAddUrl2_Click(object sender, EventArgs e)
        {
            output(TxtUrl2, PictureOutput2, LblUrlWarning2,BtnAdd2,TxtSepartedEmails2);
           
        }

        private void BtnAddUrl3_Click(object sender, EventArgs e)
        {
            
            output(TxtUrl3, PictureOutput3, LblUrlWarning3, BtnAdd3, TxtSepartedEmails3);
           
        }

        private void BtnAddUrl4_Click(object sender, EventArgs e)
        {
           
            output(TxtUrl4, PictureOutput4, LblUrlWarning4, BtnAdd4,TxtSepartedEmails4);
           

        }

        private void BtnAddUrl5_Click(object sender, EventArgs e)
        {
            output(TxtAddUrl5, PictureOutput5, LblUrlWarning5, BtnAdd5, TxtSepartedEmails5);
           
        }

        private void BtnAddUrl6_Click(object sender, EventArgs e)
        {
            output(TxtAddUrl6, PictureOutput6, LblUrlWarning6, BtnAdd6, TxtSepartedEmails6);
           
        }

        private void BtnAddUrl7_Click(object sender, EventArgs e)
        {
            output(TxtAddUrl7, PictureOutput7, LblUrlWarning7, BtnAdd7, TxtSepartedEmails7);
            
        }

        private void BtnAddUrl8_Click(object sender, EventArgs e)
        {
           
            output(TxtAddUrl8, PictureOutput8, LblUrlWarning8, BtnAdd8, TxtSepartedEmails8);
            
        }

        private void BtnAddUrl9_Click(object sender, EventArgs e)
        {
         
            output(TxtAddUrl9, PictureOutput9, LblUrlWarning9, BtnAdd9, TxtSepartedEmails9);
           
        }

        private void BtnAddUrl10_Click(object sender, EventArgs e)
        {
            
            output(TxtAddUrl10, PictureOutput10, LblUrlWarning10, BtnAdd10, TxtSepartedEmails10);
            

        }

        private void PictureOutput7_Click(object sender, EventArgs e)
        {

        }

        private void TxtUrl2_MouseHover(object sender, EventArgs e)
        {
            if (TxtUrl2.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtUrl2);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtUrl2.Text, TxtUrl2);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtUrl3_MouseHover(object sender, EventArgs e)
        {
            if (TxtUrl3.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtUrl3);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtUrl3.Text, TxtUrl3);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }

        }

        private void TxtUrl2_Enter(object sender, EventArgs e)
        {
            if (TxtUrl2.Text == "  URL or IP")
            {
                TxtUrl2.Text = "";
                TxtUrl2.ForeColor = Color.Black;
            }
        }

        private void TxtUrl3_Enter(object sender, EventArgs e)
        {
            if (TxtUrl3.Text == "  URL or IP")
            {
                TxtUrl3.Text = "";
                TxtUrl3.ForeColor = Color.Black;
            }
        }

        private void TxtUrl4_Enter(object sender, EventArgs e)
        {
            if (TxtUrl4.Text == "  URL or IP")
            {
                TxtUrl4.Text = "";
                TxtUrl4.ForeColor = Color.Black;
            }
        }

        private void TxtAddUrl5_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl5.Text == "  URL or IP")
            {
                TxtAddUrl5.Text = "";
                TxtAddUrl5.ForeColor = Color.Black;
            }
        }

        private void TxtAddUrl6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddUrl6_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl6.Text == "  URL or IP")
            {
                TxtAddUrl6.Text = "";
                TxtAddUrl6.ForeColor = Color.Black;
            }
        }

        private void TxtAddUrl7_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl7.Text == "  URL or IP")
            {
                TxtAddUrl7.Text = "";
                TxtAddUrl7.ForeColor = Color.Black;
            }
        }

        private void TxtAddUrl8_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl8.Text == "  URL or IP")
            {
                TxtAddUrl8.Text = "";
                TxtAddUrl8.ForeColor = Color.Black;
            }
        }

        private void TxtAddUrl9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAddUrl9_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl9.Text == "  URL or IP")
            {
                TxtAddUrl9.Text = "";
                TxtAddUrl9.ForeColor = Color.Black;
            }
        }

        private void TxtUrl2_Leave(object sender, EventArgs e)
        {
            if (TxtUrl2.Text == "")
            {
                TxtUrl2.Text = "  URL or IP";
                TxtUrl2.ForeColor = Color.Silver;
            }
        }

        private void TxtUrl3_Leave(object sender, EventArgs e)
        {
            if (TxtUrl3.Text == "")
            {
                TxtUrl3.Text = "  URL or IP";
                TxtUrl3.ForeColor = Color.Silver;
            }
        }

        private void TxtUrl4_Leave(object sender, EventArgs e)
        {
            if (TxtUrl4.Text == "")
            {
                TxtUrl4.Text = "  URL or IP";
                TxtUrl4.ForeColor = Color.Silver;
            }
        }

        private void TxtAddUrl5_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl5.Text == "")
            {
                TxtAddUrl5.Text = "  URL or IP";
                TxtAddUrl5.ForeColor = Color.Silver;
            }
        }

        private void TxtAddUrl6_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl6.Text == "")
            {
                TxtAddUrl6.Text = "  URL or IP";
                TxtAddUrl6.ForeColor = Color.Silver;
            }
        }

        private void TxtAddUrl7_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl7.Text == "")
            {
                TxtAddUrl7.Text = "  URL or IP";
                TxtAddUrl7.ForeColor = Color.Silver;
            }
        }

        private void TxtAddUrl8_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl8.Text == "")
            {
                TxtAddUrl8.Text = "  URL or IP";
                TxtAddUrl8.ForeColor = Color.Silver;
            }
        }

        private void TxtAddUrl9_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl9.Text == "")
            {
                TxtAddUrl9.Text = "  URL or IP";
                TxtAddUrl9.ForeColor = Color.Silver;
            }
        }

        private void TxtUrl4_MouseHover(object sender, EventArgs e)
        {
            if (TxtUrl4.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtUrl4);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtUrl4.Text, TxtUrl4);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl5_MouseHover(object sender, EventArgs e)
        {
            if (TxtAddUrl5.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl5);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl5.Text, TxtAddUrl5);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl6_MouseMove(object sender, MouseEventArgs e)
        {
            if (TxtAddUrl6.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl6);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl6.Text, TxtAddUrl6);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl7_MouseHover(object sender, EventArgs e)
        {
            if (TxtAddUrl7.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl7);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl7.Text, TxtAddUrl7);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl8_MouseHover(object sender, EventArgs e)
        {
            if (TxtAddUrl8.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl8);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl8.Text, TxtAddUrl8);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl9_MouseHover(object sender, EventArgs e)
        {
            if (TxtAddUrl9.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl9);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl9.Text, TxtAddUrl9);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtSepartedEmails2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSepartedEmails2_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails2.Text == "  , separted emails")
            {
                TxtSepartedEmails2.Text = "";
                TxtSepartedEmails2.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails3_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails3.Text == "  , separted emails")
            {
                TxtSepartedEmails3.Text = "";
                TxtSepartedEmails3.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails4_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails4.Text == "  , separted emails")
            {
                TxtSepartedEmails4.Text = "";
                TxtSepartedEmails4.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails5_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails5.Text == "  , separted emails")
            {
                TxtSepartedEmails5.Text = "";
                TxtSepartedEmails5.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails6_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails6.Text == "  , separted emails")
            {
                TxtSepartedEmails6.Text = "";
                TxtSepartedEmails6.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails7_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails7.Text == "  , separted emails")
            {
                TxtSepartedEmails7.Text = "";
                TxtSepartedEmails7.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails8_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails8.Text == "  , separted emails")
            {
                TxtSepartedEmails8.Text = "";
                TxtSepartedEmails8.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails9_Enter(object sender, EventArgs e)
        {
            if (TxtSepartedEmails9.Text == "  , separted emails")
            {
                TxtSepartedEmails9.Text = "";
                TxtSepartedEmails9.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails2_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails2.Text == "")
            {
                TxtSepartedEmails2.Text = "  , separted emails";
                TxtSepartedEmails2.ForeColor = Color.Silver;
            }
        }

        private void TxtSepartedEmails3_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails3.Text == "")
            {
                TxtSepartedEmails3.Text = "  , separted emails";
                TxtSepartedEmails3.ForeColor = Color.Silver;
            }
        }

        private void TxtSepartedEmails4_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails4.Text == "")
            {
                TxtSepartedEmails4.Text = "  , separted emails";
                TxtSepartedEmails4.ForeColor = Color.Silver;
            }
        }

        private void TxtSepartedEmails5_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails5.Text == "")
            {
                TxtSepartedEmails5.Text = "  , separted emails";
                TxtSepartedEmails5.ForeColor = Color.Silver;
            }

        }

        private void TxtSepartedEmails6_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails6.Text == "")
            {
                TxtSepartedEmails6.Text = "  , separted emails";
                TxtSepartedEmails6.ForeColor = Color.Silver;
            }

        }

        private void TxtSepartedEmails7_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails7.Text == "")
            {
                TxtSepartedEmails7.Text = "  , separted emails";
                TxtSepartedEmails7.ForeColor = Color.Silver;
            }

        }

        private void TxtSepartedEmails8_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails8.Text == "")
            {
                TxtSepartedEmails8.Text = "  , separted emails";
                TxtSepartedEmails8.ForeColor = Color.Silver;
            }

        }

        private void TxtSepartedEmails9_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails9.Text == "")
            {
                TxtSepartedEmails9.Text = "  , separted emails";
                TxtSepartedEmails9.ForeColor = Color.Silver;
            }
        }

        private void TxtSepartedEmails2_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails2.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails2);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails2.Text, TxtSepartedEmails2);

            }
        }

        private void TxtSepartedEmails3_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails3.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails3);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails3.Text, TxtSepartedEmails3);

            }
        }

        private void TxtSepartedEmails4_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails4.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails4);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails4.Text, TxtSepartedEmails4);

            }
        }

        private void TxtSepartedEmails5_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails5.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails5);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails5.Text, TxtSepartedEmails5);

            }
        }

        private void TxtSepartedEmails6_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails6.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails6);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails6.Text, TxtSepartedEmails6);

            }
        }

        private void TxtSepartedEmails7_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails7.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails7);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails7.Text, TxtSepartedEmails7);

            }
        }

        private void TxtSepartedEmails8_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails8.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails8);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails8.Text, TxtSepartedEmails8);

            }
        }

        private void TxtSepartedEmails9_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails9.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails9);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails9.Text, TxtSepartedEmails9);

            }
        }

        private void BtnCancel2_Click(object sender, EventArgs e)
        {
            TxtUrl2.Text = "  URL or IP";
            TxtSepartedEmails2.Text = "  , separted emails";
            tableLayoutPanel2.Visible = false;
            BtnAdd1.Visible = true;
            BtnAdd1.Enabled = true;
            PictureOutput2.Visible = false;

           
        }

        private void BtnCancel3_Click(object sender, EventArgs e)
        {

            TxtUrl3.Text = "  URL or IP";
            TxtSepartedEmails3.Text = "  , separted emails";
            tableLayoutPanel3.Visible = false;
            PictureOutput3.Visible = false;
            BtnAdd2.Visible = true;
            BtnAdd2.Enabled = true;
           
        }

        private void BtnCancel4_Click(object sender, EventArgs e)
        {
            TxtUrl4.Text = "  URL or IP";
            TxtSepartedEmails4.Text = "  , separted emails";
            tableLayoutPanel4.Visible = false;
            PictureOutput4.Visible = false;
            BtnAdd3.Visible = true;
            BtnAdd3.Enabled = true;
        }

        private void BtnCancel5_Click(object sender, EventArgs e)
        {
            TxtAddUrl5.Text = "  URL or IP";
            TxtSepartedEmails5.Text = "  , separted emails";
            tableLayoutPanel5.Visible = false;
            PictureOutput5.Visible = false;
            BtnAdd4.Visible = true;
            BtnAdd4.Enabled = true;
        }

        private void BtnCancel6_Click(object sender, EventArgs e)
        {
            TxtAddUrl6.Text = "  URL or IP";
            TxtSepartedEmails6.Text = "  , separted emails";
            tableLayoutPanel6.Visible = false;
            PictureOutput6.Visible = false;
            BtnAdd5.Visible = true;
            BtnAdd5.Enabled = true;
        }

        private void BtnCancel7_Click(object sender, EventArgs e)
        {
            TxtAddUrl7.Text = "  URL or IP";
            TxtSepartedEmails7.Text = "  , separted emails";
            tableLayoutPanel7.Visible = false;
            PictureOutput7.Visible = false;
            BtnAdd6.Visible = true;
            BtnAdd6.Enabled = true;
        }

        private void BtnCancel8_Click(object sender, EventArgs e)
        {
            TxtAddUrl8.Text = "  URL or IP";
            TxtSepartedEmails8.Text = "  , separted emails";
            tableLayoutPanel8.Visible = false;
            PictureOutput8.Visible = false;
            BtnAdd7.Visible = true;
            BtnAdd7.Enabled = true;
        }

        private void BtnCancel9_Click(object sender, EventArgs e)
        {
            TxtAddUrl9.Text = "  URL or IP";
            TxtSepartedEmails9.Text = "  , separted emails";
            tableLayoutPanel9.Visible = false;
            PictureOutput9.Visible = false;
            BtnAdd8.Visible = true;
            BtnAdd8.Enabled = true;
        }

        private void BtnCancel10_Click(object sender, EventArgs e)
        {
            TxtAddUrl10.Text = "  URL or IP";
            TxtSepartedEmails10.Text = "  , separted emails";
            tableLayoutPanel10.Visible = false;
            PictureOutput10.Visible = false;
            BtnAdd9.Visible = true;
            BtnAdd9.Enabled = true;
        }

        private void TxtAddUrl10_MouseHover(object sender, EventArgs e)
        {
            if (TxtAddUrl10.Text == "  URL or IP")

            {
                toolTip1.Show("https://google.com", TxtAddUrl10);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;
            }

            else
            {
                toolTip1.Show(TxtAddUrl10.Text, TxtAddUrl10);
                toolTip1.OwnerDraw = true;
                toolTip1.BackColor = Color.Black;
                toolTip1.ForeColor = Color.White;

            }
        }

        private void TxtAddUrl10_Leave(object sender, EventArgs e)
        {
            if (TxtAddUrl10.Text == "")
            {
                TxtAddUrl10.Text = "  URL or IP";
                TxtAddUrl10.ForeColor = Color.Silver;
            }

        }

        private void TxtAddUrl10_Enter(object sender, EventArgs e)
        {
            if (TxtAddUrl10.Text == "  URL or IP")
            {
                TxtAddUrl10.Text = "";
                TxtAddUrl10.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails10_MouseHover(object sender, EventArgs e)
        {
            if (TxtSepartedEmails10.Text == "  , separted emails")

            {
                toolTip1.Show("email@gmail.com", TxtSepartedEmails10);

            }

            else
            {
                toolTip1.Show(TxtSepartedEmails10.Text, TxtSepartedEmails10);

            }

        }

        private void TxtSepartedEmails10_Enter(object sender, EventArgs e)
        {
              if (TxtSepartedEmails10.Text == "  , separted emails")
            {
                TxtSepartedEmails10.Text = "";
                TxtSepartedEmails10.ForeColor = Color.Black;
            }
        }

        private void TxtSepartedEmails10_Leave(object sender, EventArgs e)
        {
            if (TxtSepartedEmails10.Text == "")
            {
                TxtSepartedEmails10.Text = "  , separted emails";
                TxtSepartedEmails10.ForeColor = Color.Silver;
            }
        }
    }
    }






