using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF_Patient.Validaicja
{
    class ValidacijaDatum : ValidationRule
    {
          public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {

                try
                {
                    var s = value;

                    if ((DateTime)s > DateTime.Now)
                    {
                        return new ValidationResult(false, "Ne možete odabrati datum iz buducnosti!");

                    }


                    return new ValidationResult(true, null);

                }
                catch
                {
                    return new ValidationResult(false, "Doslo je do nepoznate greske");
                }
            }
        
    }
}
