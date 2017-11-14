
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Nuevo Cliente</h2>
    <form action="Create" method="post">
        Nombre: <input type="text" name="nombre" /><br />
        Ciudad ID: <input type="text" name="ciudadid" /><br />
        Telefono: <input type="text" name="telefono" /><br />
        Direccion: <input type="text" name="direccion" /><br />
        Email: <input type="text" name="email" /><br />
        Cantidad Empleados: <input type="text" name="cantidadempleados" /><br />
       
        Estado Sistema:<select name="estadosistema">
            <option value="1">Si</option>
            <option value="0">No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>
