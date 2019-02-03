using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FTActivity.Entities
{
    public class Activity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ActivityId { get; set; }
        public DateTime Date { get; set; }
        public string Contact { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
    }
}