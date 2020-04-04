﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    public interface IProductStockReportBuilder
    {
        void BuildHeader();
        void BuildBody();
        void BuildFooter();
        ProductStockReport GetReport();
    }
}
