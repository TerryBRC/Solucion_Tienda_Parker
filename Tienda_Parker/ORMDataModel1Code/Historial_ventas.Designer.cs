﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Tienda_Parker.tienda
{

    [Persistent(@"historial_ventas")]
    public partial class Historial_ventas : XPLiteObject
    {
        int fId;
        [Key(true)]
        [Persistent(@"id")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        Facturas fFactura_id;
        [Persistent(@"factura_id")]
        [Association(@"Historial_ventasReferencesFacturas")]
        public Facturas Factura_id
        {
            get { return fFactura_id; }
            set { SetPropertyValue<Facturas>(nameof(Factura_id), ref fFactura_id, value); }
        }
        Usuarios fUsuario_id;
        [Persistent(@"usuario_id")]
        [Association(@"Historial_ventasReferencesUsuarios")]
        public Usuarios Usuario_id
        {
            get { return fUsuario_id; }
            set { SetPropertyValue<Usuarios>(nameof(Usuario_id), ref fUsuario_id, value); }
        }
        decimal fTotal;
        [Persistent(@"total")]
        public decimal Total
        {
            get { return fTotal; }
            set { SetPropertyValue<decimal>(nameof(Total), ref fTotal, value); }
        }
    }

}