using AutoMapper;
using Notado.Models;
using Notado.ViewModels;

namespace Notado.AutoMapper
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Adm, AdmViewModel>();
            CreateMap<Aluno, AlunoViewModel>();
            CreateMap<Avaliacao, AvaliacaoViewModel>();
            CreateMap<Disciplina, DisciplinaViewModel>();
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<Professor, ProfessorViewModel>();
            CreateMap<Prova, ProvaViewModel>();
            CreateMap<Recuperacao, RecuperacaoViewModel>();
            CreateMap<Trabalho, TrabalhoViewModel>();
            CreateMap<Turma, TurmaViewModel>();
            CreateMap<Usuario, UsuarioViewModel>();
            CreateMap<Nota, NotaViewModel>();

        }
    }
}