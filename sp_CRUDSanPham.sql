 CREATE OR ALTER PROCEDURE sp_CRUDSanPham(
									@MaSP    INTEGER,    
									@MaLSP    INTEGER,      
									@Ten       NVARCHAR(50),
									@Gia    DECIMAL,      
									@MoTa       NVARCHAR(1000),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO SanPham  
                        (MaLSP, Ten, Gia, MoTa)  
            VALUES     (@MaLSP, @Ten, @Gia, @MoTa) 
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   SanPham  
        END  
   

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE SanPham  
            SET    MaLSP = @MaLSP,
					Ten = @Ten,
					Gia = @Gia,
					MoTa = @MoTa
            WHERE  MaSP = @MaSP
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM SanPham  
            WHERE  MaSP = @MaSP
        END  
  END