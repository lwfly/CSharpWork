using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManage
{
    [Serializable]
    public class Order
    {
        public int OrderID { get; set; }
        public string ClientName { get; set; }
        public List<OrderItem> itemList = new List<OrderItem> { };

        public Order() { }
        public Order(int id,string name)
        {
            OrderID = id;
            ClientName = name;
        }

       

        public override string ToString()
        {
            return $"{DateTime.Now}\nOrderID:{OrderID}  ClientName:{ClientName}  Sum:{SumMoney()}";
        }

        public void ToString2()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"{ToString()}\n");
            itemList.ForEach(s => Console.WriteLine(s));
        }

        public void AddItem(int id, string goodsName, double goodsPrice,int n)
        {
            OrderItem item = new OrderItem(id, goodsName, goodsPrice,n);
            itemList.Add(item);
        }

        public double SumMoney()
        {
            double sum = 0;
            foreach(OrderItem item in itemList)
            {
                sum += item.item.Price * item.item.Num;
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID &&
                   ClientName == order.ClientName &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(itemList, order.itemList);
        }

        public override int GetHashCode()
        {
            var hashCode = -1758130255;
            hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ClientName);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(itemList);
            return hashCode;
        }
    }
    [Serializable]
    public class Goods
    {
        public double Price { get; set; }//商品单价
        public string Name { get; set; }//商品名
        public int ID { get; set; }//商品号
        public int Num { set; get; }

        public Goods() { }
        public Goods(double a,string b,int n)
        {
            Random r = new Random();
            Price = a;
            Name = b;
            ID = Math.Abs(1000 * r.Next());
            Num = n;
        }
    }

    
}
