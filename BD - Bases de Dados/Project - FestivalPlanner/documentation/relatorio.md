# <t style="color:#0080ff">Gestor de Festivias Musicais</t>

## Proposta de Projeto para Base de Dados - **P2G2**

- David Araújo - 93444
- Miguel Nogueira - 93082

## Requisitos

Os utilizadores serão capazes de interagir com o sistema da seguinte forma:

- Inserir/Remover concertos e todas as informações associadas a estes.
- Inserir/Remover informação sobre o *Manager* e o *Promotor*.
- Inserir/Remover informação dos materias que os artistas trazem.
- Inserir/Remover informação relativamente às comitivas que acompanham os artistas.
- Inserir/Remover palcos.
- Associar/Dessasociar concertos a palcos.
- Inserir/Remover informação relativamente às refeições e empreas de Catering.
- Confirgurar toda a informação do evento em si, assim como consultá-la.
- Inserir/Remover bandas, associa-las a concertos.

<div style="page-break-after: always;"></div>

## Diagrama Entidade-Relacionamento

Inicialmente, modelámos o projeto tal como está representado no DER seguinte. 

![DER](DER.png)

<div style="page-break-after: always;"></div>

Após uma análise mais cuidada do problema, fizemos algumas alterações ao DER anterior:

- As entidades *Manager* e *Promotor* passaram a ser sub-entidades da entidade *Pessoa* (relação **IS-A**).
- Os atributos da entidade *Comitiva* (nElementos, nAcompanhantes e nTecnicos) deixaram de ser derivados da entidade.
- Passou a existir uma relação ternária entre as entidades *Técnico*, *Comitiva* e *Acompanhante*.

![DER_atualizado](DER_atualizado.png)

## Equema Relacional

O esquema relacional está representado na figura seguinte:

![Relacional](Relacional.png)


## SQL Scripts

### Setup

O ficheiro *setup.sql* contém o código SQL que permite a *criação* das tabelas do projeto, de acordo com o diagrama relacional.

### Drop

O ficheiro *drops.sql* contém o código SQL que permite a *eliminação* das tabelas do projeto, de acordo com o diagrama relacional.

### Inserts

O ficheiro *inserts.sql* contém o código SQL que permite a *insersão* de dados nas tabelas do projeto.

### Queries

O ficheiro *queries.sql* contém o código SQL de algumas *queries* efetuadas sobre a base de dados:

 - Promotores com mais do que um evento;
 - Eventos cujo número de bilhetes seja maior que a média de todos os bilhetes vendidos;
 - Promotores dos eventos a acontecer a partir de 2022;
 - Empresas de catering e o número de eventos aos quais fornecem serviços;
 - Número de Musicos de cada comitiva;
 - Número de Instrumentos que cada banda traz;
 - Eventos, número de dias e de concertos.


### Views

O ficheiro *views.sql* contém o código SQL de algumas *views* criadas sobre a base de dados:

 - *V_Bandas* que permite visualizar atributos da entidade banda;
 - *V_Geral* que permite ter uma noção geral de um evento, sendo para isso necessário juntar atributos de várias entidades.


### Triggers

O ficheiro *triggers.sql* contém o código SQL de alguns *triggers* criados sobre a base de dados:

 - Apagar um concerto apaga também o seu soundcheck;
 - Apagar um evento apaga também os seus concertos e soundchecks;
 - Soundcheck não pode durar mais de 1 hora (se durar a sua duração é ajustada para 1 hora);
 - não podem existir dois soundchecks ao mesmo tempo.

### Stored Procedures

O ficheiro *sps.sql* contém o código SQL de alguns *stored procedures* criados sobre a base de dados:

 - Criar um evento;
 - Criar um concerto e um soundcheck para uma determinada banda;
 - Apagar um evento dado o id do mesmo;
 - Apagar um concerto dado o id do mesmo;
 - Editar um evento.

Estes *stored procedures* foram criados por forma a que as alterações da base de dados não fossem executadas diretamente sobre a mesma. Cria-se assim uma camada de abstração entre a base de dados e as operações que podem pôr em risco a integridade da base de dados (operações que interagem diretamente com o conteúdo da base de dados).


### User Defined Functions

O ficheiro *udfs_FP.sql* contém o código SQL de algumas *UDFs* criadas sobre a base de dados:

 - Dado um id devolve um evento;
 - Dado um nome devolve um evento;
 - Dado um ccPromotor devolve um evento;
 - Dado um ccManager devolve um evento;
 - Dado o id de um Evento devolver os seus concertos;
 - Dado o id de um Evento devolver os seus concertos e respectivos soundchecks;
 - Dado o id de um Evento devolver as bandas que vão tocar;
 - Dado o id de uma Banda devolver os seus concertos;
 - Dado o nome de uma Banda devolver os seus concertos;
 - Pesquisar músico por CC do músico;
 - Pesquisar músico por Nome Artístico;
 - Dado um id devolver a banda;
 - Dado um nome devolver a banda;
 - Dado um género devolver bandas;
 - Dado o id de uma Banda devolver os músicos constituintes que vão tocar;
 - Dado uma data de inicio e de fim dar os eventos aí dentro;
 - Dada uma duração minima e uma duração máxima devolver todos os concertos cuja duração se encontra entre esses valores;
 - Dado um nome do evento, devolver informação sobre o mesmo;
 - Dado um número de dias do evento, devolver informação sobre o mesmo;
 - Dado um nome da banda, devolver informação sobre o evento em que a banda participa.

Estas funções de consulta são utilizadas nos formulários de pesquisa de informação da Base de Dados.

### Indexes

O ficheiro *indexes.sql* contém o código SQL de alguns *triggers* criados sobre a base de dados:

 - *idx_eventId* sobre a tabela *Evento* e atributo *id*;
 - *idx_concertoId* sobre a tabela *Concerto* e atributo *id*;
 - *idx_BandaId* sobre a tabela *Banda* e atributo *id*;
 - *idx_Musico* sobre a tabela *Musico* e atributo *cc*.

Como são feitas pesquisas pelas chaves primárias de várias tabelas, criámos *indexes* em cada uma delas. Desta forma, é mais fácil a pesquisa de informação com base nas chaves primárias.

### Interface

Interface construida em Windows Form Application, em C#.

Foi dado maior foco à implementação das principais tarefas como gestão dos dados de um Evento e dos dados de um Concerto por serem as tabelas mais complexas em termos de dependências e para as quais também fora dado maior destaque na criação de views, triggers, used defined functions e stored procedures; de forma a assim maximizarmos a utilização deste trabalho em SQL.

A ser implementado no GUI ficam interações semelhantes às já implementadas mas paras as restantes, e que não apresentam grande variadade de interação comparativamente as anteriores descritas.

Com base nos scripts SQL de criação de *queries*, é possível simular alguns dos cenários de interação com a base de dados, por exemplo:
  
 - Obter eventos cujo número de bilhetes seja maior que a média de todos os bilhetes vendidos;
 - Obter o número de Musicos de cada comitiva e ordenar pelo número de músicos;
 - Obter todas as empresas de catering e o número de eventos aos quais estas fornecem serviços;
 - etc.

Com base nos scripts SQL de criação de *triggers*, é possível simular cenários de interação com a base de dados, por exemplo:

 - garantir que não podem existir dois soundchecks ao mesmo tempo;
 - Soundcheck não pode durar mais de 1 hora (se durar a sua duração é ajustada para 1 hora);
 - etc.
  

Com base nos scripts SQL de criação de *UDFs*, é possível simular cenários de interação com a base de dados, por exemplo:

 - Editar dados de um evento;
 - Apagar eventos;
 - Pesquisar músico por Nome Artístico;
 - Dada uma data de inicio e de fim dar os eventos aí dentro;
 - Dado um nome da banda, devolver informação sobre o evento em que a banda participa;
 - Dado o id de um Evento devolver os seus concertos e respectivos soundchecks
 - Dado um género devolver bandas;
 - etc.

Com base nos scripts SQL de criação de *Stored Procedures*, é possível simular cenários de interação com a base de dados, por exemplo:

 - Apagar um concerto dado o id do mesmo;
 - Criar um concerto e um soundcheck para uma determinada banda;
 - Editar um evento;
 - etc.
