using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;


namespace OrderManage
{
    public class OrderService
    {
      
        public List<Order> orderList = new List<Order> {};
        

        //添加订单
        public void AddOrder(int num,string clientName)
        {
            try
            {
                Order order = new Order(num, clientName);
                orderList.Add(order);
            }
            catch
            {
                throw new Exception(message: "invalid IDinput");
            }
            
        }

        //修改订单
        public void ModifyOrder(int modifiedID,string newClientName)
        {
            if (orderList[modifiedID - 1] == null)
            {
                throw new Exception(message: "fail to modify");
            }
            else
            {
                this.orderList[modifiedID - 1].ClientName = newClientName;
            }
        }
        //修改订单明细
        public void ModifyItem(int modifiedID, int itemID,OrderItem newItem)
        {
            if (orderList[modifiedID - 1] == null || orderList[modifiedID - 1].itemList[itemID - 1]==null)
            {
                throw new Exception(message: "fail to modify");
            }
            else
            {
                this.orderList[modifiedID - 1].itemList[itemID - 1] = newItem;
            }       
        }

        //删除订单
        public void DeleteOrder(int deletedOrderID)
        {
            orderList.RemoveAt(deletedOrderID-1);
        }
        
        //查询订单
        public Order SereachOrder(int num)
        {
            if(num<=0||num>orderList.Count())
            {
                throw new Exception(message: "Fail");
            }
            return orderList[num - 1];
        }
        //查询相同用户的订单时以总金额升序排列，不同用户时以订单id升序排列
        public List<Order> SereachOrder(string name)
        {
            List<int> i = new List<int> { };
            foreach(Order order in orderList)
            {
                if(order.ClientName == name)
                {
                     i.Add(order.OrderID);
                }
                
            }
            if (i == null)
            {
                throw new Exception(message: "Fail");
            }
            var sereachList = from order in orderList
                              where i.Contains(order.OrderID)
                              orderby order.SumMoney()
                              select order;

            List<Order> sereachResult = sereachList.ToList();
            return sereachResult;
        }
        //查询商品
        public List<OrderItem> SereachItem(string itemName)
        {
            List<OrderItem> sereachResult = new List<OrderItem> { };
            foreach (Order order in orderList)
            {
                foreach (OrderItem orderItem in order.itemList)
                {
                    var sereachTemp = from item in order.itemList
                                      where item.item.Name == itemName
                                      orderby item.ID
                                      select item;
                    sereachResult = sereachTemp.ToList();
                }
            }
            if(sereachResult == null)
            {
                throw new Exception(message: "fail");
            }

            return sereachResult;
        }


        public void Export(string path)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("serialized into XML:");
            XmlSerializer xmlserialize = new XmlSerializer(typeof(List<Order>));
            using (FileStream f = new FileStream(path, FileMode.Create))
            {
                xmlserialize.Serialize(f, orderList);
            }
            Console.WriteLine(File.ReadAllText(path));
        }

        public void Import(string path)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("deserialized from XML");
            XmlSerializer xmlserialize = new XmlSerializer(typeof(List<Order>));
            using (FileStream f = new FileStream(path, FileMode.Open))
            {
                orderList = (List<Order>)xmlserialize.Deserialize(f);
                orderList.ForEach(p => Console.WriteLine(p.ToString()));
            }
        }
    }
}
