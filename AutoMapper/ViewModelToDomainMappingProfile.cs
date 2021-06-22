using AutoMapper;
using Notado.Models;
using Notado.ViewModels;

namespace Notado.AutoMapper
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AdmViewModel, Adm>();
            CreateMap<AlunoViewModel, Aluno>();
            CreateMap<AvaliacaoViewModel, Avaliacao>();
            CreateMap<DisciplinaViewModel, Disciplina>();
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<ProfessorViewModel, Professor>();
            CreateMap<ProvaViewModel, Prova>();
            CreateMap<RecuperacaoViewModel, Recuperacao>();
            CreateMap<TrabalhoViewModel, Trabalho>();
            CreateMap<TurmaViewModel, Turma>();
            CreateMap<UsuarioViewModel, Usuario>();
            CreateMap<NotaViewModel, Nota>();
        }
    }
}