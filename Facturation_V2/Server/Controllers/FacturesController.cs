﻿using Facturation_V2.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturation_V2.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacturesController : ControllerBase
    {
        private readonly ILogger<FacturesController> _logger;
        private readonly IBusinessData _data;

        public FacturesController(ILogger<FacturesController> logger, IBusinessData data)
        {
            _logger = logger;
            _data = data;
        }

        [HttpGet]
        public IEnumerable<Facture> Get()
        {
            return _data.lesFactures;
        }

        [HttpGet("{numero}")]
        public ActionResult<Facture> Get(string numero)
        {
            var facture = _data.lesFactures.Where(f => f.Numero == numero).FirstOrDefault();

            if (facture != null)
            {
                return facture; 
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public void Post([FromBody] FactureDTO factureDTO)
        {
            if (ModelState.IsValid)
            {
                _data.lesFactures.Add(factureDTO.ToFacture());
            }
        }
    }
}
