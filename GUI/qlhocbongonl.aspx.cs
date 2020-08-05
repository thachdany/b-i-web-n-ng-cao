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
    public partial class qlhocbongonl : System.Web.UI.Page
    {
        Lop_Xl xl = new Lop_Xl();
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            dgvxethb.DataSource = from c in db.tlb_sinhviens
                                    join p in db.tlb_hocbongs on c.MaSV equals p.MaSV
                                    where c.MaSV==p.MaSV
                                    select new
                                    {
                                        MaSV = p.MaSV,
                                        c.TenSV,
                                        c.MaLop,
                                        p.SDT,
                                        p.hoancanh,
                                        p.dienkhokhan,
                                        p.hientrang
                                        

                                    };
            dgvxethb.DataBind();
        }

        protected void dgvxethb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = dgvxethb.SelectedRow;
            //if (txtms.Text != "" || txtten.Text != "" || txtngaysinh.Text != "" || txtgioitinh.Text != "" || txtmalop.Text != "" || txtcvht.Text != "" || txtdc.Text != "")

            txtms.Text = gr.Cells[0].Text;
            txtten.Text = HttpUtility.HtmlDecode(gr.Cells[1].Text);
            txtsdt.Text = gr.Cells[2].Text;
            txtdkk.Text = gr.Cells[3].Text;
            TextBox1.Text =HttpUtility.HtmlDecode( gr.Cells[5].Text);

            string txttentk = gr.Cells[0].Text;
            
            var svv = xl.timten(txttentk);            
            txtlop.Text = svv.MaLop;
            txtdiachi.Text = svv.DiaChi;
        }

        protected void btduyet_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text == "" || txtdkk.Text == "")
            {
                string scr = "swal('Thông báo',' Vui lòng điền đầy đủ thông tin!!','error');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
            }
            else
            {
                bool kt;
                kt = xl.suahocbong(txtms.Text, txthientrang.Text);
                if (kt)
                {
                    // xl.themdiem(txtms.Text);

                    string scr = "swal('Thông báo','Đã duyệt','success');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                    dgvxethb.DataSource = from c in db.tlb_sinhviens
                                          join p in db.tlb_hocbongs on c.MaSV equals p.MaSV
                                          where c.MaSV == p.MaSV
                                          select new
                                          {
                                              MaSV = p.MaSV,
                                              c.TenSV,
                                              c.MaLop,
                                              p.SDT,
                                              p.hoancanh,
                                              p.dienkhokhan,
                                              p.hientrang


                                          };
                    dgvxethb.DataBind();

                }
                else
                {
                    string scr = "swal('Thông báo','Duyệt thất bại','error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                }
            }
        }
    }
}