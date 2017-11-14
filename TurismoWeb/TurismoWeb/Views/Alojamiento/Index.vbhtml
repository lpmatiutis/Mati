﻿@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code


    <h1>Alojamientos</h1>
    <h2>
        <a href="/Alojamiento/Create" class="btn btn-success">+ Crear Nuevo</a>
    </h2>
    <table id="mi_tabla" class="table table-striped table-hover table-bordered">
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

    <!-- jQuery 2.1.4 -->
    <script src="~/scripts/js/jQuery-2.1.4.min.js"></script>
    <!-- Bootstrap 3.3.5 -->
    <script src="~/scripts/js/bootstrap.min.js"></script>

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