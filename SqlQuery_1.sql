
CREATE TRIGGER [dbo].[Tr_ins__projektstatus]
    ON [dbo].[projektstatus]
    FOR  INSERT, UPDATE
    AS
    BEGIN
        SET NoCount ON

		update projektstatus set update_am = GETDATE() where id = 
		(select id from projektstatus where id = @@IDENTITY);
    END