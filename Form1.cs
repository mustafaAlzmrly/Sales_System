using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMS_PRO_MAX
{
    
    public partial class Form1 : Form
    { 
        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        dialog dialo = new dialog();
        FRM_HOME fRM_HOME ;
        details details;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frm_txt_user.Text = Convert.ToString(db.Users.Count());
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
            txt_cont_item.Text = Convert.ToString(db.Items.Count());
            if (pn_home.Visible == false)
            {
                pn_home.Visible = true;
            }
            else
            {
                pn.Controls.Clear();
                pn.Controls.Add(pn_home);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (pn_lift.Width == 250)
            {
                pn_lift.Width = 50;
                pn_had.Visible = false;

            }
            else
            {
                pn_lift.Width = 250;
                pn_had.Visible = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
            fRM_HOME = new FRM_HOME();
            pn.Controls.Clear();
            pn.Controls.Add(fRM_HOME.pn_cat);
            db = new DB_AMS_PROEntities5();
            fRM_HOME.dataGridView1.DataSource = db.Items.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FRM_ADD fadd = new FRM_ADD();
            fadd.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
           /* Login log = new Login();
            this.Enabled = false;
            log.Show();
            this.Hide();*/
            
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
/*            dialo = new dialog();
            var res = MessageBox.Show("هل انت متاكد من هذه العملية", "تسجيل الخروج", MessageBoxButtons.YesNo);
             if(res==DialogResult.Yes)
            {
                
                dialo.label6.Text = "تم تسجيل الخروج";
                dialo.Show();
                btn_login.Enabled = true;
                btn_login.Visible = true;
                btn_cancel.Visible = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                btn_alert.Enabled = false;
                txt_cot_alert.Visible = false;
                pn.Controls.Clear();
                txt_username.Text = "اسم مستخدم";
            }*/

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FRM_ADDuser fru = new FRM_ADDuser();
            fru.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cls_alert d = new Cls_alert();
            d.button4_Click();
            FRM_Alert fal = new FRM_Alert();
            fal.Show();
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            details = new details();
            frm_txt_user.Text =Convert.ToString( db.Users.Count());
            txt_cont_item.Text= Convert.ToString(db.Items.Count());
            txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
            var cont = Convert.ToInt32(txt_cot_alert.Text);
            if (cont != 0)
            {
                details.txt_det.Text = "لديك تنبيهات";
                details.timer1.Interval = 10000;
                details.Show();
            }

            /*FRM_Alert fal = new FRM_Alert();
            fRM_HOME = new FRM_HOME();
            db = new DB_AMS_PROEntities5();
            fal.dataGridView1.DataSource = db.Alerts.ToList();
            fRM_HOME.dataGridView1.DataSource = db.Items.ToList();*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frm_txt_user_Click(object sender, EventArgs e)
        {

        }
        public string usern()
        {
            return txt_username.Text;
        }
    }
}
