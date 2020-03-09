﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebHospital.Models;

namespace WebHospital.Controllers
{
    public class ClientsController : Controller
    {
        private readonly List<Client> _allClients;

        public ClientsController()
        {
            ImitationDB imitationDB = new ImitationDB();
            _allClients = imitationDB.Clients;
        }

        public ViewResult Index()
        {
            ViewBag.Title = "Все клиенты";
            return View(_allClients);
        }
    }
}
