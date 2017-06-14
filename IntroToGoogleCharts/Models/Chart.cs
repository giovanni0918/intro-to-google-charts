using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroToGoogleCharts.Models
{
    public class Chart
    {
        public int ChartID { get; set; }
        public object Labels { get; set; }
        public object Options { get; set; }
    }
}