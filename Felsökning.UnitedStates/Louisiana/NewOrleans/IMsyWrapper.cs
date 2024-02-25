
namespace Felsökning.UnitedStates.Louisiana.NewOrleans
{
    public interface IMsyWrapper
    {
        Task<List<Flight>> GetFlightsAsync();
    }
}