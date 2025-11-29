using NerdStore.Core.Domain.Objects;

namespace NerdStore.Vendas.Domain
{
    public class Voucher : Entity           // desconto
    {
        public string? Codigo { get; private set; }

        public decimal? Percentual { get; private set; }

        public decimal? ValorDesconto { get; private set; }

        public int Qunatidade { get; private set; }

        public TipoDescontoVoucher TipoDescontoVoucher { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataValidade { get; private set; }

        public bool Ativo { get; private set; }

        public bool Utiliazdo { get; private set; }

        // EF Rel.
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
