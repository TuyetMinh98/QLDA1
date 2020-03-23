using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using System.Data;
using Public;
namespace Bussiness
{
    public class NhanVienBussiness
    {
        public static object ViewWeb { get; private set; }

        public static TblNhanVien InssertNhanVien(TblNhanVien item)
        {
            return new TblNhanVienController().Insert(item);
        }
        public static TblNhanVien UpdateNhanVien(TblNhanVien item)
        {
            return new TblNhanVienController().Update(item);
        }
        public static bool DeleteNhanVien(object id)
        {
            return new TblNhanVienController().Delete(id);
        }
        public static TblNhanVien GwtNhanViebById(object id)
        {
            return new Select().From(TblNhanVien.Schema.TableName).Where(TblNhanVien.Columns.Id).
                IsEqualTo(id).ExecuteSingle<TblNhanVien>();
        }
        public static List<TblNhanVien> GetListNhanVien()
        {
            return new Select().From(TblNhanVien.Schema.TableName).Where(TblNhanVien.TrangThaiColumn).In(1)
                .OrderAsc(TblNhanVien.Columns.TenNhanVien).ExecuteTypedList<TblNhanVien>();
        }
        public static List<TblNhanVien> SearchListNhanVien(String textSearch)
        {
            string sql = @"select * from TblNhanVien"; 
            DateTime dateTimeTemp = DateTime.MinValue;
            DateTime.TryParse(textSearch, out dateTimeTemp);
            if (dateTimeTemp != DateTime.MinValue)
            {
                sql += " WHERE cast( NamSinh as Date) = '" + dateTimeTemp.ToString("yyyy-MM-dd") + "'" + "OR cast( NgayVaoLam as Date) = '" + dateTimeTemp.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                sql += " WHERE HoNhanVien + TenNhanVien Like N'%" + textSearch.Replace(" ", "%") + "%' OR DiaChi Like '%" + textSearch + "%' OR Email Like '%" + textSearch + "%'";
            }
            //DateTime dateTimeTemp = DateTime.MinValue; 
            //dateTimeTemp =  DateTime.Parse(textSearch);
            //DateTime.TryParse(textSearch, out dateTimeTemp);
            //  string sql = @"select * from TblNhanVien 
            //     WHERE HoNhanVien + TenNhanVien Like N'%" + textSearch.Replace(" ","%") + "%' OR DiaChi Like '%" + textSearch + "%'";

            //    if (dateTimeTemp != DateTime.MinValue)
            //    {
            //       sql += " Or NamSinh = '" + dateTimeTemp.ToString("yyyy/MM/dd") +"'";
            //    }
            return new InlineQuery().ExecuteTypedList<TblNhanVien>(sql);

            //return new Select().From(TblNhanVien.Schema.TableName).Where(TblNhanVien.HoNhanVienColumn)+(TblNhanVien.TenNhanVienColumn).Like("%" + a + "%").
            //     Or(TblNhanVien.Columns.TenNhanVien).Like("%" + a + "%").Or(TblNhanVien.Columns.NguoiTao).Like("%" + a + "%").
            //     Or(TblNhanVien.Columns.Email).Like("%" + a + "%").Or(TblNhanVien.Columns.NamSinh).Like("%" + a + "%").
            //     ExecuteTypedList<TblNhanVien>();

        }


    }
}
