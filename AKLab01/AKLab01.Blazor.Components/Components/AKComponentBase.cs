using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKLab01.Blazor.Components
{
    public class AKComponentBase : ComponentBase
    {

        [Parameter(CaptureUnmatchedValues = true)]
        public Dictionary<string, object> UserAttributes { get; set; } = new Dictionary<string, object>();

        [Parameter]
        public string? Class { get; set; }

        [Parameter]
        public string? Style { get; set; }

    }
}
