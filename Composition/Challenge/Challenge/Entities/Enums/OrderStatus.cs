using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.Entities.Enums {
    enum OrderStatus {
        PendingPayment = 0;
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}