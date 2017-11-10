
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Create</title>
</head>
<body>
    <h2>Nuevo Empleado</h2>
    <form action="Create" method="post">
        Nombre: <input type="text" name="nombre" /><br />
        Apellido: <input type="text" name="apellido" /><br />
        Cargo Empleado ID: <input type="text" name="cargoempleadoid" /><br />
        Tipo Documento ID: <input type="text" name="tipodocumentoid" /><br />
        Nro Documento: <input type="text" name="nrodocumento" /><br />
        Fecha Nacimiento: <input type="text" name="fechanacimiento" /><br />
        Sucursal Empresa ID: <input type="text" name="sucursalempresaid" /><br />
        Telefono: <input type="text" name="telefono" /><br />
        Direccion: <input type="text" name="direccion" /><br />
        Estado Civil: <input type="text" name="estadocivil" /><br />
        Antiguedad: <input type="text" name="antiguedad" /><br />
        Estado Sistema:<select name="estadosistema">
            <option value="S">Si</option>
            <option value="N">No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>
</body>
</html>
