#pragma checksum "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/Home/Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af9c34b58478055176a346413cd469d58e1338b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Resume), @"mvc.1.0.view", @"/Views/Home/Resume.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Resume.cshtml", typeof(AspNetCore.Views_Home_Resume))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/_ViewImports.cshtml"
using FullStack_portfolio;

#line default
#line hidden
#line 2 "/Users/angeloliwanag/Documents/FINAL_PORTFOLIO/FullStack_portfolio/Views/_ViewImports.cshtml"
using FullStack_portfolio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af9c34b58478055176a346413cd469d58e1338b1", @"/Views/Home/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77d6adac4e6777286af25733c8b8be1f6314711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Resume : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(33, 439, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9c34b58478055176a346413cd469d58e1338b13356", async() => {
                BeginContext(39, 426, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Angelo Liwanag Resume</title>
    <link rel=""stylesheet"" href=""index.css"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/lux/bootstrap.min.css"">
    <script src=""https://kit.fontawesome.com/28d5bf3399.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(472, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(473, 9043, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af9c34b58478055176a346413cd469d58e1338b14960", async() => {
                BeginContext(479, 9030, true);
                WriteLiteral(@"
    <div class=""container shadow-lg bg-white p-5 mb-5"">
        <!-- Name -->
        <div class=""Name mx-auto"">
            <h1 class=""angelo"">ANGELO LIWANAG</h1>
            <h3 class=""text-secondary dev"">Full Stack Developer</h3>
        </div>

        <!-- Contact -->
        <div class=""contact row mt-3 mx-auto"">
            <div class=""col-4"">
                <div class=""email"">
                    <i class=""far fa-envelope text-success""></i>
                    <a class=""d-inline-block"">angeloliwanag75@gmail.com</a>
                </div>
                <div class=""number"">
                    <i class=""fas fa-mobile-alt text-success""></i>
                    <a class=""d-inline-block"">+1(562) 522-2861</a>
                </div>
                <div class=""location"">
                    <i class=""fas fa-map-marker-alt text-success""></i>
                    <a class=""d-inline-block"">Long Beach, CA</a>
                </div>
            </div>
            <div class=""col-4"">
                <div class=");
                WriteLiteral(@"""LinkedIn"">
                    <i class=""fab fa-linkedin text-success""></i>
                    <a class=""d-inline-block text-primary"" href=""https://www.linkedin.com/in/angelo-liwanag/"">linkedin.com/in/angelo-liwanag</a>
                </div>
                <div class=""GitHub"">
                    <i class=""fab fa-github-square text-success""></i>
                    <a class=""d-inline-block text-primary"" href=""https://github.com/AngeloLiwanag\"">github.com/AngeloLiwanag</a>
                </div>
            </div>
        </div>

        <!-- Body Container -->
        <div class=""body-container row mt-4 mx-auto"">
            <div class=""col"">
                <div class=""summary"">
                    <h3>SUMMARY</h3>
                    <hr>
                    <p>Self-driven Full Stack Developer with a passion for creating, designing and problem solving.  Eager to learn about programming outside of the College of Business with hands on experience with three different full stack applications; Python, MEAN ");
                WriteLiteral(@"and C#/.NET. A strong team player looking to apply technical skills to real world applications.</p>
                </div>
                <div class=""projects"">
                    <h3>PROJECTS</h3>
                    <hr>
                    <div class=""dog-scover mt-3"">
                        <h5 class=""text-success"">Dogscover</h5>
                        <b>Technologies Utilized: C#, ASP.NET Core</b>
                        <p class=""m-2"">Dogscover is a dedicated startup website solely made for dog products. Innovators can display their dog products and receive backing and funding for their products to launch.</p>
                    </div>
                    
                    <div class=""stock-palace mt-3"">
                        <h5 class=""text-success"">Stock Palace</h5>
                        <b>Technologies Utilized: MongoDB, Express, Angular, Node.js</b>
                        <p class=""m-2"">Stock Palace is an eCommerce website which was inspired by StockX. It implemented Angular’s component");
                WriteLiteral(@"s to create a shopping cart that stores the user’s items for present or future purchase to increase the user’s selling and buying experience.</p>
                    </div>

                    <div class=""note-pad"">
                        <h5 class=""text-success"">NotePad</h5>
                        <b>Technologies Utilized: Python, Django</b>
                        <p class=""m-2"">NotePad is a web application that allows users to take notes. It features a sidebar which allows for custom categories and subcategories, it also gives the user the ability to filter through certain categories and enhance the user's experience with light and dark mode setting.</p>
                    </div>


                </div>
                <div class=""leadership"">
                    <h3>LEADERSHIP</h3>
                    <hr>     
                    
                    <div class=""zeta-president"">
                        <h5 class=""text-success"">Zeta Phi Rho</h5>
                        <b> Leadership Role: Chapter Pr");
                WriteLiteral(@"esident</b>
                        <b class=""d-block""><i class=""far fa-calendar-alt""></i> May 2019 - Present</b>
                        <div class=""m-2"">
                            <p>Constructed bi-weekly meetings with the head of the Fraternity Sorority Life Advisor to report weekly minutes, and developed school approved events.</p>
                            <p>Coordinated regional district chapter meetings to obtain chapter wide Fraternity Liability Insurance, and modified Chapter Bylaws and Policy Procedures.</p>
                        </div>
                    </div>
                    
                    <div class=""zeta-treasurer"">
                        <h5 class=""text-success"">Zeta Phi Rho</h5>
                        <b> Leadership Role: Executive Treasurer</b>
                        <b class=""d-block""><i class=""far fa-calendar-alt""></i> August 2018 - May 2019</b>
                        <div class=""m-2"">
                            <p>Effectively communicated with other campus organizati");
                WriteLiteral(@"ons to successfully plan and organize 12 events that helped raised $850 of funds for a variety of organizations such as AIDS Walk Los Angeles, Long Beach Rescue Mission, and beach clean ups.</p>
                            <p>Composed weekly spreadsheet presentations for the executive board in regards to the organization’s income statement, retained earnings, and total budget.</p>
                        </div>
                    </div>
                </div>
            </div>
            
            <!-- <div class=""col-1""></div> -->

            <div class=""col-5"">
                <div class=""tech-skill"">
                    <h3>TECHNICAL SKILLS</h3>
                    <hr>
                    <p><span class=""text-success"">Languages:</span> Python, JavaScript, C#, CSS3, HTML5</p>
                    <p><span class=""text-success"">Frameworks/Libraries:</span> Django, Angular, Express.js, Node.js, Mongoose, ASP.NET Core, Bootstrap, Materialize, jQuery</p>
                    <p><span class=""text-success"">D");
                WriteLiteral(@"atabases:</span> MySQL, NoSQL, MongoDB</p>
                </div>
                
                <div class=""education"">
                    <h3>EDUCATION</h3>
                    <hr>
                    
                    <div class=""CSULB"">
                        <h5 class=""text-success"">California State University, Long Beach</h5>
                        <b class=""d-block"">Estimated Graduation: Spring 2021</b>
                        <b>Major: Business Economics</b>
                    </div>
                    
                    <div class=""coding-dojo mt-3"">
                        <h5 class=""text-success"">Coding Dojo, Costa Mesa</h5>
                        <b class=""d-block""><i class=""far fa-calendar-alt""></i> May 2019 - August 2019</b>
                        <div class=""m-2"">
                            <p>Completed intensive 14 weeks, full-time web development program, including the introduction of web fundamentals, implementation of algorithms, and 3 full stack languages.</p>
             ");
                WriteLiteral(@"           </div>
                    </div>
                </div>
                <div class=""experience"">
                    <h3>EXPERIENCE</h3>
                    <hr>
                
                    <div class=""hironori"">
                        <h5 class=""text-success"">HiroNori Craft Ramen</h5>
                        <b>Occupation: Host</b>
                        <b class=""d-block""><i class=""far fa-calendar-alt""></i>
                        November 2018 - August 2019</b>
                        <div class=""m-2"">
                            <p>Promoted as the Host Supervisor within the first month of employment and responsible for monitoring activities and making corrections with other supervisors on a bi-weekly basis.</p>
                            <!-- <p>Acknowledge, escorted, and provided additional services for over 180 of the restaurant's guests on a daily basis while achieving complete customer satisfaction.</p> -->
                        </div>
                    </div>
             ");
                WriteLiteral(@"       <div class=""gyukaku"">
                        <h5 class=""text-success"">Gyu-Kaku Japanese BBQ</h5>
                        <b>Occupation: Server</b>
                        <b class=""d-block""><i class=""far fa-calendar-alt""></i>
                        November 2017 - September 2018</b>
                        <div class=""m-2"">
                            <p>Exhibited problem resolution skills and an attention to detail in a timely manner to satisfy customer needs and maintain optimal restaurant operation levels.</p>
                            <!-- <p>Frequently assisted and delegated colleagues during peak hours to ensure productivity and reach the establishment’s desired sales targets.</p> -->
                        </div>
                    </div>
                </div> 
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9516, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
