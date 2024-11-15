using ComercioLib.DTOs;
using ComercioLib.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComercioController : ControllerBase
    {
        Comercio comercio = new Comercio();
        // GET: api/<ComercioController>
        [HttpGet]
        public IActionResult Get(int tipo, string dni, int nroCC)
        {
            Ticket t = null;
            if(tipo == 1)
            {
                t = new Cliente(dni);
                comercio.AgregarTicket(t);
            } else if (tipo == 2) 
            {
                CuentaCorriente cuenta = comercio.VerCC(nroCC);
                t = new Pagos (cuenta);
                
            }
            if (t != null)
            {

                comercio.AgregarTicket(t);
                return Ok("Ticket agregado");
            }
            return NotFound("Ticket no generado");
        }
        [HttpGet("AtenderTicket")]
        public IActionResult GetAtenderTicket(int tipo)
        {
            TicketDTO ticket = null;
            Ticket t = comercio.AtenderTicket(tipo);
            if ( t != null)
            {
                ticket = new TicketDTO(t);
                return Ok(ticket);
            }
            return NotFound("no hay turno");
        }

        [HttpGet("AtenderTicket")]
        public IActionResult GetAgregarCuentaCorriente( int nroCC, string dni)
        {
           CuentaCorriente cc = comercio.AgregarCuentaC(nroCC, dni);
            return Ok(cc);
        }

        }
    }

