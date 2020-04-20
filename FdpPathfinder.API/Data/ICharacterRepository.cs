using System;
using System.Threading.Tasks;
using FdpPathfinder.API.Models;

namespace FdpPathfinder.API.Data
{
    public interface ICharacterRepository
    {
        Task<Character> GetCharacterById(int characterId);
        void InsertCharacter(Character character);
        void UpdateCharacter(Character character);
    }
}