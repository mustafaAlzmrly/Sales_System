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
    public partial class FRM_Alert : Form
    {
        Cls_alert d = new Cls_alert();
        DB_AMS_PROEntities5 db;
        dialog dialo;
        Form1 frm;
        public FRM_Alert()
        {
            InitializeComponent();
        }

        private void FRM_Alert_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dB_AMS_PRODataSet2.Alerts' table. You can move, or remove it, as needed.
            this.alertsTableAdapter.Fill(this.dB_AMS_PRODataSet2.Alerts);
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                db = new DB_AMS_PROEntities5();
                frm = new Form1();
                dialo = new dialog();

                var expiredItems = db.Alerts.Where(x => x.ExpiryDate < DateTime.Now).ToList();

                if (expiredItems.Count > 0)
                {
                    var dialogResult = MessageBox.Show("هل أنت متأكد من هذا الإجراء؟ سيتم حذف جميع الأصناف التي انتهت صلاحيتها", "إجراء الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        db.Alerts.RemoveRange(expiredItems);
                        db.SaveChanges();

                        dialo.label6.Text = "تم حذف  ";
                        dialo.Show();
                    }
                }
                else
                {
                    MessageBox.Show("لا يوجد أصناف تم انتهاء صلاحيتها", "لا يمكن إجراء العملية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال بقاعدة البيانات: " + ex.Message, "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm = new Form1();
            db = new DB_AMS_PROEntities5();
            dataGridView1.DataSource = db.Alerts.ToList();
            frm.txt_cot_alert.Text = Convert.ToString(db.Alerts.Count());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
