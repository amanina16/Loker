using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Lantai : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        dvlokasi.Visible = false;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        int lantai = 0;
        int noloker = Convert.ToInt32(txtloker.Text);
        int nomer = 0;
        txtloker.Text = "";

        if (noloker == 0)
        {
            lbllokasi.Text = "Tidak ada loker nomer 0";
        }
        else
        {
            while (noloker > nomer)
            {
                lantai++;
                nomer = nomer + 9;
                if (noloker <= nomer)
                {
                    break;
                }
                lantai++;
                nomer = nomer + 3;
                if (noloker <= nomer)
                {
                    break;
                }
                lantai++;
                nomer = nomer + 7;
                if (noloker <= nomer)
                {
                    break;
                }
                lantai++;
                nomer = nomer + 2;
                if (noloker <= nomer)
                {
                    break;
                }

            }

            lbllokasi.Text = "LOKASI LOKER NO " + noloker + " BERADA DI LANTAI " + lantai;
        }
        dvlokasi.Visible = true;
        txtloker.Text = "";
    }
}