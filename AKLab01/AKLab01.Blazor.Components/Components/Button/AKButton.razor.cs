using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorComponentUtilities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace AKLab01.Blazor.Components
{
    public partial class AKButton : AKComponentBase
    {

        /// <summary>
        /// Defines the general the style of the button, Primary = blue backgroun with white color ...etc available values 
        /// </summary>
        [Parameter]
        public ButtonStyle ButtonStyle { get; set; } = ButtonStyle.Primary;

        [Parameter]
        public string? Text { get; set; }

        /// <summary>
        /// Set an Icon on the left side of the text, if Icon is not needed, by default it's null
        /// </summary>
        [Parameter]
        public string? Icon { get; set; }

        [Parameter]
        public bool IsFullWidth { get; set; }

        [Parameter]
        public EventCallback OnClick { get; set; }

        [Parameter]
        public bool IsDisabled { get; set; }

        private string _buttonClasses => new CssBuilder()
                                                .AddClass("button")
                                                .AddClass("primary", ButtonStyle == ButtonStyle.Primary)
                                                .AddClass("secondary", ButtonStyle == ButtonStyle.Secondary)
                                                .AddClass("outlined", ButtonStyle == ButtonStyle.Outlined)
                                                .AddClass("disabled", IsDisabled)
                                                .AddClass(Class, !string.IsNullOrWhiteSpace(Class))
                                                .Build();

        private string _buttonStyle => new StyleBuilder()
                                                .AddStyle("width", "100%", IsFullWidth)
                                                .Build();


    }

    public enum ButtonStyle
    {
        Primary, Secondary, Outlined
    }
}