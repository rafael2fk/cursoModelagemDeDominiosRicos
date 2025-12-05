namespace NerdStore.Pagamentos.AntiCorruption
{
    public interface IPaymentConfigurationManager
    {
        string GetValue(string node);
    }
}