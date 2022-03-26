using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookReviewClientApp
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "";
        }

        protected void AddBookSubmit_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Author = author.Text;
            string DatePublished = datepublished.Text;
            BookReviewClientApp.BookServiceReference.BookServiceClient proxy = new BookReviewClientApp.BookServiceReference.BookServiceClient("WSHttpBinding_IBookService");
            string msg = proxy.AddBook(Name, Author, DatePublished);
            Label4.Text = msg;
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}