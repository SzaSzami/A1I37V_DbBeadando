create or replace function sf_check_presentid(
	p_PRESENT_ID in PRESENTS.PRESENT_ID%type
)
return int
deterministic

as
	v_PRESENT_ID_int int(1);
	v_i int;
begin
	if p_PRESENT_ID is null then
		return 0;
	end if;
	if length(trim(p_PRESENT_ID)) = 6 then
		v_i := 1;
		while v_i <= 6 loop
			v_PRESENT_ID_int := substr(p_PRESENT_ID, v_i, 1);
			if not (ascii('0') <= ascii(v_PRESENT_ID_int) and ascii(v_PRESENT_ID_int) <= ascii('9')) then
			return 0;
			end if;
			v_i := v_i + 1;
		end loop;
		return 1;
	end if;
	return 0;
end sf_check_presentid;
