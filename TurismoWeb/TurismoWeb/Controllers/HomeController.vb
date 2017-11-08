Imports System.Web.Mvc
Imports TurismoClases

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Util.inicializaSesion("(localdb)\mssqllocaldb", "Turismo", "sa", "123456")
            Return View()
        End Function
    End Class
End Namespace