 CREATE OR ALTER PROCEDURE sp_CRUDChiTietSanPham(
									@MaCTSP    INTEGER,    
									@MaSP    INTEGER,      
									@Mau       NVARCHAR(50),
									@Size    NVARCHAR(50),   
									@SoLuong   INTEGER,      
									@GiamGia	INTEGER,      
									@StatementType NVARCHAR(20) = '')  
AS  
  BEGIN  
      IF @StatementType = 'Insert'  
        BEGIN  
            INSERT INTO ChiTietSanPham  
                        (MaSP, Mau, Size, SoLuong, GiamGia)  
            VALUES     (@MaSP, @Mau, @Size, @SoLuong, @GiamGia) 
        END  
  
      IF @StatementType = 'SelectAll'  
        BEGIN  
            SELECT *  
            FROM   ChiTietSanPham  
        END  
   

      IF @StatementType = 'Update'  
        BEGIN  
            UPDATE ChiTietSanPham  
            SET    MaSP = @MaSP,
					Mau = @Mau,
					Size = @Size,
					SoLuong = @SoLuong
            WHERE  MaCTSP = @MaCTSP
        END  
      ELSE IF @StatementType = 'Delete'  
        BEGIN  
            DELETE FROM ChiTietSanPham  
            WHERE  MaCTSP = @MaCTSP
        END  
  END