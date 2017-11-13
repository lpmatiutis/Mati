Imports TurismoClases
Imports System.Web.Mvc

Namespace Controllers
    Public Class SucursalController
        Inherits Controller

        ' GET: Sucursal
        Function Index() As ActionResult
            Dim dtSucursal As New DataTable
            Dim vSucursal As New Sucursal
            dtSucursal = vSucursal.RecuperarSucursal
            ViewData("SucursalEmpresa") = dtSucursal.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Dim dtSucursal As New DataTable
            Dim vSucursal As New Sucursal
            dtSucursal = vSucursal.RecuperarSucursal()
            ViewData("SucursalEmpresa") = dtSucursal.AsEnumerable
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            Dim vSucursal As New Sucursal
            With vSucursal
                .pNombre = form("nombre")
                .pCiudadID = form("ciudadid")
                .pTelefono = form("telefono")
                .pDireccion = form("direccion")
                .pEmail = form("email")
                .pCantidadEmpleados = form("cantidadempleados")
                .pEstadoSistema = form("estadosistema")
                .Insertar()
            End With
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vSucursal As New Sucursal
            vSucursal = vSucursal.RecuperarSucursalID(id)
            Return View(vSucursal)
        End Function

        <HttpPost()>
        Function Edit(form As FormCollection) As ActionResult
            Dim vSucursal As New Sucursal
            vSucursal.pNombre = form("nombre")
            vSucursal.pCiudadID = form("ciudadid")
            vSucursal.pTelefono = form("telefono")
            vSucursal.pDireccion = form("direccion")
            vSucursal.pEmail = form("email")
            vSucursal.pCantidadEmpleados = form("cantidadempleados")
            vSucursal.pEstadoSistema = form("estadosistema")
            vSucursal.Actualizar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace