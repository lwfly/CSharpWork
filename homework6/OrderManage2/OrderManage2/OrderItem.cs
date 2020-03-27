using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManage
{
    [Serializable]
    public class OrderItem
    {
        public int ID { set; get; }
        public Goods item;

        public OrderItem() { }
        public OrderItem(int id,string goodsName,double goodsPrice,int n)
        {
            item = new Goods(goodsPrice, goodsName,n);
            ID = id;
        }

        

        public override string ToString()
        {
            return $"{ID}  itemName:{item.Name}  itemID:{item.ID}  itemPrice:￥{item.Price} Number:{item.Num }";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   ID == item.ID &&
                   EqualityComparer<Goods>.Default.Equals(this.item, item.item);
        }

        public override int GetHashCode()
        {
            var hashCode = -410204602;
            hashCode = hashCode * -1521134295 + ID.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Goods>.Default.GetHashCode(item);
            return hashCode;
        }
    }
}
