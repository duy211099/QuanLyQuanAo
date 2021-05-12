 CREATE OR ALTER PROCEDURE sp_CRUDChiNhanh(
									@MaCN    NVARCHAR(20),     
									@Ten    NVARCHAR(50),  
									@DiaChi       NVARCHAR(1000),
									@SDT      VARCHAR(12),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO ChiNhanh  
                        (MaCN, Ten, DiaChi, SDT)  
            VALUES     ( @MaCN, @Ten, @DiaChi, @SDT)  
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE ChiNhanh  
            SET    DiaChi = @DiaChi,
					Ten = @Ten,
					SDT = @SDT
            WHERE  MaCN = @MaCN
        END 
	
	IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM ChiNhanh  
            WHERE  MaCN = @MaCN
        END  
  END