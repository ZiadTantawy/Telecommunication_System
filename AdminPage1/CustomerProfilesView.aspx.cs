using System;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace Telecommunication_System
{
    public partial class CustomerAccounts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCustomerAccountsData();
            }
        }

        private void BindCustomerAccountsData()
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Telecom_Team_104"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connstr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM allCustomerAccounts", conn);
                    cmd.CommandType = CommandType.Text;

                    conn.Open();

                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        
                        tblCustomerAccounts.Rows.Clear();

                        TableRow headerRow = new TableRow();
                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            TableCell headerCell = new TableCell();
                            headerCell.Text = rdr.GetName(i);
                            headerRow.Cells.Add(headerCell);
                        }
                        tblCustomerAccounts.Rows.Add(headerRow);

                        
                        while (rdr.Read())
                        {
                            TableRow row = new TableRow();
                            for (int i = 0; i < rdr.FieldCount; i++)
                            {
                                TableCell cell = new TableCell();
                                cell.Text = (rdr.IsDBNull(i) ? "null" : rdr[i].ToString());
                                row.Cells.Add(cell);
                            }
                            tblCustomerAccounts.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void redirectBack(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard1.aspx");
        }
    }
}
