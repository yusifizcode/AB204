using CarTemplateMVC.DAL;
using CarTemplateMVC.Models;
using CarTemplateMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarTemplateMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //Technician technician1 = new Technician
            //{
            //    Fullname = "Eli Memmedov",
            //    Profession = "Motorist",
            //    FbLink = "www.facebook.com/avara_04",
            //    InstaLink = "www.instagram.com/mammedovf_004",
            //    XLink = "www.instagram.com/mammedovf_004",
            //    Image = "team-1.jpg"
            //};

            //Technician technician2 = new Technician
            //{
            //    Fullname = "Riad Hamidov",
            //    Profession = "Makler",
            //    FbLink = "www.facebook.com/riaad",
            //    InstaLink = "www.instagram.com/riaad",
            //    XLink = "www.instagram.com/riaad",
            //    Image = "team-2.jpg"
            //};

            //Technician technician3 = new Technician
            //{
            //    Fullname = "Nicat Cabbarov",
            //    Profession = "Backend developer",
            //    FbLink = "www.facebook.com/nicat_123",
            //    InstaLink = "www.instagram.com/nicat_123",
            //    XLink = "www.instagram.com/nicat_123",
            //    Image = "team-3.jpg"
            //};

            //Technician technician4 = new Technician
            //{
            //    Fullname = "Araz Hummetov",
            //    Profession = "Backend developer",
            //    FbLink = "www.facebook.com/arazz",
            //    InstaLink = "www.instagram.com/arazz",
            //    XLink = "www.instagram.com/arazz",
            //    Image = "team-4.jpg"
            //};

            //List<Technician> technicians = new List<Technician> { technician1, technician2, technician3, technician4 };

            //_dbContext.Technicians.AddRange(technicians);
            //_dbContext.SaveChanges();

            //Client client1 = new Client
            //{
            //    FullName = "Nazeni Mustafayeva",
            //    Description = "lorem ipsum",
            //    Image = "testimonial-1.jpg",
            //    Profession = "Backend developer"
            //};

            //Client client2 = new Client
            //{
            //    FullName = "Mehriban Safarova",
            //    Description = "lorem ipsum",
            //    Image = "testimonial-2.jpg",
            //    Profession = "Backend developer"
            //};

            //Client client3 = new Client
            //{
            //    FullName = "Zuleyxa Shirinli",
            //    Description = "lorem ipsum",
            //    Image = "testimonial-3.jpg",
            //    Profession = "Backend developer"
            //};

            //List<Client> clients = new List<Client>() { client1, client2, client3 };

            //_dbContext.Clients.AddRange(clients);
            //_dbContext.SaveChanges();


            List<Client> clients = _dbContext.Clients.ToList();
            List<Technician> technicians = _dbContext.Technicians.ToList();

            HomeVM vm = new HomeVM
            {
                Clients = clients,
                Technicians = technicians,
            };
            return View(vm);
        }
    }
}
