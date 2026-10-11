create table clientes(
	codigo		numeric(10) not null identity(1,1) primary key,
	nome		varchar(60) not null,
	endereco	varchar(50),
	bairro		varchar(40),
	cidade		varchar(40),
	uf		varchar(2),
	cep		varchar(8),
	fone		varchar(12),
	celular		varchar(12),
	obs		varchar(200)
);

create table produtos(
	codigo		varchar(10) not null primary key,
	descricao	varchar(50) not null,
	unidade		varchar(3), --cx,pc,un,lt,mt...
	estoque		numeric(3),
	valor_compra	numeric(6,2),
	porc_lucro	numeric(5,2)
);

create table departamentos(
	codigo		numeric(2) not null identity(1,1) primary key,
	descricao	varchar(30) not null
);

create table funcionarios(
	codigo		numeric(4) not null identity(1,1) primary key,
	nome		varchar(60) not null,
	endereco	varchar(50),
	bairro		varchar(40),
	cidade		varchar(40),
	uf		varchar(2),
	cep		varchar(8),
	fone		varchar(12),
	celular		varchar(12),
	departamento	numeric(2) not null,
	usuario		varchar(10) not null,
	senha		varchar(10) not null,
	obs		varchar(200)
);

alter table funcionarios add constraint fk_departamento_fun foreign key(departamento)
references departamentos (codigo);

create table vendas(
	numero		numeric(15) not null identity(1,1) primary key,
	data		date not null,
	funcionario	numeric(4) not null,
	cliente		numeric(10) not null
);

alter table vendas add constraint fk_venda_fun foreign key(funcionario)
references funcionarios (codigo);
alter table vendas add constraint fk_venda_cli foreign key(cliente)
references clientes (codigo);

create table itens_venda(
	numero_venda		numeric(15) not null,
	produto			varchar(10) not null,
	qtde			numeric(4) not null,
	valor_unt		numeric(6,2) not null,
	porc_desct		numeric(5,2) not null
);
alter table itens_venda add constraint fk_venda_itens_venda foreign key(numero_venda)
references vendas (numero);
alter table itens_venda add constraint fk_itens_venda_prod foreign key(produto)
references produtos (codigo);


create table orcamentos(
	numero		numeric(15) not null identity(1,1) primary key,
	data		date not null,
	funcionario	numeric(4) not null,
	cliente		numeric(10) not null,
	status		varchar(15)	--aberto,vendido,cancelado
);

alter table orcamentos add constraint fk_orcamento_fun foreign key(funcionario)
references funcionarios (codigo);
alter table orcamentos add constraint fk_orcamento_cli foreign key(cliente)
references clientes (codigo);

create table itens_orcamento(
	numero_orcamento	numeric(15) not null,
	produto			varchar(10) not null,
	qtde			numeric(4) not null,
	valor_unt		numeric(6,2) not null,
	porc_desct		numeric(5,2) not null
);


alter table itens_orcamento add constraint fk_orcamento_itens_orcamento foreign key(numero_orcamento)
references orcamentos (numero);
alter table itens_orcamento add constraint fk_itens_orcamento_prod foreign key(produto)
references produtos (codigo);