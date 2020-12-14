create table PRESENTS
(
    PRESENT_ID char(6) not null,
    PRESENT_NAME varchar2(250) not null,
    MANUFACTURER_ID int not null,
    PRESENT_COLOR varchar2(20) not null,
    PRESENT_SIZE varchar2(3) not null,
    PRESENT_PRICE int not null,
    PRESENT_WEIGHT int,

constraint pk_presents primary key(PRESENT_ID),
constraint ch_presents_size check(PRESENT_SIZE in ('S','M','L','XL','XXL')),
constraint fk_manufacturer foreign key(manufacturer_id) references makers(makers_id)
);