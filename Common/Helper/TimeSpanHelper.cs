using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Util.Helper
{
    public static class TimeSpanHelper
    {
        public static string GetTimeSpan(DateTime dateTime)
        {
            string rtnResult = String.Empty;

            TimeSpan timeSpan = DateTime.Now - dateTime;
            int daySpan = (DateTime.Now.Date - dateTime.Date).Days;

            double totalMinutes = Math.Floor(timeSpan.TotalMinutes);
            double totalHoures = Math.Floor(timeSpan.TotalHours);

            //3分钟内显示刚刚
            if (totalMinutes <= 3)
            {
                rtnResult = "刚刚";
            }

            //60分钟内显示分钟
            if (totalMinutes > 3 && totalMinutes <= 60)
            {
                rtnResult = totalMinutes + "分钟前";
            }

            //30分钟到上一天夜里12点显示小时
            if (totalMinutes > 60 && daySpan == 0)
            {
                rtnResult = totalHoures + "小时前";
            }

            //昨天
            if (daySpan == 1)
            {
                rtnResult = "昨天" + dateTime.ToString("HH:mm");
            }

            if (daySpan > 1)
            {
                rtnResult = dateTime.ToString("yyyy-MM-dd HH:mm");
            }

            return rtnResult;
        }
    }
}
