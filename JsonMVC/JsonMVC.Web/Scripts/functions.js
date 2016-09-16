$(function() {
    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/TestandoJson/GetDados",
        success: function(dados) {
            $(dados).each(function(i) {
                var p = "Nome: " + dados[i].nome + " - Telefone: " + dados[i].telefone;
                $(".inner").append("<p>" + p + "</p>");
            });
        },
        error: function() {
            $('#lblErro').html('Erro ao trazer os dados.');
            $('#modalAlerta').modal();
        }
    });
});

$(function() {
    $(".btnClick").click(function() {
        var person = getPessoa();

        //Poor validation
        if (person == null) {
            $('#lblErro').html('Campos devem ser preenchidos');
            $('#modalAlerta').modal();
            return;
        }

        $.ajax({
            dataType: "json",
            type: "POST",
            contentType: 'application/json',
            url: "/TestandoJson/PostDados",
            data: JSON.stringify(person),
            success: function (data) {
                var msg = "Usuario: " + data.Name + " " + data.LastName + " adicionado com sucesso.";
                $("#lblInformation").html(msg);
                $('#modalInfo').modal();
            },
            error: function () {
                $('#lblErro').html('Erro ao trazer os dados.');
                $('#modalAlerta').modal();
            }
        });
    });
});

function getPessoa() {
    var name = $("#Name").val();
    var lastname = $("#LastName").val();
    return (name === "") ? null : { Name: name, LastName: lastname };
}