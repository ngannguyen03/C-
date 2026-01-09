using System;
using System.Collections.Generic;
using System.IO;
using OfficeOpenXml; // Yêu cầu NuGet EPPlus
using QuanLyShopQuanAo.DAL;
using QuanLyShopQuanAo.DTO;

namespace QuanLyShopQuanAo.BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal = new SanPhamDAL();

        public List<SanPhamDTO> GetAll() => dal.GetAll();
        public List<string> GetImagesByMaSP(string ma) => dal.GetImagesByMaSP(ma);
        public bool AddSanPham(SanPhamDTO sp) => dal.Insert(sp);
        public bool EditSanPham(SanPhamDTO sp) => dal.Update(sp);
        public bool DeleteSanPham(string ma) => dal.Delete(ma);

        // XUẤT EXCEL
        public void ExportToExcel(string path)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var pck = new ExcelPackage())
            {
                var ws = pck.Workbook.Worksheets.Add("Sản phẩm");
                var list = dal.GetAll();
                ws.Cells["A1"].Value = "Mã SP"; ws.Cells["B1"].Value = "Tên SP";
                ws.Cells["C1"].Value = "Số lượng"; ws.Cells["D1"].Value = "Đơn giá";

                for (int i = 0; i < list.Count; i++)
                {
                    ws.Cells[i + 2, 1].Value = list[i].MaSP;
                    ws.Cells[i + 2, 2].Value = list[i].TenSP;
                    ws.Cells[i + 2, 3].Value = list[i].SoLuong;
                    ws.Cells[i + 2, 4].Value = list[i].DonGia;
                }
                pck.SaveAs(new FileInfo(path));
            }
        }

        // NHẬP EXCEL
        public int ImportFromExcel(string path)
        {
            int count = 0;
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var pck = new ExcelPackage(new FileInfo(path)))
            {
                var ws = pck.Workbook.Worksheets[0];
                for (int row = 2; row <= ws.Dimension.End.Row; row++)
                {
                    try
                    {
                        SanPhamDTO sp = new SanPhamDTO
                        {
                            MaSP = ws.Cells[row, 1].Text,
                            TenSP = ws.Cells[row, 2].Text,
                            SoLuong = int.Parse(ws.Cells[row, 3].Text),
                            DonGia = decimal.Parse(ws.Cells[row, 4].Text)
                        };
                        if (dal.Insert(sp)) count++;
                    }
                    catch { continue; }
                }
            }
            return count;
        }
    }
}