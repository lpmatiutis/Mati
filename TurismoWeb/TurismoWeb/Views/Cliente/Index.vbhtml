
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <link href="~/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h3>
        <a href="/Cliente/Create" class="btn btn-success"> Nuevo CLiente </a>
    </h3>

    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>Codigo</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>TipoDocumentoID</th>
                <th>NroDocumentoID</th>
                <th>EstadoCivil</th>
                <th>Telefono</th>
                <th>Direccion</th>
                <th>Email</th>
                <th>FechaNacimiento</th>
                <th>Sexo</th>
                <th>TipoClientes</th>
                <th>EstadoSistema</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In ViewData("cliente")
                @<tr>
                    <td>@item("ClienteID")</td>
                    <td>@item("Nombre")</td>
                    <td>@item("Apellido")</td>
                    <td>@item("TipoDocumentoID")</td>
                    <td>@item("NroDocumento")</td>
                    <td>@item("EstadoCivil")</td>
                    <td>@item("Telefono")</td>
                    <td>@item("Direccion")</td>
                    <td>@item("Telefono")</td>
                    <td>@item("Direccion")</td>
                    <td>@item("Email")</td>
                    <td>@item("FechaNacimiento")</td>
                    <td>@item("ProfesionID")</td>
                    <td>@item("Sexo")</td>
                    <td>@item("TipoClienteID")</td>
                    <td>@item("EstadoSistema")</td>
                    <td>
                        <a href="Cliente/Edit/@item("ClienteID")" class="btn btn-info">Modificar</a>
                        <a href="javascript:eliminar(@item("ClienteID"))" class="btn btn-danger">Eliminar</a>
                    </td>
                </tr>
            Next
        </tbody>
    </table>

    <script src="~/js/jquery-3.2.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
</body>
</html>
