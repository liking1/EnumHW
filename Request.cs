using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumHW
{
    struct Request : ICloneable
    {
        public uint Code { get; set; }
        public Client clientNew { get; }
        public DateTime OrderTime { get; set; }
        public List<RequestItem> requestItems { get; set; }
        public readonly double OrderSum
        {
            get
            {
                double sum = 0;
                foreach (RequestItem r in requestItems)
                {
                    sum += (double)r.article_.Price * r.NumberOfItems;
                }
                return sum;
            }
        }
        public Request(uint code, Client client, DateTime dateTime, List<RequestItem> requestItem)
        {
            Code = code;
            clientNew = client;
            OrderTime = dateTime;
            requestItems = requestItem;
            clientNew.CountOrders = (uint)requestItem.Count;
            clientNew.SumOfOrders += OrderSum;
        }
        public override string ToString()
        {
            return $"\n\nRequest\nCode : {Code}\n" +
                $"Client {clientNew}\n" +
                $"Order Time : {OrderTime}\n" +
                $"Request Items : {String.Join('\n', requestItems)}\n";
        }
        public object Clone()
        {
            return new Request(Code, new Client(clientNew.Code, 
                clientNew.FullName, clientNew.Adress, clientNew.PhoneNumber, 
                clientNew.CountOrders, clientNew.SumOfOrders ), 
                OrderTime, new List<RequestItem>(requestItems));
        }
    }
}
