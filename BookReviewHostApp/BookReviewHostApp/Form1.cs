using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Description;
using BookReviewSystem;

namespace BookReviewHostApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            Uri httpa = new Uri("http://localhost:9000/HttpBinding");
            try
            {
                sh = new ServiceHost(typeof(BookService), httpa);
                WSHttpBinding httpb = new WSHttpBinding();

                ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
                sh.Description.Behaviors.Add(mBehave);
                sh.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");

                sh.AddServiceEndpoint(typeof(IBookService), httpb, httpa);
                sh.Open();
                label1.Text = "Service Running!!";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
