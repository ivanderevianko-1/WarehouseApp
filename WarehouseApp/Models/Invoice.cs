using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseApp.Models
{
    public class Invoice
    {
        public int Id { get; set; }

        public string Type { get; set; } = "";

        public DateTime Date { get; set; }

        public string ProductName { get; set; } = "";

        public int Quantity { get; set; }

        public string Comment { get; set; } = "";
    }
}