﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/User/_List_Toolbar_Batch.cshtml")]
    public partial class _Areas_Admin_Views_User__List_Toolbar_Batch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_User__List_Toolbar_Batch_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityOperate;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
 if (enableSelect)
{

            
            #line default
            #line hidden
WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-purple btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 9 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
                                                                                  Write(Url.Action("EnableSelect"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量启用\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-purple btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 12 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
                                                                                  Write(Url.Action("DisableSelect"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量禁用\r\n    </button>\r\n");

            
            #line 15 "..\..\Areas\Admin\Views\User\_List_Toolbar_Batch.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
