Imports System.Web.Mvc
Imports TurismoClases

Namespace Controllers
    Public Class AlojamientoController
        Inherits Controller

        ' GET: Alojamiento
        Function Index() As ActionResult
            ViewData("alojamientos") = Alojamiento.RecuperarRegistros.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Create(form As FormCollection) As ActionResult
            Dim vAlojamiento As New Alojamiento
            With vAlojamiento
                .pNombre = form("nombre")
                .pDireccion = form("direccion")
                .pTelefono = form("telefono")
                .pPaginaWeb = form("paginaweb")
                .pEstrellas = form("estrellas")
                .pEstadoSistema = form("estadosistema")
                .Insertar()
            End With
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vAlojamiento As New Alojamiento
            vAlojamiento = Alojamiento.RecuperarRegistro(id)
            Return View(vAlojamiento)
        End Function

        <HttpPost>
        Function Edit(form As FormCollection) As ActionResult
            Dim vAlojamiento As New Alojamiento
            With vAlojamiento
                .pAlojamientoID = form("AlojamientoID")
                .pNombre = form("nombre")
                .pDireccion = form("direccion")
                .pTelefono = form("telefono")
                .pPaginaWeb = form("paginaweb")
                .pEstrellas = form("estrellas")
                .pEstadoSistema = form("estadosistema")
                .Actualizar()
            End With
            Return RedirectToAction("Index")
        End Function

        <HttpPost>
        Function Delete(id As Integer) As ActionResult
            Dim vAlojamiento As New Alojamiento
            vAlojamiento = Alojamiento.RecuperarRegistro(id)
            vAlojamiento.Eliminar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace