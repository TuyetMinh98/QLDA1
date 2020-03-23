using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using Public;
namespace Bussiness
{
    public class KhachHangBussiness
    {
        public static TblKhachHang InsertKhachHang(TblKhachHang item)
        {
            return new TblKhachHangController().Insert(item);
        }
        public static TblKhachHang UpDateKhachHang(TblKhachHang item)
        {
            return new TblKhachHangController().Update(item);
        }
        public static bool DeleteKhachHang(object id)
        {
            return new TblKhachHangController().Delete(id);
        }
        public static TblKhachHang GwtKhachHangById(object id)
        {
            return new Select().From(TblKhachHang.Schema.TableName).Where(TblKhachHang.Columns.Id).IsEqualTo(id).ExecuteSingle<TblKhachHang>();
        }
        public static List<TblKhachHang> GetListKhachHang()
        {
            return new Select().From(TblKhachHang.Schema.TableName).OrderAsc(TblKhachHang.Columns.HoTen).ExecuteTypedList<TblKhachHang>();
        }
        public static List<TblKhachHang> SearchListKhachHang(string a)
        {
            return new Select().From(TblKhachHang.Schema.TableName).Where(TblKhachHang.HoTenColumn).Like("%" + a + "%").ExecuteTypedList<TblKhachHang>();
        }
    }
}
