// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\Pages\Eliminar.razor"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Eliminar")]
    public partial class Eliminar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\abelb\Desktop\ITLA\CUATRIMESTRES\CUATRIMESTRE V\I. PROGRAMACIÓN III\MÓDULO VII - TEAMUP\III. ACTIVIDAD II\Tarea7\Tarea7\Pages\Eliminar.razor"
       
    string cedula;
    SqlConnection conexion = new SqlConnection("server= localhost\\SQLEXPRESS; database = Tarea7; Integrated security = True");
    string exito;
    string error;
    void eliminar()
    {
        try
        {
            string query = "DELETE FROM Personas where Cedula = @cedula";
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.ExecuteNonQuery();
            conexion.Close();
            exito = "PERSONA ELIMINADA CON EXITO";
        }
        catch(Exception e)
        {
            error = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
