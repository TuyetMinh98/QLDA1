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
	/// Strongly-typed collection for the TblMauThongBao class.
	/// </summary>
    [Serializable]
	public partial class TblMauThongBaoCollection : ActiveList<TblMauThongBao, TblMauThongBaoCollection>
	{	   
		public TblMauThongBaoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblMauThongBaoCollection</returns>
		public TblMauThongBaoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblMauThongBao o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the TblMauThongBao table.
	/// </summary>
	[Serializable]
	public partial class TblMauThongBao : ActiveRecord<TblMauThongBao>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblMauThongBao()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblMauThongBao(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblMauThongBao(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblMauThongBao(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("TblMauThongBao", TableType.Table, DataService.GetInstance("ViewWeb"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "Id";
				colvarId.DataType = DbType.Guid;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = false;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarTenMauThongBao = new TableSchema.TableColumn(schema);
				colvarTenMauThongBao.ColumnName = "TenMauThongBao";
				colvarTenMauThongBao.DataType = DbType.String;
				colvarTenMauThongBao.MaxLength = 100;
				colvarTenMauThongBao.AutoIncrement = false;
				colvarTenMauThongBao.IsNullable = false;
				colvarTenMauThongBao.IsPrimaryKey = false;
				colvarTenMauThongBao.IsForeignKey = false;
				colvarTenMauThongBao.IsReadOnly = false;
				colvarTenMauThongBao.DefaultSetting = @"";
				colvarTenMauThongBao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenMauThongBao);
				
				TableSchema.TableColumn colvarNoiDung = new TableSchema.TableColumn(schema);
				colvarNoiDung.ColumnName = "NoiDung";
				colvarNoiDung.DataType = DbType.String;
				colvarNoiDung.MaxLength = 1073741823;
				colvarNoiDung.AutoIncrement = false;
				colvarNoiDung.IsNullable = false;
				colvarNoiDung.IsPrimaryKey = false;
				colvarNoiDung.IsForeignKey = false;
				colvarNoiDung.IsReadOnly = false;
				colvarNoiDung.DefaultSetting = @"";
				colvarNoiDung.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNoiDung);
				
				TableSchema.TableColumn colvarNgayTao = new TableSchema.TableColumn(schema);
				colvarNgayTao.ColumnName = "NgayTao";
				colvarNgayTao.DataType = DbType.DateTime;
				colvarNgayTao.MaxLength = 0;
				colvarNgayTao.AutoIncrement = false;
				colvarNgayTao.IsNullable = false;
				colvarNgayTao.IsPrimaryKey = false;
				colvarNgayTao.IsForeignKey = false;
				colvarNgayTao.IsReadOnly = false;
				colvarNgayTao.DefaultSetting = @"";
				colvarNgayTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayTao);
				
				TableSchema.TableColumn colvarNguoiTao = new TableSchema.TableColumn(schema);
				colvarNguoiTao.ColumnName = "NguoiTao";
				colvarNguoiTao.DataType = DbType.String;
				colvarNguoiTao.MaxLength = 50;
				colvarNguoiTao.AutoIncrement = false;
				colvarNguoiTao.IsNullable = false;
				colvarNguoiTao.IsPrimaryKey = false;
				colvarNguoiTao.IsForeignKey = false;
				colvarNguoiTao.IsReadOnly = false;
				colvarNguoiTao.DefaultSetting = @"";
				colvarNguoiTao.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiTao);
				
				TableSchema.TableColumn colvarNgayCapNhat = new TableSchema.TableColumn(schema);
				colvarNgayCapNhat.ColumnName = "NgayCapNhat";
				colvarNgayCapNhat.DataType = DbType.DateTime;
				colvarNgayCapNhat.MaxLength = 0;
				colvarNgayCapNhat.AutoIncrement = false;
				colvarNgayCapNhat.IsNullable = true;
				colvarNgayCapNhat.IsPrimaryKey = false;
				colvarNgayCapNhat.IsForeignKey = false;
				colvarNgayCapNhat.IsReadOnly = false;
				colvarNgayCapNhat.DefaultSetting = @"";
				colvarNgayCapNhat.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayCapNhat);
				
				TableSchema.TableColumn colvarNguoiCapNhat = new TableSchema.TableColumn(schema);
				colvarNguoiCapNhat.ColumnName = "NguoiCapNhat";
				colvarNguoiCapNhat.DataType = DbType.String;
				colvarNguoiCapNhat.MaxLength = 50;
				colvarNguoiCapNhat.AutoIncrement = false;
				colvarNguoiCapNhat.IsNullable = true;
				colvarNguoiCapNhat.IsPrimaryKey = false;
				colvarNguoiCapNhat.IsForeignKey = false;
				colvarNguoiCapNhat.IsReadOnly = false;
				colvarNguoiCapNhat.DefaultSetting = @"";
				colvarNguoiCapNhat.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNguoiCapNhat);
				
				TableSchema.TableColumn colvarTrangThai = new TableSchema.TableColumn(schema);
				colvarTrangThai.ColumnName = "TrangThai";
				colvarTrangThai.DataType = DbType.Boolean;
				colvarTrangThai.MaxLength = 0;
				colvarTrangThai.AutoIncrement = false;
				colvarTrangThai.IsNullable = false;
				colvarTrangThai.IsPrimaryKey = false;
				colvarTrangThai.IsForeignKey = false;
				colvarTrangThai.IsReadOnly = false;
				colvarTrangThai.DefaultSetting = @"";
				colvarTrangThai.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTrangThai);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ViewWeb"].AddSchema("TblMauThongBao",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public Guid Id 
		{
			get { return GetColumnValue<Guid>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("TenMauThongBao")]
		[Bindable(true)]
		public string TenMauThongBao 
		{
			get { return GetColumnValue<string>(Columns.TenMauThongBao); }
			set { SetColumnValue(Columns.TenMauThongBao, value); }
		}
		  
		[XmlAttribute("NoiDung")]
		[Bindable(true)]
		public string NoiDung 
		{
			get { return GetColumnValue<string>(Columns.NoiDung); }
			set { SetColumnValue(Columns.NoiDung, value); }
		}
		  
		[XmlAttribute("NgayTao")]
		[Bindable(true)]
		public DateTime NgayTao 
		{
			get { return GetColumnValue<DateTime>(Columns.NgayTao); }
			set { SetColumnValue(Columns.NgayTao, value); }
		}
		  
		[XmlAttribute("NguoiTao")]
		[Bindable(true)]
		public string NguoiTao 
		{
			get { return GetColumnValue<string>(Columns.NguoiTao); }
			set { SetColumnValue(Columns.NguoiTao, value); }
		}
		  
		[XmlAttribute("NgayCapNhat")]
		[Bindable(true)]
		public DateTime? NgayCapNhat 
		{
			get { return GetColumnValue<DateTime?>(Columns.NgayCapNhat); }
			set { SetColumnValue(Columns.NgayCapNhat, value); }
		}
		  
		[XmlAttribute("NguoiCapNhat")]
		[Bindable(true)]
		public string NguoiCapNhat 
		{
			get { return GetColumnValue<string>(Columns.NguoiCapNhat); }
			set { SetColumnValue(Columns.NguoiCapNhat, value); }
		}
		  
		[XmlAttribute("TrangThai")]
		[Bindable(true)]
		public bool TrangThai 
		{
			get { return GetColumnValue<bool>(Columns.TrangThai); }
			set { SetColumnValue(Columns.TrangThai, value); }
		}
		
		#endregion
		
		
		#region PrimaryKey Methods		
		
        protected override void SetPrimaryKey(object oValue)
        {
            base.SetPrimaryKey(oValue);
            
            SetPKValues();
        }
        
		
		public Public.TblThongBaoCollection TblThongBaoRecords()
		{
			return new Public.TblThongBaoCollection().Where(TblThongBao.Columns.MoTa, Id).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varId,string varTenMauThongBao,string varNoiDung,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai)
		{
			TblMauThongBao item = new TblMauThongBao();
			
			item.Id = varId;
			
			item.TenMauThongBao = varTenMauThongBao;
			
			item.NoiDung = varNoiDung;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayCapNhat = varNgayCapNhat;
			
			item.NguoiCapNhat = varNguoiCapNhat;
			
			item.TrangThai = varTrangThai;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varId,string varTenMauThongBao,string varNoiDung,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai)
		{
			TblMauThongBao item = new TblMauThongBao();
			
				item.Id = varId;
			
				item.TenMauThongBao = varTenMauThongBao;
			
				item.NoiDung = varNoiDung;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayCapNhat = varNgayCapNhat;
			
				item.NguoiCapNhat = varNguoiCapNhat;
			
				item.TrangThai = varTrangThai;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn TenMauThongBaoColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn NoiDungColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayCapNhatColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiCapNhatColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangThaiColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"Id";
			 public static string TenMauThongBao = @"TenMauThongBao";
			 public static string NoiDung = @"NoiDung";
			 public static string NgayTao = @"NgayTao";
			 public static string NguoiTao = @"NguoiTao";
			 public static string NgayCapNhat = @"NgayCapNhat";
			 public static string NguoiCapNhat = @"NguoiCapNhat";
			 public static string TrangThai = @"TrangThai";
						
		}
		#endregion
		
		#region Update PK Collections
		
        public void SetPKValues()
        {
}
        #endregion
    
        #region Deep Save
		
        public void DeepSave()
        {
            Save();
            
}
        #endregion
	}
}
