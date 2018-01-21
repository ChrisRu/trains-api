﻿using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TrainAPI.Models;

namespace TrainAPI.Controllers
{
    [Route("/")]
    public class TrainController : Controller
    {
        private Random Random { get; }

        // GET /
        // Returns all trains
        [EnableCors("MyPolicy")]
        [HttpGet]
        public List<Train> Get()
        {
            return TrainManager.Trains;
        }

        // GET /{id}
        // Returns train matching ID
        [EnableCors("MyPolicy")]
        [HttpGet("{id}")]
        public Train Get(int id)
        {
            return TrainManager.Trains.Find(train => train.Id == id);
        }
    }
}
