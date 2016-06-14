using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gash_Pi
{
    class ChargeProcess
    {
        private int chargeAmount = 0;
        private int currentChargeAmount = 0 ;
        private int refundMoney = 0;

        public int ChargeAmount
        {
            get
            {
                return chargeAmount;
            }

            set
            {
                chargeAmount = value;
            }
        }

        public int CurrentChargeAmount
        {
            get
            {
                return currentChargeAmount;
            }

            set
            {
                currentChargeAmount = value;
            }
        }

        public int RefundMoney
        {
            get
            {
                return refundMoney;
            }

            set
            {
                refundMoney = value;
            }
        }
    }
}
