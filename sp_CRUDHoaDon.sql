 CREATE OR ALTER PROCEDURE sp_CRUDHoaDon(
									@MaHD INT,
									@MaNV       INT,
									@MaKH    INT,    
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
                        (MaNV, MaKH, NgayMua, TamTinh, GiamGia, TongTien)
            VALUES     (@MaNV, @MaKH, @NgayMua, @TamTinh, @GiamGia, @TongTien)
						
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
					MaKH = @MaKH,
					NgayMua = @NgayMua,
					TamTinh = @TamTinh,
					GiamGia = @GiamGia,
					TongTien = @TongTien
            WHERE  MaHD = @MaHD
        END  

  END