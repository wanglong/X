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
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 1 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_List_Data_Item.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Item.cshtml")]
    public partial class _Views_Shared__List_Data_Item_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Item_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\_List_Data_Item.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

    var value = entity[item.Name];

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Shared\_List_Data_Item.cshtml"
 if (item.IsIdentity)
{

            
            #line default
            #line hidden
WriteLiteral("    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\_List_Data_Item.cshtml"
                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 13 "..\..\Views\Shared\_List_Data_Item.cshtml"
}
else
{
    switch (Type.GetTypeCode(item.Type))
    {
        case TypeCode.Boolean:
            if ((Boolean)value)
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-ok\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 24 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"glyphicon glyphicon-remove\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></i>\r\n                </td>\r\n");

            
            #line 30 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.DateTime:
            var dt = (DateTime)value;

            
            #line default
            #line hidden
WriteLiteral("            <td>");

            
            #line 34 "..\..\Views\Shared\_List_Data_Item.cshtml"
           Write(dt.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 35 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Decimal:

            
            #line default
            #line hidden
WriteLiteral("            <td>");

            
            #line 37 "..\..\Views\Shared\_List_Data_Item.cshtml"
           Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 38 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Single:
        case TypeCode.Double:

            
            #line default
            #line hidden
WriteLiteral("            <td>");

            
            #line 41 "..\..\Views\Shared\_List_Data_Item.cshtml"
           Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 42 "..\..\Views\Shared\_List_Data_Item.cshtml"
            break;
        case TypeCode.Byte:
        case TypeCode.Int16:
        case TypeCode.Int32:
        case TypeCode.Int64:
        case TypeCode.UInt16:
        case TypeCode.UInt32:
        case TypeCode.UInt64:
            //特殊处理枚举
            if (item.Type.IsEnum)
            {
                var val = "";
                try
                {
                    val = System.EnumHelper.GetDescription((Enum)value) ?? value + "";
                }
                catch { }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 59 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                   Write(val);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 60 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else if (item.Name.EqualIgnoreCase("CreateUserID", "UpdateUserID"))
            {
                var provider = ViewData["Provider"] as IManageProvider;

            
            #line default
            #line hidden
WriteLiteral("                <td>");

            
            #line 64 "..\..\Views\Shared\_List_Data_Item.cshtml"
               Write(provider.FindByID(value));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 65 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 68 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                  Write(Convert.ToInt64(value).ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 69 "..\..\Views\Shared\_List_Data_Item.cshtml"
            }
            break;
        case TypeCode.String:
        default:
            {
                var val = value;
                var map = item.Map;
                if (map != null && map.Provider != null && val + "" != "")
                {
                    var dic = new RouteValueDictionary();
                    var key = map.Provider.Key;
                    if (!key.IsNullOrEmpty() && item.OriField != null) { dic[key] = entity[item.OriField.Name]; }

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 81 "..\..\Views\Shared\_List_Data_Item.cshtml"
                   Write(Html.ActionLink(value + "", "Edit", map.Provider.EntityType.Name, dic, null));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 82 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else if (item.Name.EqualIgnoreCase("CreateIP", "UpdateIP"))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteAttribute("title", Tuple.Create(" title=\"", 2759), Tuple.Create("\"", 2794)
            
            #line 85 "..\..\Views\Shared\_List_Data_Item.cshtml"
, Tuple.Create(Tuple.Create("", 2767), Tuple.Create<System.Object, System.Int32>((value+"").IPToAddress()
            
            #line default
            #line hidden
, 2767), false)
);

WriteLiteral(">");

            
            #line 85 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 86 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else if (item.Name.EqualIgnoreCase("Remark", "Description"))
                {
                    //防止内容过长

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" style=\"max-width:600px;overflow:hidden;white-space: nowrap;text-overflow: ellips" +
"is;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 3063), Tuple.Create("\"", 3077)
            
            #line 90 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                    , Tuple.Create(Tuple.Create("", 3071), Tuple.Create<System.Object, System.Int32>(value
            
            #line default
            #line hidden
, 3071), false)
);

WriteLiteral(">");

            
            #line 90 "..\..\Views\Shared\_List_Data_Item.cshtml"
                                                                                                                       Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 91 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td>");

            
            #line 94 "..\..\Views\Shared\_List_Data_Item.cshtml"
                   Write(value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 95 "..\..\Views\Shared\_List_Data_Item.cshtml"
                }
            }
            break;
            
            
            #line default
            #line hidden
            
            #line 100 "..\..\Views\Shared\_List_Data_Item.cshtml"
                        
    }
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
