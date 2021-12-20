using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace BlazorTemplater.Library
{
    public class CascadeParentBase : ComponentBase
    {
        [CascadingParameter] public CascadeInfo Info { get; set; }
    }
}
