 CREATE OR ALTER PROCEDURE sp_CRUDLoaiSanPham(
									@MaLSP    INTEGER,     
									@MaLSPCha    INTEGER,  
									@Ten       VARCHAR(10),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO LoaiSanPham  
                        (MaLSPCha, Ten)  
            VALUES     ( @MaLSPCha, @Ten)  
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   LoaiSanPham  
        END  
  
      IF @StatementType = 'Filter'  
        BEGIN  
            SELECT *  
            FROM   LoaiSanPham  
			WHERE MaLSPCha=@MaLSPCha OR Ten=@Ten OR MaLSP = @MaLSP
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE LoaiSanPham  
            SET    MaLSPCha = @MaLSPCha,
					Ten = @Ten
            WHERE  MaLSPCha = @MaLSPCha
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM LoaiSanPham  
            WHERE  MaLSP = @MaLSP
        END  
  END