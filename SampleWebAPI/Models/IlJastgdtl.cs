using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class IlJastgdtl
    {
        public int Interfaceid { get; set; }
        public string Entitycode { get; set; }
        public int? Interfacetypeid { get; set; }
        public string Interfacetype { get; set; }
        public string Transactiontype { get; set; }
        public int? Interfacerefid { get; set; }
        public string Interfacerefno { get; set; }
        public string Accountingperiod { get; set; }
        public string Interfacemessage { get; set; }
        public string Createdtimezone { get; set; }
        public string Statuscode { get; set; }
        public string Status { get; set; }
        public byte[] Datecreated { get; set; }
        public string Createdby { get; set; }
    }
}
