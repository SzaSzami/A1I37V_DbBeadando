drop table MAKERS;

create table MAKERS
(
	MAKERS_ID int not null,
	MAKERS_NEV varchar2(200) not null,

	constraint pk_makers primary key(MAKERS_ID)
);
