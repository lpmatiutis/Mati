Imports System.Data
Imports TurismoClases.Util

Public Class Profesion

#Region "atributos"
    Private ProfesionID As Integer
    Private Descripcion As String
#End Region

#Region "propiedades"
    Public Property pProfesionID As Integer
        Get
            Return ProfesionID
        End Get
        Set(value As Integer)
            ProfesionID = value
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
            Return gDatos.TraerDataTable("spListarProfesion")
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Function RecuperarRegistroPorID(id As Integer) As Profesion
        Try
            Dim dtProfesion As New DataTable
            dtProfesion = gDatos.TraerDataTable("spListarProfesionPorID", id)
            If dtProfesion.Rows.Count > 0 Then
                Dim vProfesion As New Profesion
                With vProfesion
                    .ProfesionID = dtProfesion.Rows(0).Item("ProfesionID")
                    .Descripcion = dtProfesion.Rows(0).Item("Descripcion")
                End With
                Return vProfesion
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
End Class
