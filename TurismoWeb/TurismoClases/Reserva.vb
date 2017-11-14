Imports TurismoClases.Util
Imports System.Data
Public Class Reserva

#Region "Atributos"
    Private ReservaID As Integer
    Private ClienteID As Integer
    Private AlojamientoID As Integer
    Private PrecioReserva As Integer
    Private FechaReserva As Date
    Private Pagado As Integer


#End Region

#Region "Propiedades"
    Public Property pReservaID As Integer
        Get
            Return ReservaID
        End Get
        Set(value As Integer)
            ReservaID = value
        End Set
    End Property

    Public Property pClienteID As Integer
        Get
            Return ClienteID
        End Get
        Set(value As Integer)
            ClienteID = value
        End Set
    End Property

    Public Property pAlojamientoID As Integer
        Get
            Return AlojamientoID
        End Get
        Set(value As Integer)
            AlojamientoID = value
        End Set
    End Property

    Public Property pPrecioReserva As Integer
        Get
            Return PrecioReserva
        End Get
        Set(value As Integer)
            PrecioReserva = value
        End Set
    End Property

    Public Property pFechaReserva As Date
        Get
            Return FechaReserva
        End Get
        Set(value As Date)
            FechaReserva = value
        End Set
    End Property

    Public Property pPagado As Integer
        Get
            Return Pagado
        End Get
        Set(value As Integer)
            Pagado = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spInsertarReserva", Me.ClienteID, Me.AlojamientoID, Me.PrecioReserva, Me.PrecioReserva, Me.FechaReserva, Me.Pagado)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarReserva", Me.ReservaID, Me.ClienteID, Me.AlojamientoID, Me.PrecioReserva, Me.PrecioReserva, Me.FechaReserva, Me.Pagado)
        Catch ex As Exception

            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarReservas", Me.ReservaID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarRegistroID(ByVal vCodigo As Integer) As Reserva
        Try
            Dim dtReserva As New Data.DataTable("Reserva")
            dtReserva = gDatos.TraerDataTable("spListarReservasID", vCodigo)
            If dtReserva.Rows.Count > 0 Then
                Dim vReserva As New Reserva
                vReserva.pReservaID = dtReserva.Rows(0).Item("ReservaID")
                vReserva.pClienteID = dtReserva.Rows(0).Item("ClienteID")
                vReserva.pAlojamientoID = dtReserva.Rows(0).Item("AlojamientoID")
                vReserva.pPrecioReserva = dtReserva.Rows(0).Item("PrecioReserva")
                vReserva.pFechaReserva = dtReserva.Rows(0).Item("FechaReserva")
                vReserva.pPagado = dtReserva.Rows(0).Item("Pagado")
                Return vReserva
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarRegistrosReservas() As DataTable
        Try
            Dim dtReserva As New Data.DataTable("Reserva")
            dtReserva = gDatos.TraerDataTable("spListarReservas")
            Return dtReserva
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region


End Class
