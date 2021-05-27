 CREATE OR ALTER PROCEDURE sp_CRUDHoaDon(
									@MaHD INT,
									@MaNV       INT,
									@TenKH    NVARCHAR(20),    
									@NgayMua       DATE,
									@TamTinh    DECIMAL(18,0),    
									@GiamGia       INT,
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
		DECLARE @TongTien    DECIMAL(18,0)
		SET @TongTien = @TamTinh * ((100 - @GiamGia) / 100)

      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO HoaDon  
                        (MaNV, TenKH, NgayMua, TamTinh, GiamGia, TongTien)
            VALUES     (@MaNV, @TenKH, @NgayMua, @TamTinh, @GiamGia, @TongTien)
						
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   HoaDon  
        END  

	
      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE HoaDon  
            SET    MaNV = @MaNV,
					@TenKH = @TenKH,
					NgayMua = @NgayMua,
					TamTinh = @TamTinh,
					GiamGia = @GiamGia,
					TongTien = @TongTien
            WHERE  MaHD = @MaHD
        END  

  END