using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ClientsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClientRequest>>> GetClients()
    {
        return await _context.ClientRequests.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ClientRequest>> GetClient(int id)
    {
        var client = await _context.ClientRequests.FindAsync(id);
        return client == null ? NotFound() : client;
    }

    [HttpPost]
    public async Task<ActionResult<ClientRequest>> CreateClient([FromBody] ClientRequest client)
    {
        _context.ClientRequests.Add(client);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateClient(int id, [FromBody] ClientRequest client)
    {
        if (id != client.Id)
            return BadRequest();

        _context.Entry(client).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ClientExists(id))
                return NotFound();

            throw;
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteClient(int id)
    {
        var client = await _context.ClientRequests.FindAsync(id);
        if (client == null)
            return NotFound();

        _context.ClientRequests.Remove(client);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ClientExists(int id)
    {
        return _context.ClientRequests.Any(e => e.Id == id);
    }
}