using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace sweetshop.Controllers{

public class RegisterModel
{
    public string? username{get; set;}

    public string? firstname{get; set;}

    public string? lastname{get; set;}

    public string? dob{get; set;}

    public string? gender{get; set;}

    public string? qualification{get; set;}

    public string? location{get; set;}

    public string? phone{get; set;}

    public string? email{get; set;}

    public string? address{get; set;}

    public string? password{get; set;}
    
    public string? confirm_password{get; set;}

}

}