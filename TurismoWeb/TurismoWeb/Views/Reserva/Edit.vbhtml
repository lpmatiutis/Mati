@ModelType TurismoClases.Reserva
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

<h2>Modificar Cliente</h2>
<form action="Edit" method="post">
    <input type="hidden" name="reservaid" value="@Model.pReservaID" />
    Cliente ID: <input type="text" name="clienteid" value="@Model.pClienteID" /><br />
    Alojamiento ID: <input type="text" name="alojamientoid" value="@Model.pAlojamientoID" /><br />
    Precio Reserva: <input type="text" name="precioreserva" value="@Model.pPrecioReserva" /><br />
    Fecha Reserva: <input type="text" name="fechareserva" value="@Model.pPrecioReserva" /><br />
    Pagado: <select name="pagado">
        <option value="1" @IIf(Model.pPagado = "1", "Selected", "")>Si</option>
        <option value="0" @IIf(Model.pPagado = "0", "Selected", "")>No</option>
    </select>
    <br />
    <input type="submit" value="Guardar" />
</form>
