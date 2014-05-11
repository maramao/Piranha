﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Piranha.Areas.Manager.Views.Content
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Piranha.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Manager/Views/Content/Index.cshtml")]
    public partial class Index : System.Web.Mvc.WebViewPage<Piranha.Models.Manager.ContentModels.ListModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Manager\Views\Content\Index.cshtml"
  
    ViewBag.Title = @Piranha.Resources.Content.ListTitle ;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Head", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        function formatSitemap() {
            $.each($("".sitemap li:visible""), function (i, e) {
                if (i % 2 == 1)
                    $(this).addClass(""odd"");
                else $(this).removeClass(""odd"");
            });
        }

        var deleteimagemsg = '");

            
            #line 15 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                         Write(Piranha.Resources.Content.MessageDeleteConfirmImage);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deletedocumentmsg = \'");

            
            #line 16 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                            Write(Piranha.Resources.Content.MessageDeleteConfirmFile);

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var deletefoldermsg = \'");

            
            #line 17 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                          Write(Piranha.Resources.Content.MessageDeleteConfirmFolder);

            
            #line default
            #line hidden
WriteLiteral(@"';

        $(document).ready(function () {
            formatSitemap();

            // Handle the site tree
            $("".sitemap .action"").click(function () {
                var li = $(this).parent().parent();
                li.toggleClass(""collapsed"");
                li.toggleClass(""expanded"");
                formatSitemap();
            });

            $('.sitemap .delete').click(function () {
                if ($(this).hasClass('media-image'))
                    return confirm(deleteimagemsg);
                else if ($(this).hasClass('media-folder'))
                    return confirm(deletefoldermsg);
                else return confirm(deletedocumentmsg);
            });
        });
    </script>
");

});

DefineSection("Toolbar", () => {

WriteLiteral(" \r\n");

            
            #line 41 "..\..\Areas\Manager\Views\Content\Index.cshtml"
Write(Html.Partial("Partial/Tabs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"toolbar\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"inner\"");

WriteLiteral(">\r\n        <ul>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1574), Tuple.Create("\"", 1602)
            
            #line 45 "..\..\Areas\Manager\Views\Content\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1581), Tuple.Create<System.Object, System.Int32>(Url.Action("insert")
            
            #line default
            #line hidden
, 1581), false)
);

WriteLiteral(" class=\"add\"");

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                                                       Write(Piranha.Resources.Global.ToolbarAdd);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1681), Tuple.Create("\"", 1715)
            
            #line 46 "..\..\Areas\Manager\Views\Content\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Url.Action("insertfolder")
            
            #line default
            #line hidden
, 1688), false)
);

WriteLiteral(" class=\"addfolder\"");

WriteLiteral(">");

            
            #line 46 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                                                                   Write(Piranha.Resources.Content.ToolbarAddFolder);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n            <li><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1807), Tuple.Create("\"", 1834)
            
            #line 47 "..\..\Areas\Manager\Views\Content\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1814), Tuple.Create<System.Object, System.Int32>(Url.Action("index")
            
            #line default
            #line hidden
, 1814), false)
);

WriteLiteral(" class=\"refresh\"");

WriteLiteral(">");

            
            #line 47 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                                                          Write(Piranha.Resources.Global.ToolbarReload);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");

WriteLiteral("            ");

            
            #line 48 "..\..\Areas\Manager\Views\Content\Index.cshtml"
       Write(Piranha.Manager.Toolbar.Render(Url, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </ul>\r\n        <button");

WriteLiteral(" class=\"search\"");

WriteAttribute("title", Tuple.Create(" title=\"", 2004), Tuple.Create("\"", 2051)
            
            #line 50 "..\..\Areas\Manager\Views\Content\Index.cshtml"
, Tuple.Create(Tuple.Create("", 2012), Tuple.Create<System.Object, System.Int32>(Piranha.Resources.Global.ToolbarSearch
            
            #line default
            #line hidden
, 2012), false)
);

WriteLiteral("></button>");

            
            #line 50 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                                                                                   Write(Html.TextBox("search"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <div");

WriteLiteral(" class=\"clear\"");

WriteLiteral("></div>\r\n    </div>\r\n</div>\r\n");

});

WriteLiteral("<div");

WriteLiteral(" class=\"grid_12\"");

WriteLiteral(">\r\n    <ul");

WriteLiteral(" class=\"sitemap media\"");

WriteLiteral(">\r\n        <li");

WriteLiteral(" class=\"header\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"buttons\"");

WriteLiteral("></span>\r\n            <span");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 59 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                          Write(Piranha.Resources.Global.Created);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span");

WriteLiteral(" class=\"date\"");

WriteLiteral(">");

            
            #line 60 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                          Write(Piranha.Resources.Global.Updated);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span");

WriteLiteral(" class=\"title\"");

WriteLiteral(">");

            
            #line 61 "..\..\Areas\Manager\Views\Content\Index.cshtml"
                           Write(Piranha.Resources.Content.Filename);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </li>\r\n");

WriteLiteral("        ");

            
            #line 63 "..\..\Areas\Manager\Views\Content\Index.cshtml"
   Write(Html.Partial("Partial/ContentTree", Model.Content));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </ul>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
