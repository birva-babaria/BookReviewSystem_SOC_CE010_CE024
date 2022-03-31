using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookReviewClientApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            //DataSet ds = proxy.GetBooks();
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("select Id,Name,Author,DatePublished,GoodPercentage,AveragePercentage,BadPercentage from books", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GoToAddBook(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void GoToUpdateBook(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBook.aspx");
        }

        protected void GoToDeleteBook(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBook.aspx");
        }

        protected void reviewBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReviewBook.aspx");
        }
    }
}