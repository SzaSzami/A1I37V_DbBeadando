set serveroutput on;
declare
	v_call_PRESENT_ID int;
	v_PRESENT_ID PRESENTS.PRESENT_ID%type := '123456';
begin
	v_call_PRESENT_ID := sf_check_presentid(v_PRESENT_ID);

	if v_call_PRESENT_ID = 1 then
		DBMS_OUTPUT.PUT_LINE('The following ID is correct: '||v_PRESENT_ID);
	else
		DBMS_OUTPUT.PUT_LINE('The following ID is incorrect: '||v_PRESENT_ID);
	end if;
end;