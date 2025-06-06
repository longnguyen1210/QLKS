﻿
using qlksss.Class;
namespace qlksss
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void mnuPhieu_Click(object sender, EventArgs e)
        {
            // TODO: Xử lý khi click vào mục Phiếu
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();

        }
        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();

        }

        private void mnuDanhMuc_Click(object sender, EventArgs e)
        {

        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmDMNhanVien = new frmDMNhanVien();
            this.Hide();
            frmDMNhanVien.ShowDialog();

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKhachHang = new frmKhachHang();
            this.Hide();
            frmKhachHang.ShowDialog();
        }

        private void mnuLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLoaiPhong = new frmLoaiPhong();
            this.Hide();
            frmLoaiPhong.ShowDialog();
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            frmPhong frmPhong = new frmPhong();
            this.Hide();
            frmPhong.ShowDialog();
        }

        private void mnuDichVu_Click(object sender, EventArgs e)
        {
            frmDV frmDV = new frmDV();
            this.Hide();
            frmDV.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
