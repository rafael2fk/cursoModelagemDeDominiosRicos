using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Commands
{
    public async class PedidoCommandHandler : IRequestHandler<AdicionarItemPedidoCommand, bool>
    {
        public Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            return true;
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                // lançar um evento de erro
            }

            return false;
        }
    }
}
