﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Prato
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }

        public Boolean Ativo { get; set; }

        public List<Reserva> Reservas { get; set; }
        public List<Menu> Menus { get; set; }


    }
}
