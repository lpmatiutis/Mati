@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h3>
        <a href="/Empleado/Create" class="btn btn-success"> Nuevo Empleado </a>

    </h3>

    <table id="mi_tabla" class="table table-striped table-condensed table-bordered table-hover">
        <thead>
            <tr>
                <th>Codigo</th>
                <th>Nombre</th>
                <th>Apellido</th>
                <th>CargoEmpleadoID</th>
                <th>TipoDocumentoID</th>
                <th>NroDocumento</th>
                <th>FechaNacimiento</th>
                <th>SucursalEmpleadoID</th>
                <th>Telefono</th>
                <th>Direccion</th>
                <th>EstadoCivil</th>
                <th>Antiguedad</th>
                <th>EstadoSistema</th>
            </tr>
        </thead>
        <tbody>
            @For Each item In ViewData("Empleado")
                @<tr>
                    <td>@item("EmpleadoID")</td>
                    <td>@item("Nombre")</td>
                    <td>@item("Apellido")</td>
                    <td>@item("CargoEmpleadoID")</td>
                    <td>@item("TipoDocumentoID")</td>
                    <td>@item("NroDocumento")</td>
                    <td>@item("FechaNacimiento")</td>
                    <td>@item("SucursalEmpresaID")</td>
                    <td>@item("Telefono")</td>
                    <td>@item("Direccion")</td>
                    <td>@item("EstadoCivil")</td>
                    <td>@item("Antiguedad")</td>
                    <td>@item("EstadoSistema")</td>
                    <td>
                        <a href="Empleado/Edit/@item("EmpleadoID")" class="btn btn-info">Modificar</a>
                        <a href="javascript:eliminar(@item("EmpleadoID"))" class="btn btn-danger">Eliminar</a>
                    </td>
                </tr>
            Next
        </tbody>
    </>
    <script type="text/javascript">

         function eliminar(id) {

             //sdsds
             if (confirm('¿Estas seguro de eliminar el registro?')) {
                 var parametros = {
                     id: id
                 };

                 $.ajax({
                     url: '../Empleado/Eliminar',
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
