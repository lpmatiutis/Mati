Imports System.Web.Mvc
Imports ClasesRestaurante
Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            'Establecer la conexión a la base de datos
            Util.inicializaSesion("M205-03", "Restaurante", "sa", "@lumno123")
            Return View()
        End Function
    End Class
End Namespace