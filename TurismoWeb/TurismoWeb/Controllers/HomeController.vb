Imports System.Data.SqlClient
Imports System.Web.Mvc
Imports TurismoClases

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            'Dim cadenaConexion As String = "data source=(local); initial catalog=Turismo; user id=sa; password=@lumno123"
            'Dim conexion As New SqlConnection(cadenaConexion)

            Util.inicializaSesion("(localdb)\mssqllocaldb", "Turismo", "sa", "123456")
            Return View()
        End Function
    End Class
End Namespace
