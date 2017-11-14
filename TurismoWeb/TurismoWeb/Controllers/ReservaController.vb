Imports System.Web.Mvc
Imports System.Data
Imports TurismoClases

Namespace Controllers
    Public Class ReservaController
        Inherits Controller

        ' GET: Reserva
        Function Index() As ActionResult
            Dim dtReserva As New DataTable
            dtReserva = Reserva.RecuperarRegistrosReservas
            ViewData("Reserva") = dtReserva.AsEnumerable
            Return View()
        End Function

        Function Create() As ActionResult
            Dim dtReserva As New DataTable
            dtReserva = Reserva.RecuperarRegistrosReservas
            ViewData("Reserva") = dtReserva.AsEnumerable
            Return View()
        End Function

        <HttpPost()>
        Function Create(form As FormCollection) As ActionResult
            Dim vReserva As New Reserva
            With vReserva
                .pClienteID = form("clienteid")
                .pAlojamientoID = form("alojamientoid")
                .pPrecioReserva = form("precioreserva")
                .pFechaReserva = form("fechareserva")
                .pPagado = form("pagado")

            End With
            vReserva.Insertar()
            Return RedirectToAction("Index")
        End Function

        Function Edit(id As Integer) As ActionResult
            Dim vReserva As New Reserva
            vReserva = vReserva.RecuperarRegistroID(id)
            Return View(vReserva)
        End Function

        <HttpPost>
        Function Edit(form As FormCollection) As ActionResult
            Dim vReserva As New Reserva
            With vReserva
                .pClienteID = form("clienteid")
                .pAlojamientoID = form("alojamientoid")
                .pPrecioReserva = form("precioreserva")
                .pFechaReserva = form("fechareserva")
                .pPagado = form("pagado")

            End With
            vReserva.Actualizar()
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace