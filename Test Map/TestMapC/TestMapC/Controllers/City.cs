﻿using System;
using System.ComponentModel.DataAnnotations;
namespace TestMapC.Controllers
{
    public class City
    {
        public string Title { get; set; }

        public double Lat { get; set; }

        public double Lng { get; set; }
    }
}