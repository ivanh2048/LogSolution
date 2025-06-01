namespace LogSolution.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string TaxId { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
