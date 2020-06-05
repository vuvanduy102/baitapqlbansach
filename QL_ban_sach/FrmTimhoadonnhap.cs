using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_ban_sach
{
    public partial class FrmTimhoadonnhap : Form
    {
        DataTable tblTimHDN;
        public FrmTimhoadonnhap()
        {
            InitializeComponent();
        }

        private void FrmTimhoadonnhap_Load(object sender, EventArgs e)
        {
            Functions.Connection();
            dataGridView1.DataSource = null;
        }
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtNgayNhap.Text = "";
            txtMaHang.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHang.Text == "") && (txtNgayNhap.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select a.SoHDN,a.NgayNhap,a.MaNV,a.MaNhaCC,a.TongTien from HoaDonNhap a join ChiTietHDN b on a.SoHDN=b.SoHDN where 1=1";
            if (txtMaHang.Text != "")
            {
                sql = sql + " AND b.MaSach Like '%" + txtMaHang.Text + "%'";
            }
            if (txtNgayNhap.Text != "")
            {
                sql = sql + " AND a.NgayNhap Like '%" + txtNgayNhap.Text + "%'";
            }
            tblTimHDN = Functions.GetDataToTable(sql);
            if (tblTimHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblTimHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = tblTimHDN;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimLai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dataGridView1.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có chắc chắn muốn thoát chương trình không", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
