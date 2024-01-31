using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVEpaper
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null && Session["Login"].ToString() == "Y")
            {

            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string foldername = txtFolderName.Text;

            string[] fileList = Directory.GetFiles("D:\\Internship\\UVEpaper\\UVEpaper\\PDF\\" + foldername);


            DataTable dt = new DataTable();
            dt.Columns.Add("filename", typeof(string));
            dt.Columns.Add("mainedition", typeof(string));
            dt.Columns.Add("date", typeof(string));
            dt.Columns.Add("pagenumber", typeof(string));
            dt.Columns.Add("subedition", typeof(string));
            dt.Columns.Add("filepath", typeof(string));
            for (int i = 0; i < fileList.Length; i++)
            {
                DataRow dr = dt.NewRow();
                string sFileName = Path.GetFileName(fileList[i]);



                string mainedition = sFileName.Substring(0, 3);
                string date = sFileName.Substring(3, 2);
                string month = sFileName.Substring(5, 2);
                string year = sFileName.Substring(7, 2);
                string pageno = sFileName.Substring(9, 2);
                string subedition = sFileName.Substring(11, 4);


                string sMainEdition = "";
                string sPublishDate = "";
                string sPageNo = "";
                string sSubEdition = "";

                sPageNo = pageno;
                sPublishDate = date + "-" + month + "-20" + year;

                if (mainedition.ToUpper() == "MAN")
                {
                    sMainEdition = "Manipal";

                    if (subedition.ToUpper() == "MEDN")
                    {
                        sSubEdition = "Main Edition";
                    }
                    else if (subedition.ToUpper() == "SUDP")
                    {
                        sSubEdition = " Sudina Udupi";
                    }

                    if (subedition.ToUpper() == "SSMG")
                    {
                        sSubEdition = "sudina mangalore";
                    }
                    else if (subedition.ToUpper() == "SSGM")
                    {
                        sSubEdition = " Sudina greater Mangalore";
                    }
                    if (subedition.ToUpper() == "SBLB")
                    {
                        sSubEdition = "sudina  beltangady bantwal";
                    }
                    else if (subedition.ToUpper() == "SPTR")
                    {
                        sSubEdition = " Sudina Puttur sullia";
                    }
                    if (subedition.ToUpper() == "SKRK")
                    {
                        sSubEdition = "sudina karkala";
                    }
                    else if (subedition.ToUpper() == "SKND")
                    {
                        sSubEdition = " Sudina Kundapur";
                    }
                    if (subedition.ToUpper() == "SKSR")
                    {
                        sSubEdition = "sudina Kasargod";
                    }
                    else if (subedition.ToUpper() == "SWSS")
                    {
                        sSubEdition = " Sudina Sapthahika sampada";
                    }
                    if (subedition.ToUpper() == "SSPL")
                    {
                        sSubEdition = "Special supplement";
                    }
                    else if (subedition.ToUpper() == "SPL")
                    {
                        sSubEdition = " Special edition";
                    }



                }
                else if (mainedition.ToUpper() == "BAN")
                {
                    sMainEdition = "bangalore";
                    if (subedition.ToUpper() == "MEDN")
                    {
                        sSubEdition = "Main Edition";
                    }
                    else if (subedition.ToUpper() == "MBGR")
                    {
                        sSubEdition = "bangalore rural";
                    }
                    if (subedition.ToUpper() == "MCMR")
                    {
                        sSubEdition = "Chamarajnagar";
                    }
                    else if (subedition.ToUpper() == "MCKB")
                    {
                        sSubEdition = "Chikballapur";
                    }
                    if (subedition.ToUpper() == "MHSN")
                    {
                        sSubEdition = "Hassan";
                    }
                    else if (subedition.ToUpper() == "MKLR")
                    {
                        sSubEdition = "Kollar";
                    }
                    if (subedition.ToUpper() == "MMDY")
                    {
                        sSubEdition = "Mandya";
                    }
                    else if (subedition.ToUpper() == "MMYS")
                    {
                        sSubEdition = "Mysore";
                    }
                    if (subedition.ToUpper() == "MRMN")
                    {
                        sSubEdition = "Ramnagar";
                    }
                    else if (subedition.ToUpper() == "MTMK")
                    {
                        sSubEdition = "Tumkur";
                    }
                    if (subedition.ToUpper() == "SSPL")
                    {
                        sSubEdition = "Special edition";
                    }
                    else if (subedition.ToUpper() == "xxx")
                    {
                        sSubEdition = "null";
                    }
                }
                else if (mainedition.ToUpper() == "MUM")
                {
                    sMainEdition = "Mumbai";
                    if (subedition.ToUpper() == "MEDN")
                    {
                        sSubEdition = "Main Edition";
                    }
                  }


                    if (!(Directory.Exists(Server.MapPath("final/" + sMainEdition + "/" + sPublishDate + "/"))))
                    {
                        Directory.CreateDirectory(Server.MapPath("final/" + sMainEdition + "/" + sPublishDate + "/"));
                    }
                    File.Copy("D:\\Internship\\UVEpaper\\UVEpaper\\PDF\\" + foldername + "\\" + sFileName, Server.MapPath("final/" + sMainEdition + "/" + sPublishDate + "/") + sFileName, true);

                    dr["filename"] = sFileName;
                    dr["Mainedition"] = sMainEdition;
                    dr["date"] = sPublishDate;
                    dr["pagenumber"] = sPageNo;
                    dr["subedition"] = sSubEdition;
                    dr["filepath"] = fileList[i];

                    dt.Rows.Add(dr);




                }


                gridfilelist.DataSource = dt;
                gridfilelist.DataBind();


            
        } 
        protected void gridfilelist_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                string filename = ((HiddenField)e.Row.Cells[0].FindControl("hidfilename")).Value;
                string filepath = ((HiddenField)e.Row.Cells[0].FindControl("hidfilepath")).Value;

                ((Literal)e.Row.Cells[0].FindControl("litfilename")).Text = "<a href='pdf/"+txtFolderName.Text+"/"+filename+"' target='_blank' style='font-weight:bold;text-decoration:underline;'>"+filename+"</a>";

            }
        }
    }
}