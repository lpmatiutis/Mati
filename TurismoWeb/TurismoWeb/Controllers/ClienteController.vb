Imports System.Web.Mvc

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
    End Class

End Namespace