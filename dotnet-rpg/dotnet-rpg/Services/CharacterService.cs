using AutoMapper;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Services
{
    public class CharacterService : ICharacterService
    {

        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CharacterService(IMapper mapper, DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _mapper = mapper;
        }

        public Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            throw new NotImplementedException();
        }



      
    }
}
