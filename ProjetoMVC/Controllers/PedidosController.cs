using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class PedidosController : Controller
    {
        private readonly Context _context;

        public PedidosController(Context context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var context = _context.Pedidos.Include(p => p.Fornecedor).Include(p => p.Produto);
            return View(await context.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Fornecedor)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "RazaoSocial");
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "id", "Descricao");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProdutoId,QtdPedido,FornecedorId")] Pedido pedido)
        {
            decimal valorConvertido;
            decimal total;
            if (ModelState.IsValid)
            {
                var result = _context.Produtos.Where(o => o.id == pedido.ProdutoId).FirstOrDefault();
                pedido.DataPedido = DateTime.Now;
                var str = result.Valor.Replace("R", "").Replace("$", "");
                valorConvertido = Convert.ToDecimal(str);
                total = valorConvertido * pedido.QtdPedido;
                pedido.ValorTotal = total.ToString("C");

                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "RazaoSocial", pedido.FornecedorId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "id", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "RazaoSocial", pedido.FornecedorId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "id", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Codigo,DataPedido,ProdutoId,QtdPedido,FornecedorId,ValorTotal")] Pedido pedido)
        {
            decimal valorConvertido;
            decimal total;
            if (id != pedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var result = _context.Produtos.Where(o => o.id == pedido.ProdutoId).FirstOrDefault();
                    pedido.DataPedido = DateTime.Now;
                    var str = result.Valor.Replace("R", "").Replace("$", "");
                    valorConvertido = Convert.ToDecimal(str);
                    total = valorConvertido * pedido.QtdPedido;
                    pedido.ValorTotal = total.ToString("C");
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["FornecedorId"] = new SelectList(_context.Fornecedores, "Id", "RazaoSocial", pedido.FornecedorId);
            ViewData["ProdutoId"] = new SelectList(_context.Produtos, "id", "Descricao", pedido.ProdutoId);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.Fornecedor)
                .Include(p => p.Produto)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }
    }
}
