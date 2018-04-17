using System.ComponentModel.DataAnnotations.Schema;

namespace ManheimEventApi.Models.Units
{
    [Table("ConditionReport")]
    public class ConditionReport
    {
        public int ID { get; set; }

        public string href { get; set; }

        public string source { get; set; }
    }
}