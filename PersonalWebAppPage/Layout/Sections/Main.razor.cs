using Microsoft.AspNetCore.Components;

namespace PersonalWebAppPage.Layout.Sections;

public partial class Main
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
