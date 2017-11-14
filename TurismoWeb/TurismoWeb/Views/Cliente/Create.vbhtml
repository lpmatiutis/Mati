@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Nuevo Cliente</h2>
    <form action="Create" method="post" class="form-horizontal">
        Nombre: <input type="text" name="nombre"/><br />
        Apellido: <input type="text" name="apellido" /><br />
        Tipo Documento: <input type="text" name="tipodocumento"/><br />
        Nro Documento: <input type="text" name="nrodocumento"/><br />
        Estado Civil: <input type="text" name="estadocivil"/><br />
        Telefono: <input type="text" name="telefono"/><br />
        Direccion: <input type="text" name="Direccion" /><br />
        Email: <input type="text" name="email"/><br />
        FechaNacimiento: <input type="text" name="fechanacimiento"/><br />
        Profesion: <input type="text" name="profesion"/><br />
        Sexo: <input type="text" name="sexo"/><br />
        TipoCliente: <input type="text" name="tipocliente"/><br />
        Estado Sistema: <input type="text" name="estadosistema"/><br />
        Estado Sistema:<select name="estadosistema">
            <option value="S">Si</option>
            <option value="N">No</option>
        </select>
        <br />
        <input type="submit" value="Guardar" />
    </form>
