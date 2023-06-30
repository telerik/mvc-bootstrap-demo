﻿namespace Kendo_UI_Bootstrap_Integration.Models
{
    public class SalesPerRegionViewModel
    {
        public SalesPerRegionViewModel(string date, double canterbury, double manchester, double rochester) 
        {
            Date = date;
            Canterbury = canterbury;
            Manchester = manchester;
            Rochester = rochester;
        }

        public string Date
        {
            get;
            set;
        }

        public double Canterbury
        {
            get;
            set;
        }

        public double Manchester
        {
            get;
            set;
        }

        public double Rochester
        {
            get;
            set;
        }
    }
}