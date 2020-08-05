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
    public partial class suatttk : System.Web.UI.Page
    {
        Lop_Xl xl = new Lop_Xl();
        DataClasses1DataContext db = new DataClasses1DataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
           txttentk.Text = Convert.ToString( Session["tentk"]);
            txttentk.Enabled = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var svv = xl.timtheotentk(txttentk.Text); 
            

            if (txtmk.Text==svv.mk)
                {
                    bool kt;
                    kt = xl.suamk(txttentk.Text, txtmknew.Text);
                    if (kt)
                    {
                        string scr = "swal('Thông báo',' Cập nhật thành công','success');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                    }
                    else
                    {
                        string scr = "swal('Thông báo','Cập nhật thất bại','error');";
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                    }
                }
                else
                {
                    string scr = "swal('Thông báo','Mật khẩu cũ không đúng','error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                }
                
               
                
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            var svv = xl.timtheotentk(txttentk.Text);


            if (txtmk.Text == svv.mk)
            {
                bool kt;
                kt = xl.suamk(txttentk.Text, txtmknew.Text);
                if (kt)
                {
                    string scr = "swal('Thông báo',' Cập nhật thành công','success');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                }
                else
                {
                    string scr = "swal('Thông báo','Cập nhật thất bại','error');";
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
                }
            }
            else
            {
                string scr = "swal('Thông báo','Mật khẩu cũ không đúng','error');";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
            }



        }
    }
}