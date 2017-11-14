@ModelType TurismoClases.Alojamiento
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code


    <div class="row">
        <div class="col-lg-4 col-md-7 col-sm-7 col-xs-12">
            <h1>
                <span class="glyphicon glyphicon-edit"></span>
                Modificar Alojamiento
            </h1>
        </div>
    </div>

    <form action="/Alojamiento/Edit" method="post" class="form-horizontal">
        <input type="hidden" name="AlojamientoID" value="@Model.pAlojamientoID" />
        <div class="well">
            <fieldset>
                <div class="form-group">
                    <label for="nombre" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nombre</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required value="@Model.pNombre" name="nombre" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="direccion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Dirección</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required value="@Model.pDireccion" name="direccion" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="telefono" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Teléfono</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required value="@Model.pTelefono" name="telefono" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="paginaweb" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Página Web</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required value="@Model.pPaginaWeb" name="paginaweb" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="estrellas" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estrellas</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required value="@Model.pEstrellas" name="estrellas" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="estadosistema" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Sistema</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="estadosistema" class="form-control">
                            <option value="1" @IIf(Model.pEstadoSistema = True, "selected", "")>Activo</option>
                            <option value="0" @IIf(Model.pEstadoSistema = False, "selected", "")>Inactivo</option>
                        </select>
                    </div>
                </div>
            </fieldset>

            <footer>
                <input type="submit" value="Guardar" class="btn btn-success" />
                <input type="reset" value="Limpiar" class="btn btn-warning" />
            </footer>
        </div>
    </form>
