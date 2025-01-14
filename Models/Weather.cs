﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Weather_test.Models
{
    public class Weather
    {
        public string success { get; set; }
        public Result result { get; set; }
        public Records records { get; set; }
        public class Result
        {
            public string resource_id { get; set; }
            public Field[] fields { get; set; }
        }

        public class Field
        {
            public string id { get; set; }
            public string type { get; set; }
        }

        public class Records
        {
            public Location[] locations { get; set; }
        }

        public class Location
        {
            public string datasetDescription { get; set; }
            public string locationsName { get; set; }
            public string dataid { get; set; }
            public Location1[] location { get; set; }
        }

        public class Location1
        {
            [Display(Name = "地區")]
            public string locationName { get; set; }
            public string geocode { get; set; }
            [Display(Name = "經緯度")]
            public string lat { get; set; }
            public string lon { get; set; }
            public Weatherelement[] weatherElement { get; set; }
        }

        public class Weatherelement
        {
            public string elementName { get; set; }
            public string description { get; set; }
            public Time[] time { get; set; }
        }

        public class Time
        {
            public string startTime { get; set; }
            public string endTime { get; set; }
            public Elementvalue[] elementValue { get; set; }
        }

        public class Elementvalue
        {
            public string value { get; set; }
            public string measures { get; set; }
        }

        /*public string locationName { get; set; }
        public string geocode { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public Weatherelement[] weatherElement { get; set; }
        

        public class Weatherelement
        {
            public string elementName { get; set; }
            public string description { get; set; }
            public Time[] time { get; set; }
        }

        public class Time
        {
            public string startTime { get; set; }
            public string endTime { get; set; }
            public Elementvalue[] elementValue { get; set; }
        }

        public class Elementvalue
        {
            public string value { get; set; }
            public string measures { get; set; }
        }*/


    }
}
