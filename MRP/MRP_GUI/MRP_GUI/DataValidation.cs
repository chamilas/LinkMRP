using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MRP_GUI.Sales
{
    public class DataValidation
    {
        public static bool IsNumericNumber(String text) 
        {
            if (Regex.IsMatch(text, @"^\d+$"))
            {
                return true;
            }
            else 
            {
                return false;
            }    
        }

        public static bool Is2DecimalPointNumber(String text)
        {
            if (Regex.IsMatch(text, @"^[0-9]+(\.[0-9]{1,2})?$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Is3DecimalPointNumber(String text)
        {
            if (Regex.IsMatch(text, @"^[0-9]+(\.[0-9]{1,3})?$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNIC(String text)
        {
            if (Regex.IsMatch(text, "^[0-9]{9}[vVxX]$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsTime(String text)
        {
            if (Regex.IsMatch(text, "^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsHours(String text)
        {
            if (Regex.IsMatch(text, "^(?:0?[0-9]|1[0-9]|2[0-3])$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsMinutes(String text)
        {
            if (Regex.IsMatch(text, "^[0-5][0-9]$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsTimeShift(String from, String to)
        {
            if (Regex.IsMatch(from, "^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$") && Regex.IsMatch(to, "^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$"))
            {
                DateTime timeFrom = DateTime.Parse(from);
                DateTime timeTo = DateTime.Parse(to);
                if (timeFrom < timeTo)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool IsPhoneNumber(String text)
        {
            if (Regex.IsMatch(text, @"^\d{10}$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
