using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace sweetshop.Controllers;

public class LoginModel
{
    public string? username{get; set;}

    public string? password{get; set;}
}