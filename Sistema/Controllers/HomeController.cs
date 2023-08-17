using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPets_mvc.Models;
using LHPets.models;

namespace LHPets_mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Clientes cl1=new Clientes(01, "Kauã Fragozo", "021.868.780-03", "kauafragozo18@gmail.com", "Mel");
        Clientes cl2= new Clientes(02,"Liara Castro", "098.903.800-99", "liaracastro@outlook.com", "Dimaria");
        Clientes cl3 =new Clientes (03, "Alessandra Fragozo", "040.507.860-95","ale.fragozo@icloud.com", " Dibu");
        Clientes cl4 = new Clientes (04,"Isabela Baldessar", "457.513.640-90", "isabelabaldessar@aluno.senai.br", "Gatolomeu");
        Clientes cl5 = new Clientes (05, "Jair Baldessar", "751.838.040-44", "jairbaldessar@hotmail.com", "Fred");

        List<Clientes> listaclientes = new List<Clientes>();
        listaclientes.Add(cl1);
        listaclientes.Add(cl2);
        listaclientes.Add(cl3);
        listaclientes.Add(cl4);
        listaclientes.Add(cl5);

        ViewBag.listaclientes = listaclientes;

        Fornecedores f1 = new Fornecedores(01,"AgroBichos", "28.547.759/0001-08", "agrobichos@icloud.com");
        Fornecedores f2 = new Fornecedores(02,"PetLover", "31.311.229/0001-70", "pet.lover@outlook.com");
        Fornecedores f3 = new Fornecedores(03,"PetMania", "65.091.710/0001-10", "petmania@gmail.com");
        Fornecedores f4 = new Fornecedores(04, "Turma do Dog", "16.096.656/0001-90", "turmadodog@aluno.senai.br");
        Fornecedores f5 = new Fornecedores(05, "Dog&CIA", "43.102.264/0001-69", "dog.cia@educar.gob.br");

        List<Fornecedores> listafornecedores = new List<Fornecedores>();
        listafornecedores.Add(f1);
        listafornecedores.Add(f2);
        listafornecedores.Add(f3);
        listafornecedores.Add(f4);
        listafornecedores.Add(f5);

        ViewBag.listafornecedores = listafornecedores;



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
