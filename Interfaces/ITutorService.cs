﻿using TindogService.Controllers.Request;
using TindogService.Controllers.Responses;
using TindogService.Objetos;

namespace TindogService.Interfaces
{
    public interface ITutorService
    {
        public List<Tutor> ConsultarTutor(int id_tutor);
        public List<Pet> ConsultarTutorPets(int idTutor);
        public Endereco? ConsultarTutorEndereco(int idTutor);
        public List<Pet> ConsultarPets(int idPais, int idEstado, int idCidade);
        public EnderecoResponse CadastrarEndereco(EnderecoRequest enderecoRequest);
        public bool AtualizarEndereco(int idEndereco, EnderecoRequest endereco);
        public void ValidarTutorEndereco(EnderecoRequest enderecoRequest);
        public int Logar(LoginRequest loginRequest);
        public bool ExcluirTutor(int idTutor);

    }
}
