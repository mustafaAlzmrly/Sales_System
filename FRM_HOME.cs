using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace AMS_PRO_MAX
{
    public partial class FRM_HOME : Form
    {
        Form1 frm;
        //FRM_ADD eidt;
        DB_AMS_PROEntities5 db;
        Item add;
        dialog dialo;
        User User;
        public int id;
        public FRM_HOME()
        {
            InitializeComponent();


        }



        private void button1_Click(object sender, EventArgs e)
        {

            FRM_ADD fadd = new FRM_ADD();
            fadd.Show();
        }

        private void pn_cat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_HOME_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.dB_AMS_PRODataSet.Items);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Items.ToList();
            frm = new Form1();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete_Item();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Delete_Item()
        {
            try
            {
                db = new DB_AMS_PROEntities5();
                User = new User();

                add = new Item();
                dialo = new dialog();

                if (txt_sear.Text != "")
                {
                    id = Convert.ToInt32(txt_sear.Text); // تحديد الصف المحدد واستخراج قيمة العمود "ItemID

                    if (id != 0)
                    {
                        var dialogResult = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟ لا يمكن استرجاع البيانات، سيتم حذف جميع البيانات المرتبطة", "إجراء الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            add = db.Items.FirstOrDefault(x => x.ItemID == id);

                            if (add != null)
                            {
                                frm = new Form1();
                                db.Items.Remove(add); // حذف العنصر من قاعدة البيانات
                                db.SaveChanges();

                                dialo.label6.Text = "تم حذف الصنف بواسطة ";
                                dialo.Show();

                            }
                            else
                            {
                                MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("لا يوجد بيانات لحذفها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    dialo.label6.Text = "ادخل id لحذف";
                }
                

               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال بقاعدة البيانات: " + ex.Message, "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eidit_Click(object sender, EventArgs e)
        {
            db = new DB_AMS_PROEntities5();
            if (txt_sear.Text != "") 
            {                 
                int searchId = Convert.ToInt32(txt_sear.Text);
            var item = db.Items.Find(searchId);

            if (item != null)
            {
                FRM_ADD editForm = new FRM_ADD();
                editForm.id = searchId;
                editForm.txt_name.Text = item.Name;
                    editForm.btn_add.Text = "تعديل";
                editForm.Show();
            }
            else
            {
                dialo = new dialog();
                dialo.label6.Text = "لم يتم العتور على الصنف الدي تريد تعديله";
                dialo.Show();


            }}
            else
            {
                dialo = new dialog();
                dialo.label6.Text = "لتعديل الصنف id ادخل ";
                dialo.Show();
            }
            

        }
    }
}