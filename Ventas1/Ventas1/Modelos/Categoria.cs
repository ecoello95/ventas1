﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas1.Modelos
{
   public class Categoria
    {
        public int Id { get; internal set; }

        public class Categoria
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }

            public Categoria(int id, string descripccion)
            {
                Id = id;
                Descripcion = descripccion;

            }
        }
    }
