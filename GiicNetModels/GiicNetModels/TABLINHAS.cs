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
    
    public partial class TABLINHAS
    {
        public string MARCA { get; set; }
        public string LINHA { get; set; }
    
        public virtual tblmarcas tblmarcas { get; set; }
    }
}