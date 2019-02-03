using System;

namespace FTActivity.Models
{
    public class ActivityDTO
    {
        public DateTime Date { get; set; }
        public string Contact { get; set; }
        public double Amount { get; set; }
        public string Note { get; set; }
    }
}