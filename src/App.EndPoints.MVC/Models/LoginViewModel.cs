﻿namespace App.EndPoints.MVC.Models;

public class LoginViewModel
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string? ReturnUrl { get; set; }
}
