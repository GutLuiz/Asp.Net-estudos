## CONTEXTO: Definições de REST, tipos de parametros, http Status Codes, Verbos http


- Rest é um padrao arquiterural basicamente leve por natureza. Então 
quando temos limitaçoes de banda perfira web services REST;
- Tem um desenvolvimento facil e rapido;
- Aplicativos mobile tem ganahdo cada vez mais espaço
- Suporta varios tipos de arquivos

-> Request e Response

- Request é toda a requisição que fazemos em um api
- Response é toda a resposta de um requeste que fazemos em uma api


## TIPOS DE PARAMETROS

- Path Params: São usados para identificar um recurso único e específico. 
- Query Params:  são usados para filtrar, ordenar ou paginar uma 
lista de dados.
- Header Params:são metadados enviados ocultos no corpo da requisição 
HTTP para fornecer informações sobre o contexto da comunicação (autorizações,
formato da resposta etc).
- Body Params: refere-se exatamente aos dados enviados dentro do Body

== obs: se for um parametro obrigatorio eu uso PATH PARAMS, se for opcional
usamos QUERY PARAMS (consultas ou buscas), se eu quero informar um contexto
da minha aplicação eu uso HEADER PARAMS, e para fazer um post usamos um 
BODY PARAMS

## HTTPS STATUS CODE

= Principais status:

- 1XX Informacionais:
	-- 100 = Continue
	-- 101 = Trocando protocolos
	-- 102 = Processando
- 2xx Sucesso:
	-- 200 = OK
	-- 202 = Aceito
	-- 204 = Sem corpo
- 3xx Redirecionamento:
- 4xx Erro de client:
	-- 400 = Requsição errada
	-- 401 = Sem autorização
	-- 402 = Pagamento necessario
	-- 404 = Não encontrado
- 5xx Erro do servidor:
	-- 500 = Erro interno do servidor

## VERBOS HTTP

= CREATE: HTTP POST
= READ = HTTP GET
= UPDATE = HTTP PUT OU PATCH
= DELETE = HTTP DELETE

- GET (READ):
	= Verbo get é usado para lero  ou recuper uma representação de um recurso
	Retornando um status 200 se for um sucesso e 404 (not found) ou 400 (bad
	request)
- POST (CREATE):
	= É frequetemente mais usado para criar novos recurso, inserir um novo
	item na base de dados. Retona 200 ou 201 se for um sucesso.
- PUT (UPDATE):
	= É comumente usado para atualizar informações, colocando no body as novas
	informações que representam o recurso original, e na url o identificador desse
	recurso especifico.
- DELETE (DELETE):
	= É usado para deletar algum recurso, normalmente você deleta e não retorna
	nada (204).

