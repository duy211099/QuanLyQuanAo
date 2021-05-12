 CREATE OR ALTER PROCEDURE sp_CRUDNhanVienChiNhanh(
									@MaNVCN    INTEGER,     
									@MaNV    INTEGER,  
									@MaCN       VARCHAR(20),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO NhanVienChiNhanh  
                        (MaNVCN, MaNV, MaCN)  
            VALUES     (@MaNVCN, @MaNV, @MaCN)  
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   NhanVienChiNhanh  
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE NhanVienChiNhanh  
            SET    MaNV=@MaNV, MaCN = @MaCN
            WHERE  MaNVCN=@MaNVCN 
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM NhanVienChiNhanh  
            WHERE MaNVCN=@MaNVCN
        END  
  END