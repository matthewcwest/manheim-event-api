using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ManheimEventApi.Models.Units
{
    [Table("Images")]
    public class Images
    {
        public int ID { get; set; }

        public string type { get; set; }

        public string href { get; set; }
    }
}