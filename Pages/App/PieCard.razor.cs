using BethanyPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace BethanyPieShop.Pages.App
{
    public partial class PieCard
    {
        [Parameter]
        public Pie? Pie { get; set; }
    }
}
