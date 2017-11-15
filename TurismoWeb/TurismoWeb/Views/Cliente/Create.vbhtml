@Code
    Layout = "~/Views/Plantillas/Plantilla.vbhtml"
End Code

    <h2>Nuevo Cliente</h2>  
    <form action="/Cliente/Create" method="post" class="form-horizontal">

        <div class="well">
            <fieldset>
                <div class="form-group">
                    <label for="nombre" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nombre</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="nombre" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="apellido" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Apellido</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="apellido" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="tipodocumento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Tipo Documento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="tipodocumento" class="form-control" required>
                            @Code
                                Dim first As Boolean = True
                            End Code
                            @For each row In ViewData("tipodocumento")
                                @<option value="@row("TipoDocumentoID")" @IIf(first, "selected", "") >@row("Descripcion")</option>
                                first = False
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="nrodocumento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nro. Documento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="nrodocumento" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="estadocivil" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Civil</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="estadocivil" class="form-control" required>
                            <option value="s" selected>Soltero/a</option>
                            <option value="c">Casado/a</option>
                            <option value="v">Viudo/a</option>
                            <option value="d">Divorciado/a</option>
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="telefono" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Teléfono</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="tel" class="form-control" required name="telefono" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="direccion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Direccion</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="direccion" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="email" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Email</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="email" class="form-control" required name="email" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="fechanacimiento" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Fecha Nacimiento</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="date" value="@Date.Today" class="form-control" required name="fechanacimiento" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="profesion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Profesión</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="profesion" required class="form-control">
                            @Code
                                first = True
                            End Code
                            @For Each row In ViewData("profesion")
                                @<option value="@row("ProfesionID")" @IIf(first, "selected", "")>@row("Descripcion")</option>
                                first = False
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="sexo" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Sexo</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <i class="fa fa-male" aria-hidden="true"></i> <input type="radio" name="sexo" value="1" checked />
                        <i class="fa fa-female" aria-hidden="true"></i> <input type="radio" name="sexo" value="0" />
                    </div>
                </div>

                <div class="form-group">
                    <label for="tipoclienteid" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Tipo Cliente</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="tipoclienteid" required class="form-control">
                            @Code
                                first = True
                            End Code
                            @For Each row In ViewData("tipocliente")
                                @<option value="@row("TipoClienteID")" @IIf(first, "selected", "")>@row("Descripcion")</option>
                                first = False
                            Next
                        </select>
                    </div>
                </div>

                <div class="form-group">
                    <label for="estadosistema" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Sistema</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <i class="fa fa-check" aria-hidden="true"></i> <input type="radio" name="estadosistema" value="1" checked />
                        <i class="fa fa-times" aria-hidden="true"></i> <input type="radio" name="estadosistema" value="0" />
                    </div>
                </div>

            </fieldset>

            <footer>
                <input type="submit" value="Guardar" class="btn btn-success" />
                <input type="reset" value="Limpiar" class="btn btn-warning" />
            </footer>
        </div>
    </form>
