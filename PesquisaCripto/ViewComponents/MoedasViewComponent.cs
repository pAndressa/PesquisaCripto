﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PesquisaCripto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaCripto.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedasContexto _moedasContexto;

        public MoedasViewComponent(MoedasContexto moedasContexto)
        {
            _moedasContexto = moedasContexto;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _moedasContexto.Moedas.ToListAsync());
        }
    }
}
