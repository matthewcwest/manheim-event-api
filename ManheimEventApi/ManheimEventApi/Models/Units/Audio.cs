using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Units
{
    [Table("Audio")]
    public class Audio
    {
        public int ID { get; set; }

        public string type { get; set; }
    }
}