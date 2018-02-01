//Cliente MODEL
@model ProyectoBanco.Models.Cliente
@{
    ViewBag.Title = "Index";
}

<div class="container" style="margin-top:3%">
    <table class="table table-striped">
        <thead>
            <tr>
                <td>Id Cliente</td>
                <td>Nombre</td>
                <td>Fecha Creacion</td>
                <td>Fecha Actualizacion</td>
                <td>Fecha Eliminacion</td>
                <td>Editar Cliente</td>
                <td>Eliminar Cliente</td>
            </tr>
        </thead>
        <tbody id="SetListaCliente">
            <tr id="LoadingCliente" style="color:red"></tr>         
        </tbody>
    </table>
</div>

<script>
    $("#LoadingCliente").html("Loading...");
    $.get("/Home/ObtenerClientes", null, DataBind);
    function DataBind(listaCliente) {
        var SetData = $("#SetListaCliente");
        for (var i = 0; i < listaCliente.length; i++) {
            var Data = "<tr class='row_" + listaCliente[i].IdCliente + "'>" +
                "<td>" + listaCliente[i].Nombre + "</td>" +
                "<td>" + listaCliente[i].Apellido + "</td>" +
                "<td>" + listaCliente[i].Direccion + "</td>" +
                "<td>" + listaCliente[i].FechaCreacion + "</td>" +
                "<td>" + listaCliente[i].FechaActualizacion + "</td>" +
                "<td>" + listaCliente[i].FechaEliminacion + "</td>" +
                "<td>" + "<a href='#' class='btn btn-warning' onclick='editarCliente()'><span class='glyphicon glyphicon-edit'></span></a>" + "</td>" +
                "<td>" + "<a href='#' class='btn btn-warning' onclick='eliminarCliente()'><span class='glyphicon glyphicon-edit'></span></a>" + "</td>" +
                "</tr>";

            SetData.append(Data);
            $("#LoadingCliente").html(" ");
        }
    }
</script>

<h2>Lista de Clientes</h2>