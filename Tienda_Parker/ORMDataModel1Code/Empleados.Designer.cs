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

    [Persistent(@"empleados")]
    public partial class Empleados : XPLiteObject
    {
        int fId;
        [Key(true)]
        [Persistent(@"id")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fNombre;
        [Persistent(@"nombre")]
        public string Nombre
        {
            get { return fNombre; }
            set { SetPropertyValue<string>(nameof(Nombre), ref fNombre, value); }
        }
        string fEmail;
        [Indexed(Name = @"email", Unique = true)]
        [Persistent(@"email")]
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fTelefono;
        [Size(15)]
        [Persistent(@"telefono")]
        public string Telefono
        {
            get { return fTelefono; }
            set { SetPropertyValue<string>(nameof(Telefono), ref fTelefono, value); }
        }
        string fDireccion;
        [Size(255)]
        [Persistent(@"direccion")]
        public string Direccion
        {
            get { return fDireccion; }
            set { SetPropertyValue<string>(nameof(Direccion), ref fDireccion, value); }
        }
        string fCargo;
        [Size(50)]
        [Persistent(@"cargo")]
        public string Cargo
        {
            get { return fCargo; }
            set { SetPropertyValue<string>(nameof(Cargo), ref fCargo, value); }
        }
        DateTime fFecha_ingreso;
        [Persistent(@"fecha_ingreso")]
        public DateTime Fecha_ingreso
        {
            get { return fFecha_ingreso; }
            set { SetPropertyValue<DateTime>(nameof(Fecha_ingreso), ref fFecha_ingreso, value); }
        }
        decimal fSalario;
        [Persistent(@"salario")]
        public decimal Salario
        {
            get { return fSalario; }
            set { SetPropertyValue<decimal>(nameof(Salario), ref fSalario, value); }
        }
        Usuarios fUsuario_id;
        [Persistent(@"usuario_id")]
        [Association(@"EmpleadosReferencesUsuarios")]
        public Usuarios Usuario_id
        {
            get { return fUsuario_id; }
            set { SetPropertyValue<Usuarios>(nameof(Usuario_id), ref fUsuario_id, value); }
        }
    }

}