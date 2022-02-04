namespace LabOOAutoEscola.Models
{
    public enum FormasPagamento
    {
        Carne,
        Cartao,
        Avista
    }
    public class FormaPagamento
    {
        FormasPagamento _carne = FormasPagamento.Carne;
        FormasPagamento _cartao = FormasPagamento.Cartao;
        FormasPagamento _avista = FormasPagamento.Avista;
    }
