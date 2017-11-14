
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h3>
        <a href="/Sucursal/Create" class="btn btn-success"> Nueva Sucursal </a>
    </h3>

    <table id="mi_tabla" class="table table-striped table-condensed table-bordered table-hover">
        <thead>
            <tr>
                <th>Codigo</th>
                <th>Nombre</th>
                <th>Ciudad ID</th>
                <th>Telefono</th>
                <th>Direccion</th>
                <th>Email</th>
                <th>Cantidad Empleados</th>
                <th>EstadoSistema</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In ViewData("SucursalEmpresa")
                @<tr>
                    <td>@item("SucursalEmpresaID")</td>
                    <td>@item("Nombre")</td>
                    <td>@item("CiudadID")</td>
                    <td>@item("Telefono")</td>
                    <td>@item("Direccion")</td>
                    <td>@item("Email")</td>
                    <td>@item("CantidadEmpleados")</td>
                    <td>@item("EstadoSistema")</td>
                   
                    <td>
                        <a href="Sucursal/Edit/@item("SucursalEmpresaID")" class="btn btn-info">Modificar</a>
                        <a href="javascript:eliminar(@item("SucursalEmpresaID"))" class="btn btn-danger">Eliminar</a>
                    </td>
                </tr>
            Next
        </tbody>
    </table>
    <script type="text/javascript">

         function eliminar(id) {

             //sdsds
             if (confirm('¿Estas seguro de eliminar el registro?')) {
                 var parametros = {
                     id: id
                 };

                 $.ajax({
                     url: '../Sucursal/Eliminar',
                     data: parametros,
                     type: "post",
                     cache: false,
                     success: function (retorno) {
                         location.reload();
                     },
                     error: function () {
                         alert("se ha producido un error");
                     }
                 });
             }
         }
    </script>
    <script src="~/js/jquery-3.2.1.min.js"></script>
    <script src="~/js/bootstrap.min.js"></script>