create or replace procedure spInsert_Presents(
    P_PRESENT_ID in PRESENTS.PRESENT_ID%type,
    P_PRESENT_NAME IN PRESENTS.PRESENT_NAME%type,
    P_MANUFACTURER_ID IN MAKERS.makers_nev%type,
    P_PRESENT_COLOR IN PRESENTS.PRESENT_COLOR%type,
    P_PRESENT_SIZE IN PRESENTS.PRESENT_SIZE%type,
    P_PRESENT_PRICE IN PRESENTS.PRESENT_PRICE%type,
    P_PRESENT_WEIGHT IN PRESENTS.PRESENT_WEIGHT%type,
    
    p_out_rowcnt out int
)

authid definer
as
    v_check_PRESENT_ID int;

begin
    p_out_rowcnt := 0;

    if v_check_PRESENT_ID = 1 then
        insert into PRESENTS
            (PRESENT_ID, PRESENT_NAME, MANUFACTURER_ID, PRESENT_COLOR, PRESENT_SIZE, PRESENT_PRICE, PRESENT_WEIGHT)
        values
            (P_PRESENT_ID, P_PRESENT_NAME, P_MANUFACTURER_ID, P_PRESENT_COLOR, P_PRESENT_SIZE, P_PRESENT_PRICE, P_PRESENT_WEIGHT);
        p_out_rowcnt := SQL%rowcount;
        commit;
    end if;
    
end spInsert_Presents;