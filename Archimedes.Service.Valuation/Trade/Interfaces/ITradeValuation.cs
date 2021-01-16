using Archimedes.Library.Message.Dto;

namespace Archimedes.Service.Valuation
{
    public interface ITradeValuation
    {
        void UpdateTradeLocked(PriceDto price);
    }
}