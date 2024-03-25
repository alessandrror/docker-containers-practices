using Data;
using Microsoft.AspNetCore.Mvc;
using Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(UserContext context) : ControllerBase
{
  private readonly UserContext _context = context;

  // Get: api/users
  [HttpGet]
  public async Task<ActionResult<IEnumerable<User>>> GetUsers()
  {
    return await _context.Users.ToListAsync();
  }

  // Get: api/users/3
  [HttpGet("{id}")]
  public async Task<ActionResult<User>> GetUser(int id)
  {

    var user = await _context.Users.FindAsync(id);

    if (user == null)
    {
      return NotFound();
    }

    return user;
  }

  // Post: api/users
  [HttpPost]
  public async Task<ActionResult<User>> PostUser(User user)
  {

    _context.Users.Add(user);

    await _context.SaveChangesAsync();

    return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
  }

  // Put: api/users
  [HttpPut("{id}")]
  public async Task<ActionResult> PutUser(int id)
  {

    // if (id != user.Id)
    // {
    //   return BadRequest();
    // }

    // _context.Entry(user).State = EntityState.Modified;
    // await _context.SaveChangesAsync();

    // return NoContent();

    var user = await _context.Users.FindAsync(id);

    if (user == null)
    {
      return NotFound();
    }

    _context.Users.Update(user);
    await _context.SaveChangesAsync();

    return NoContent();

  }

  // Delete: api/users
  [HttpDelete("{id}")]
  public async Task<ActionResult> DeleteUser(int id)
  {

    var user = await _context.Users.FindAsync(id);

    if (user == null)
    {
      return NotFound();
    }

    _context.Users.Remove(user);
    await _context.SaveChangesAsync();

    return NoContent();
  }

  [HttpGet("test")]
  public string Test()
  {
    return "Hello World!";
  }

}