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
    
    public partial class CLIENTES : Base
    {
        public CLIENTES()
        {
            this.CLIENTES_CRM = new HashSet<CLIENTES_CRM>();
        }
    
        public string CLIENTE { get; set; }
        public string NOME { get; set; }
        public string NOMEABR { get; set; }
        public string MORADA1 { get; set; }
        public string MORADA2 { get; set; }
        public string MORADA3 { get; set; }
        public string MORADA4 { get; set; }
        public string FMORADA1 { get; set; }
        public string FMORADA2 { get; set; }
        public string FMORADA3 { get; set; }
        public string FMORADA4 { get; set; }
        public string CODPOST { get; set; }
        public string PAIS { get; set; }
        public string ZONA { get; set; }
        public string LOCAL { get; set; }
        public string IDIOMA { get; set; }
        public Nullable<short> cee { get; set; }
        public Nullable<System.DateTime> DTINI { get; set; }
        public string NRCONT { get; set; }
        public string CLASSE { get; set; }
        public string ACTV { get; set; }
        public string FPAG { get; set; }
        public string CONDPAG { get; set; }
        public Nullable<decimal> DESCRCB1 { get; set; }
        public Nullable<decimal> DESCRCB2 { get; set; }
        public Nullable<decimal> DESCRCB3 { get; set; }
        public string MOEDA { get; set; }
        public Nullable<decimal> DESCRCB { get; set; }
        public string CodSeg { get; set; }
        public string NrActa { get; set; }
        public string NrApolice { get; set; }
        public Nullable<decimal> PLAFOND { get; set; }
        public Nullable<decimal> PLAFONDSEG { get; set; }
        public string AGENTE { get; set; }
        public Nullable<decimal> COMISSAO { get; set; }
        public string TELEF { get; set; }
        public string TELEX { get; set; }
        public string FAX { get; set; }
        public string WEB { get; set; }
        public string SKYPE { get; set; }
        public string MESSENGER { get; set; }
        public string CONTACTO { get; set; }
        public string COMENT1 { get; set; }
        public string COMENT2 { get; set; }
        public string COMENT3 { get; set; }
        public string COMENT4 { get; set; }
        public string COMENT5 { get; set; }
        public string COMENT6 { get; set; }
        public Nullable<int> TABPRC { get; set; }
        public string ID_CONTA { get; set; }
        public string NIB { get; set; }
        public string SWIFFCOD { get; set; }
        public string NOMEBANCO { get; set; }
        public string MORADAB1 { get; set; }
        public string MORADAB2 { get; set; }
        public Nullable<decimal> TXIVACLI { get; set; }
        public Nullable<bool> CONFIRMADO { get; set; }
        public string CODFORN_CLI { get; set; }
        public string PARTYID { get; set; }
        public string PARTYTYPE { get; set; }
        public Nullable<bool> INACTIVO { get; set; }
        public Nullable<System.DateTime> DATA_INACTIVO { get; set; }
        public string COD_CTB { get; set; }
        public Nullable<bool> LOJAWEB { get; set; }
        public string ETIQ_EMB { get; set; }
        public string ETIQ_EMB_RESUMO { get; set; }
        public Nullable<bool> CONF_PASS_EMB { get; set; }
        public Nullable<decimal> PORTES { get; set; }
        public Nullable<bool> ISENTOPORTES { get; set; }
        public Nullable<bool> NEWSLETTER { get; set; }
        public Nullable<bool> ENVIOCOBRANCA { get; set; }
        public string TIPO_CONTRATO { get; set; }
        public Nullable<int> KM { get; set; }
        public string GPS_LATITUDE { get; set; }
        public string GPS_LONGITUDE { get; set; }
        public string COD_RETENCAO { get; set; }
        public string SUPEREP_AGENTES { get; set; }
        public string SUPEREP_ID { get; set; }
        public string EMAIL { get; set; }
        public string CODMT { get; set; }
        public string CODTRAN { get; set; }
        public string CNDENT { get; set; }
    
        public virtual TABAGE TABAGE { get; set; }
        public virtual TABCONTASBAN TABCONTASBAN { get; set; }
        public virtual TABPAG TABPAG { get; set; }
        public virtual TABPAIS TABPAIS { get; set; }
        public virtual TABSEG TABSEG { get; set; }
        public virtual TABZON TABZON { get; set; }
        public virtual ICollection<CLIENTES_CRM> CLIENTES_CRM { get; set; }
    }
}
