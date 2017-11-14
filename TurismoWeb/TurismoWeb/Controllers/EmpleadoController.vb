Imports TurismoClases
Imports System.Web.Mvc
Namespace Controllers
    Public Class EmpleadoController
        Inherits Controller

        ' GET: Empleado
        Function Index() As ActionResult
            Dim dtEmpleados As New DataTable
            dtEmpleados = Empleado.RecuperarRegistrosEmpleado
            ViewData("Empleado") = dtEmpleados.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Dim dtEmpleado As New DataTable
            dtEmpleado = Empleado.RecuperarRegistrosEmpleado
            ViewData("Empleado") = dtEmpleado.AsEnumerable
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            Dim vEmpleado As New Empleado
            With vEmpleado
                .pNombre = form("nombre")
                .pApellido = form("apellido")
                .pCargoEmpleadoID = form("cargoempleadoid")
                .pTipoDocumentoID = form("tipodocumentoid")
                .pNroDocumento = form("nrodocumento")
                .pFechaNacimiento = form("fechanacimiento")
                .pSucursalEmpresaID = form("sucursalempresaid")
                .pTelefono = form("telefono")
                .pDireccion = form("direccion")
                .pEstadoCivil = form("estadocivil")
                .pAntiguedad = form("antiguedad")
                .pEstadoSistema = form("estadosistema")
            End With
            vEmpleado.Insertar()
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vEmpleado As New Empleado
            vEmpleado = vEmpleado.RecuperarRegistroEmpleado(id)
            Return View(vEmpleado)
        End Function

        <HttpPost>
        Function Edit(form As FormCollection) As ActionResult
            Dim vEmpleado As New Empleado
            vEmpleado.pNombre = form("nombre")
            vEmpleado.pApellido = form("apellido")
            vEmpleado.pCargoEmpleadoID = form("cargoempleadoid")
            vEmpleado.pTipoDocumentoID = form("tipodocumentoid")
            vEmpleado.pNroDocumento = form("nrodocumento")
            vEmpleado.pFechaNacimiento = form("fechanacimiento")
            vEmpleado.pSucursalEmpresaID = form("sucursalempresaid")
            vEmpleado.pTelefono = form("telefono")
            vEmpleado.pDireccion = form("direccion")
            vEmpleado.pEstadoCivil = form("estadocivil")
            vEmpleado.pAntiguedad = form("antiguedad")
            vEmpleado.pEstadoSistema = form("estadosistema")
            vEmpleado.Actualizar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace