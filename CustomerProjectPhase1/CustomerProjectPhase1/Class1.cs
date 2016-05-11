using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleLayer
{
    public class CustomerBase
        {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public virtual void Validate()
            {
            throw new NotImplementedException ();
            }
        }
    public class Customer: CustomerBase
        {
        public override void Validate ( )
            {
            if (CustomerName.Length==0)
                {

                }
            if (PhoneNumber.Length == 0)
                {

                }
            if (Address.Length == 0)
                {

                }
            if (CustomerName.Length == 0)
                {

                }
            if (CustomerName.Length == 0)
                {

                }
            }
        }
    public class Lead: CustomerBase
        {
        public override void Validate ( )
            {
            base.Validate ();
            }

        }
    }
