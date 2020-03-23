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
    public class VaiTroBussiness
    {
        public static object ViewWeb { get; private set; }

        public static TblVaiTro InssertVaiTro(TblVaiTro item)
        {
            return new TblVaiTroController().Insert(item);
        }
        public static TblVaiTro UpdateVaiTro(TblVaiTro item)
        {
            return new TblVaiTroController().Update(item);
        }
        public static bool DeleteVaiTro(object id)
        {
            return new TblVaiTroController().Delete(id);
        }
        public static TblVaiTro GwtVaiTroById(object id)
        {
            return new Select().From(TblVaiTro.Schema.TableName).Where(TblVaiTro.Columns.Id).
                IsEqualTo(id).OrderAsc(TblVaiTro.Columns.VaiTro).ExecuteSingle<TblVaiTro>();
        }
        public static List<TblVaiTro> GetListVaiTro()
        {
            return new Select().From(TblVaiTro.Schema.TableName).ExecuteTypedList<TblVaiTro>();
        }
        public static List<TblVaiTro> SearchListVaiTro(String a)
        {
            return new Select().From(TblVaiTro.Schema.TableName).Where(TblVaiTro.VaiTroColumn).Like("%" + a + "%").ExecuteTypedList<TblVaiTro>();

        }

    }
}
