namespace ThueTro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DuLieu : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q1',N'Quận 1')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q10',N'Quận 10')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q11',N'Quận 11')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q12',N'Quận 12')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q2',N'Quận 2')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q3',N'Quận 3')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q4',N'Quận 4')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q5',N'Quận 5')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q6',N'Quận 6')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q7',N'Quận 7')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q8',N'Quận 8')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('Q9',N'Quận 9')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QBinhTan',N'Quận Bình Tân')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QBinhThanh',N'Quận Bình Thạnh')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QGovap',N'Quận Gò Vấp')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QPhuNhuan',N'Quận Phú Nhuận')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QTanBinh',N'Quận Tân Bình')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QThuDuc',N'Quận Thủ Đức')");
            Sql("INSERT INTO DiaDiems (IDQuan,TenQuan) VALUES ('QTanPhu',N'Quận Tân Phú')");
        }
        
        public override void Down()
        {
           
        }
    }
}
