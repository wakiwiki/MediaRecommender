﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaRecommenderApi.Models
{
    public class Media
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImageURL { get; set; }
        public string MediaURL { get; set; }
        public string Description { get; set; }
    }
}
