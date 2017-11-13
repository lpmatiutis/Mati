
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code


    <h3>
        <a href="/Cliente/Create" class="btn btn-success"> Nuevo CLiente </a>
    </h3>

    <table id="mi_tabla" class="table table-striped table-hover table-bordered">
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
    <script type="text/javascript">

        function eliminar(id) {
            if (confirm('¿Estas seguro de eliminar el registro?')) {
                var parametro = {
                    id: id
                };

                $.ajax({
                    url: '../Cliente/Eliminar',
                    data: parametro,
                    type: "post",
                    cache: false,
                    success: function (retorno) {
                        location.reload();
                    },
                    error: function () {
                        alert("se ha producido un error.");
                    }
                });
            }
        }
    </script>
    <script src="~/js/jquery-3.2.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>
