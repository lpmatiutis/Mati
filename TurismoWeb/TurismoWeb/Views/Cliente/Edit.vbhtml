@ModelType TurismoClases.Cliente
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Modificar Cliente</h2>
    <form action="Edit" method="post">
        <input type="hidden" name="clienteid" value="@Model.pClienteID" />
        Nombre: <input type="text" name="nombre" value="@Model.pNombre" /><br />
        Apellido: <input type="text" name="apellido" value="@Model.pApellido" /><br />
        Tipo Documento: <input type="text" name="tipodocumento" value="@Model.pTipoDocumento" /><br />
        Nro Documento: <input type="text" name="nrodocumento" value="@Model.pNroDocumento" /><br />
        Estado Civil: <input type="text" name="estadocivil" value="@Model.pEstadoCivil" /><br />
        Telefono: <input type="text" name="telefono" value="@Model.pTelefono" /><br />
        Direccion: <input type="text" name="Direccion" value="@Model.pDireccion" /><br />
        Email: <input type="text" name="email" value="@Model.pEmail" /><br />
        FechaNacimiento: <input type="text" name="fechanacimiento" value="@Model.pFechaNacimiento" /><br />
        Profesion: <input type="text" name="profesion" value="@Model.pProfesion" /><br />
        Sexo: <input type="text" name="sexo" value="@Model.pSexo" /><br />
        TipoCliente: <input type="text" name="tipocliente" value="@Model.pTipoClienteID" /><br />
        Estado Sistema: <input type="text" name="estadosistema" value="@Model.pEstadoSistema" /><br />
        Estado Sistema:<select name="estadosistema">
            <option value="1" @IIf(Model.pEstadoSistema = "1", "Selected", "")>Si</option>
            <option value="0" @IIf(Model.pEstadoSistema = "0", "Selected", "")>No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>
