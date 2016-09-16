$(function () {
    $.ajax({
        dataType: "json",
        type: "GET",
        url: "/TestandoJson/GetDados",
        success: function (dados) {
            $(dados).each(function (i) {
                var p = "Nome: " + dados[i].nome + " - Telefone: " + dados[i].telefone;
                $(".inner").append("<p>" + p + "</p>");
            });
        },
        error: function () {
            $('#lblErro').html('Erro ao trazer os dados.');
            $('#modalAlerta').modal();
        }
    });
})