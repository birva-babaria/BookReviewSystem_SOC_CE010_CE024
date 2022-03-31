using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReviewSystem
{
    public class BookService : IBookService
    {
        DataSet IBookService.GetBooks()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Name, Author, DatePublished, Good, Average, Bad",
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            DataSet ds = new DataSet();
            da.Fill(ds, "books");
            return ds;
        }
        string IBookService.AddBook(string Name, string Author, string DatePublished)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("INSERT INTO books (Name, Author, DatePublished) VALUES (@name, @author, @datepublished)");
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@author", Author);
            cmd.Parameters.AddWithValue("@datepublished", DatePublished);
            cmd.Connection = cnn;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
            return "Book added successfully!";
        }
        string IBookService.UpdateBook(int Id, string Name, string Author, string DatePublished)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM books WHERE Id = @id");
            cmd1.Connection = cnn;
            cmd1.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd1.ExecuteReader();
            if(reader.HasRows)
            {
                cnn.Close();
                SqlCommand cmd = new SqlCommand("UPDATE books SET Name = @name, Author = @author, DatePublished = @datepublished WHERE Id = @id");
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@author", Author);
                cmd.Parameters.AddWithValue("@datepublished", DatePublished);
                cnn.Open();
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
                return "Book updated successfully!";
            }
            else
            {
                cnn.Close();
                return "Book with ID = " + Id + " is not present!!";
            }

        }
        string IBookService.DeleteBook(int Id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM books WHERE Id = @id");
            cmd1.Connection = cnn;
            cmd1.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd1.ExecuteReader();
            if(reader.HasRows)
            {
                cnn.Close();
                SqlCommand cmd = new SqlCommand("DELETE FROM books WHERE Id = @id");
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Connection = cnn;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                return "Book deleted successfully!";
            }
            else
            {
                return "Book with ID = " + Id + " is not present!!";
            }
        }
        string IBookService.GoodReview(int Id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Good, Average, Bad FROM books WHERE Id = @id");
            cmd1.Connection = cnn;
            cmd1.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd1.ExecuteReader();
            int good = 0;
            int average = 0;
            int bad = 0;
            double goodper = 0.00;
            double avgper = 0.00;
            double badper = 0.00;
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    good = reader.GetInt32(0);
                    average = reader.GetInt32(1);
                    bad = reader.GetInt32(2);
                }
                good += 1;
                int total = good + average + bad;
                goodper = (Convert.ToDouble(good) / Convert.ToDouble(total)) * 100.00;
                avgper = (Convert.ToDouble(average) / Convert.ToDouble(total)) * 100.00;
                badper = (Convert.ToDouble(bad) / Convert.ToDouble(total)) * 100.00;

                goodper = Math.Truncate(goodper * 100) / 100;
                avgper = Math.Truncate(avgper * 100) / 100;
                badper = Math.Truncate(badper * 100) / 100;

                cnn.Close();

                SqlCommand cmd2 = new SqlCommand("UPDATE books SET Good = @good , GoodPercentage= @goodper,AveragePercentage = @avgper, BadPercentage = @badper WHERE Id = @id");
                cmd2.Parameters.AddWithValue("@good", good);
                cmd2.Parameters.AddWithValue("@goodper", goodper);
                cmd2.Parameters.AddWithValue("@avgper", avgper);
                cmd2.Parameters.AddWithValue("@badper", badper);

                cmd2.Parameters.AddWithValue("@id", Id);
                cnn.Open();
                cmd2.Connection = cnn;
                cmd2.ExecuteNonQuery();
                cnn.Close();
                return "Good review added!";
            }
            else
            {
                return "ID = " + Id + " is invalid!!";
            }
        }
        string IBookService.AverageReview(int Id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Good, Average, Bad FROM books WHERE Id = @id");
            cmd1.Connection = cnn;
            cmd1.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd1.ExecuteReader();
            int good = 0;
            int average = 0;
            int bad = 0;
            double goodper = 0.00;
            double avgper = 0.00;
            double badper = 0.00;
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    good = reader.GetInt32(0);
                    average = reader.GetInt32(1);
                    bad = reader.GetInt32(2);
                }
                average += 1;
                int total = good + average + bad;
                goodper = (Convert.ToDouble(good) / Convert.ToDouble(total)) * 100.00;
                avgper = (Convert.ToDouble(average) / Convert.ToDouble(total)) * 100.00;
                badper = (Convert.ToDouble(bad) / Convert.ToDouble(total)) * 100.00;

                goodper = Math.Truncate(goodper * 100) / 100;
                avgper = Math.Truncate(avgper * 100) / 100;
                badper = Math.Truncate(badper * 100) / 100;
                cnn.Close();

                SqlCommand cmd2 = new SqlCommand("UPDATE books SET Average = @average ,GoodPercentage= @goodper,AveragePercentage = @avgper, BadPercentage = @badper WHERE Id = @id");
                cmd2.Parameters.AddWithValue("@average", average);
                cmd2.Parameters.AddWithValue("@goodper", goodper);
                cmd2.Parameters.AddWithValue("@avgper", avgper);
                cmd2.Parameters.AddWithValue("@badper", badper);
                cmd2.Parameters.AddWithValue("@id", Id);
                cnn.Open();
                cmd2.Connection = cnn;
                cmd2.ExecuteNonQuery();
                cnn.Close();
                return"Average review added!";
            }
            else
            {
                return "ID = " + Id + " is invalid!!";
            }
        }
        string IBookService.BadReview(int Id)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bookDB;Integrated Security=True;Pooling=False");
            cnn.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT Good, Average, Bad FROM books WHERE Id = @id");
            cmd1.Connection = cnn;
            cmd1.Parameters.AddWithValue("@id", Id);
            SqlDataReader reader = cmd1.ExecuteReader();
            int good = 0;
            int average = 0;
            int bad = 0;
            double goodper = 0.00;
            double avgper = 0.00;
            double badper = 0.00;
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    good = reader.GetInt32(0);
                    average = reader.GetInt32(1);
                    bad = reader.GetInt32(2);
                }
                bad += 1;
                int total = good + average + bad;
                goodper = (Convert.ToDouble(good) / Convert.ToDouble(total)) * 100.00;
                avgper = (Convert.ToDouble(average) / Convert.ToDouble(total)) * 100.00;
                badper = (Convert.ToDouble(bad) / Convert.ToDouble(total)) * 100.00;

                goodper = Math.Truncate(goodper * 100) / 100;
                avgper = Math.Truncate(avgper * 100) / 100;
                badper = Math.Truncate(badper * 100) / 100;
                cnn.Close();

                SqlCommand cmd2 = new SqlCommand("UPDATE books SET Bad = @bad , GoodPercentage= @goodper,AveragePercentage = @avgper, BadPercentage = @badper WHERE Id = @id");
                cmd2.Parameters.AddWithValue("@bad", bad);
                cmd2.Parameters.AddWithValue("@goodper", goodper);
                cmd2.Parameters.AddWithValue("@avgper", avgper);
                cmd2.Parameters.AddWithValue("@badper", badper);
                cmd2.Parameters.AddWithValue("@id", Id);
                cnn.Open();
                cmd2.Connection = cnn;
                cmd2.ExecuteNonQuery();
                cnn.Close();
                return "Bad review added!";
            }
            else
            {
                return "ID = " + Id + " is invalid!!"; 
            }
        }
    }
}
