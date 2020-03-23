using Public;
using SubSonic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bussiness
{
   public class VanPhongBussiness
    {
        public static TblVanPhong InsertVanPhong(TblVanPhong item)
        {
            return new TblVanPhongController().Insert(item);
        }
        public static TblVanPhong UpdateVanPhong(TblVanPhong item)
        {
            return new TblVanPhongController().Update(item);
        }
        public static bool DeleteVanPhong(object id)
        {
            return new TblVanPhongController().Delete(id);
        }
        public static TblVanPhong GwtVanPhongById(object id)
        {
            return new Select().From(TblVanPhong.Schema.TableName).Where(TblVanPhong.Columns.Id).
                IsEqualTo(id).ExecuteSingle<TblVanPhong>();
        }
        public static List<TblVanPhong> GetListVanPhong()
        {
            return new Select().From(TblVanPhong.Schema.TableName).Where(TblVanPhong.TrangThaiColumn).In(1)
                .OrderDesc(TblVanPhong.Columns.NgayTao).ExecuteTypedList<TblVanPhong>();
        }
        public static List<TblVanPhong> SearchListVanPhong(String a)
        {
            return new Select().From(TblVanPhong.Schema.TableName).Where(TblVanPhong.TenVanPhongColumn).Like("%" + a + "%").ExecuteTypedList<TblVanPhong>();
        }

    }
}
