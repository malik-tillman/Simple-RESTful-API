using System;
using System.Collections.Generic;

namespace TriviaWebService.Models
{
    public partial class Tadcityweathers
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int? CurTemp { get; set; }
        public string TestColumn { get; set; }
    }
}
