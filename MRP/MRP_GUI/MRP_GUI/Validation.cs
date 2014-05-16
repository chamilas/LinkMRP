using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI
{
   public class Validation
    {

       public static void Validate_3Decimals(object sender, KeyPressEventArgs e)
       {
       if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

          
            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                {
                    e.Handled = true;
                }

            }

       }



       public static void Validate_2Decimals(object sender, KeyPressEventArgs e)
       {
           if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
           {
               e.Handled = true;
               return;
           }


           if (!char.IsControl(e.KeyChar))
           {

               TextBox textBox = (TextBox)sender;

               if (textBox.Text.IndexOf('.') > -1 &&
                        textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
               {
                   e.Handled = true;
               }

           }

       }


    }
}
