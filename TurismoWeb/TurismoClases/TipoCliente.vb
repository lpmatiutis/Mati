Imports System.Data
Imports TurismoClases.Util

Public Class TipoCliente

#Region "atributos"
    Private TipoClienteID As Integer
    Private Descripcion As String
#End Region

#Region "propiedades"
    Public Property pTipoClienteID As Integer
        Get
            Return TipoClienteID
        End Get
        Set(value As Integer)
            TipoClienteID = value
        End Set
    End Property

    Public Property pDescripcion As String
        Get
            Return Descripcion
        End Get
        Set(value As String)
            Descripcion = value
        End Set
    End Property
#End Region

#Region "metodos"

    Public Shared Function RecuperarRegistros() As DataTable
        Try
            Return gDatos.TraerDataTable("spListarTipoCliente")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function RecuperarRegistroPorID(id As Integer) As TipoCliente
        Try
            Dim dtTipoCliente As New DataTable
            dtTipoCliente = gDatos.TraerDataTable("spListarTipoClientePorID", id)
            If dtTipoCliente.Rows.Count > 0 Then
                Dim vTipoCliente As New TipoCliente
                With vTipoCliente
                    .TipoClienteID = dtTipoCliente.Rows(0).Item("TipoClienteID")
                    .Descripcion = dtTipoCliente.Rows(0).Item("Descripcion")
                End With
                Return vTipoCliente
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

#End Region
End Class
