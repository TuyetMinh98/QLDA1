using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using Public;

namespace Bussiness
{
    public class NguoiDungBussiness
    {
        public static TblNguoiDung InsertNguoiDung(TblNguoiDung item)
        {
            return new TblNguoiDungController().Insert(item);
        }
        public static TblNguoiDung UpDateNguoiDung(TblNguoiDung item)
        {
            return new TblNguoiDungController().Update(item);
        }
        public static bool DeleteNguoiDung(object id)
        {
            return new TblNguoiDungController().Delete(id);
        }
        public static TblNguoiDung GwtNguoiDungById(object id)
        {
            return new Select().From(TblNguoiDung.Schema.TableName).Where(TblNguoiDung.Columns.Id).IsEqualTo(id).ExecuteSingle<TblNguoiDung>();
        }
        public static List<TblNguoiDung> GetListNguoiDung()
        {
            string sql = @"select TblNguoiDung.*, TblNhanVien.HoNhanVien, TblNhanVien.TenNhanVien, TblVaiTro.VaiTro from tblNguoiDung 
            inner join TblNhanVien on TblNhanvien.Id = TblNguoiDung.IdNhanVien inner join TblVaiTro on TblVaiTro.Id =TblNguoiDung.IdVaiTro
            where TblNguoiDung.TrangThai = 1";
            return new InlineQuery().ExecuteTypedList<TblNguoiDung>(sql);
            // return new Select().From(TblNguoiDung.Schema.TableName).Where(TblNguoiDung.TrangThaiColumn).In(1).ExecuteTypedList<TblNguoiDung>();
        }
        public static List<TblNguoiDung> SearchListNguoiDung(string a)
        {
            return new Select().From(TblNguoiDung.Schema.TableName).Where(TblNguoiDung.TenDangNhapColumn).
                Like("%" + a + "%").ExecuteTypedList<TblNguoiDung>();
        }
        public static TblNguoiDung GetUserByUserName(string userName)
        {
            // Đây là hàm collection, cái này lấy cả danh sách, ta ko nên dùng nó nếu chỉ lấy 1 giá trị, nó sẽ nặng
            // Đặt tên biến rất quan trọng, nên rèn luyện tính cẩn thận
            // ExcuteSingle là lấy 1 giá trị
            // ExcuteList là lấy danh sách
            return new Select().From(TblNguoiDung.Schema.TableName).Where(TblNguoiDung.Columns.TenDangNhap).
                IsEqualTo(userName).ExecuteSingle<TblNguoiDung>();




            //TblNguoiDungCollection arrUser = new TblNguoiDungController().FetchByQuery(new SubSonic.Query(Tables.TblNguoiDung).WHERE
            //    (TblNguoiDung.Columns.TenDangNhap, strTen));
            //return (arrUser != null && arrUser.Count > 0) ? arrUser[0] : null;
        }

    }
}
