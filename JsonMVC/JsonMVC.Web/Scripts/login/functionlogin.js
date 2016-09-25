$(function($) {
	"use strict";

	$("#BtnForgotPassword").click(function () {
		$("#lblInformation").find("p").html("Esqueceu sua senha!? <br/>Não se preocupe, preencha o campo abaixo que enviaremos seu acesso por email.");

		$("#modalInfo").modal();
	});


	//Acessar Sistema
	$("#BtnSignIn").click(function() {
		
	});
});