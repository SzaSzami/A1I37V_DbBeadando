create or replace procedure sp_InsertMakers (
    p_makers_nev in MAKERS.makers_nev%type

)
authid definer
as
	v_makers_id int;
begin
	select max(makers_id) into v_makers_id from MAKERS;

	if v_makers_id is null then
		v_makers_id := 0;
	end if;
	v_makers_id := v_makers_id + 1;

	insert into MAKERS
		(makers_id, makers_nev)
		values
		(v_makers_id, p_makers_nev);
end sp_InsertMakers;