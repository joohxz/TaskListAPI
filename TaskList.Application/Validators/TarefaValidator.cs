using FluentValidation;
using TaskList.Application.Requests;

namespace TaskList.Application.Validators
{
    public class TarefaValidator : AbstractValidator<TarefaRequest>
    {
        public TarefaValidator()
        {
            RuleFor(x => x.Id).NotEmpty()
                .WithMessage("O id deve ser informado")
                .GreaterThan(0).WithMessage("O id deve ser maior que zero");
            
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome da tarefa deve ser informado");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("A descrição da tarefa deve ser informada");
            
            RuleFor(x => x.Prioridade)
                .NotNull().WithMessage("A prioridade da tarefa deve ser informada")
                .IsInEnum().WithMessage("A prioridade selecionada é inválida");

            RuleFor(x => x.DataLimite)
                .NotNull().WithMessage("A data limite da tarefa deve ser informada");

            RuleFor(x => x.Status)
                .NotNull().WithMessage("O status da tarefa deve ser informado")
                .IsInEnum().WithMessage("O status selecionado é inválido");
        }
    }
}
