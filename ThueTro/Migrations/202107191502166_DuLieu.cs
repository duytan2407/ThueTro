namespace ThueTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DuLieu : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 1')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 2')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 3')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 4')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 5')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 6')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 7')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 8')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 9')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 10')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 11')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận 12')");            
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Bình Tân')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Bình Thạnh')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Gò Vấp')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Phú Nhuận')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Tân Bình')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Thủ Đức')");
            Sql("INSERT INTO DiaDiems (TenQuan) VALUES (N'Quận Tân Phú')");

            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'42 đường Vĩnh Hội, Phường 4','60 m2',N'Lê','0346879151',N'Ký Túc Xá Q4 Sale Khuyến Mãi Cho Tháng Đầu',N'Giường tầng được đặt hàng chắc chắn, nệm, ga giường, gối bông gòn, chăn bông 100% cotton','1tr/tháng',NULL,'4')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'682 đường Đoàn Văn Bơ, Phường 16','12 m2',N'Nguyễn Hùng','0901847523',N'Phòng trọ đẹp mới, có nội thất giá siêu rẻ',N'Phòng nhỏ gọn, có nội thất, wc chung','1tr7/tháng',NULL,'4')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'576/119 đường Đoàn Văn Bơ, Phường 14','15 m2',N'Phạm Tuân','0905952525',N'Cho thuê phòng trọ giá rẻ quận 4',N'Gần các trường đại học Luật, Nguyễn Tất Thành, Tài chính - Marketing, khu ăn uống, chợ....','2tr8/tháng',NULL,'4')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'243/74/9 đường Hoàng Diệu, Phường 4','6m2',N'Đại','0948963963',N'Cho thuê phòng trọ có cửa sổ rộng',N'Có sân thượng chung, rộng phơi quần áo, có chỗ để xe máy miễn phí có camera quan sát','1tr5/tháng',NULL,'4')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'150/44 đường Bến Vân Đồn, Phường 6','35m2',N'Lộc','0935193355',N'Phòng trọ KTX cao cấp đầy đủ tiện nghi',N'Vệ sinh dọn phòng, toilet, khu vực chung, phòng thông thoáng, có hành lang hóng mát','1tr3/tháng',NULL,'4')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'338/1/19 đường An Dương Vương, P.4','25m2',N'Dung','0908313036',N'Phòng mới đẹp',N'Không gian sân vườn rộng rãi, kiến trúc kiểu Villa, Biệt thự, tha hồ tổ chức Party, BBQ cuối tuần','1tr/tháng',NULL,'5')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'126 đường Hồng Bàng, Phường 12','130m2',N'Nguyễn Trọng','0967890139',N'Ở ghép KTX siêu cao cấp FREE Gym Hùng Vương Plaza',N'Đi bộ vài phút đến các trường đại học Sài Gòn, đại học Khoa Học tự nhiên, đại học Sư Phạm, gần chợ An Đông, chợ Bàu Sen.','1tr3/tháng',NULL,'5')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'19 đường Nguyễn Kim, Phường 12','30m2',N'Trâm','0963191024',N'Cho thuê giường tầng và phòng trong nhà nguyên căn',N'Có bếp, lò vi sóng, bếp điện từ, tủ lạnh toàn hàng hiện đại, có thể thoải mái nấu ăn sinh hoạt','1tr2/tháng',NULL,'5')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'111 đường Nguyễn Chí Thanh, Phường 9','50 m2',N'Túc','0908171529',N'KTX ngay ĐH Y Dược, Kinh Tế, Sư Phạm, Dự Bị trọn gói, full nội thất',N'Vị trí đắc địa, ngay trung tâm Q5, sát Q1, Q3... ngay trục đường chính rất thuận tiện giao thông','1tr7/tháng',NULL,'5')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'50 đường Phạm Đôn, Phường 10','30m2',N'Mỹ An','0912238824',N'Cần cho thuê phòng giá tốt',N'Phòng mới, bếp riêng, tủ lạnh, máy lạnh riêng, nước uống miễn phí','2tr/tháng',NULL,'5')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'491 đường Hậu Giang, Phường 6','100m2',N'Hoàng Khánh Ly','0325664329',N'Kí túc xá nữ cao cấp',N'Khu vực ăn uống, yên tĩnh, sạch sẽ, giờ giấc tự do','1tr6/tháng',NULL,'6')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'7 đường Kinh Dương Vương, Phường 13','13m2',N'Minh Huy','0936217210',N'Phòng sạch sẽ cách công viên Phú Lâm 1 phút',N'Nội thất thông minh, dàn phơi thông minh tại 2 ban công cực rộng!!!','1tr7/tháng',NULL,'6')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'132 đường Chợ Lớn, Phường 11','15m2',N'Võ Hồng Ngân','0963181015',N'Giảm sốc. Phòng mới xây 132 Chợ Lớn',N'Cho nấu ăn thoải mái, thích hợp cho người đi làm, sinh viên thuê, nhân viên văn phòng','1tr8/tháng',NULL,'6')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'1472 đường Võ Văn Kiệt, Phường 3','70m2',N'Gia Châu Lâm','0909002329',N'Cozoro Dorm - KTX 5 SAO CAO CẤP MIỄN PHÍ HỒ BƠI VÀ PHÒNG GYM',N'Không giới hạn người ở ','1tr6/tháng',NULL,'6')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'184F/1 đường Tân Hòa Đông, Phường 14','20m2',N'Bảo','0367582554',N'Cho thuê phòng giá rẻ quận 6',N'Bếp điện từ, lò nướng, lò vi sóng, máy lọc nước uống trực tiếp, bàn ủi, máy sấy tóc...','1tr2/tháng',NULL,'6')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'337/22/4 đường Trần Xuân Soạn, Phường Tân Hưng','90m2',N'Phùng Đức Tuấn','0961148620',N'Chung cư HAGL chân cầu kinh tẻ, cho thuê phòng riêng đầy đủ tiện nghi',N'Có chìa khóa riêng, giờ giấc tự do, có lối vận chuyển hàng hóa dễ dàng, phòng vệ sinh rộng sạch sẽ 24/24, máy nước nóng lạnh, điện nước giá nhà nước.','1tr6/tháng',NULL,'7')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'110 đường Số 7, Phường Tân Kiểng','30m2',N'Bắc Nam Home','0948733302',N'Ở ghép nhà Biệt Thự gần Lotte Mart',N'Tiện ích cao cấp như: sàn gỗ, thang máy, hồ bơi, phòng gym, hầm xe, sân tenis, khu đi bộ, siêu thị','1tr6/tháng',NULL,'7')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'102 đường số 77, Phường Tân Quy','32m2',N'Trinh Phạm','0908544938',N'Phòng Trọ ở Ghép Trung Tâm Quận 7',N'Công viên trước nhà thoáng mát cho các bạn tập thể dục khi rảnh rỗi','1tr3/tháng',NULL,'7')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'72 đường Phan Huy Thực, Phường Tân Kiểng','80m2',N'Quang','0782977773',N'Cho Thuê Homestay nội thất đầy đủ',N'Đầy đủ tiện nghi, bếp và nhà vệ sinh ngay trong phòng, thiết bị vệ sinh cao cấp','1tr5/tháng',NULL,'7')");
            Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,DiaDiemIdQuan) VALUES (N'783 đường Trần Xuân Soạn, Phường Tân Hưng','20m2',N'Thảo Nhỏ','0989174230',N'Cho thuê phòng Master trong chung cư Hoàng Anh gia Lai 2',N'Tiện ích đầy đủ dưới nhà, phòng gym, siêu thị, gần bệnh viện, DH Tôn Đức Thắng, DH cảnh sát, DH RMIT','1tr6/tháng',NULL,'7')");

            //Sql("INSERT INTO NhaTroes (Tenduong,DienTich,TenChuNha,SDT,CTNha,GioiThieu,Gia,image,IDQuan) VALUES (N'  ','    ',N'  ','  ',N'  ',N'  ','  ',NULL,'  ')");
        }

        public override void Down()
        {
           
        }
    }
}
