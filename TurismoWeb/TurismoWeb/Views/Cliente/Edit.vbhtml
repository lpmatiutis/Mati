@ModelType TurismoClases.Cliente
@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Modificar Cliente</h2>
    <form action="/Cliente/Edit" method="post" class="form-horizontal">
        <input type="hidden" name="clienteid" value="@Model.pClienteID" />
        <div class="well">
            <fieldset>
                <div class="form-group">
                    <label for="nombre" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nombre</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" value="@Model.pNombre" required name="nombre" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="apellido" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Apellido</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" value="@Model.pApellido" required name="apellido" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="tipodocumento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Tipo Documento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="tipodocumento" class="form-control" required>
                            @For Each row In ViewData("tipodocumento")
                                @<option value="@row("TipoDocumentoID")" @IIf(Model.pTipoDocumento = row("TipoDocumentoID"), "selected", "")>@row("Descripcion")</option>
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="nrodocumento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nro. Documento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" value="@Model.pNroDocumento" required name="nrodocumento" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="estadocivil" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Civil</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="estadocivil" class="form-control" required>
                            <option value="s" @IIf(Model.pEstadoCivil = "s", "selected", "")>Soltero/a</option>
                            <option value="c" @IIf(Model.pEstadoCivil = "c", "selected", "")>Casado/a</option>
                            <option value="v" @IIf(Model.pEstadoCivil = "v", "selected", "")>Viudo/a</option>
                            <option value="d" @IIf(Model.pEstadoCivil = "d", "selected", "")>Divorciado/a</option>
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="telefono" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Teléfono</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="tel" class="form-control" value="@Model.pTelefono" required name="telefono" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="direccion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Direccion</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" value="@Model.pDireccion" required name="direccion" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="email" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Email</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="email" class="form-control" value="@Model.pEmail" required name="email" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="fechanacimiento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Fecha Nacimiento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="date" value="@Model.pFechaNacimiento.Year-@Model.pFechaNacimiento.Month-@Model.pFechaNacimiento.Day" class="form-control" required name="fechanacimiento" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="profesion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Profesión</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="profesion" required class="form-control">
                            @For Each row In ViewData("profesion")
                                @<option value="@row("ProfesionID")" @IIf(Model.pProfesion = row("ProfesionID"), "selected", "")>@row("Descripcion")</option>
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="sexo" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Sexo</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <i class="fa fa-male" aria-hidden="true"></i> <input type="radio" name="sexo" value="1" @IIf(Model.pSexo = "true", "checked", "") />
                        <i class="fa fa-female" aria-hidden="true"></i> <input type="radio" name="sexo" value="0" @IIf(Model.pSexo = "false", "checked", "") />
                    </div>
                </div>

                <div class="form-group">
                    <label for="tipoclienteid" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Tipo Cliente</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="tipoclienteid" required class="form-control">
                            @For Each row In ViewData("tipocliente")
                                @<option value="@row("TipoClienteID")" @IIf(Model.pTipoClienteID = row("TipoClienteID"), "selected", "")>@row("Descripcion")</option>
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="estadosistema" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Sistema</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <i class="fa fa-check" aria-hidden="true"></i> <input type="radio" name="estadosistema" value="1"  @IIf(Model.pEstadoSistema = "true", "checked", "") />
                        <i class="fa fa-times" aria-hidden="true"></i> <input type="radio" name="estadosistema" value="0" @IIf(Model.pEstadoSistema = "false", "checked", "") />
                    </div>
                </div>

            </fieldset>

            <footer>
                <input type="submit" value="Guardar" class="btn btn-success" />
                <input type="reset" value="Limpiar" class="btn btn-warning" />
            </footer>
        </div>
    </form>
