using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Hoc_Them
{
    public partial class Form1 : Form
    {
        public static string phanquyen;
        public Form1()
        {
            InitializeComponent();
            hideAllSubMenu();
        }
        private void hideAllSubMenu()
        {
            panelUpdateSubmenu.Visible = false;
            panelThongKeSubmenu.Visible = false;
            panelHelpSubmenu.Visible = false;
            panelHeThongSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelUpdateSubmenu.Visible == true)
                panelUpdateSubmenu.Visible = false;
            if (panelThongKeSubmenu.Visible == true)
                panelThongKeSubmenu.Visible = false;
            if (panelHelpSubmenu.Visible == true)
                panelHelpSubmenu.Visible = false;
            if (panelHeThongSubmenu.Visible == true)
                panelHeThongSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUpdateSubmenu);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(panelThongKeSubmenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHelpSubmenu);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHeThongSubmenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHocSinh());
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FormLopHoc());
        }

        private void btnBuoiHoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBuoiHoc());
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGiaoVien());
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FormKhoaHoc());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new FormBLHocPhi());
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAccount());

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (phanquyen == "2")
            {
                btnGiaoVien.Visible = false;
                Phanquyen.Visible = false;
                btnKhoaHoc.Visible = false;
                btnLopHoc.Visible = false;
                button4.Visible = false;
            }
        }
    }
}
