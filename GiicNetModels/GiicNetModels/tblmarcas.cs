//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GiicNetModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblmarcas : Base
    {
        public tblmarcas()
        {
            this.TABLINHAS = new HashSet<TABLINHAS>();
        }
    
        public string IDMarca { get; set; }
        public string Marca { get; set; }
        public string logo { get; set; }
        public string cortexto { get; set; }
        public Nullable<decimal> margem_pvpr { get; set; }
    
        public virtual ICollection<TABLINHAS> TABLINHAS { get; set; }
    }
}
