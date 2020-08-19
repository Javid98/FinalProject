using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class PublishersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PublishersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Publisher> publishers = _db.Publishers.ToList();
            return View(publishers);
        }
    }
}