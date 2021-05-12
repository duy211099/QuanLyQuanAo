 CREATE OR ALTER PROCEDURE sp_CRUDChucVu(
									@MaCV    NVARCHAR(20),    
									@MoTa       NVARCHAR(1000),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO ChucVu  
                        (MaCV, MoTa) 
            VALUES     (@MaCV, @MoTa) 
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   ChucVu  
        END  

     IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM ChucVu  
            WHERE  MaCV = @MaCV
        END  
  END