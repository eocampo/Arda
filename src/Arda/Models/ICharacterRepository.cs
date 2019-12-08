using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arda.Models
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetAllCharacters();
        Character GetCharacterById(int characterId);
        Character GetCharacter(string nameOrPublicKey);
    }
}
