#pragma checksum "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370c58a3c4082669012c0992da42970332b85526"
// <auto-generated/>
#pragma warning disable 1591
namespace Examen_Final.Pages.Reporte
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Examen_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Examen_Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Reporte")]
    public partial class Reporte : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container");
                __builder2.AddMarkupContent(5, "\r\n            ");
                __builder2.AddMarkupContent(6, "<div class=\"text-center\">\r\n                <div class=\"col-md-6 offset-3\">\r\n                    <h2 class=\"alert alert-primary\">Informes y Reporter&#237;a</h2>\r\n                </div>\r\n            </div>\r\n            ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "my-5");
                __builder2.AddMarkupContent(9, "\r\n                ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-md-5");
                __builder2.AddMarkupContent(12, "\r\n                    ");
                __builder2.OpenElement(13, "select");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                        selectorReporte

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectorReporte = __value, selectorReporte));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(17, "\r\n                        \r\n                        ");
                __builder2.OpenElement(18, "option");
                __builder2.AddAttribute(19, "selected", true);
                __builder2.AddContent(20, "Seleccione reporte");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "option");
                __builder2.AddAttribute(23, "value", "1");
                __builder2.AddContent(24, " - Listado de productos");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "option");
                __builder2.AddAttribute(27, "value", "2");
                __builder2.AddContent(28, " - Productos y servicios con mayor demanda");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.OpenElement(30, "option");
                __builder2.AddAttribute(31, "value", "3");
                __builder2.AddContent(32, " - Clientes con mayor frecuencia de compra");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.OpenElement(34, "option");
                __builder2.AddAttribute(35, "value", "4");
                __builder2.AddContent(36, " - Cuempleaños de los clientes");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n");
#nullable restore
#line 31 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                 if (selectorReporte == "1")
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(40, "                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "my-3");
                __builder2.AddAttribute(43, "id", "Imprimir_reporte");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "row");
                __builder2.AddMarkupContent(47, "\r\n                            ");
                __builder2.AddMarkupContent(48, "<div class=\"col-md-6\">\r\n                                <h2>Listado de productos</h2>\r\n\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-md-6 text-right");
                __builder2.AddMarkupContent(51, "\r\n                                ");
                __builder2.OpenElement(52, "p");
                __builder2.AddContent(53, 
#nullable restore
#line 40 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                    date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "table");
                __builder2.AddAttribute(58, "class", "tabla productos_th_color");
                __builder2.AddMarkupContent(59, "\r\n                            ");
                __builder2.AddMarkupContent(60, @"<thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>Descripci&#243;n</th>
                                    <th>Precio</th>
                                    <th>Cantidad</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(61, "tbody");
                __builder2.AddMarkupContent(62, "\r\n");
#nullable restore
#line 53 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                 if (productos.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                     foreach (var producto in productos)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(63, "                                        ");
                __builder2.OpenElement(64, "tr");
                __builder2.AddMarkupContent(65, "\r\n                                            ");
                __builder2.OpenElement(66, "td");
                __builder2.AddContent(67, 
#nullable restore
#line 58 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 producto.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                            ");
                __builder2.OpenElement(69, "td");
                __builder2.AddContent(70, 
#nullable restore
#line 59 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 producto.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                                            ");
                __builder2.OpenElement(72, "td");
                __builder2.AddContent(73, 
#nullable restore
#line 60 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 producto.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                                            ");
                __builder2.OpenElement(75, "td");
                __builder2.AddContent(76, 
#nullable restore
#line 61 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 producto.Cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n");
#nullable restore
#line 63 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(79, "                                    ");
                __builder2.AddMarkupContent(80, "<tr><td colspan=\"12\"><strong>No hay productos registrados</strong></td></tr>\r\n");
#nullable restore
#line 68 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(81, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                        ");
                __builder2.AddMarkupContent(84, "<div class=\"mt-4\">\r\n                            <h4 class=\"text-center\">Fin del reporte</h4>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n");
                __builder2.AddContent(86, "                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "text-right");
                __builder2.AddMarkupContent(89, "\r\n                        ");
                __builder2.OpenElement(90, "button");
                __builder2.AddAttribute(91, "class", "btn btn-light");
                __builder2.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                                Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(93, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n");
#nullable restore
#line 79 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                 if (selectorReporte == "2")
                {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(96, "                    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "my-3");
                __builder2.AddAttribute(99, "id", "Imprimir_reporte");
                __builder2.AddMarkupContent(100, "\r\n                        ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "row");
                __builder2.AddMarkupContent(103, "\r\n                            ");
                __builder2.AddMarkupContent(104, "<div class=\"col-md-6\">\r\n                                <h2>Productos m&#225;s vendidos</h2>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col-md-6 text-right");
                __builder2.AddMarkupContent(107, "\r\n                                ");
                __builder2.OpenElement(108, "p");
                __builder2.AddContent(109, 
#nullable restore
#line 90 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                    date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                        ");
                __builder2.OpenElement(113, "table");
                __builder2.AddAttribute(114, "class", "tabla demanda_th_color");
                __builder2.AddMarkupContent(115, "\r\n                            ");
                __builder2.OpenElement(116, "thead");
                __builder2.AddMarkupContent(117, "\r\n                                ");
                __builder2.OpenElement(118, "tr");
                __builder2.AddMarkupContent(119, "\r\n");
#nullable restore
#line 96 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                     foreach (var factura in facturas)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                         foreach (var item in factura.facturas_detalle.GroupBy(o => o.producto).OrderByDescending(g => g.Sum(oi => oi.Cantidad)))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                             foreach (var data in item)
                                            {
                                                

#line default
#line hidden
#nullable disable
                __builder2.AddContent(120, 
#nullable restore
#line 102 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 data.producto.Nombre

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 102 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                                     
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                             
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 104 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(121, "\r\n                                    \\\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                            ");
                __builder2.AddMarkupContent(124, "<tbody>\r\n                            </tbody>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(125, "\r\n                        ");
                __builder2.AddMarkupContent(126, "<div class=\"mt-4\">\r\n                            <h4 class=\"text-center\">Fin del reporte</h4>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                    ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "text-right");
                __builder2.AddMarkupContent(130, "\r\n                        ");
                __builder2.OpenElement(131, "button");
                __builder2.AddAttribute(132, "class", "btn btn-light");
                __builder2.AddAttribute(133, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                                Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(134, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\r\n");
#nullable restore
#line 120 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                 if (selectorReporte == "3")
                {
                    

#line default
#line hidden
#nullable disable
                __builder2.AddContent(137, "                    ");
                __builder2.OpenElement(138, "div");
                __builder2.AddAttribute(139, "class", "my-3");
                __builder2.AddAttribute(140, "id", "Imprimir_reporte");
                __builder2.AddMarkupContent(141, "\r\n                        ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "row");
                __builder2.AddMarkupContent(144, "\r\n                            ");
                __builder2.AddMarkupContent(145, "<div class=\"col-md-6\">\r\n                                <h2>Clientes que m&#225;s compran</h2>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(146, "div");
                __builder2.AddAttribute(147, "class", "col-md-6 text-right");
                __builder2.AddMarkupContent(148, "\r\n                                ");
                __builder2.OpenElement(149, "p");
                __builder2.AddContent(150, 
#nullable restore
#line 132 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                    date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(151, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\r\n                        ");
                __builder2.AddMarkupContent(154, @"<table class=""tabla frecuencia_th_color"">
                            <thead>
                                <tr>
                                    <th>Firstname</th>
                                    <th>Lastname</th>
                                    <th>Email</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                </tr>
                            </tbody>
                        </table>
                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(155, "\r\n                    ");
                __builder2.OpenElement(156, "div");
                __builder2.AddAttribute(157, "class", "text-right");
                __builder2.AddMarkupContent(158, "\r\n                        ");
                __builder2.OpenElement(159, "button");
                __builder2.AddAttribute(160, "class", "btn btn-light");
                __builder2.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 166 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                                Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(162, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\r\n");
#nullable restore
#line 168 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                 if (selectorReporte == "4")
                {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(165, "                    ");
                __builder2.OpenElement(166, "div");
                __builder2.AddAttribute(167, "class", "my-3");
                __builder2.AddAttribute(168, "id", "Imprimir_reporte");
                __builder2.AddMarkupContent(169, "\r\n                        ");
                __builder2.OpenElement(170, "div");
                __builder2.AddAttribute(171, "class", "row");
                __builder2.AddMarkupContent(172, "\r\n                            ");
                __builder2.AddMarkupContent(173, "<div class=\"col-md-6\">\r\n                                <h2>Cumplea&#241;os de clientes</h2>\r\n                            </div>\r\n                            ");
                __builder2.OpenElement(174, "div");
                __builder2.AddAttribute(175, "class", "col-md-6 text-right");
                __builder2.AddMarkupContent(176, "\r\n                                ");
                __builder2.OpenElement(177, "p");
                __builder2.AddContent(178, 
#nullable restore
#line 178 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                    date

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(180, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(181, "\r\n                        ");
                __builder2.OpenElement(182, "table");
                __builder2.AddAttribute(183, "class", "tabla cumpleanos_th_color");
                __builder2.AddMarkupContent(184, "\r\n                            ");
                __builder2.AddMarkupContent(185, @"<thead>
                                <tr>
                                    <th>Nombre</th>
                                    <th>RNC o c&#233;dula</th>
                                    <th>Direcci&#243;n</th>
                                    <th>Tel&#233;fono</th>
                                    <th>Correo</th>
                                    <th>Fecha de cumplea&#241;os</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(186, "tbody");
                __builder2.AddMarkupContent(187, "\r\n");
#nullable restore
#line 193 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                 if (clientes.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                     foreach (var cliente in clientes.OrderBy(f => f.Fecha_nacimiento.Month).OrderBy(f => f.Fecha_nacimiento.Day))
                                    {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(188, "                                        ");
                __builder2.OpenElement(189, "tr");
                __builder2.AddMarkupContent(190, "\r\n                                            ");
                __builder2.OpenElement(191, "td");
                __builder2.AddContent(192, 
#nullable restore
#line 199 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(193, "\r\n                                            ");
                __builder2.OpenElement(194, "td");
                __builder2.AddContent(195, 
#nullable restore
#line 200 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Rnc

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(196, "\r\n                                            ");
                __builder2.OpenElement(197, "td");
                __builder2.AddContent(198, 
#nullable restore
#line 201 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Direccion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n                                            ");
                __builder2.OpenElement(200, "td");
                __builder2.AddContent(201, 
#nullable restore
#line 202 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Telefono

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(202, "\r\n                                            ");
                __builder2.OpenElement(203, "td");
                __builder2.AddContent(204, 
#nullable restore
#line 203 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Correo

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n                                            ");
                __builder2.OpenElement(206, "td");
                __builder2.AddContent(207, 
#nullable restore
#line 204 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                 cliente.Fecha_nacimiento.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(208, "\r\n\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(209, "\r\n");
#nullable restore
#line 207 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 208 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(210, "                                    ");
                __builder2.AddMarkupContent(211, "<tr><td colspan=\"12\"><strong>No hay clientes registrados</strong></td></tr>\r\n");
#nullable restore
#line 213 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(212, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(213, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(214, "\r\n                        ");
                __builder2.AddMarkupContent(215, "<div class=\"mt-4\">\r\n                            <h4 class=\"text-center\">Fin del reporte</h4>\r\n                        </div>\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(216, "\r\n                    ");
                __builder2.OpenElement(217, "div");
                __builder2.AddAttribute(218, "class", "text-right");
                __builder2.AddMarkupContent(219, "\r\n                        ");
                __builder2.OpenElement(220, "button");
                __builder2.AddAttribute(221, "class", "btn btn-light");
                __builder2.AddAttribute(222, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 221 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                                                                Imprimir

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(223, "Imprimir");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(224, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(225, "\r\n");
#nullable restore
#line 223 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(226, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(227, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(228, "\r\n    ");
            }
            ));
            __builder.AddAttribute(229, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(230, "\r\n        ");
                __builder2.AddMarkupContent(231, "<center>\r\n            <h1>Lo sentimos, debe iniciar sesi&#243;n</h1>\r\n            <br><br>\r\n            <p>\r\n                Necesita acceder a su cuenta para visualizar los productos registrados.\r\n            </p>\r\n        </center>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 238 "C:\Users\leudy\Desktop\Nuevo Rep\Tienda\Examen_Final\Pages\Reporte\Reporte.razor"
      

    DateTime date = DateTime.Now;
    string selectorReporte;


    //Reportes
    List<Producto> productos = new List<Producto>();
    List<Cliente> clientes = new List<Cliente>();
    List<Factura> facturas = new List<Factura>();


    protected override async Task OnInitializedAsync()
    {
        await Refresh();
    }

    private async Task Refresh()
    {
        productos = await serviceProducto.GetProductoAsync();
        clientes = await serviceCliente.GetClientesAsync();
        facturas = await ServiceFactura.GetFacturaAsync();
    }


    //M�dulo de impresion
    public async Task Imprimir()
    {

        await JSRuntime.InvokeVoidAsync("imprimir_reporte");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceCliente serviceCliente { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceFactura ServiceFactura { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto serviceProducto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigate { get; set; }
    }
}
#pragma warning restore 1591
