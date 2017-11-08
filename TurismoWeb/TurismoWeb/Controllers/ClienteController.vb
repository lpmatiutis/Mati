Imports System.Web.Mvc
Imports System.Data
Imports TurismoClases

Namespace Controllers
    Public Class ClienteController
        Inherits Controller

        ' GET: Cliente
        Function Index() As ActionResult
            Dim dtClientes As New DataTable
            dtClientes = Cliente.RecuperarRegistrosCliente
            ViewData("Cliente") = dtClientes.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Dim dtClients As New DataTable
            dtClients = Cliente.RecuperarRegistrosCliente
            ViewData("Cliente") = dtClients.AsEnumerable
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            Dim vCliente As New Cliente
            With vCliente
                .pNombre = form("nombre")
                .pApellido = form("apellido")
                .pTipoDocumento = form("tipodocumento")
                .pNroDocumento = form("nrodocumento")
                .pEstadoCivil = form("estadocivil")
                .pTelefono = form("telefono")
                .pDireccion = form("direccion")
                .pEmail = form("email")
                .pFechaNacimiento = form("fechanacimiento")
                .pProfesion = form("profesion")
                .pSexo = form("sexo")
                .pTipoClienteID = form("tipoclienteid")
                .pEstadoSistema = form("estadosistema")


            End With
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vCliente As New Cliente
            vCliente = vCliente.RecuperarRegistro(id)
            Return View(vCliente)
        End Function

        <HttpPost>
        Function Edit(form As FormCollection) As ActionResult
            Dim vCliente As New Cliente
            vCliente.pNombre = form("nombre")
            vCliente.pApellido = form("apellido")
            vCliente.pTipoDocumento = form("tipodocumento")
            vCliente.pNroDocumento = form("nrodocumento")
            vCliente.pEstadoCivil = form("estadocivil")
            vCliente.pTelefono = form("telefono")
            vCliente.pDireccion = form("direccion")
            vCliente.pEmail = form("email")
            vCliente.pFechaNacimiento = form("fechanacimiento")
            vCliente.pProfesion = form("profesion")
            vCliente.pSexo = form("sexo")
            vCliente.pTipoClienteID = form("tipoclienteid")
            vCliente.pEstadoSistema = form("estadosistema")
            vCliente.Actualizar()
            Return RedirectToAction("Index")
        End Function
    End Class

End Namespace