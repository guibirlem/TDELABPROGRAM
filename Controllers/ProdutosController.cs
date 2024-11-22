using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetAll()
    {
        return _context.Produtos.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> GetById(int id)
    {
        var produto = _context.Produtos.Find(id);

        if (produto == null)
        {
            return NotFound();
        }

        return produto;
    }

    [HttpPost]
    public ActionResult Post(Produto produto)
    {
        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public ActionResult Put(int id, Produto produtoAtualizado)
    {
        var produto = _context.Produtos.Find(id);

        if (produto == null)
        {
            return NotFound();
        }

        produto.Nome = produtoAtualizado.Nome;
        produto.Preco = produtoAtualizado.Preco;

        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var produto = _context.Produtos.Find(id);

        if (produto == null)
        {
            return NotFound();
        }

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return NoContent();
    }
}
