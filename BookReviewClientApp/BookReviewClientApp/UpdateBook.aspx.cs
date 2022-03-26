using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookReviewClientApp
{
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "";
        }

        protected void UpdateBookSubmit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(id.Text);
            string Name = name.Text;
            string Author = author.Text;
            string DatePublished = datepublished.Text;
            BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookReviewClientApp.BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            string msg = proxy.UpdateBook(Id,Name,Author,DatePublished);
            Label4.Text = msg;
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}