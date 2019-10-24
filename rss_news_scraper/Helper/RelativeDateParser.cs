﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rss_news_scraper.Helper
{
    public class RelativeDateParser
    {
        public static string ConvertToTimeAgo(DateTime date)
        {

            if (date > DateTime.Now)
                return "few seconds ago";

            TimeSpan span = DateTime.Now - date;

            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("{0} {1} ago", years, years == 1 ? "year" : "years");
            }

            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("{0} {1} ago", months, months == 1 ? "month" : "months");
            }

            if (span.Days > 0)
                return String.Format("{0} {1} ago", span.Days, span.Days == 1 ? "day" : "days");

            if (span.Hours > 0)
                return String.Format("{0} {1} ago", span.Hours, span.Hours == 1 ? "hour" : "hours");

            if (span.Minutes > 0)
                return String.Format("{0} {1} ago", span.Minutes, span.Minutes == 1 ? "minute" : "minutes");

            if (span.Seconds > 5)
                return String.Format("{0} seconds ago", span.Seconds);

            if (span.Seconds <= 5)
                return "just now";

            return string.Empty;
        }

    }
}
