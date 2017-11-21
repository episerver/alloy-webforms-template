using System;
using EPiServer.Core;
using AlloyTemplates.Models.Pages;

namespace AlloyTemplates.Views.Pages
{
    public partial class NewsPageTemplate : SiteTemplatePage<NewsPage>
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            NoListRootMessage.DataBind();
        }
    }
}
