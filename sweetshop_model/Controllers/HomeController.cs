using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using sweetshop.Models;
using Microsoft.Data.SqlClient;

namespace sweetshop.Controllers;

public class HomeController : Controller
{

    SqlConnection con = new SqlConnection();
    SqlCommand com = new SqlCommand();
    SqlDataReader? dr;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    void connectionString(){
        con.ConnectionString = "data source = 192.168.1.240\\SQLEXPRESS; database=cad_sss; User ID=CADBATCH01; Password=CAD@123pass;  TrustServerCertificate=True;";
    }

    [HttpPost]
    public IActionResult VerifyLogin(LoginModel lmodel){
        connectionString();
        con.Open();
        com.Connection= con;
        com.CommandText="SELECT * FROM sss_usr_login WHERE username='"+lmodel.username+"' AND password='"+lmodel.password+"' ;";
        
        dr=com.ExecuteReader();

        if(dr.Read()){
            con.Close();
            return View("Success");
        }
        else{
            con.Close();
            return View("Error");
        }
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Aboutus()
    {
        return View();
    }

    public IActionResult Sweets()
    {
        return View();
    }

    public IActionResult Snacks()
    {
        return View();
    }

    public IActionResult Allproducts()
    {
        return View();
    }

    public IActionResult Cart()
    {
        return View();
    }

    public IActionResult Contactus()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
