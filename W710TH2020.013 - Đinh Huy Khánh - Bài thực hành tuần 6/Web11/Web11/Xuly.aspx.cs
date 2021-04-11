using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace Web11
{
  
    public partial class Xuly : System.Web.UI.Page
    {
        List<Nhanvien> nhanviens;
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Nhanvien> nhanviens = (List<Nhanvien>)Session["danhsach"];
            if(nhanviens == null)
            {
                nhanviens = new List<Nhanvien>();
            }
            string namsinh = Request.Form["nub-namsinh"];
            string name = Request.Form["txtname"];
            // Console.WriteLine(namsinh + " " + name);
            if (name != null && namsinh != null)
            {
                int myNamsinh;
                Int32.TryParse(namsinh, out myNamsinh);
                // Nhanvien mynv = new Nhanvien(name, myNamsinh);
                nhanviens.Add(new Nhanvien(name,myNamsinh));
                Session["danhsach"] = nhanviens;

            }

            nhanviens = (List<Nhanvien>)Session["danhsach"];
            int stt = 0;
            foreach (Nhanvien nv in nhanviens)
            {
                TableRow temprow = new TableRow();
                stt++;
                TableCell tempcell1 = new TableCell();
                tempcell1.Text = stt.ToString();
                temprow.Cells.Add(tempcell1);

                TableCell tempcell2 = new TableCell();
                tempcell2.Text = nv.getHoten().ToString();
                temprow.Cells.Add(tempcell2);

                TableCell tempcell3 = new TableCell();
                tempcell3.Text = nv.getNamsinh().ToString();
                temprow.Cells.Add(tempcell3);

                tablenv.Rows.Add(temprow);
            }
        }

        private void NewMethod(Nhanvien mynv)
        {
            nhanviens.Add(mynv);
        }
    }
}

