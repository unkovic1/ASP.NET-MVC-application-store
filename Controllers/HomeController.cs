﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using INKO.Models;
using INKO.Services;

namespace INKO.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext context;

    public HomeController(ApplicationDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {



        var products = context.Products.OrderByDescending(p => p.Id).Take(4).ToList();
        return View(products);
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



