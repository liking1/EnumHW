using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    class Client
    {
        private uint code;
        private string fullName;
        private string adress;
        private string phoneNumber;
        private uint countOrders;
        private double sum;
        public uint Code {
            get => code;
            set
            {
                this.code = value;
            }
        }
        public string FullName
        {
            get => fullName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Wrong name");
                }
                this.fullName = value;
            }
        }
        public string Adress
        {
            get => adress;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Wrong adress");
                }
                this.adress = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Wrong phone number");
                }
                this.phoneNumber = value;
            }
        }
        public uint CountOrders
        {
            get => countOrders;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wrong count");
                }
                this.countOrders = value;
            }
        }
        public double SumOfOrders
        {
            get => sum;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wrong sum");
                }
                this.sum = value;
            }
        }
        public Client(uint code, string fullName, string adress, string phoneNumber, uint countOrders, double sum)
        {
            this.Code = code;
            this.FullName = fullName;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.CountOrders = countOrders;
            this.SumOfOrders = sum;
        }
        public override string ToString()
        {
            return $"=========Client=========\n" +
                $"Code : {code}\n" +
                $"FullName : {FullName}\n" +
                $"Adress : {Adress}\n" +
                $"Phone Number : {PhoneNumber}\n" +
                $"Count Orders : {CountOrders}\n" +
                $"Sum of Orders : {SumOfOrders}";
        }
    }
    
}
