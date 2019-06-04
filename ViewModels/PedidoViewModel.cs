using System.Collections.Generic;
using Hamburgueria.Models;

namespace Hamburgueria.ViewModels
{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres{get;set;}
        public List<Shake> Shakes {get;set;}
    }
}