using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using Bussiness;
using Public;
namespace Bussiness
{
    public class ThongBaoBussiness
    {
        public static object ViewWeb { get; private set; }

        public static TblThongBao InssertThongBao(TblThongBao item)
        {
            return new TblThongBaoController().Insert(item);
        }
        public static TblThongBao UpdateThongBao(TblThongBao item)
        {
            return new TblThongBaoController().Update(item);
        }
        public static bool DeleteThongBao(object id)
        {
            return new TblThongBaoController().Delete(id);
        }
        public static TblThongBao GwtThongBaoById(object id)
        {
            return new Select().From(TblThongBao.Schema.TableName).Where(TblThongBao.Columns.Id).
                IsEqualTo(id).ExecuteSingle<TblThongBao>();
        }
        public static List<TblThongBao> GetListThongBao()
        {
            string sql = @"select tb.*, kh.HoTen, nv.HoNhanVien, nv.TenNhanVien, mtb.TenMauThongBao
                            from TblThongBao as tb left outer join TblKhachHang as kh on kh.Id = tb.IdKhachhang
                            left outer join TblNhanVien nv on nv.Id = tb.IdNhanVien
                            left outer join TblMauThongBao mtb on mtb.Id = tb.MoTa
                            where tb.TrangThai = 1";
            return new InlineQuery().ExecuteTypedList<TblThongBao>(sql);
            // return new Select().From(TblThongBao.Schema.TableName).ExecuteTypedList<TblThongBao>();
        }
        public static List<TblThongBao> GetViewListThongBao(string id)
        {
            string sql = @"select TblThongBao.*,TblNhanVien.HoNhanVien,TblNhanVien.TenNhanVien,TblVanPhong.TenVanPhong,TblMauThongBao.TenMauThongBao
                from TblThongBao inner join TblNhanVien on TblNhanVien.Id = TblThongBao.IdNhanVien inner join TblVanPhong on TblVanPhong.Id = TblThongBao.IdVanPhong 
             inner join TblMauThongBao on TblMauThongBao.id = TblThongBao.MoTa  where TblThongBao.Id = '" + id + "'";
            return new InlineQuery().ExecuteTypedList<TblThongBao>(sql);
        }
        public static List<TblThongBao> GetListTopThongBao()
        {
            string sql = @"select TblThongBao.*,TblNhanVien.HoNhanVien,TblNhanVien.TenNhanVien,TblVanPhong.TenVanPhong,TblMauThongBao.TenMauThongBao
                from TblThongBao inner join TblNhanVien on TblNhanVien.Id = TblThongBao.IdNhanVien inner join TblVanPhong on TblVanPhong.Id = TblThongBao.IdVanPhong 
             inner join TblMauThongBao on TblMauThongBao.id = TblThongBao.MoTa  ORDER BY TblThongBao.NgayTao DESC";
            return new InlineQuery().ExecuteTypedList<TblThongBao>(sql);
        }
        public static List<TblThongBao> SearchListThongBao(String a)
        {
            return new Select().From(TblThongBao.Schema.TableName).Where(TblThongBao.Columns.NguoiTao).Like("%" + a + "%").ExecuteTypedList<TblThongBao>();
        }

    }
}
