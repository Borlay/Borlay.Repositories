using System;
using System.Collections.Generic;
using System.Text;

namespace Borlay.Repositories
{
    public interface IIndexOrderProvider
    {
        void SetOrder(Type type, IndexLevel indexLevel, OrderType orderType);
        OrderType GetOrder(Type type, IndexLevel indexType);
    }

    public class IndexOrderProvider : IIndexOrderProvider
    {
        private readonly Dictionary<Type, OrderType[]> indexOrders = new Dictionary<Type, OrderType[]>();

        public void SetOrder(Type type, IndexLevel indexLevel, OrderType orderType)
        {
            if (indexOrders.TryGetValue(type, out var orders))
                orders[(byte)indexLevel] = orderType;
            else
            {
                orders = new OrderType[256];
                orders[(byte)indexLevel] = orderType;
                indexOrders[type] = orders;
            }
        }

        public OrderType GetOrder(Type type, IndexLevel indexLevel)
        {
            if (indexOrders.TryGetValue(type, out var orders))
                return orders[(byte)indexLevel];

            return OrderType.None;
            //throw new KeyNotFoundException($"Index order for type '{type.Name}' and level '{indexLevel}' not found");
        }
    }
}
