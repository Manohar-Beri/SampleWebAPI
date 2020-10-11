using System;
using System.Collections.Generic;

namespace SampleWebAPI.Models
{
    public partial class IlJaobdtl
    {
        public int Fobdid { get; set; }
        public int? Interfaceid { get; set; }
        public int? Ftob { get; set; }
        public string Batchid { get; set; }
        public string Batchname { get; set; }
        public int? Interfacerefid { get; set; }
        public string Interfacerefno { get; set; }
        public string Interfacetype { get; set; }
        public string Statuscode { get; set; }
        public string Statusmessages { get; set; }
        public DateTime? Datecreated { get; set; }
        public string Createdby { get; set; }
        public DateTime? Datemodified { get; set; }
        public string Modifiedby { get; set; }
        public string Stateid { get; set; }
        public string Ownerorgid { get; set; }
        public string Ownerlocid { get; set; }
        public string Associatedflag { get; set; }
    }
}
