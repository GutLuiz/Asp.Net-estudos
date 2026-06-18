## Contexto: Criação de apis basicas, anotações tipos de parametros


1 - Primeira coisa que tem que notas é a contrução do endpoint é 
feita em arquivos que tem o final chamado "controller".

2 - As primeiras coisas que tem que fazer em um novo arquivo de 
controller é herdar a classe CONTROLLERBASE(classe fundamental
do aspnet para lidar com requisições HTTP e criar web apis)

3 - Antes de criar sua classe com os seus endpoints eu faço anotações:
	= [ApiController] para falar que é um arquivo de api
	= [Route] criar uma rota organizada dos seus endpoints


