set xact_abort on;

begin transaction;

create table status
(
	id		int primary key identity,
	name	varchar(20),
	beschreibung	varchar(200)
)
go

create table projekt 
(
	id				int primary key identity,
	name			varchar(50),
	beschreibung	varchar(max),
	beginn			date,
	ende			date
)
go

create table projektstatus
(
	id			int primary key identity,
	projekt		int references projekt(id),
	status		int references status(id),
	update_am	date
)
go

create table person
(
	id			int primary key identity,
	Vorname		varchar(100),		
	Nachame		varchar(100),
	Anmeldename	varchar(100) not null

)
go

create table personen_projekte
(
	id			int primary key identity,
	projekt		int references projekt(id),
	person		int	references person(id)
)
go

alter table person
	add passwort varchar(20);
go

create unique index  idx_person_anmname on  person(anmeldename);
go



commit;