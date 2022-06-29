using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DBOTry
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\learning.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State==ConnectionState.Open) {
                con.Close();
            }
            con.Open();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            newSchoolAdd();
        }

        public void newSchoolAdd()
        {
            string commandstr = "insert into table2 values('" + firstname.Text + "','" + lastname.Text + "')";
            SqlCommand cmd = new SqlCommand(commandstr, con);
            cmd.ExecuteNonQuery();
            disp_data();
        }

        public void oldSchoolAdd() {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table2 values('" + firstname.Text + "','" + lastname.Text + "')";
            System.Diagnostics.Debug.WriteLine(cmd.CommandText);
            cmd.ExecuteNonQuery();
            firstname.Text = "";
            lastname.Text = "";
            disp_data();
        }
        public void disp_data() {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table2";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

    }
}