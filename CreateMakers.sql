drop table MAKERS;

create table MAKERS
(
	makers_id int not null,
	makers_nev varchar2(200) not null,

	constraint pk_makers primary key(makers_id)
);