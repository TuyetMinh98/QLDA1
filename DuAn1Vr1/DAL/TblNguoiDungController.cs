using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace Public
{
    public partial class TblNguoiDung
    {
        public string HoNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string VaiTro { get; set; }
    }
    /// <summary>
    /// Controller class for TblNguoiDung
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblNguoiDungController
    {
        // Preload our schema..
        TblNguoiDung thisSchemaLoad = new TblNguoiDung();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public TblNguoiDungCollection FetchAll()
        {
            TblNguoiDungCollection coll = new TblNguoiDungCollection();
            Query qry = new Query(TblNguoiDung.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNguoiDungCollection FetchByID(object Id)
        {
            TblNguoiDungCollection coll = new TblNguoiDungCollection().Where("Id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblNguoiDungCollection FetchByQuery(Query qry)
        {
            TblNguoiDungCollection coll = new TblNguoiDungCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TblNguoiDung.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TblNguoiDung.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public TblNguoiDung Insert(TblNguoiDung item)
	    {
            item.Save(UserName);
            return item;
        }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public TblNguoiDung Update(TblNguoiDung item)
	    {
            item.Save(UserName);
            return item;
        }
    }
}
