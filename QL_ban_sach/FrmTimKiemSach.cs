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
    public partial class FrmTimKiemSach : Form
    {
        DataTable tblKhoSach;
        public FrmTimKiemSach()
        {
            InitializeComponent();
        }

        private void FrmTimKiemSach_Load(object sender, EventArgs e)
        {
            Functions.Connection();
            dataGridView1.DataSource = null;
        }
        private void ResetValues()
        {
            txtTenSach.Text = "";
            txtTenNXB.Text = "";
            txtTenLoaiSach.Text = "";
            txtTenSach.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtTenSach.Text == "") && (txtTenNXB.Text == "") && (txtTenLoaiSach.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "select  a.MaSach,a.TenSach,a.SoLuong,a.DonGiaNhap,a.DonGiaBan,a.MaLoaiSach,a.MaTG,a.MaNXB,a.MaLinhVuc,a.MaNgonNgu,a.Anh,a.SoTrang" +
                " from KhoSach a join LoaiSach b on a.MaLoaiSach=b.MaloaiSach join NhaXuatBan c on a.MaNXB=c.MaNXB where 1=1";
            if (txtTenSach.Text != "")
            {
                sql = sql + " AND a.TenSach Like '%" + txtTenSach.Text + "%'";
            }
            if (txtTenLoaiSach.Text != "")
            {
                sql = sql + " AND b.TenLoaiSach Like '%" + txtTenLoaiSach.Text + "%'";
            }
            if (txtTenNXB.Text != "")
            {
                sql = sql + " AND c.TenNXB Like '%" + txtTenNXB.Text + "%'";
            }
            
            tblKhoSach = Functions.GetDataToTable(sql);
            if (tblKhoSach.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblKhoSach.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = tblKhoSach;
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
