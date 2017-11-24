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
    
    #line 1 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data.cshtml")]
    public partial class _Views_Shared__List_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Views\Shared\_List_Data.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as List<FieldItem>;
    var fk = fact.Unique;
    var enableSelect = false;
    if (ViewData.ContainsKey("EnableSelect"))
    {
        enableSelect = (Boolean)ViewData["EnableSelect"];
    }
    else
    {
        enableSelect = user.Has(PermissionFlags.Update, PermissionFlags.Delete);
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 24 "..\..\Views\Shared\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_List_Data.cshtml"
             if (fk != null && enableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chbAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 27 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 28 "..\..\Views\Shared\_List_Data.cshtml"
             foreach (var item in fields)
            {
                var sortUrl = item.OriField != null ? page.GetSortUrl(item.OriField.Name) : page.GetSortUrl(item.Name);
                if (item.Type == typeof(DateTime))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1197), Tuple.Create("\"", 1222)
            
            #line 33 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1205), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1226), Tuple.Create("\"", 1251)
            
            #line 33 "..\..\Views\Shared\_List_Data.cshtml"
                        , Tuple.Create(Tuple.Create("", 1233), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1233), false)
);

WriteLiteral(">");

            
            #line 33 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                                                       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 34 "..\..\Views\Shared\_List_Data.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteLiteral(" class=\"text-center\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1384), Tuple.Create("\"", 1409)
            
            #line 37 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1392), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1413), Tuple.Create("\"", 1438)
            
            #line 37 "..\..\Views\Shared\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1420), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1420), false)
);

WriteLiteral(">");

            
            #line 37 "..\..\Views\Shared\_List_Data.cshtml"
                                                                                              Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 38 "..\..\Views\Shared\_List_Data.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("            ");

            
            #line 40 "..\..\Views\Shared\_List_Data.cshtml"
             if (user.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:100px;\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 43 "..\..\Views\Shared\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 47 "..\..\Views\Shared\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Shared\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 50 "..\..\Views\Shared\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\_List_Data.cshtml"
                 if (fk != null && enableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1964), Tuple.Create("\"", 1988)
            
            #line 52 "..\..\Views\Shared\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 1972), Tuple.Create<System.Object, System.Int32>(entity[fk.Name]
            
            #line default
            #line hidden
, 1972), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 53 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 54 "..\..\Views\Shared\_List_Data.cshtml"
                 foreach (var item in fields)
                {
                    
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Shared\_List_Data.cshtml"
               Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\Shared\_List_Data.cshtml"
                                                                            
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 58 "..\..\Views\Shared\_List_Data.cshtml"
                 if (user.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 61 "..\..\Views\Shared\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 63 "..\..\Views\Shared\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 65 "..\..\Views\Shared\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>\r\n<script>\r\n    $(\'#chbAll\').click(function () {\r\n        $" +
"(\'input[name=\"keys\"]\').prop(\'checked\', $(this).is(\':checked\'));\r\n    });\r\n</scri" +
"pt>");

        }
    }
}
#pragma warning restore 1591
