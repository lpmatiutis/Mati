@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code


    <h1>Alojamientos</h1>
    <h2>
        <a href="/Alojamiento/Create" class="btn btn-success">+ Crear Nuevo</a>
    </h2>
    <table class="table table-bordered table-hover">
        <thead>
            <tr>
                <th>AlojamientoID</th>
                <th>Nombre</th>
                <th>Direccion</th>
                <th>Telefono</th>
                <th>PaginaWeb</th>
                <th>Estrellas</th>
                <th>EsadoSistema</th>
                <th>Acciones</th>
            </tr>
        </thead>
        <tbody>
            @For Each row In ViewData("alojamientos")
                @<tr>
                    <td>@row("AlojamientoID")</td>
                    <td>@row("Nombre")</td>
                    <td>@row("Direccion")</td>
                    <td>@row("Telefono")</td>
                    <td>@row("PaginaWeb")</td>
                    <td>@row("Estrellas")</td>
                    <td>@IIf(row("EstadoSistema") = "True", "Activo", "Inactivo")</td>
                    <td>
                        <a href="/Alojamiento/Edit/@row("AlojamientoID")" class="btn btn-info">Modificar</a>
                        <a href="javascript:eliminar(@row("AlojamientoID"))" class="btn btn-danger">Eliminar</a>
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
                    url: '/Alojamiento/Delete',
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
