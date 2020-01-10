using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Components
{
    public class PagerComponent : ComponentBase
    {
        [Parameter] public int PageNumber { get; set; }
        [Parameter] public int TotalRecords { get; set; }
        [Parameter] public int PageSize { get; set; } = 20;
        [Parameter] public string LinkUrl { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalRecords / PageSize);
    }

}
