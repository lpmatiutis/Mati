Imports System.Data
Imports TurismoClases.Util

Public Class TipoDocumento
#Region "Atributos"
    Private TipoDocumentoID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property pTipoDocumentoID As Integer
        Get
            Return TipoDocumentoID
        End Get
        Set(value As Integer)
            TipoDocumentoID = value
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

#Region "Metodos"
    Public Shared Function RecuperarRegistros() As DataTable
        Try
            Return gDatos.TraerDataTable("spListarTipoDocumento")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function RecuperarRegistroPorID(id As Integer) As TipoDocumento
        Try
            Dim dtTipoDocumento As New DataTable
            dtTipoDocumento = gDatos.TraerDataTable("spListarTipoDocumentoPorID", id)
            If dtTipoDocumento.Rows.Count > 0 Then
                Dim vTipoDocumento As New TipoDocumento
                With vTipoDocumento
                    .TipoDocumentoID = dtTipoDocumento.Rows(0).Item("TipoDocumentoID")
                    .Descripcion = dtTipoDocumento.Rows(0).Item("Descripcion")
                End With
                Return vTipoDocumento
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
End Class
