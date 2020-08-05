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
    public partial class xemhocbong : System.Web.UI.Page
    {
        Lop_Xl xl = new Lop_Xl();
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bthocbong_Click(object sender, EventArgs e)
        {
            var max = db.tlb_diemhks.Where(tl => tl.HK == DropDownhk.Text && tl.Namhoc == DropDownnamhoc.Text).Max(s => s.DiemTB);
            if (max < 2.5)
            {
                string scr = "swal('Thông báo','Không có ai đạt học bổng','error');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
            }
            else
            {
                //var max = db.tlb_diemhks.Where(tl => tl.HK == DropDownhk.Text && tl.Namhoc == DropDownnamhoc.Text).Max(s => s.DiemTB);
                //var max2 = db.tlb_diemhks.Where(tl => tl.HK == DropDownhk.Text && tl.Namhoc == DropDownnamhoc.Text&& tl.DiemTB==max);
                var diem = from c in db.tlb_sinhviens
                           join p in db.tlb_diemhks on c.MaSV equals p.MSSV
                           where c.MaLop == DropDownlop.Text && p.HK == DropDownhk.Text && p.Namhoc == DropDownnamhoc.Text
                           orderby p.DiemTB descending
                           orderby p.DiemRL descending

                           select new
                           {
                               MaSV = p.MSSV,
                               c.TenSV,
                               c.MaLop,
                               p.HK,
                               p.Namhoc,
                               p.DiemTB,
                               p.DiemRL,
                               p.Xeploai
                           };


                double shb = diem.Count() * 0.08;

                dgvkqhb.DataSource = diem.Take(Convert.ToInt32(Math.Round(shb, 4)));

                dgvkqhb.DataBind();
            }
        }
    }
    
}