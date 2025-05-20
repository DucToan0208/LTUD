---t?o store in danh sach hoa ??n
create proc InDSHoaDon
as
select * from HOADON
drop Procedure if exists ThemHoaDon
set dateformat dmy
go
---t?o store th�m h�a ??n
create proc ThemHoaDon(@mahd char(10),@ngaylap date, @soluong int, @dongia float,@thanhtien float,@makhang char(10))
as	
insert into HOADON(MAHD,NGAYLAP,SOLUONG,DONGIA,Thanhtien,MAKHANG)
values(@mahd,@ngaylap,@soluong,@dongia,@thanhtien,@makhang)

---t?o store S?a h�a ??n
create proc SuaHoaDon(@mahd char(10),@ngaylap date, @soluong int, @dongia float,@thanhtien float, @makhang char(10))
as
update HOADON
set  NGAYLAP = @ngaylap, SOLUONG = @soluong, DONGIA = @dongia, Thanhtien = @thanhtien,MAKHANG = @makhang
where MAHD = @mahd
---t?o store in ds khach hang
create proc InDSKH
as
select * from KHACHHANG
exec InDSKH
---t?o store x�a hoadon
create proc XoaHD(@mahd char(10))
as
delete
from HOADON
where MAHD = @mahd
---t?o store t�m m� hoa don
	create proc TimMaHD(@mahd char(10))
	as
	select * 
	from HOADON
	where MAHD = @mahd
	--- t?o store t�m m� kh
	create proc TimMaKH(@makh char(10))
	as
	select * 
	from HOADON
	where MAKHANG = @makh

