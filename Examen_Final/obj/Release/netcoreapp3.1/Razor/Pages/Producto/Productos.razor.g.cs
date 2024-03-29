#pragma checksum "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b69feca69e1c4b24bbc09f2bc695c26e60787c9"
// <auto-generated/>
#pragma warning disable 1591
namespace Examen_Final.Pages.Producto
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Examen_Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Examen_Final.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Producto")]
    public partial class Productos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, @"<div class=""d-flex flex-row-reverse""><button type=""button"" class=""btn btn-success  btn-lg"" data-toggle=""modal"" data-target=""#exampleModalLong""><span class=""oi oi-plus"" aria-hidden=""true""></span> Crear Producto
            </button></div>
        <br><br><br>
        ");
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "row bg-light");
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-bordered");
                __builder2.AddMarkupContent(7, @"<thead class=""thead-dark""><tr><th>Imagen</th>
                        <th>Nombre</th>
                        <th>Descripción</th>
                        <th>Precio</th>
                        <th>Servicio</th>
                        <th>Cantidad</th>
                        <th>Ver mas Detalle</th></tr></thead>
                ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 35 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                     if (productos.Any())
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                         foreach (var producto in productos)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.OpenElement(10, "td");
                __builder2.OpenElement(11, "img");
                __builder2.AddAttribute(12, "src", 
#nullable restore
#line 40 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                   producto.img

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(13, "width", "100");
                __builder2.AddAttribute(14, "height", "100");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n                        ");
                __builder2.OpenElement(16, "td");
                __builder2.AddContent(17, 
#nullable restore
#line 41 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                             producto.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                        ");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 42 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                             producto.Descripcion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 43 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                             producto.Precio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 44 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                             producto.Servicio

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 45 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                             producto.Cantidad

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                          ");
                __builder2.OpenElement(31, "td");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "btn btn-primary");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                        (() => Navegar(producto))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, "View");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        <td></td>");
                __builder2.CloseElement();
#nullable restore
#line 53 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(37, "<tr><td colspan=\"6\"><strong>No hay producto creado</strong></td></tr>");
#nullable restore
#line 58 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n\r\n\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "modal fade");
                __builder2.AddAttribute(41, "id", "exampleModalLong");
                __builder2.AddAttribute(42, "tabindex", "-1");
                __builder2.AddAttribute(43, "role", "dialog");
                __builder2.AddAttribute(44, "aria-labelledby", "exampleModalLongTitle");
                __builder2.AddAttribute(45, "aria-hidden", "true");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "modal-dialog");
                __builder2.AddAttribute(48, "role", "document");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "modal-content");
                __builder2.AddMarkupContent(51, @"<div class=""modal-header""><h5 class=""modal-title"" id=""exampleModalLongTitle"">Creación de Producto</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button></div>
                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "modal-body");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "col-md-10 mx-auto py-4");
                __builder2.OpenElement(56, "form");
                __builder2.AddAttribute(57, "Model", 
#nullable restore
#line 76 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                          NewProducto

#line default
#line hidden
#nullable disable
                );
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label for=\"titulo\">Nombre</label>\r\n                                    ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "text");
                __builder2.AddAttribute(63, "id", "titulo");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "required", true);
                __builder2.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                                                NewProducto.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProducto.Nombre = __value, NewProducto.Nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                                  ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "<label for=\"descripcion\">Descripción</label>\r\n                                    ");
                __builder2.OpenElement(72, "textarea");
                __builder2.AddAttribute(73, "type", "text");
                __builder2.AddAttribute(74, "id", "descripcion");
                __builder2.AddAttribute(75, "class", "form-control");
                __builder2.AddAttribute(76, "required", true);
                __builder2.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 83 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                                                        NewProducto.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProducto.Descripcion = __value, NewProducto.Descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "form-group");
                __builder2.AddMarkupContent(82, "<label for=\"precio\"> Precio</label>\r\n                                    ");
                __builder2.OpenElement(83, "input");
                __builder2.AddAttribute(84, "type", "number");
                __builder2.AddAttribute(85, "id", "precio");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "required", true);
                __builder2.AddAttribute(88, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                                                  NewProducto.Precio

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(89, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProducto.Precio = __value, NewProducto.Precio, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n                                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "form-group");
                __builder2.AddMarkupContent(93, "<label for=\"servicio\">Servicio</label>\r\n                                    ");
                __builder2.OpenElement(94, "input");
                __builder2.AddAttribute(95, "type", "checkbox");
                __builder2.AddAttribute(96, "id", "servicio");
                __builder2.AddAttribute(97, "class", "form-control");
                __builder2.AddAttribute(98, "required", true);
                __builder2.AddAttribute(99, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                                                      NewProducto.Servicio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProducto.Servicio = __value, NewProducto.Servicio));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                                  ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "form-group");
                __builder2.AddMarkupContent(104, "<label for=\"cantidad\">Cantidad</label>\r\n                                    ");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "type", "number");
                __builder2.AddAttribute(107, "id", "cantidad");
                __builder2.AddAttribute(108, "class", "form-control");
                __builder2.AddAttribute(109, "required", true);
                __builder2.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 95 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                                                    NewProducto.Cantidad

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewProducto.Cantidad = __value, NewProducto.Cantidad, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                               ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group");
                __builder2.AddMarkupContent(115, "<label for=\"nombre\">Pruebas gráficas(s)</label>\r\n                                ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(116);
                __builder2.AddAttribute(117, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 99 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                     HandleSelectImagen

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                            \r\n\r\n                                ");
                __builder2.OpenElement(119, "div");
                __builder2.AddAttribute(120, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "class", "btn btn-info");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
                                                                           AddNewProducto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(124, " Agregar ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(125, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(126, "<center><h1>Lo Siento necesita esta logueado</h1>\r\n            <br><br>\r\n            <p>\r\n                Necesita entrar con tu usuario\r\n            </p></center>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 187 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Producto\Productos.razor"
       
    public string name_search;
    Usuario usuario1;
    List<Producto> productos = new List<Producto>();
    IFileListEntry image;
     async Task HandleSelectImagen(IFileListEntry[] images ){
Console.WriteLine("productos",images.FirstOrDefault());
        image = images.FirstOrDefault();
        Console.WriteLine(image);
        

    }
    protected override async Task OnInitializedAsync()
    {
        name_search = httpContextAccessor.HttpContext.User.Identity.Name;
        await Refresh();
    }
      private void Navegar(Producto producto)
    {
        NavigationManager.NavigateTo("/Producto/" + producto.ProductoID);
    }

    private async Task Refresh()
    {
        productos = await service.GetProductoAsync();
        usuario1 = await service_usuario.getInformation(name_search);
    }


    public Producto NewProducto { get; set; } = new Producto();
    private async Task AddNewProducto()
    {
        await service.AddProductoAsync(NewProducto,image);
        NewProducto = new Producto();
        await Refresh();
    }
    Producto ProductoUpdate = new Producto();
    private void SetProductoForUpdate(Producto producto)
    {
        ProductoUpdate = producto;
    }
    private async Task UpdateProductoData()
    {
        await service.UpdateProductoAsync(ProductoUpdate);
        await Refresh();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuario> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceUsuario service_usuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
