﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    #line 2 "..\..\Pages\DeletedJobsPage.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\DeletedJobsPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\DeletedJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Pages\DeletedJobsPage.cshtml"
    using States;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\DeletedJobsPage.cshtml"
    using Storage.Monitoring;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class DeletedJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\n");








            
            #line 8 "..\..\Pages\DeletedJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Deleted Jobs" };

    int from, perPage;

    int.TryParse(Request.QueryString["from"], out from);
    int.TryParse(Request.QueryString["count"], out perPage);

    var monitor = JobStorage.Current.GetMonitoringApi();
    Pager pager = new Pager(from, perPage, monitor.DeletedListCount())
    {
        BasePageUrl = Request.LinkTo("/deleted")
    };

    JobList<DeletedJobDto> jobs = monitor.DeletedJobs(pager.FromRecord, pager.RecordsPerPage);


            
            #line default
            #line hidden
WriteLiteral("\n");


            
            #line 25 "..\..\Pages\DeletedJobsPage.cshtml"
 if (pager.TotalPageCount == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\n        No deleted jobs found.\n    </div>\n");


            
            #line 30 "..\..\Pages\DeletedJobsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"js-jobs-list\">\n        <div class=\"btn-toolbar btn-toolbar-top\">\n" +
"            <button class=\"js-jobs-list-command btn btn-sm btn-primary\"\n        " +
"            data-url=\"");


            
            #line 36 "..\..\Pages\DeletedJobsPage.cshtml"
                         Write(Request.LinkTo("/deleted/requeue"));

            
            #line default
            #line hidden
WriteLiteral("\"\n                    data-loading-text=\"Enqueueing...\">\n                <span cl" +
"ass=\"glyphicon glyphicon-repeat\"></span>\n                Requeue jobs\n          " +
"  </button>\n            ");


            
            #line 41 "..\..\Pages\DeletedJobsPage.cshtml"
       Write(RenderPartial(new PerPageSelector(pager)));

            
            #line default
            #line hidden
WriteLiteral(@"
        </div>
        <table class=""table"">
            <thead>
                <tr>
                    <th class=""min-width"">
                        <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                    </th>
                    <th class=""min-width"">Id</th>
                    <th>Job</th>
                    <th class=""align-right"">Deleted</th>
                </tr>
            </thead>
            <tbody>
");


            
            #line 55 "..\..\Pages\DeletedJobsPage.cshtml"
                 foreach (var job in jobs)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr class=\"js-jobs-list-row ");


            
            #line 57 "..\..\Pages\DeletedJobsPage.cshtml"
                                            Write(job.Value != null && !job.Value.InDeletedState ? "obsolete-data" : null);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 57 "..\..\Pages\DeletedJobsPage.cshtml"
                                                                                                                       Write(job.Value != null && job.Value.InDeletedState && job.Value != null ? "hover" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\n                        <td>\n");


            
            #line 59 "..\..\Pages\DeletedJobsPage.cshtml"
                             if (job.Value != null && job.Value.InDeletedState)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <input type=\"checkbox\" class=\"js-jobs-list-checkb" +
"ox\" name=\"jobs[]\" value=\"");


            
            #line 61 "..\..\Pages\DeletedJobsPage.cshtml"
                                                                                                     Write(job.Key);

            
            #line default
            #line hidden
WriteLiteral("\" />\n");


            
            #line 62 "..\..\Pages\DeletedJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\n                        <td class=\"min-width\">\n    " +
"                        <a href=\"");


            
            #line 65 "..\..\Pages\DeletedJobsPage.cshtml"
                                Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\n                                ");


            
            #line 66 "..\..\Pages\DeletedJobsPage.cshtml"
                           Write(HtmlHelper.JobId(job.Key));

            
            #line default
            #line hidden
WriteLiteral("\n                            </a>\n");


            
            #line 68 "..\..\Pages\DeletedJobsPage.cshtml"
                             if (job.Value != null && !job.Value.InDeletedState)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span title=\"Job\'s state has been changed while f" +
"etching data.\" class=\"glyphicon glyphicon-question-sign\"></span>\n");


            
            #line 71 "..\..\Pages\DeletedJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\n\n");


            
            #line 74 "..\..\Pages\DeletedJobsPage.cshtml"
                         if (job.Value == null)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td colspan=\"2\">\n                                <em>" +
"Job was expired.</em>\n                            </td>\n");


            
            #line 79 "..\..\Pages\DeletedJobsPage.cshtml"
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td>\n                                <a class=\"job-me" +
"thod\" href=\"");


            
            #line 83 "..\..\Pages\DeletedJobsPage.cshtml"
                                                       Write(Request.LinkTo("/job/" + job.Key));

            
            #line default
            #line hidden
WriteLiteral("\">\n                                    ");


            
            #line 84 "..\..\Pages\DeletedJobsPage.cshtml"
                               Write(HtmlHelper.DisplayMethod(job.Value.Job));

            
            #line default
            #line hidden
WriteLiteral("\n                                </a>\n                            </td>\n");



WriteLiteral("                            <td class=\"align-right\">\n");


            
            #line 88 "..\..\Pages\DeletedJobsPage.cshtml"
                                 if (job.Value.DeletedAt.HasValue)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span data-moment=\"");


            
            #line 90 "..\..\Pages\DeletedJobsPage.cshtml"
                                                  Write(JobHelper.ToStringTimestamp(job.Value.DeletedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\n                                        ");


            
            #line 91 "..\..\Pages\DeletedJobsPage.cshtml"
                                   Write(job.Value.DeletedAt);

            
            #line default
            #line hidden
WriteLiteral("\n                                    </span>\n");


            
            #line 93 "..\..\Pages\DeletedJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\n");


            
            #line 95 "..\..\Pages\DeletedJobsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\n");


            
            #line 97 "..\..\Pages\DeletedJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\n        </table>\n    </div>\n");


            
            #line 101 "..\..\Pages\DeletedJobsPage.cshtml"
    
            
            #line default
            #line hidden
            
            #line 101 "..\..\Pages\DeletedJobsPage.cshtml"
Write(RenderPartial(new Paginator(pager)));

            
            #line default
            #line hidden
            
            #line 101 "..\..\Pages\DeletedJobsPage.cshtml"
                                        
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
