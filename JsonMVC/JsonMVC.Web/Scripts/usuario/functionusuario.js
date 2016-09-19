$(function($) {
    "use strict";
    //Função adicionar item na tabela
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
        cols += '<td><button class="btn btn-danger" id="btnRemoverLinha" onclick="RemoveTableRow(this)" type="button">Remover</button></td></tr>';
        newRow.append(cols);
        $("#users-table").append(newRow);
        return false;
    });

    //Função gravar dados
    $("#btnGravar").click(function () {
        var request = new UsuarioViewModel();
        var table = $("#users-table > tbody");
        table.find("tr").each(function () {

            request.Nome = $(this).find("td:nth-child(1)").text();
            request.Email = $(this).find("td:nth-child(2)").text();
            request.Telefone = $(this).find("td:nth-child(3)").text();
            request.Celular = $(this).find("td:nth-child(4)").text();
            request.DocumentoRg = $(this).find("td:nth-child(5)").text();
            request.DocumentoCpf = $(this).find("td:nth-child(6)").text();
            request.Facebook = $(this).find("td:nth-child(7)").text();
            request.Twitter = $(this).find("td:nth-child(8)").text();
            request.Instagram = $(this).find("td:nth-child(9)").text();

            $.ajax({
                type: 'post',
                url: '/Usuario/GravaUser',
                data: JSON.stringify(request),
                contentType: "application/json; charset=utf-8",
                traditional: true,
                success: function (data) {
                    $("#titleModal").text("Envio de Dados");
                    $("#msgModal").html("Usuario " + data.Nome + " adicionado com sucesso.");
                    $("#myModal").modal("show");
                }
            });
        });
    });
});

RemoveTableRow = function (handler) {
    var tr = $(handler).closest("tr");
    tr.fadeOut(800, function () {
        tr.remove();
    });
    return false;
};

function verificaCampos() {
    var sMgs = "";
    $("#formularioUsuario input[type=text]").each(function() {
        if (this.value === "") {
            sMgs = sMgs + "Campo " + this.name + " não foi preenchido.<br>";
        }
    });
    return sMgs;
}

function UsuarioViewModel() {
    var self = this;
    self.Nome = "sdfsdfdsd";
    self.Email = "sdfs";
    self.Telefone = "sdf";
    self.Celular = "sdf";
    self.DocumentoRg = "sdf";
    self.DocumentoCpf = "sdf";
    self.Facebook = "sdf";
    self.Twitter = "sdf";
    self.Instagram = "sdfsdf";
}