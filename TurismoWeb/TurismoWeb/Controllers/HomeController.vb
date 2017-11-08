Imports System.Web.Mvc


Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Util.inicializaSesion("M205-03", "Restaurante", "sa", "@lumno123")
            Return View()
        End Function
    End Class
End Namespace