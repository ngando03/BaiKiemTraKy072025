using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class KT
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Diem { get; set; }
       
    }
}
