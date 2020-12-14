create or replace procedure sf_GetMakersId (
	p_makers_nev in MAKERS.makers_nev%type
)
return int
deterministic

as
	temp int;
	temp_cnt int;
begin
	select count(*) into temp_cnt FROM MAKERS where makers_nev = p_makers_nev;

	if temp_cnt = 0 then
		return null;
	else
		SELECT makers_id into temp from MAKERS where makers_nev = p_makers_nev;
	end if;

	return temp;
	
end sf_GetMakersId;