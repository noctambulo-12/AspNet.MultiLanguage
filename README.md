
# AspNet.MultiLanguage
#### Creando una aplicación web AspNet Core multi lenguaje (cultura) con sencillos pasos

De forma predeterminada ASP.NET Core proporciona los siguientes proveedores de cultura:
- **QueryStringRequestCultureProvider**, Este proveedor permite recuperar la cultura desde un parametro de la URL.<p/>
Ejemplo: https://localhost:44339/?culture=es-PE

- **CookieRequestCultureProvider**, Este proveedor permite recuperar la cultural desde una cookie.<p/>
Comúnmente el nombre de la cookie es ".AspNetCore.Culture"

- **AcceptLanguageHeaderRequestCultureProvider**, Este proveedor  recupera la cultura desde el encabezado "Accept-Language" del navegador.<p/>

<br/>


Referencia:
1. https://docs.microsoft.com/es-es/aspnet/core/fundamentals/localization?view=aspnetcore-3.1
