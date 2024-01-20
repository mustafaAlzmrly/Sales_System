using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AMS_PRO_MAX
{
    public partial class FRM_ADD : Form
    {
        DB_AMS_PROEntities5 db = new DB_AMS_PROEntities5();
        Item tb_item = new Item();
        Form1 frm;



        public int id;

        public FRM_ADD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Methods method = new Methods();
            dialog dialog = new dialog();
            details details = new details();

            try
            {
                var existingItem = db.Items.FirstOrDefault(item => item.Name == txt_name.Text);
                if (existingItem != null)
                {
                    dialog.Width = this.Width;
                    dialog.label6.Text = "اسم الصنف مكرر";
                    dialog.Show();
                }
                else
                {
                    if (txt_name.Text == "")
                    {
                        dialog.Width = this.Width;
                        dialog.label6.Text = "اسم الصنف مطلوب";
                        dialog.Show();
                    }
                    else
                    {

                        if (id == 0)
                        {
                            // Add
                            tb_item.Name = txt_name.Text;
                            tb_item.QuantityAvailable = Convert.ToInt32(txt_qun.Text);
                            tb_item.Price = Convert.ToInt32(txt_price.Text);
                            tb_item.Description = txt_des.Text;
                            tb_item.ExpiryDate = txt_dat.Value;
                            db.Items.Add(tb_item);
                            db.SaveChanges();
                            details.txt_det.Text = "تم اضافة صنف";
                            details.Show();
                            // تحديث عدد الاشعارات
                            frm = new Form1();
                            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
                        }
                        else
                        {
                            // Edit
                            var item = db.Items.Find(id);
                            if (item != null)
                            {
                                item.Name = txt_name.Text;
                                item.QuantityAvailable = Convert.ToInt32(txt_qun.Text);
                                item.Price = Convert.ToInt32(txt_price.Text);
                                item.Description = txt_des.Text;
                                item.ExpiryDate = Convert.ToDateTime(txt_dat.Text);
                                db.SaveChanges();
                                details.txt_det.Text = "تم تعديل الصنف";
                                details.Show();
                            }
                            else
                            {
                                dialog.Width = this.Width;
                                dialog.label6.Text = "الصنف غير موجود";
                                dialog.Show();
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {



        }

        private void txt_dat_TextChanged(object sender, EventArgs e)
        {

        }
    }   
    
}

