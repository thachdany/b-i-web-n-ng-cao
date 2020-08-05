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
    public partial class xemdiem1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btxemdiem_Click(object sender, EventArgs e)  

        {
            Lop_Xl xl = new Lop_Xl();
            DataClasses1DataContext db = new DataClasses1DataContext();
            dgvxemdiem.DataSource = from c in db.tlb_sinhviens
                                    join p in db.tlb_diemhks on c.MaSV equals p.MSSV
                                    where c.MaLop == DropDownlop.Text && p.HK == DropDownhk.Text && p.Namhoc == DropDownnamhoc.Text
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
            dgvxemdiem.DataBind();
        }
    }
}