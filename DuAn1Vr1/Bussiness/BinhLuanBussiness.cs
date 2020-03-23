using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using Public;
namespace Bussiness
{
    public class BinhLuanBussiness
    {
        public static object ViewWeb { get; private set; }
        
        public static TblBinhLuan InssertBinhLuan(TblBinhLuan item)
        {
            return new TblBinhLuanController().Insert(item);
        }
        public static TblBinhLuan UpdateBinhLuan(TblBinhLuan item)
        {
            return new TblBinhLuanController().Update(item);
        }
        public static bool DeleteBinhLuan(object id)
        {
            return new TblBinhLuanController().Delete(id);
        }
        public static TblBinhLuan GwtBinhLuanById(object id)
        {
            return new Select().From(TblBinhLuan.Schema.TableName).Where(TblBinhLuan.Columns.Id).
                IsEqualTo(id).ExecuteSingle<TblBinhLuan>();
        }
        public static List<TblBinhLuan> GetListBinhLuan()
        {
            string sql = @"select  bl.*, nv.HoNhanVien, nv.TenNhanVien, tb.ThoiGian
                   from TblBinhLuan as bl inner join TblNhanVien as nv on nv.Id = bl.IdNguoiBinhLuan inner join 
                   TblThongBao as tb on tb.IdNhanVien = nv.Id";

            return new InlineQuery().ExecuteTypedList<TblBinhLuan>(sql);
            // return new Select().From(TblThongBao.Schema.TableName).ExecuteTypedList<TblThongBao>();
        }
        public static List<TblBinhLuan> GetAddListBinhLuan(string id)
        {
            string sql = @"select bl.*, nv.HoNhanVien, nv.TenNhanVien, bl.NoiDung
                   from TblBinhLuan as bl inner join TblNhanVien as nv on nv.Id = bl.IdNguoiBinhLuan inner join
                   TblThongBao as tb on tb.Id = bl.IdThongBao where bl.IdThongBao ='" + id + "' ORDER BY bl.NgayTao DESC ";
            return new InlineQuery().ExecuteTypedList<TblBinhLuan>(sql);

            //return new Select(TblBinhLuan.NoiDungColumn,TblBinhLuan.IdNguoiBinhLuanColumn,TblBinhLuan.NgayTaoColumn,
            //    TblNhanVien.HoNhanVienColumn,TblNhanVien.TenNhanVienColumn,TblThongBao.ThoiGianColumn).From(TblBinhLuan.Schema).
            //  InnerJoin(TblNhanVien.IdColumn, TblBinhLuan.IdNguoiBinhLuanColumn).
            //    InnerJoin(TblThongBao.IdColumn, TblBinhLuan.IdThoiGianRaVaoColumn).
            //    Where(TblBinhLuan.IdThoiGianRaVaoColumn).Like(id).ExecuteTypedList<TblBinhLuan>();
        }
        public static List<TblBinhLuan> SearchListBinhLuan(String a)
        {
            return new Select().From(TblBinhLuan.Schema.TableName).Where(TblBinhLuan.Columns.NoiDung).Like(" % " + a + "%").ExecuteTypedList<TblBinhLuan>();
        }

    }
}
