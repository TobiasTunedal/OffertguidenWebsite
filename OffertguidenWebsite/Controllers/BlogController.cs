using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using UsingAzureDB;
using OffertguidenWebsite.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace OffertguidenWebsite.Controllers
namespace UsingAzureDB
{
    public class BlogController : Controller
    {

        private SqlConnection con;
        //To Handle connection related activities
        private void Connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }
        // GET: /<controller>/
        public IActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBlog(BlogModel blog)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    if (CreateBlog(blog)
                    {
                        ViewBag.Message = "Employee details added successfully";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        //To Add Employee details
        public bool CreateBlog(BlogModel obj)
        {

            Connection();
            SqlCommand com = new SqlCommand("AddNewBlogDetails", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            com.Parameters.AddWithValue("@Title", obj.Title);
            com.Parameters.AddWithValue("@Text", obj.Text);
            com.Parameters.AddWithValue("@Date", obj.Date);
            com.Parameters.AddWithValue("@Picture", obj.Picture);
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {

                return true;

            }
            else
            {

                return false;
            }
        }
    }
}
