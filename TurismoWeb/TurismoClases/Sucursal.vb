Imports TurismoClases.Util
Imports System.Data
Public Class Sucursal

#Region "Atributos"
    Private SucursalEmpresaID As Integer
    Private Nombre As String
    Private CiudadID As Integer
    Private Telefono As String
    Private Direccion As String
    Private Email As String
    Private Cantidadempleados As Integer
    Private EstadoSistema As Integer

#End Region

#Region "Propiedades"
    Public Property pSucursalEmpresaID() As Integer
        Get
            Return SucursalEmpresaID
        End Get
        Set(ByVal value As Integer)
            SucursalEmpresaID = value

        End Set
    End Property

    Public Property pNombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value

        End Set
    End Property

    Public Property pCiudadID() As Integer
        Get
            Return CiudadID
        End Get
        Set(ByVal value As Integer)
            CiudadID = value

        End Set
    End Property


    Public Property pTelefono() As String
        Get
            Return Telefono
        End Get
        Set(ByVal value As String)
            Telefono = value

        End Set
    End Property

    Public Property pDireccion() As String
        Get
            Return Direccion
        End Get
        Set(ByVal value As String)
            Direccion = value

        End Set
    End Property

    Public Property pEmail() As String
        Get
            Return Email
        End Get
        Set(ByVal value As String)
            Email = value

        End Set
    End Property

    Public Property pCantidadEmpleados() As Integer
        Get
            Return Cantidadempleados
        End Get
        Set(ByVal value As Integer)
            Cantidadempleados = value

        End Set
    End Property

    Public Property pEstadoSistema() As Integer
        Get
            Return EstadoSistema
        End Get
        Set(ByVal value As Integer)
            EstadoSistema = value

        End Set
    End Property


#End Region

#Region "Metodos"
    Public Sub Insertar()
        Try
            gDatos.Ejecutar("spInsertarSucursal", Me.Nombre, Me.CiudadID, Me.Telefono, Me.Direccion, Me.Email, Me.Cantidadempleados, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarSucursal", Me.SucursalEmpresaID, Me.Nombre, Me.CiudadID, Me.Telefono, Me.Direccion, Me.Email, Me.Cantidadempleados, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarSucursal", Me.SucursalEmpresaID)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarSucursalID(ByVal vCodigo As Integer) As Sucursal
        Try
            Dim dtSucursal As New Data.DataTable("SucursalEmpresa")
            dtSucursal = gDatos.TraerDataTable("spListarSucursalID", vCodigo)
            If dtSucursal.Rows.Count > 0 Then
                Dim vSucursal As New Sucursal
                With vSucursal
                    .pSucursalEmpresaID = dtSucursal.Rows(0).Item("SucursalEmpresaID")
                    .pNombre = dtSucursal.Rows(0).Item("Nombre")
                    .pCiudadID = dtSucursal.Rows(0).Item("CiudadID")
                    .pTelefono = dtSucursal.Rows(0).Item("Telefono")
                    .pDireccion = dtSucursal.Rows(0).Item("Direccion")
                    .pEmail = dtSucursal.Rows(0).Item("Email")
                    .pCantidadEmpleados = dtSucursal.Rows(0).Item("CantidadEmpleados")
                    .pEstadoSistema = dtSucursal.Rows(0).Item("EstadoSistema")


                End With
                Return vSucursal
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RecuperarSucursal() As DataTable
        Try
            Dim dtSucursal As New Data.DataTable("SucursalEmpresa")
            dtSucursal = gDatos.TraerDataTable("spListarSucursal")
            Return dtSucursal
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
