﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{   
    internal class CantinaContext : DbContext
    {
        public CantinaContext() { }

        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Estudante> Estudantes { get;set;}
        public DbSet<Extra> Extras { get; set;}
        public DbSet<Fatura> Faturas { get; set;}
        public DbSet<Funcionario> Funcionarios { get; set;}
        public DbSet<ItemFatura> ItemFaturas { get; set;}
        public DbSet<Menu> Menus { get; set;}  
        public DbSet<Multa> Multas { get; set;} 
        public DbSet<Prato> Prato { get; set;}
        public DbSet<Professor>Professores { get; set;}
        public DbSet <Reserva> Reservas { get; set;}
        public DbSet<Utilizador> Utilizadores { get; set;}
        

    }
}
