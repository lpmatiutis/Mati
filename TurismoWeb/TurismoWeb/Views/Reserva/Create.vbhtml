
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

<h2>Nuevo Reserva</h2>
<form action="Create" method="post" class="form-horizontal">
    Cliente ID: <input type="text" name="clienteid" /><br />
    Alojamiento ID: <input type="text" name="alojamientoid" /><br />
    Precio Reserva: <input type="text" name="precioreserva" /><br />
    Fecha Reserva: <input type="text" name="fechareserva" /><br />
    Pagado:<select name="pagado">
        <option value="1">Si</option>
        <option value="0">No</option>
    </select>
    <br />
    <input type="submit" value="Guardar" />
</form>
