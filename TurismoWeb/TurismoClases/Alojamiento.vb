Imports TurismoClases.Util
Imports System.Data

Public Class Alojamiento
#Region "Atributos"
    Private AlojamientoID As Integer
    Private Nombre As String
    Private Direccion As String
    Private Telefono As String
    Private PaginaWeb As String
    Private Estrellas As Integer
    Private EstadoSistema As Integer
#End Region

#Region "Propiedades"
    Public Property pAlojamientoID As Integer
        Get
            Return AlojamientoID
        End Get
        Set(value As Integer)
            AlojamientoID = value
        End Set
    End Property

    Public Property pNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property pDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property

    Public Property pTelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property

    Public Property pPaginaWeb As String
        Get
            Return PaginaWeb
        End Get
        Set(value As String)
            PaginaWeb = value
        End Set
    End Property

    Public Property pEstrellas As Integer
        Get
            Return Estrellas
        End Get
        Set(value As Integer)
            Estrellas = value
        End Set
    End Property

    Public Property pEstadoSistema As Integer
        Get
            Return EstadoSistema
        End Get
        Set(value As Integer)
            EstadoSistema = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spInsertarAlojamiento", Nombre, Direccion, Telefono, PaginaWeb, Estrellas, EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarAlojamiento", AlojamientoID, Nombre, Direccion, Telefono, PaginaWeb, Estrellas, EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarAlojamiento", AlojamientoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function RecuperarRegistro(ByVal AlojamientoID As Integer) As Alojamiento
        Dim vAlojamiento As New Alojamiento
        Dim dtAlojamiento As New DataTable
        dtAlojamiento = gDatos.TraerDataTable("spListarAlojamientoPorID", AlojamientoID)
        If dtAlojamiento.Rows.Count > 0 Then
            With vAlojamiento
                .pAlojamientoID = dtAlojamiento.Rows(0).Item("AlojamientoID")
                .pNombre = dtAlojamiento.Rows(0).Item("Nombre")
                .pDireccion = dtAlojamiento.Rows(0).Item("Direccion")
                .pTelefono = dtAlojamiento.Rows(0).Item("Telefono")
                .pPaginaWeb = dtAlojamiento.Rows(0).Item("PaginaWeb")
                .pEstrellas = dtAlojamiento.Rows(0).Item("Estrellas")
                .pEstadoSistema = dtAlojamiento.Rows(0).Item("EstadoSistema")
            End With
            Return vAlojamiento
        Else
            Return Nothing
        End If
    End Function

    Public Shared Function RecuperarRegistros() As DataTable
        Return gDatos.TraerDataTable("spListarAlojamiento")
    End Function
#End Region
End Class
