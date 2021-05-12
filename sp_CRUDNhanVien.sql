 CREATE OR ALTER PROCEDURE sp_CRUDNhanVien(
									@MaNV    INTEGER,     
									@MaCV    VARCHAR(20),  
									@Ten       VARCHAR(1000),
									@Luong    DECIMAL(18,0),     
									@NgaySinh    DATE,  
									@SDT       VARCHAR(12),
									@DiaChi       VARCHAR(1000),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO NhanVien  
                        (MaNV, MaCV, Ten, Luong, NgaySinh, SDT, DiaChi)  
            VALUES     (@MaNV, @MaCV, @Ten, @Luong, @NgaySinh, @SDT, @DiaChi)  
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   NhanVien  
        END  
  
      IF @StatementType = 'Filter'  
        BEGIN  
            SELECT *  
            FROM   NhanVien  
			WHERE MaNV=@MaNV OR MaCV=@MaCV OR Ten = @Ten OR Luong=@Luong OR NgaySinh=@NgaySinh OR SDT = @SDT OR DiaChi = @DiaChi
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE NhanVien  
            SET    MaCV=@MaCV, Ten = @Ten, Luong=@Luong, NgaySinh=@NgaySinh, SDT = @SDT, DiaChi = @DiaChi
            WHERE  MaNV=@MaNV 
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM NhanVien  
            WHERE MaNV=@MaNV 
        END  
  END