﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Timeboard
    {
        private static int sday { get; set; }
        private static int smonth { get; set; }
        private static int syear { get; set; }
        private static int eday { get; set; }
        private static int emonth { get; set; }
        private static int eyear { get; set; }
        private static SortedDictionary<DateOnly, SortedDictionary<int, int>> Timesheet = new SortedDictionary<DateOnly, SortedDictionary<int, int>>();
        public void ReadStartDate(int day, int month, int year)
        {
            sday = day;
            smonth = month;
            syear = year;
        }

        public void ReadEndDate(int day, int month, int year)
        {
            eday = day;
            emonth = month;
            eyear = year;
        }

        public void ReadTimesheet(int year, int month, int day, int number, int hours)
        {
            DateOnly date = new DateOnly(year, month, day);
            Timesheet.Add(date, new SortedDictionary<int, int> { [number] = hours });
        }
        public SortedDictionary<DateOnly, SortedDictionary<int,int>> WriteTimesheet()
        {
            return Timesheet;
        }
    }
}
