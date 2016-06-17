using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Gash_Pi
{
    
    class Barcode : VerifyProcess
    {
        ChargeProcess charge = new ChargeProcess();

        public int decode(string value)
        {
            //decode process

            //initialize code 
            int code = 0 ;
            int chargeAmount; 

            try
            {
                code = Int32.Parse(value);
                chargeAmount = code; 
                charge.ChargeAmount = chargeAmount; 
            }
            catch (FormatException except)
            {
                Debug.WriteLine(except.Message);
            }

            return code;
        }
    }
}
