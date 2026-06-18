## CONTEXTO: Autenticação

- Basicamente quando fazemos o nosso cadastro ele retorna dois tipos
de tokens, o acess token que vai ser usado para fazer request a lugares
que precisam de permissao.
- Existe tambem o refresh token serve para gerar um novo access token
automaticamente quando o antigo vence, sem que você precise digitar
sua senha novamente.
- O access token de curta duração limita o tempo que um invasor tem 
para agir caso seja roubado. O refresh token fica mais escondido e
protegido no sistema.