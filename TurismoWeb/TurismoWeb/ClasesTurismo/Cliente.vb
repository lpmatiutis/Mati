Imports ClasesTurismo.Util
Public class Cliente

   #Region "Atributos"
   private ClienteID as Integer
   private Nombre as String
   private Apellido as String
   private TipoDocumento as Integer
   private NroDocumento as String
   private EstadoCivil as String
   private Telefono as String
   private Direccion as String
   private Email as String
   private FechaNacimiento as Date
   private Profesion as Integer
   private Sexo as Integer
   private TipoClienteID as Integer
   private EstadoSistema as Integer
   #End Region

   #Region "Propiedades"
   public property pClienteID() as Integer
       get
           return ClienteID
       end get

       set(byval value as Integer)
           ClienteID = value
       end set
   end property

   public property pNombre() as String
       get
           return Nombre
       end get

       set(byval value as String)
           Nombre = value
       end set
   end property
   public property pApellido() as String
       get
           return Apellido
       end get

       set(byval value as String)
           Apellido = value
       end set
   end property

   public property pTipoDocumento() as Integer
       get
           return TipoDocumento
       end get

       set(byval value as Integer)
           TipoDocumento = value
       end set
   end property

   public property pNroDocumento() as String
       get
           return NroDocumento
       end get

       set(byval value as String)
           NroDocumento = value
       end set
   end property

   public property pEstadoCivil() as String
       get
           return EstadoCivil
       end get

       set(byval value as String)
           EstadoCivil = value
       end set
   end property

   public property pTelefono() as String
       get
           return Telefono
       end get

       set(byval value as String)
           Telefono = value
       end set
   end property

   public property pDireccion() as String
       get
           return Direccion
       end get

       set(byval value as String)
           Direccion = value
       end set
   end property

   public property pEmail() as String
       get
           return Email
       end get

       set(byval value as String)
           Email = value
       end set
   end property

   public property pFechaNacimiento() as Date
       get
           return FechaNacimiento
       end get

       set(byval value as Date)
           FechaNacimiento = value
       end set
   end property

   public property pProfesion() as Integer
       get
           return Profesion
       end get

       set(byval value as String)
           Profesion = value
       end set
   end property

   public property pSexo() as Integer
       get
           return Sexo
       end get

       set(byval value as Integer)
           Sexo = value
       end set
   end property

public property pTipoClienteID() as Integer
       get
           return TipoClienteID
       end get

       set(byval value as Integer)
           TipoClienteID = value
       end set
   end property

   public property pEstadoSistema() as Integer
       get
           return EstadoSistema
       end get

       set(byval value as Integer)
           EstadoSistema = value
       end set
   end property

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
            gDatos.Ejecutar("spActualizarCliente", Me.ClienteID, Me.Nombre, Me.Apellido, Me.TipoDocumento, Me.NroDocumento, Me.EstadoCivil, Me.Telefono, me.Direccion, Me.Email, Me.FechaNacimiento, Me.Profesion, Me.Sexo, Me.TipoClienteID, Me.EstadoSistema)
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
                vUsuario.pEstadoSistema = dtUsuario.Rows(0).Item("EstadoSistema")
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
End class
