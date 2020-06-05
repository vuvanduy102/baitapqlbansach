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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            Functions.Connection();
        }

        private void tìmKiếmHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimhoadonnhap timkiem_HDB = new FrmTimhoadonnhap();
            timkiem_HDB.ShowDialog();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemSach timkiem_HDB = new FrmTimKiemSach();
            timkiem_HDB.ShowDialog();
        }
    }
}
