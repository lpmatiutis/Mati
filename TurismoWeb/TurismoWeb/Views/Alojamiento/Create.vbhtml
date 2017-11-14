
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <meta charset="utf-8" />
    <title>Create</title>
    <link href="~/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <h2>Alojamiento</h2>
    <form action="/Alojamiento/Create" method="post" class="form-horizontal">
        <div class="well">
            <fieldset>
                <div class="form-group">
                    <label for="nombre" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Nombre</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="nombre" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="direccion" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Dirección</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="direccion" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="telefono" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Teléfono</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="telefono" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="paginaweb" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Página Web</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="text" class="form-control" required name="paginaweb" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="estrellas" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estrellas</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <input type="number" class="form-control" required name="estrellas" />
                    </div>
                </div>
                <div class="form-group">
                    <label for="estadosistema" class="col-lg-2 col-md-2 col-sm-3 col-xs-12">Estado Sistema</label>
                    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
                        <select name="estadosistema" class="form-control">
                            <option value="1" selected>Activo</option>
                            <option value="0">Inactivo</option>
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
</body>
</html>
