using System;
using System.Collections.Generic;

namespace TriviaWebService.Models
{
    public partial class TadcountryPopulations
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public int? Population { get; set; }
        public string TestColumn { get; set; }
    }
}
