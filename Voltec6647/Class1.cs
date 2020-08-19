using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voltec6647
{
    class Class1
    {
        static string herramienta;
        static string herramientaR;
        static string cantidadStock;
        static string nombre;
        static Boolean admin;
        static string user;
        public static string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        public static string Herramienta
        {
            get
            {
                return herramienta;
            }
            set
            {
                herramienta = value;
            }
        }   
            public static string HerramientaR
        {
            get
            {
                return herramientaR;
            }
            set
            {
                herramientaR = value;
            }
        }
        public static string CantidadStock{
            get
            {
                return cantidadStock;
            }
            set
            {
                cantidadStock = value;
            }
        }
        public static string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public static Boolean Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }
    }
}
