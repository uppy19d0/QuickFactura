#pragma checksum "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a206489185fcaa50d498eef8640520cbab8a31aa"
// <auto-generated/>
#pragma warning disable 1591
namespace Examen_Final.Pages.Factura
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
#line 12 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
using Examen_Final.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Factura/Crear")]
    public partial class CrearFactura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddMarkupContent(3, "<div><h5>Factura</h5></div>\r\n         ");
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "Model", " " + (
#nullable restore
#line 20 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                        NewFactura

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "row");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-group col-md-6");
                __builder2.AddMarkupContent(10, "<label for>Clientes:</label>\r\n                        ");
                __builder2.OpenElement(11, "select");
                __builder2.AddAttribute(12, "id", "customer");
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "placeholder", "Cliente");
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                                                                                 NewFactura.ClienteID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewFactura.ClienteID = __value, NewFactura.ClienteID));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 25 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                             foreach (var cliente in clientes)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(17, "option");
                __builder2.AddAttribute(18, "value", 
#nullable restore
#line 27 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                                cliente.ClienteID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(19, 
#nullable restore
#line 28 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                     cliente.Nombres

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 30 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group col-md-3");
                __builder2.AddMarkupContent(23, "<label for>Fecha de Creacion:</label>\r\n                 ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "date");
                __builder2.AddAttribute(26, "disabled", true);
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                           NewFactura.Fecha

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewFactura.Fecha = __value, NewFactura.Fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                  \r\n            <div class=\"form-group\"></div>\r\n            ");
                __builder2.AddMarkupContent(30, "<label for>Producto:</label>\r\n                        ");
                __builder2.OpenElement(31, "select");
                __builder2.AddAttribute(32, "id", "customer");
                __builder2.AddAttribute(33, "class", "form-control");
                __builder2.AddAttribute(34, "placeholder", "Producto");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                                                                                  NewFactura.ProductoID

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => NewFactura.ProductoID = __value, NewFactura.ProductoID));
                __builder2.SetUpdatesAttributeName("value");
#nullable restore
#line 47 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                             foreach (var producto in productos)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "option");
                __builder2.AddAttribute(38, "value", 
#nullable restore
#line 49 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                                producto.ProductoID

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(39, 
#nullable restore
#line 50 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                     producto.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 52 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                \r\n                    \r\n                                ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "text-center p-3 mb-3");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "class", "btn btn-info");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
                                                                           AddNewFactura

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(46, " Agregar ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(47, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(48, "<center><h1>Lo Siento necesita esta logueado</h1>\r\n            <br><br>\r\n            <p>\r\n                Necesita entrar con tu  usuario para poder visualizar los secreto y poder ver tu secreto\r\n            </p></center>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
            
    
    string selectedString ;

        
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\luis_\OneDrive\Escritorio\Tienda\Examen_Final\Pages\Factura\CrearFactura.razor"
       
    
    public string name_search;
    Usuario usuario1;
    int producto_id;
    List<Factura> facturas = new List<Factura>();
    List<Cliente> clientes = new List<Cliente>();
    List<Producto> productos = new List<Producto>();


    protected override async Task OnInitializedAsync()
    {
        name_search = httpContextAccessor.HttpContext.User.Identity.Name;
        await Refresh();
        NewFactura.Fecha= DateTime.Now;
    }
      private void Navegar(Factura factura)
    {
        NavigationManager.NavigateTo("/Factura/" + factura.FacturaID);
    }

    private async Task Refresh()
    {
        clientes = await service_cliente.GetClientesAsync();
        productos = await service_producto.GetProductoAsync();
        facturas = await service.GetFacturaAsync();
        usuario1 = await service_usuario.getInformation(name_search);
    }


    public Factura NewFactura { get; set; } = new Factura();
    private async Task AddNewFactura()
    {
        NewFactura.UsuarioID = usuario1.Id;
        await service.AddFacturaAsync(NewFactura);
        NewFactura = new Factura();
        await Refresh();
    }
    Factura FacturaUpdate = new Factura();
    private void SetProductoForUpdate(Factura factura)
    {
        FacturaUpdate = factura;
    }
    private async Task UpdateFacturaData()
    {
        await service.UpdateFacturaAsync(FacturaUpdate);
        await Refresh();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuario> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuario> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceCliente service_cliente { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceFactura service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceProducto service_producto { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServiceUsuario service_usuario { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
