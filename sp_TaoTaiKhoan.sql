CREATE OR ALTER PROC sp_GetLoginInfoo
	@LGNAME NVARCHAR(50),
	@PASS NVARCHAR(50),
	@USERNAME NVARCHAR(50),
	@ROLE NVARCHAR(50)
AS
BEGIN
	DECLARE @RET INT
	EXEC @RET = SP_ADDLOGIN @LGNAME, @PASS, 'CSDLPT'

	IF(@RET = 1) 
		RETURN 1

	EXEC @RET = SP_GRANTDBACCESS @LGNAME, @USERNAME
	IF (@RET = 1) --USERNAME TRUNG
	BEGIN
		EXEC SP_DROPLOGIN @LGNAME
		RETURN 2
	END
	EXEC sp_addrolemember @ROLE, @USERNAME

	IF @ROLE = 'GIAMDOC'
	BEGIN
		EXEC sp_addrolemember @LGNAME, 'sysadmin'
		EXEC sp_addrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addrolemember @LGNAME, 'ProcessAdmin'
	END
		
	IF @ROLE = 'QLCHINHANH'
	BEGIN
		EXEC sp_addrolemember @LGNAME, 'sysadmin'
		EXEC sp_addrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addrolemember @LGNAME, 'ProcessAdmin'
	END
		
	IF @ROLE = 'NHANVIEN'
	BEGIN
		EXEC sp_addrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO