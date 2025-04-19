using Microsoft.AspNetCore.Components;

namespace PersonalWebAppPage.Layout.Sections;

public partial class Aside
{
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}
