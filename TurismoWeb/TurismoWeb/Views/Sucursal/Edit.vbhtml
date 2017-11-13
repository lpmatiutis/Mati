@ModelType TurismoClases.Sucursal
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Modificar Cliente</h2>
    <form action="Edit" method="post">
        <input type="hidden" name="sucursalempresaid" value="@Model.pSucursalEmpresaID" />
        Nombre: <input type="text" name="nombre" value="@Model.pNombre" /><br />
        Ciudad ID: <input type="text" name="ciudadid" value="@Model.pCiudadID" /><br />
        Telefono: <input type="text" name="telefono" value="@Model.pTelefono" /><br />
        Direccion: <input type="text" name="direccion" value="@Model.pDireccion" /><br />
        Email: <input type="text" name="email" value="@Model.pEmail" /><br />
        Cantidad Empleados: <input type="text" name="cantidadempleados" value="@Model.pCantidadEmpleados" /><br />
        Estado Sistema:<select name="estadosistema">
            <option value="1" @IIf(Model.pEstadoSistema = "1", "Selected", "")>Si</option>
            <option value="0" @IIf(Model.pEstadoSistema = "0", "Selected", "")>No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>
