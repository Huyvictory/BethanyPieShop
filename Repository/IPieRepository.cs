using BethanyPieShop.Models;

namespace BethanyPieShop.Repository
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie? GetPieById(int pieId);
        IEnumerable<Pie> SearchPiesByName(string pieName);
    }
}
