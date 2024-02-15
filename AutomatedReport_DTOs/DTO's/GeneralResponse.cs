﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedReport_DTOs
{
    public class GeneralResponse
    {
        public string Message { get; set; }
        public object Data { get; }
        public GeneralResponse(object Data) 
        {
            this.Data = Data;
        }
    }
}
