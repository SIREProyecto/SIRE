﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIRE.Administracion.Datos
{
    public class DTO_Consulta
    {
        public string SessionID { get; set; }

        public int StartIndex { get; set; }
        public int CurrentPage
        {
            get
            {
                return (StartIndex / (PageSize == 0 ? 10 : PageSize)) + 1;
            }
        }
        public int PageSize { get; set; }
        public string OrderField { get; set; }
    }
}
