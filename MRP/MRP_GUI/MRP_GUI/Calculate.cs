using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MRP_GUI
{
   public class Calculate
    {

       public static decimal CalOTHours(decimal Hours, decimal Minutes)
       {
           decimal OTMinutes = 0;

           if (Minutes != 0)
           {
               if (Minutes < 60)
               {
                   OTMinutes = Minutes / 60;
               }

           }
           else
           {
               OTMinutes = 0;
           }

           return Hours + OTMinutes;
       }

    }
}
