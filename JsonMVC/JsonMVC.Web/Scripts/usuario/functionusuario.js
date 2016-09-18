$(function () {
    $("#btnAdicionar").click(function () {
        
        if (verificaCampos()) {
            $("#titleModal").text("Dados incompletos");
            $("#msgModal").html(verificaCampos());
            $("#myModal").modal("show");
            return false;
        }

        var newRow = $("<tr>");
        var cols = "";
        cols += '<td class="font-table">' + $("#Nome").val() + '</td>';
        cols += '<td class="font-table">' + $("#Email").val() + '</td>';
        cols += '<td class="font-table">' + $("#Telefone").val() + '</td>';
        cols += '<td class="font-table">' + $("#Celular").val() + '</td>';
        cols += '<td class="font-table">' + $("#DocumentoRg").val() + '</td>';
        cols += '<td class="font-table">' + $("#DocumentoCpf").val() + '</td>';
        cols += '<td class="font-table">' + $("#Facebook").val() + '</td>';
        cols += '<td class="font-table">' + $("#Twitter").val() + '</td>';
        cols += '<td class="font-table">' + $("#Instagram").val() + '</td>';
        cols += '<td><button class="btn btn-danger" id="btnRemoverLinha" onclick="RemoveTableRow(this)" type="button">Remover</button></td>';
        newRow.append(cols);
        $("#users-table").append(newRow);
        return false;
    });
});

$(function () {
    RemoveTableRow = function (handler) {
        var tr = $(handler).closest("tr");
        tr.fadeOut(800, function () {
            tr.remove();
        });
        return false;
    };
});

function verificaCampos() {
    var sMgs = "";
    $("#formularioUsuario input[type=text]").each(function() {
        if (this.value === "") {
            sMgs = sMgs + "Campo " + this.name + " não foi preenchido.<br>";
        }
    });
    return sMgs;
}

$(function() {
    $("#btnGravar").click(function() {
        var table = $("#users-table").tableToJSON();
        console.log(table);
        alert(JSON.stringify(table));
    });
})