using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmoxarifadoRequisicaosController : ControllerBase
    {
        private readonly ReqContext _context;

        public AlmoxarifadoRequisicaosController(ReqContext context)
        {
            _context = context;
        }

        // GET: api/AlmoxarifadoRequisicaos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlmoxarifadoRequisicao>>> GetAlmoxarifadoRequisicao()
        {
            return await _context.AlmoxarifadoRequisicao.ToListAsync();
        }

        // GET: api/AlmoxarifadoRequisicaos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlmoxarifadoRequisicao>> GetAlmoxarifadoRequisicao(int id)
        {
            var almoxarifadoRequisicao = await _context.AlmoxarifadoRequisicao.FindAsync(id);

            if (almoxarifadoRequisicao == null)
            {
                return NotFound();
            }

            return almoxarifadoRequisicao;
        }

        // PUT: api/AlmoxarifadoRequisicaos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlmoxarifadoRequisicao(int id, AlmoxarifadoRequisicao almoxarifadoRequisicao)
        {
            if (id != almoxarifadoRequisicao.AreId)
            {
                return BadRequest();
            }

            _context.Entry(almoxarifadoRequisicao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmoxarifadoRequisicaoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AlmoxarifadoRequisicaos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlmoxarifadoRequisicao>> PostAlmoxarifadoRequisicao(AlmoxarifadoRequisicao almoxarifadoRequisicao)
        {
            _context.AlmoxarifadoRequisicao.Add(almoxarifadoRequisicao);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlmoxarifadoRequisicao", new { id = almoxarifadoRequisicao.AreId }, almoxarifadoRequisicao);
        }

        // DELETE: api/AlmoxarifadoRequisicaos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlmoxarifadoRequisicao(int id)
        {
            var almoxarifadoRequisicao = await _context.AlmoxarifadoRequisicao.FindAsync(id);
            if (almoxarifadoRequisicao == null)
            {
                return NotFound();
            }

            _context.AlmoxarifadoRequisicao.Remove(almoxarifadoRequisicao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmoxarifadoRequisicaoExists(int id)
        {
            return _context.AlmoxarifadoRequisicao.Any(e => e.AreId == id);
        }
    }
}
