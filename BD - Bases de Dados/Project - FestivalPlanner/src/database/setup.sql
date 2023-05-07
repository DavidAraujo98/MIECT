/*	
** script to instaciate Database of bd project
**
** Miguel Nogueira & David Araújo
 */

 use p2g2
 --use Projeto
 go

-- schema
if not exists (select * from sys.schemas where name='FP') -- FP -> FESTIVAL_PLANNER
begin
  exec('create schema FP;')
end

go

-- types 
--
--

if not exists( select * from sys.types where name = 'id')
begin
	create type id from varchar(20)
end
--drop type id

if not exists( select * from sys.types where name = 'str150')
begin
	create type str150 from varchar(150)
end
--drop type str150

if not exists( select * from sys.types where name = 'cc')
begin
	create type cc from varchar(12)
end
--drop type cc

if not exists( select * from sys.types where name = 'telefone')
begin
	create type telefone from VARCHAR(12)
end
--drop type telefone

if not exists( select * from sys.types where name = 'email')
begin
	create type email from VARCHAR(100)
end
--drop type email

if not exists( select * from sys.types where name = 'endereco')
begin
	create type endereco from VARCHAR(150)
end
--drop type endereco

if not exists( select * from sys.types where name = 'str50')
begin
	create type str50 from VARCHAR(50)
end
--drop type str50

go

-- tables

CREATE TABLE FP.Banda (
    id id NOT NULL,
    nome str150 NOT NULL,
    telefone telefone,
    email email,
    nElementos INT CHECK (nElementos >= 1),
	PRIMARY KEY(id),
);


CREATE TABLE FP.Pessoa (
    cc cc NOT NULL,
    email email,
    nome str150 NOT NULL,
    telefone telefone,
    sexo VARCHAR(1) CHECK (sexo = 'm' OR sexo = 'f'),
    PRIMARY KEY(cc),
);

-- DATETIME = YYYY-MM-DD HH:MI:SS
CREATE TABLE FP.SoundCheck (
    id id NOT NULL,
    duracao INT CHECK (duracao > 0),
    dataInicio DATETIME,
    PRIMARY KEY(id),
);


CREATE TABLE FP.EmpresaCatering (
    nif	INT NOT NULL,
    nome str150 NOT NULL,
    email email,
    telefone telefone,
    endereco endereco NOT NULL,
    PRIMARY KEY(nif),
);


CREATE TABLE FP.GeneroMusical (
    id_banda id NOT NULL,
    genero str50 NOT NULL,
    PRIMARY KEY (id_banda, genero),
    FOREIGN KEY (id_banda) REFERENCES FP.Banda(id),
);


CREATE TABLE FP.Comitiva (
    id id NOT NULL,
    email email,
    telefone telefone,
    nTecnicos INT NOT NULL,
    nElementos INT NOT NULL,
    nAcompanhantes INT,
    id_banda id NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(id_banda) REFERENCES FP.Banda(id),
);


CREATE TABLE FP.Acompanhante (
    cc cc NOT NULL,
    tipo str50,
    id_comitiva id NOT NULL,
    PRIMARY KEY(cc),
    FOREIGN KEY(cc) REFERENCES FP.Pessoa(cc),
    FOREIGN KEY(id_comitiva) REFERENCES FP.Comitiva(id),
);


CREATE TABLE FP.Tecnico (
    cc cc,
    tipo str50,
    id_comitiva id NOT NULL,
    PRIMARY KEY(cc),
    FOREIGN KEY(cc) REFERENCES FP.Pessoa(cc),
    FOREIGN KEY(id_comitiva) REFERENCES FP.Comitiva(id),
);


CREATE TABLE FP.Musico (
    cc cc,
    nomeArtistico str50,
    id_banda id NOT NULL,
    PRIMARY KEY(cc),
    FOREIGN KEY(cc) REFERENCES FP.Pessoa(cc),
    FOREIGN KEY(id_banda) REFERENCES FP.Banda(id),
);


CREATE TABLE FP.Instrumento (
    id id NOT NULL,
    marca str50,
    fabricante str50,
    model str50,
    cc_musico cc,
    PRIMARY KEY(id),
    FOREIGN KEY(cc_musico) REFERENCES FP.Musico(cc),
);


CREATE TABLE FP.FamiliaInstrumento (
    id_instrumento id NOT NULL,
    familia str50,
    PRIMARY KEY(id_instrumento, familia),
    FOREIGN KEY(id_instrumento) REFERENCES FP.Instrumento(id),
);


CREATE TABLE FP.Manager (
    cc cc,
    tipo str50,
    PRIMARY KEY(cc),
    FOREIGN KEY(cc) REFERENCES FP.Pessoa(cc),
);


CREATE TABLE FP.Promotor (
    cc cc,
    tipo str50,
    PRIMARY KEY(cc),
    FOREIGN KEY(cc) REFERENCES FP.Pessoa(cc),
);


CREATE TABLE FP.Evento (
    id id NOT NULL,
    nome str150 NOT NULL,
    nDias INT CHECK (nDias > 0),
    dataInicio DATETIME NOT NULL,
    dataFim DATETIME NOT NULL,
    nBilhetes INT,
    dataProposta DATETIME NOT NULL,
    cc_promotor cc NOT NULL,
    cc_manager cc NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(cc_promotor) REFERENCES FP.Promotor(cc),
    FOREIGN KEY(cc_manager) REFERENCES FP.Manager(cc),
);


CREATE TABLE FP.Palco(
    id id NOT NULL,
    endereco endereco NOT NULL,
    lotacao INT CHECK (lotacao > 0),
    id_evento id NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(id_evento) REFERENCES FP.Evento(id),
);


CREATE TABLE FP.Concerto(
    id id NOT NULL,
    id_evento id NOT NULL,
    id_palco id NOT NULL,
    id_banda id NOT NULL,
    duracao INT CHECK (duracao > 0),
    dataInicio DATETIME NOT NULL,
    id_soundcheck id NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY(id_evento) REFERENCES FP.Evento(id),
    FOREIGN KEY(id_palco) REFERENCES FP.Palco(id),
    FOREIGN KEY(id_banda) REFERENCES FP.Banda(id),
    FOREIGN KEY(id_soundcheck) REFERENCES FP.SoundCheck(id),
);


CREATE TABLE FP.Refeicao(
    id_evento id NOT NULL,
    nif_empresa INT NOT NULL,
    id id NOT NULL,
    prato str50 NOT NULL,
    sobremesa str50,
    bebida str50,
    PRIMARY KEY(id),
    FOREIGN KEY(id_evento) REFERENCES FP.Evento(id),
    FOREIGN KEY(nif_empresa) REFERENCES FP.EmpresaCatering(nif),
);