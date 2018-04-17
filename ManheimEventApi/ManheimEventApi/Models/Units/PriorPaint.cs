using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Units
{
    [Table("PriorPaint")]
    public class PriorPaint
    {
        public int ID { get; set; }

        public string description { get; set; }

        public string condition { get; set; }
    }
}