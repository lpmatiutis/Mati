Imports TurismoClases
Imports TurismoClases.Util
Imports TurismoClases.Empleado
Imports System.Data
Public Class Empleado

#Region "Atributos"
    Private EmpleadoID As Integer
    Private Nombre As String
    Private Apellido As String
    Private CargoEmpleadoID As Integer
    Private TipoDocumentoID As Integer
    Private NroDocumento As String
    Private FechaNacimiento As Date
    Private SucursalEmpresaID As Integer
    Private Telefono As String
    Private Direccion As String
    Private EstadoCivil As Char
    Private Antiguedad As Integer
    Private EstadoSistema As Integer
#End Region

#Region "Propiedades"
    Public Property pEmpleadoID() As Integer
        Get
            Return EmpleadoID
        End Get

        Set(ByVal value As Integer)
            EmpleadoID = value
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
    Public Property pApellido() As String
        Get
            Return Apellido
        End Get

        Set(ByVal value As String)
            Apellido = value
        End Set
    End Property

    Public Property pCargoEmpleadoID() As Integer
        Get
            Return CargoEmpleadoID
        End Get

        Set(ByVal value As Integer)
            CargoEmpleadoID = value
        End Set
    End Property

    Public Property pTipoDocumentoID() As Integer
        Get
            Return TipoDocumentoID
        End Get

        Set(ByVal value As Integer)
            TipoDocumentoID = value
        End Set
    End Property

    Public Property pNroDocumento() As String
        Get
            Return NroDocumento
        End Get

        Set(ByVal value As String)
            NroDocumento = value
        End Set
    End Property

    Public Property pFechaNacimiento() As Date
        Get
            Return FechaNacimiento
        End Get

        Set(ByVal value As Date)
            FechaNacimiento = value
        End Set
    End Property

    Public Property pSucursalEmpresaID() As Integer
        Get
            Return SucursalEmpresaID
        End Get

        Set(ByVal value As Integer)
            SucursalEmpresaID = value
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

    Public Property pEstadoCivil() As Char
        Get
            Return EstadoCivil
        End Get

        Set(ByVal value As Char)
            EstadoCivil = value
        End Set
    End Property


    Public Property pAntiguedad() As Integer
        Get
            Return Antiguedad
        End Get

        Set(ByVal value As Integer)
            Antiguedad = value
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
            gDatos.Ejecutar("spInsertarEmpleado", Me.Nombre, Me.Apellido, Me.CargoEmpleadoID, Me.TipoDocumentoID, Me.NroDocumento, Me.FechaNacimiento, Me.SucursalEmpresaID, Me.Telefono, Me.Direccion, Me.EstadoCivil, Me.Antiguedad, Me.EstadoSistema, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarEmpleado", Me.EmpleadoID, Me.Nombre, Me.Apellido, Me.CargoEmpleadoID, Me.TipoDocumentoID, Me.NroDocumento, Me.FechaNacimiento, Me.SucursalEmpresaID, Me.Telefono, Me.Direccion, Me.pEstadoCivil, Me.Antiguedad, Me.EstadoSistema, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarEmpleado", Me.EmpleadoID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarRegistroEmpleado(ByVal vCodigo As Integer) As Empleado
        Try
            Dim dtEmpleado As New Data.DataTable("Empleado")
            dtEmpleado = gDatos.TraerDataTable("spListarEmpleadoPorID", vCodigo)
            If dtEmpleado.Rows.Count > 0 Then
                Dim vEmpleado As New Empleado
                vEmpleado.pEmpleadoID = dtEmpleado.Rows(0).Item("EmpleadoID")
                vEmpleado.pNombre = dtEmpleado.Rows(0).Item("Nombre")
                vEmpleado.pApellido = dtEmpleado.Rows(0).Item("Apellido")
                vEmpleado.pCargoEmpleadoID = dtEmpleado.Rows(0).Item("CargoEmpleadoID")
                vEmpleado.pTipoDocumentoID = dtEmpleado.Rows(0).Item("TipoDocumentoID")
                vEmpleado.pNroDocumento = dtEmpleado.Rows(0).Item("NroDocumento")
                vEmpleado.pFechaNacimiento = dtEmpleado.Rows(0).Item("FechaNacimiento")
                vEmpleado.pSucursalEmpresaID = dtEmpleado.Rows(0).Item("SucursalEmpresaID")
                vEmpleado.pTelefono = dtEmpleado.Rows(0).Item("Telefono")
                vEmpleado.pDireccion = dtEmpleado.Rows(0).Item("Direccion")
                vEmpleado.pEstadoCivil = dtEmpleado.Rows(0).Item("EstadoCivil")
                vEmpleado.pAntiguedad = dtEmpleado.Rows(0).Item("Antiguedad")
                vEmpleado.pEstadoSistema = dtEmpleado.Rows(0).Item("EstadoSistema")
                Return vEmpleado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarRegistrosEmpleado() As DataTable
        Try
            Dim dtEmpleado As New Data.DataTable("Empleado")
            dtEmpleado = gDatos.TraerDataTable("spListarEmpleado")
            Return dtEmpleado
        Catch ex As Exception
            Throw ex
        End Try
    End Function



#End Region
End Class
