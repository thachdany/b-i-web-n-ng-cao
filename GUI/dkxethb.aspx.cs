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
    public partial class dkxethb : System.Web.UI.Page
    {
        Lop_Xl xl = new Lop_Xl();
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        int quyen = Convert.ToInt32(Session["quyen"]); ;
        if (quyen == 4)
        {
            //string scr = "swal('Thông báo','Xin chào admin','success');";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);

            
            string txttentk = Convert.ToString(Session["tentk"]);           
            var svv = xl.timten(txttentk);
            txtms.Text = svv.MaSV;
            txtten.Text = svv.TenSV;
            txtlop.Text = svv.MaLop;
            txtdiachi.Text = svv.DiaChi;
        }

           
        }

        protected void btxethb_Click(object sender, EventArgs e)
        {
            if (txtsdt.Text==""|| txtdkk.Text=="")
            {
                string scr = "swal('Thông báo',' Vui lòng điền đầy đủ thông tin!!','error');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
            }
            else

            {
                xl.xoahb(txtms.Text);
                bool kt;

                kt = xl.dkhocbong(txtms.Text,txtdkk.Text,TextBox1.Text,txtsdt.Text);

                if (kt)
                {
                    // xl.themdiem(txtms.Text);
                    
                    string scr = "swal('Thông báo','Đăng ký thành công.. Vui lòng chờ kết quả sớm nhất','success');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);

                }
                else
                {
                    string scr = "swal('Thông báo','Đăng ký thất bại.. Vui lòng kiểm tra lại thông tin','error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtdkk.Text = "";
            TextBox1.Text = "";
            txtsdt.Text = "";
        }
    }
}