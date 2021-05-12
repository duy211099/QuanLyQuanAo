 CREATE OR ALTER PROCEDURE sp_CRUDChiTietHoaDon(
									@MaCTHD    INTEGER,     
									@MaHD    INTEGER,  
									@MaCTSP    INTEGER,  
									@SoLuong    INTEGER,  
									@GiaHienTai       DECIMAL(18, 0),
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  

	DECLARE @TongTien DECIMAL(18, 0) 
	SET @TongTien = @GiaHienTai * @SoLuong 

      IF @StatementType = 'Insert'		
        BEGIN  
            INSERT INTO ChiTietHoaDon  
                        (MaCTHD, MaHD, MaCTSP, SoLuong, GiaHienTai, TongTien)  
            VALUES     ( @MaCTHD, @MaHD, @MaCTSP, @SoLuong, @GiaHienTai, @TongTien)  
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   ChiTietHoaDon  
        END  
  
      IF @StatementType = 'Filter'  
        BEGIN  
            SELECT *  
            FROM   ChiTietHoaDon  
			WHERE MaCTHD=@MaCTHD OR MaHD=@MaHD OR MaCTSP = @MaCTSP OR SoLuong=@SoLuong OR GiaHienTai=@GiaHienTai OR TongTien=@TongTien
        END  

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE ChiTietHoaDon  
            SET    MaHD=@MaHD,
					MaCTSP = @MaCTSP, 
					SoLuong=@SoLuong, 
					GiaHienTai=@GiaHienTai, 
					TongTien=@TongTien
            WHERE  MaCTHD=@MaCTHD
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM ChiTietHoaDon  
            WHERE MaCTHD=@MaCTHD
        END  
  END