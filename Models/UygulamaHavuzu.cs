using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UygulamaHavuzum.Models
{
    public class UygulamaHavuzu
        {
            public string? ApplicationName { get; set; }
            public string? Image { get; set; }
            public string? ApplicationController { get; set; }
            public string? ApplicationAction { get; set; }


        }
    }
