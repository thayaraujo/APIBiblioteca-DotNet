using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoMakersCode.Biblioteca.Application.Models.AdicionarUsuario;
using WoMakersCode.Biblioteca.Core.Entities;
using WoMakersCode.Biblioteca.Core.Repositories;

namespace WoMakersCode.Biblioteca.Application.UseCases
{
    public class AdicionarUsuarioUseCase : IUseCaseAsync<AdicionarUsuarioRequest, AdicionarUsuarioResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        //Construtor:
        public AdicionarUsuarioUseCase(IUsuarioRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AdicionarUsuarioResponse> ExecuteAsync(AdicionarUsuarioRequest request)
        {
            var validator = new AdicionarUsuarioRequestValidator();
            var validatorResults = validator.Validate(request);

            if (!validatorResults.IsValid)
            {
                var validatorErrors = string.Empty;
                foreach (var error in validatorResults.Errors)
                    validatorErrors += error.ErrorMessage + " | ";

                throw new Exception(validatorErrors);
            }
            
            if (request == null)
                return null;

            var usuario = _mapper.Map<Usuario>(request);

            await _repository.Inserir(usuario);

            return new AdicionarUsuarioResponse();
        }
    }
}
