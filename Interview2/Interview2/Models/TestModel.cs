using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Interview2.Models
{
    public class TestModel
    {
        public List<string> ListOfFiles { get; set; }
        public int Count { get; set; }
    }
}