using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FdpPathfinder.API.Data;
using FdpPathfinder.API.Models;

namespace FdpPathfinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepo;

        public CharacterController(ICharacterRepository characterRepo)
        {
            _characterRepo = characterRepo;
        }


        // GET: api/Character/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Character>> GetCharacter(int id)
        {
            var character = await _characterRepo.GetCharacterById(id);

            if (character == null)
            {
                return NotFound();
            }

            return character;
        }

       /*  // PUT: api/Character/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharacter(int id, Character character)
        {
            if (id != character.Id)
            {
                return BadRequest();
            }

            _characterRepo.Entry(character).State = EntityState.Modified;

            try
            {
                await _characterRepo.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CharacterExists(id))
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

        // POST: api/Character
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Character>> PostCharacter(Character character)
        {
            _characterRepo.Characters.Add(character);
            await _characterRepo.SaveChangesAsync();

            return CreatedAtAction("GetCharacter", new { id = character.Id }, character);
        }

        // DELETE: api/Character/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Character>> DeleteCharacter(int id)
        {
            var character = await _characterRepo.Characters.FindAsync(id);
            if (character == null)
            {
                return NotFound();
            }

            _characterRepo.Characters.Remove(character);
            await _characterRepo.SaveChangesAsync();

            return character;
        }

        private bool CharacterExists(int id)
        {
            return _characterRepo.Characters.Any(e => e.Id == id);
        }*/
    }
}
