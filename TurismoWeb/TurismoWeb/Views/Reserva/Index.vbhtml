
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

<h3>
    <a href="/Reserva/Create" class="btn btn-success"> Nueva Reserva </a>
</h3>

<table id="mi_tabla" class="table table-striped table-hover table-bordered">
    <thead>
        <tr>
            <th>Codigo Reserva</th>
            <th>Cliente ID</th>
            <th>Alojamiento ID</th>
            <th>Precio Reserva</th>
            <th>Fecha Reserva</th>
            <th>Pagado</th>
           
        </tr>
    </thead>
    <tbody>
        @For Each item In ViewData("Reserva")
            @<tr>
                <td>@item("ReservaID")</td>
                <td>@item("ClienteID")</td>
                <td>@item("AlojamientoID")</td>
                <td>@item("PrecioReserva")</td>
                <td>@item("FechaReserva")</td>
                <td>@item("Pagado")</td>
                
                <td>
                    <a href="Reserva/Edit/@item("ReservaID")" class="btn btn-info">Modificar</a>
                    <a href="javascript:eliminar(@item("ReservaID"))" class="btn btn-danger">Eliminar</a>
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
                    url: '../Reserva/Eliminar',
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