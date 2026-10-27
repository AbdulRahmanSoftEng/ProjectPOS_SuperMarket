using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_C_Sharp_SuperMarket_DB_MISS.Employees;

namespace System_C_Sharp_SuperMarket_DB_MISS.Settings
{
    public partial class frmTasbihs : frmSharedLayoutTop
    {
        public frmTasbihs(string Title = "...")
        :base(Title){
            InitializeComponent();
        }

        public Color GetBackColor()
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                return (Color)colorDialog1.Color;
            }
            return Color.Black;
        }

        public Color GetForeColor()
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                return (Color)colorDialog1.Color;
            }
            return Color.White;
        }

        private void btnShowsForeColorText_Click(object sender, EventArgs e)
        {
            lblShowResult.ForeColor = GetForeColor();
        }

        private void btnShowsBackColorText_Click(object sender, EventArgs e)
        {
            lblShowResult.BackColor = GetBackColor();
        }

        public void ClearAllFiald()
        {
            txtID.Clear();
            txtMessage.Clear();
            lblShowResult.BackColor = Color.White;
            lblShowResult.ForeColor = Color.Black;
        }
        public void ShowTasbihToFiald()
        {
            if(dgvShowMessageTasbih.SelectedCells.Count > 0)
            {
                clsTasbih tasbih = clsTasbih.FindTasbihByID(Convert.ToInt32(dgvShowMessageTasbih.CurrentRow.Cells[0].Value));

                txtID.Text = tasbih.ID.ToString();
                txtMessage.Text = tasbih.Name;
                lblShowResult.BackColor = Color.FromArgb(tasbih.Bred, tasbih.Bgreen, tasbih.Bgreen);
                lblShowResult.ForeColor = Color.FromArgb(tasbih.Fred, tasbih.Fgreen, tasbih.Fgreen);

            }
            
        }

        public void ReadDataFromScreen(ref clsTasbih tasbih)
        {
            if (!string.IsNullOrEmpty(txtMessage.Text.Trim()))
            {
                tasbih.Name = txtMessage.Text.ToString();

                tasbih.Bred = lblShowResult.BackColor.R;
                tasbih.Bgreen = lblShowResult.BackColor.G;
                tasbih.Bblue = lblShowResult.BackColor.B;

                tasbih.Fred = lblShowResult.ForeColor.R;
                tasbih.Fgreen = lblShowResult.ForeColor.G;
                tasbih.Fblue = lblShowResult.ForeColor.B;
            }
            else
            {
                MessageBox.Show("قم بادخال رسالة التسبيج");
                return;
            }
        }

        public void AddTasbih()
        {
            clsTasbih Tasbih = new clsTasbih();

            ReadDataFromScreen(ref Tasbih);


            if(Tasbih.Name != "")
            {
                if(clsTasbih.IsExistTasbihByName(txtMessage.Text.Trim()))
                {
                    MessageBox.Show("هذة التسبيحة موجوده بالفعل");
                    return;
                }

                if (Tasbih.Save()){
                    MessageBox.Show("تم اضافة التسبيحة بنجاح");
                    ShowAllTasbih();
                }
                else
                {
                    MessageBox.Show("لم يتم اضافة التسبيحة ");
                }
            }
        }

        public void UpdateTasbih(int ID)
        {
            clsTasbih Tasbih = clsTasbih.FindTasbihByID(ID);

            ReadDataFromScreen(ref Tasbih);
            if (Tasbih != null)
            {
                if (Tasbih.Save())
                {
                    MessageBox.Show("تم التعديل بنجاح");
                    ShowAllTasbih();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل ");
                }
            }
        }

        public void DeleteTasbih(int ID)
        {

            if (clsTasbih.IsExistTasbih(ID))
            {
                if (clsTasbih.Delete(ID))
                {
                    MessageBox.Show("تم التعديل بنجاح");
                    ShowAllTasbih();
                }
                else
                {
                    MessageBox.Show("لم يتم التعديل ");
                }
            }
        }

        public void FindByName(string Name)
        {
            dgvShowMessageTasbih.DataSource = clsTasbih.FindTasbihByNameUsingLike(Name);
        }

        public void ShowAllTasbih()
        {
            DataTable dt = clsTasbih.GetAllTasbihs();
            if(dt != null)
            {
                dgvShowMessageTasbih.DataSource = dt;

                dgvShowMessageTasbih.Columns[0].Width = 40;
                dgvShowMessageTasbih.Columns[1].Width = 400;
            }
        }

        public void _Loadding()
        {
            ShowAllTasbih();
        }

        private void btnAddNewTasbih_Click(object sender, EventArgs e)
        {
            AddTasbih();
            ClearAllFiald();
        }

        private void btnDeleteTasbih_Click(object sender, EventArgs e)
        {
            if(dgvShowMessageTasbih.Rows.Count > 0)
            {

                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    if(MessageBox.Show(
                            "هل تريد حذف رسالة التسبيح ",
                            "حذف رسالة تسبيح",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading) == DialogResult.OK)
                    {
                        DeleteTasbih(ID);
                        ClearAllFiald();
                    }

                   
                }
                else
                {
                    MessageBox.Show("قم باختيار الرسالة المراد حذفها من الجدول");
                } 
            }
        }

        private void frmTasbihs_Load(object sender, EventArgs e)
        {
            _Loadding();
        }

        private void btnUpdateTasbih_Click(object sender, EventArgs e)
        {

            if (dgvShowMessageTasbih.Rows.Count > 0)
            {

                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    int ID = Convert.ToInt32(txtID.Text);
                    UpdateTasbih(ID);
                    ClearAllFiald();
                }
                else
                {
                    MessageBox.Show("قم باختيار الرسالة المراد حذفها من الجدول");
                }

            }
        }

        private void dgvShowMessageTasbih_Click(object sender, EventArgs e)
        {
            ShowTasbihToFiald();
        }

        private void txtSearchTasbihs_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchTasbihs.Text))
            {
                FindByName(txtSearchTasbihs.Text);
            }
            else
            {
                ShowAllTasbih();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
