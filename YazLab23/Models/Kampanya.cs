//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YazLab23.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kampanya
    {
        public int FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public Nullable<int> FirmaLokasyonX { get; set; }
        public Nullable<int> FirmaLokasyonY { get; set; }
        public string KampanyaIcerik { get; set; }
        public Nullable<int> KampanyaSuresi { get; set; }
        public string KampanyaTarih { get; set; }
        public string Tur { get; set; }
    }
}
