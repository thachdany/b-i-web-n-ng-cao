using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using XuLy;

namespace GUI
{
    public partial class xemdiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void seach_Click(object sender, EventArgs e)
        {
            Lop_Xl xl = new Lop_Xl();
            DataClasses1DataContext db = new DataClasses1DataContext();
            var loc = xl.timten(txttimsinhvien.Text);
            if (listloc.Text == "Tên")
            {
                dgvsearch.DataSource = from a in db.tlb_sinhviens where a.TenSV.Contains(txttimsinhvien.Text) select a;

            }
            else if (listloc.Text == "MSSV")
            {
                dgvsearch.DataSource = from a in db.tlb_sinhviens where a.MaSV.Contains(txttimsinhvien.Text) select a;
            }
            else if (listloc.Text == "Địa Chỉ")
            {
                dgvsearch.DataSource = from a in db.tlb_sinhviens where a.DiaChi.Contains(txttimsinhvien.Text) select a;
            }
            else if (listloc.Text == "Lớp")
            {
                dgvsearch.DataSource = from a in db.tlb_sinhviens where a.MaLop.Contains(txttimsinhvien.Text) select a;
            }
            else if (listloc.Text == "CVHT")
            {
                dgvsearch.DataSource = from a in db.tlb_sinhviens where a.TenCVHT.Contains(txttimsinhvien.Text) select a;
            }

            dgvsearch.DataBind();
        }
    }
}