@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code


    <h3>
        <a href="/Cliente/Create" class="btn btn-success"> Nuevo Cliente </a>
    </h3>

    <table id="mi_tabla" class="table table-striped table-hover table-bordered">
        <thead>
            <tr>
                <th>Codigo</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>Tipo Documento</th>
                <th>Nro Documento</th>
                <th>Estado Civil</th>
                <th>Telefono</th>
                <th>Direccion</th>
                <th>Email</th>
                <th>Fecha Nacimiento</th>
                <th>Profesión</th>
                <th>Sexo</th>
                <th>Tipo Cliente</th>
                <th>Estado Sistema</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In ViewData("cliente")
                @<tr>
                    <td>@item("Codigo")</td>
                    <td>@item("Nombre")</td>
                    <td>@item("Apellido")</td>
                    <td>@item("Tipo Documento")</td>
                    <td>@item("Numero Documento")</td>
                    <td>@item("Estado Civil")</td>
                    <td>@item("Telefono")</td>
                    <td>@item("Direccion")</td>
                    <td>@item("Email")</td>
                    <td>@Convert.ToDateTime(item("Fecha Nacimiento")).Date.ToShortDateString</td>
                    <td>@item("Profesion")</td>
                    <td>@item("Sexo")</td>
                    <td>@item("Tipo Cliente")</td>
                    <td>@item("Estado Sistema")</td>
                    <td>
                        <a href="/Cliente/Edit/@item("Codigo")" class="btn btn-info"> <i class="fa fa-pencil-square-o" aria-hidden="true"></i> Modificar</a>
                        <a href="javascript:eliminar(@item("Codigo"))" class="btn btn-danger"> <i class="fa fa-trash" aria-hidden="true"></i> Eliminar</a>
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
                    url: '/Cliente/Delete',
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
