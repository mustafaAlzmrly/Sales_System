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
    public partial class FRM_ADDuser : Form
    {

        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        User add;
        Form1 form1;
        public int id;
        bool state;
        public FRM_ADDuser()
        {
            InitializeComponent();
        }
        private bool Save()
        {
            dialog dialog = new dialog();
            form1 = new Form1();
            // check fields

            if (edt_name.Text == "" || edt_password.Text == "" || edt_username.Text == "")
            {
                dialog.Width = this.Width;
                dialog.label6.Text = "اكمل الحقل لطفا";
                dialog.Show();
            }
            else
            {
                // Add or edit
                var checkDuplicate = CheckDuplicateData();
                if (id == 0)
                {
                    // Add
                    // Check Duplicate Data
                    
                    if (checkDuplicate == true)
                    {
                        dialog.Width = this.Width;
                        dialog.label6.Text = "اسم الصنف مكرر";
                        dialog.Show();

                    }
                    else
                    {
                        // Add
                        AddData();
                        state = true;
                        dialog.Width = this.Width;
                        dialog.label6.Text = "تمت اضافة مستخدم جديد من قبل "+form1.txt_username.Text;
                        dialog.Show();



                    }

                }
                else
                {
                    // Edit



                }
            }
            return state;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();

        }
        private bool CheckDuplicateData()
        {
            try
            {
                db = new DB_AMS_PROEntities5();
                add = db.Users.Where(x => x.Username == edt_username.Text).FirstOrDefault();
                if (add == null)
                {
                    state = false;
                }
                else
                {
                    state = true;
                }
            }
            catch
            {
                state = false;
                
            }


            return state;

        }
        private void AddData()
        {
            try
            {
                db = new DB_AMS_PROEntities5();
                add = new User()
                {

                    Fullname = edt_name.Text,
                    Username = edt_username.Text,
                    Password = edt_password.Text,

                };
                db.Entry(add).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                this.Close();
                

            }
            catch
            {
               

            }
        }
    }
}
