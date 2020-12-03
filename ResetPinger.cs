using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingerAssignment
{
    public partial class ResetPinger : Form
    {
        public ResetPinger()
        {
            InitializeComponent();
        }
       

        private void BtnResetCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void BtnResetConfirm_Click(object sender, EventArgs e)
        {
           
           
            
        }
    }
}
