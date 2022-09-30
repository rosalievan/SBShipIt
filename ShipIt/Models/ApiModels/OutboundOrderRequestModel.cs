﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderRequestModel
    {
        public int WarehouseId { get; set; }
        public IEnumerable<OrderLine> OrderLines { get; set; }

        // public int orderweight = 0;

        public override String ToString()
        {
            
            // foreach (OrderLine orderline in OrderLines)
            // {
            //     orderweight += orderline.Weight;
            // }
            return new StringBuilder()
                .AppendFormat("warehouseId: {0}, ", WarehouseId)
                .AppendFormat("orderLines: {0}", OrderLines)
                // .AppendFormat("numberOfTrucks: {0}", orderweight/200)
                .ToString();
        }
    }
}
