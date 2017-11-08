Imports TurismoClases.Util
Imports System.Data
Public Class Cliente

#Region "Atributos"
    Private ClienteID As Integer
    Private Nombre As String
    Private Apellido As String
    Private TipoDocumento As Integer
    Private NroDocumento As String
    Private EstadoCivil As String
    Private Telefono As String
    Private Direccion As String
    Private Email As String
    Private FechaNacimiento As Date
    Private Profesion As Integer
    Private Sexo As Integer
    Private TipoClienteID As Integer
    Private EstadoSistema As Integer
#End Region

#Region "Propiedades"
    Public Property pClienteID() As Integer
        Get
            Return ClienteID
        End Get

        Set(ByVal value As Integer)
            ClienteID = value
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

    Public Property pTipoDocumento() As Integer
        Get
            Return TipoDocumento
        End Get

        Set(ByVal value As Integer)
            TipoDocumento = value
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

    Public Property pEstadoCivil() As String
        Get
            Return EstadoCivil
        End Get

        Set(ByVal value As String)
            EstadoCivil = value
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

    Public Property pFechaNacimiento() As Date
        Get
            Return FechaNacimiento
        End Get

        Set(ByVal value As Date)
            FechaNacimiento = value
        End Set
    End Property

    Public Property pProfesion() As Integer
        Get
            Return Profesion
        End Get

        Set(ByVal value As Integer)
            Profesion = value
        End Set
    End Property

    Public Property pSexo() As Integer
        Get
            Return Sexo
        End Get

        Set(ByVal value As Integer)
            Sexo = value
        End Set
    End Property

    Public Property pTipoClienteID() As Integer
        Get
            Return TipoClienteID
        End Get

        Set(ByVal value As Integer)
            TipoClienteID = value
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
            gDatos.Ejecutar("spInsertarCliente", Me.Nombre, Me.Apellido, Me.TipoDocumento, Me.NroDocumento, Me.EstadoCivil, Me.Telefono, Me.Direccion, Me.Email, Me.FechaNacimiento, Me.Profesion, Me.Sexo, Me.TipoClienteID, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            gDatos.Ejecutar("spActualizarCliente", Me.ClienteID, Me.Nombre, Me.Apellido, Me.TipoDocumento, Me.NroDocumento, Me.EstadoCivil, Me.Telefono, Me.Direccion, Me.Email, Me.FechaNacimiento, Me.Profesion, Me.Sexo, Me.TipoClienteID, Me.EstadoSistema)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            gDatos.Ejecutar("spEliminarCliente", Me.ClienteID)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function RecuperarRegistro(ByVal vCodigo As Integer) As Cliente
        Try
            Dim dtCliente As New Data.DataTable("cliente")
            dtCliente = gDatos.TraerDataTable("spListarClienteNombre", vCodigo)
            If dtCliente.Rows.Count > 0 Then
                Dim vCliente As New Cliente
                vCliente.pClienteID = dtCliente.Rows(0).Item("ClienteID")
                vCliente.pNombre = dtCliente.Rows(0).Item("Nombre")
                vCliente.pApellido = dtCliente.Rows(0).Item("Apellido")
                vCliente.pTipoDocumento = dtCliente.Rows(0).Item("TipoDocumentoID")
                vCliente.pNroDocumento = dtCliente.Rows(0).Item("NroDocumento")
                vCliente.pEstadoCivil = dtCliente.Rows(0).Item("EstadoCivil")
                vCliente.pTelefono = dtCliente.Rows(0).Item("Telefono")
                vCliente.pDireccion = dtCliente.Rows(0).Item("Direccion")
                vCliente.pEmail = dtCliente.Rows(0).Item("Email")
                vCliente.pFechaNacimiento = dtCliente.Rows(0).Item("FechaNacimiento")
                vCliente.pProfesion = dtCliente.Rows(0).Item("Profesion")
                vCliente.pSexo = dtCliente.Rows(0).Item("Sexo")
                vCliente.pTipoClienteID = dtCliente.Rows(0).Item("TipoClienteID")
                vCliente.pEstadoSistema = dtCliente.Rows(0).Item("EstadoSistema")
                Return vCliente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Shared Function RecuperarRegistrosCliente() As DataTable
        Try
            Dim dtCliente As New Data.DataTable("cliente")
            dtCliente = gDatos.TraerDataTable("spListarCliente")
            Return dtCliente
        Catch ex As Exception
            Throw ex
        End Try
    End Function



#End Region
End Class
