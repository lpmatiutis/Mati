
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Modificar Empleado</title>
</head>
<body>
   
    <h2>Modificar Empleado</h2>
    <form action="Edit" method="post">
        <input type="hidden" name="empleadoid" value="@Model.pEmpleadoID" />
        Nombre: <input type="text" name="nombre" value="@Model.pNombre" /><br />
        Apellido: <input type="text" name="apellido" value="@Model.pApellido" /><br />
        Cargo Empleado ID: <input type="text" name="cargoempleadoid" value="@Model.pCargoEmpleadoID" /><br />
        Tipo Documento ID: <input type="text" name="tipodocumentoid" value="@Model.pTipoDocumentoID" /><br />
        Nro Documento: <input type="text" name="nrodocumento" value="@Model.pNroDocumento" /><br />
        Fecha Nacimiento: <input type="text" name="fechanacimiento" value="@Model.pFechaNacimiento" /><br />
        Sucursal Empresa ID: <input type="text" name="sucursalempresaid" value="@Model.pSucursalEmpresaID" /><br />
        Telefono: <input type="text" name="telefono" value="@Model.pTelefono" /><br />
        Direccion: <input type="text" name="direccion" value="@Model.pdireccion" /><br />
        Estado Civil: <input type="text" name="estadocivil" value="@Model.pEstadoCivil" /><br />
        Antiguedad: <input type="text" name="antiguedad" value="@Model.pAntiguedad" /><br />
        Estado Sistema:<select name="estadosistema">
            <option value="1" @IIf(Model.pEstadoSistema = "1", "Selected", "")>Si</option>
            <option value="0" @IIf(Model.pEstadoSistema = "0", "Selected", "")>No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>

</body>
</html>
