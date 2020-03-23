using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubSonic;
using Public;
namespace Bussiness
{
    public class MauThongBaoBussiness
    {
        public static object ViewWeb { get; private set; }

        public static TblMauThongBao InsertMauThongBao(TblMauThongBao item)
        {
            return new TblMauThongBaoController().Insert(item);
        }
        public static TblMauThongBao UpdateMauThongBao(TblMauThongBao item)
        {
            return new TblMauThongBaoController().Update(item);
        }
        public static bool DeleteMauThongBao(object id)
        {
            return new TblMauThongBaoController().Delete(id);
        }
        public static TblMauThongBao GwtMauThongBaoById(object id)
        {
            return new Select().From(TblMauThongBao.Schema.TableName).Where(TblMauThongBao.Columns.Id).
                IsEqualTo(id).OrderAsc(TblMauThongBao.Columns.TenMauThongBao).ExecuteSingle<TblMauThongBao>();
        }
        public static List<TblMauThongBao> GetListMauThongBao()
        {
            return new Select().From(TblMauThongBao.Schema.TableName).ExecuteTypedList<TblMauThongBao>();
        }
        public static List<TblMauThongBao> SearchListMauThongBao(String a)
        {

            return new Select().From(TblMauThongBao.Schema.TableName).Where(TblMauThongBao.TenMauThongBaoColumn).Like("%" + a + "%").ExecuteTypedList<TblMauThongBao>();

        }

    }
}