using System.Threading.Tasks;
using FdpPathfinder.API.Models;
using Microsoft.EntityFrameworkCore;

namespace FdpPathfinder.API.Data
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly PathfinderContext _context;
        public CharacterRepository(PathfinderContext context)
        {
            _context = context;

        }

        public async Task<Character> GetCharacterById(int characterId)
        {
            
            var character = await _context.Characters.FirstOrDefaultAsync(character => character.Id == characterId);
            if(character == null)
                return null;
            return character;
        }

        public void InsertCharacter(Character character)
        {

        }

        public void UpdateCharacter(Character character)
        {
        }
    }
}