using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Units
{
    [Table("Options")]
    public class Options
    {
        public int ID { get; set; }

        public string type { get; set; }

    }
}