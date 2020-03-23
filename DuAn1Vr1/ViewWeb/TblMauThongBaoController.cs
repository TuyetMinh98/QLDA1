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
    /// <summary>
    /// Controller class for TblMauThongBao
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class TblMauThongBaoController
    {
        // Preload our schema..
        TblMauThongBao thisSchemaLoad = new TblMauThongBao();
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
        public TblMauThongBaoCollection FetchAll()
        {
            TblMauThongBaoCollection coll = new TblMauThongBaoCollection();
            Query qry = new Query(TblMauThongBao.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMauThongBaoCollection FetchByID(object Id)
        {
            TblMauThongBaoCollection coll = new TblMauThongBaoCollection().Where("Id", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public TblMauThongBaoCollection FetchByQuery(Query qry)
        {
            TblMauThongBaoCollection coll = new TblMauThongBaoCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (TblMauThongBao.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (TblMauThongBao.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(Guid Id,string TenMauThongBao,string NoiDung,DateTime NgayTao,string NguoiTao,DateTime? NgayCapNhat,string NguoiCapNhat,bool TrangThai)
	    {
		    TblMauThongBao item = new TblMauThongBao();
		    
            item.Id = Id;
            
            item.TenMauThongBao = TenMauThongBao;
            
            item.NoiDung = NoiDung;
            
            item.NgayTao = NgayTao;
            
            item.NguoiTao = NguoiTao;
            
            item.NgayCapNhat = NgayCapNhat;
            
            item.NguoiCapNhat = NguoiCapNhat;
            
            item.TrangThai = TrangThai;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(Guid Id,string TenMauThongBao,string NoiDung,DateTime NgayTao,string NguoiTao,DateTime? NgayCapNhat,string NguoiCapNhat,bool TrangThai)
	    {
		    TblMauThongBao item = new TblMauThongBao();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.TenMauThongBao = TenMauThongBao;
				
			item.NoiDung = NoiDung;
				
			item.NgayTao = NgayTao;
				
			item.NguoiTao = NguoiTao;
				
			item.NgayCapNhat = NgayCapNhat;
				
			item.NguoiCapNhat = NguoiCapNhat;
				
			item.TrangThai = TrangThai;
				
	        item.Save(UserName);
	    }
    }
}
