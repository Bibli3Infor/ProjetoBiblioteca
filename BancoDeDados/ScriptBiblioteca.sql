create database BD_Biblioteca;
use BD_Biblioteca;

create table Funcionario(
	id_fun int primary key auto_increment,
    nome_fun varchar(300),
    email_fun varchar(300),
    cpf_fun varchar(100),
    rg_fun varchar(50),
    endereco_fun varchar(50),
    #codigo_acesso_fun varchar(100),
    telefone_fun varchar(100),
    turno_fun varchar(100),
    sexo_fun varchar(80),
    data_nasc_fun date
);

create table Leitor(
	id_lei int primary key auto_increment,
    cod_acesso_lei varchar(300),
    nome_lei varchar(300),
    email_lei varchar(300),
    endereco_lei varchar(200),
    cpf_lei varchar(100),
    rg_lei varchar(50),
    telefone_lei varchar(200),
    sexo_lei varchar(50),
    data_nasc_lei date
);

create table Genero(
	id_gen int primary key auto_increment,
    nome_gen varchar(300),
    descricao_gen varchar(500)
);

create table Fornecedor(
	id_for int primary key auto_increment,
	nome_empresa_for varchar(300),
	telefone_for varchar(100),
    email_fun varchar(300),
	cnpj_for varchar(100),
    endereco_for varchar(300),
    descricao_for varchar(300),
    razao_social_for varchar(300)
);

create table Autor(
	id_aut int primary key auto_increment,
    nome_aut varchar(300),
    nacionalidade_aut varchar(300),
    email_aut varchar(300),
    sexo_aut varchar(50),
    contato_aut varchar(100),
    data_nasc_aut date
);

create table Login(
	id_log int primary key auto_increment,
    nome_log varchar(300),
    senha_log varchar(500),
	id_fun_fk int,
	foreign key (id_fun_fk) references Funcionario (id_fun)
);

create table Vaga(
	id_vag int primary key auto_increment,
    funcao_vag varchar(200),
    status_vag varchar(100),
	turno_vag varchar(200),
	id_fun_fk int,
	foreign key (id_fun_fk) references Funcionario (id_fun)
);

create table Livro(
	id_liv int primary key auto_increment,
	codigo_liv varchar(200),
    titulo_liv varchar(300),
    sinopse_liv varchar(500),
    localizacao_liv varchar(300),
	data_publicacao_liv date,
    edicao_liv varchar(300)
	#int_for_fk int not null,
	#foreign key (int_for_fk) references Fornecedor (id_for),
	#int_aut_fk int not null,
	#foreign key (int_aut_fk) references Autor (id_aut)
	#int_gen_fk int not null,
	#foreign key (int_aut_fk) references Genero (id_gen)
);

create table Emprestimo(
	id_emp int primary key auto_increment,
    data_emp date,
    situacao_emp varchar(300),
	#id_fun_fk int,
	#foreign key (id_fun_fk) references Funcionario (id_fun),
    id_liv_fk int,
	foreign key (id_liv_fk) references Livro (id_liv),
	id_lei_fk int,
	foreign key (id_lei_fk) references Leitor (id_lei)
);

create table Devolucao(
	id_dev int primary key auto_increment,
    data_devolucao_dev date,
    atraso_dev date,
	id_emp_fk int,
	foreign key (id_emp_fk) references Emprestimo (id_emp)
);

create table Favoritos(
	id_fav int primary key auto_increment,
    data_adicao_fav date,
	id_liv_fk int,
	foreign key (id_liv_fk) references Livro (id_liv),
	id_lei_fk int,
	foreign key (id_lei_fk) references Leitor (id_lei)
);

insert into Livro values (null, null, "Alice no Pais das Maravilhas", null, null, null, "3º Edicao");
insert into Livro values (null, null, "A volta ao mundo em 80 dias", null, null, null, "15º Edicao");
insert into Livro values (null, null, "Memórias Póstumas de Bras Cubas", null, null, null, "10º Edicao");
insert into Livro values (null, null, "O Alienista", null, null, null, "7º Edicao");
insert into Livro values (null, null, "Contos de Grin", null, null, null, "2º Edicao");
insert into Livro values (null, null, "Sangue Azul", null, null, null, "8º Edicao");

insert into Funcionario values (null, "Danilo Bento Rezende", "danilobentorezende@bol.br", "276.450.669-46", "24.396.517-5", "Rua Princesa Isabel", "(82) 2676-8224", "Matutino", "Masculino", '1999-05-20');
insert into Funcionario values (null, "Isabel Daniela Antônia Rezende", "isabel.daniela.rezende@brastek.com.br", "276.450.669-46", "24.396.517-5", "Rua Nossa Senhora da Luz", "(86) 2764-8041", "Vespertino", "Feminino", '1995-03-18');
insert into Funcionario values (null, "Elza Laís Hadassa Martins", "delza_lais_martins@gdsambiental.com.br", "724.233.947-21", "18.105.905-8", "Rua Vera Cruz", "(73) 3903-1494", "Matutino", "Masculino", '1999-05-20');

insert into Leitor values (null, "1234", "Carlos Santos Rocha",  "Carlos@gmail.com", "Rua Princesa Isabel", "386.307.259-66", "13.980.475-4", "(69) 99233-4566", "Masculino",'1999-05-20');
insert into Leitor values (null, "1234", "Luana Pereira Lima", "Luana@gmail.com", "Rua Nossa Senhora da Luz", "586.857.532-60", "21.800.628-7", "(69) 98425-6655", "Feminino", '1995-03-18');
insert into Leitor values (null, "1234", "Patricia Costa Hadassa", "Patricia@gmail.com", "Rua Vera Cruz", "189.937.969-04", "20.471.752-8", "(69) 99992-1365", "Feminino", '1999-05-20');