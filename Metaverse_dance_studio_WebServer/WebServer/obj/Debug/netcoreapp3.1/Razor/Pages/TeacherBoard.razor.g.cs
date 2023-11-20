#pragma checksum "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14e799383e3efb5ca25330ef8606b5957c13f28d"
// <auto-generated/>
#pragma warning disable 1591
namespace WebServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using WebServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\_Imports.razor"
using WebServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
using WebServer.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
using WebServer.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Teacher/{id}")]
    public partial class TeacherBoard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "class", "mr-1 mb-3");
            __builder.AddAttribute(2, "href", "/" + (
#nullable restore
#line 9 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                             _npc.NpcMajor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(3, "BACK");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "mt-3 mb-4");
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenComponent<WebServer.Pages.TeacherInfo>(8);
            __builder.AddAttribute(9, "_Npc", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<WebServer.Data.Models.Npc>(
#nullable restore
#line 12 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                       _npc

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(12, "h4");
            __builder.AddAttribute(13, "class", "pb-3 d-flex align-items-center");
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<strong class=\"p-2 flex-grow-1\">평가 게시판</strong>\r\n    ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "btn btn-primary");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                              AddScript

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<span class=\"oi oi-plus\"> 글쓰기</span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenElement(23, "ul");
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "li");
            __builder.AddMarkupContent(26, "선생님 강의에 대한 평균 총점 : ");
            __builder.AddContent(27, 
#nullable restore
#line 24 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                            string.Format("{0:0.0}", _npc.Score)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, " / 5 점");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
 if (_showPopUp)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal");
            __builder.AddAttribute(34, "style", "display:block");
            __builder.AddAttribute(35, "role", "dialog");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-dialog modal-dialog-centered");
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "modal-content");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-header");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.AddMarkupContent(46, "<h5 class=\"modal-title\" id=\"ModalToggleLabel\">글쓰기</h5>\r\n                    ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn-close");
            __builder.AddAttribute(50, "data-bs-dismiss", "modal");
            __builder.AddAttribute(51, "aria-label", "Close");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                                                                 ClosePopUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "🗙");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-body");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(59);
            __builder.AddAttribute(60, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 38 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                     _script

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.AddMarkupContent(63, "<h5>별점</h5>\r\n                        ");
                __builder2.OpenElement(64, "label");
                __builder2.AddMarkupContent(65, "\r\n\r\n                            ");
                __Blazor.WebServer.Pages.TeacherBoard.TypeInference.CreateInputSelect_0(__builder2, 66, 67, 
#nullable restore
#line 42 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                      Score

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Score = __value, Score)), 69, () => Score, 70, (__builder3) => {
                    __builder3.AddMarkupContent(71, "\r\n                                ");
                    __builder3.AddMarkupContent(72, "<option value=\"1\">1 점</option>\r\n");
#nullable restore
#line 44 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                 for (int rate = 2; rate <= 5; rate++)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(73, "                                    ");
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 46 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                    rate.ToString()

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 46 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                      rate

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(77, " 점");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n");
#nullable restore
#line 47 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, "                            ");
                }
                );
                __builder2.AddMarkupContent(80, "\r\n\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(82, "<h5>강의평</h5>\r\n                        ");
                __builder2.OpenElement(83, "label");
                __builder2.AddMarkupContent(84, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "rows", "10");
                __builder2.AddAttribute(88, "style", "width:466px");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                                                           _script.ScriptText

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _script.ScriptText = __value, _script.ScriptText))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _script.ScriptText));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(94, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "modal-footer");
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "button");
            __builder.AddAttribute(100, "class", "btn btn-primary");
            __builder.AddAttribute(101, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                              ShowAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(102, "글 저장");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
#nullable restore
#line 65 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
     if (_showAlert)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(108, "        ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "modal");
            __builder.AddAttribute(111, "style", "display: block; z-index: 10000");
            __builder.AddAttribute(112, "role", "dialog");
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "modal-dialog modal-dialog-centered");
            __builder.AddMarkupContent(116, "\r\n                ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "modal-content");
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.AddMarkupContent(120, "<div class=\"modal-header\">\r\n                        <h5 class=\"modal-title\" id=\"ModalToggleLabel2\">확인</h5>\r\n                    </div>\r\n                    ");
            __builder.AddMarkupContent(121, "<div class=\"modal-body\">\r\n                        한번 저장하면 수정할 수 없습니다. 정말 저장하시겠습니까?\r\n                    </div>\r\n                    ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "modal-footer");
            __builder.AddMarkupContent(124, "\r\n                        ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "btn btn-secondary");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                    CloseAlert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(128, "돌아가기");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "button");
            __builder.AddAttribute(131, "class", "btn btn-primary");
            __builder.AddAttribute(132, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                  SaveScript

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(133, "글 저장");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n");
#nullable restore
#line 83 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
     

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(139, "\r\n\r\n");
#nullable restore
#line 88 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
 if (_scripts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(140, "    ");
            __builder.AddMarkupContent(141, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 91 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(142, "    ");
            __builder.OpenElement(143, "table");
            __builder.AddAttribute(144, "class", "table align-middle");
            __builder.AddMarkupContent(145, "\r\n        ");
            __builder.AddMarkupContent(146, "<thead>\r\n            <tr scope=\"col\">\r\n                <th class=\"col-6\" style=\"vertical-align: middle;\">강의평</th>\r\n                <th class=\"col-2\">별점</th>\r\n                <th class=\"col-2\">작성 일자</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(147, "tbody");
            __builder.AddMarkupContent(148, "\r\n");
#nullable restore
#line 103 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
             foreach (var script in _scripts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(149, "                ");
            __builder.OpenElement(150, "tr");
            __builder.AddAttribute(151, "style", "vertical-align: middle;");
            __builder.AddMarkupContent(152, "\r\n                    ");
            __builder.OpenElement(153, "td");
            __builder.AddAttribute(154, "class", "col-6");
            __builder.AddAttribute(155, "style", "width:736px; table-layout:fixed");
            __builder.AddContent(156, 
#nullable restore
#line 106 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                                                               script.ScriptText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n                    ");
            __builder.OpenElement(158, "td");
            __builder.AddAttribute(159, "class", "col-2");
            __builder.AddContent(160, 
#nullable restore
#line 107 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                       script.Score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n                    ");
            __builder.OpenElement(162, "td");
            __builder.AddAttribute(163, "class", "col-2");
            __builder.AddContent(164, 
#nullable restore
#line 108 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
                                       script.Date.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n");
#nullable restore
#line 110 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(167, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n");
#nullable restore
#line 113 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\metaverse_server_localization_ver2\Meta_Studio_WebServer\WebServer\Pages\TeacherBoard.razor"
       

    [Parameter]
    public string id { get; set; }
    public Npc _npc { get; set; }

    List<Script> _scripts;
    Script _script;
    bool _showPopUp;
    bool _showAlert;
    string Score { get; set; } = "1";

    protected override async Task OnInitializedAsync()
    {
        int npcId = Int32.Parse(id);
        _npc = await BoardService.GetNpcByIdAsync(npcId);
        _scripts = await BoardService.GetScriptsByNpcAsync(_npc);
    }

    void ShowAlert()
    {
        _showAlert = true;
    }

    void CloseAlert()
    {
        _showAlert = false;
    }

    void AddScript()
    {
        _showPopUp = true;
        _script = new Script()
        {
            ScriptId = 0,
            OwnerId = _npc.NpcId,
            Owner = _npc
        };
    }

    void ClosePopUp()
    {
        _showPopUp = false;
    }

    async Task SaveScript()
    {
        if (_script.ScriptId == 0)
        {
            _script.Score = Int32.Parse(Score);
            _script.Date = DateTime.Now;
            var result = BoardService.AddScript(_script);
            var isError = BoardService.UpdateNpcScore(_script);
        }
        else
        {
            Console.WriteLine("저장될 수 없는 평가 입니다(중복)");

        }
        _showPopUp = false;
        _showAlert = false;
        _scripts = await BoardService.GetScriptsByNpcAsync(_npc);
        _npc = await BoardService.GetNpcByIdAsync(_npc.NpcId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BoardService BoardService { get; set; }
    }
}
namespace __Blazor.WebServer.Pages.TeacherBoard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
