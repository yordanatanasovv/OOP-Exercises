using SoftUniRestaurant.Models.Tables.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniRestaurant.Models.Tables.Factories
{
    public class TableFactory
    {
        public ITable CreateTable(string tableType, int tableNumber, int capacity)
        {
            ITable table;

            switch (tableType)
            {

                case "Inside": table = new InsideTable(tableNumber, capacity);
                    break;
                case "Outside": table = new OutsideTable(tableNumber, capacity);
                    break;
                default: table = null;
                    break;
            }

            return table;
        }
    }
}
