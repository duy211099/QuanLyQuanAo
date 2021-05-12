 CREATE OR ALTER PROCEDURE sp_CRUDLoaiSanPhamCha(   
									@MaLSPCha    INTEGER,  
									@Ten       VARCHAR(10),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO LoaiSanPhamCha  
                        (Ten)  
            VALUES     ( @Ten)  
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   LoaiSanPhamCha  
        END  
  
      IF @StatementType = 'Filter'  
        BEGIN  
            SELECT *  
            FROM   LoaiSanPhamCha  
			WHERE MaLSPCha=@MaLSPCha OR Ten=@Ten
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE LoaiSanPhamCha  
            SET    Ten = @Ten
            WHERE  MaLSPCha = @MaLSPCha
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM LoaiSanPhamCha  
            WHERE  MaLSPCha = @MaLSPCha
        END  
  END