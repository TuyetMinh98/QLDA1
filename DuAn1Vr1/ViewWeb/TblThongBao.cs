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
	/// Strongly-typed collection for the TblThongBao class.
	/// </summary>
    [Serializable]
	public partial class TblThongBaoCollection : ActiveList<TblThongBao, TblThongBaoCollection>
	{	   
		public TblThongBaoCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblThongBaoCollection</returns>
		public TblThongBaoCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblThongBao o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblThongBao table.
	/// </summary>
	[Serializable]
	public partial class TblThongBao : ActiveRecord<TblThongBao>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblThongBao()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblThongBao(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblThongBao(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblThongBao(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblThongBao", TableType.Table, DataService.GetInstance("ViewWeb"));
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
				
				TableSchema.TableColumn colvarIdNhanVien = new TableSchema.TableColumn(schema);
				colvarIdNhanVien.ColumnName = "IdNhanVien";
				colvarIdNhanVien.DataType = DbType.Guid;
				colvarIdNhanVien.MaxLength = 0;
				colvarIdNhanVien.AutoIncrement = false;
				colvarIdNhanVien.IsNullable = false;
				colvarIdNhanVien.IsPrimaryKey = false;
				colvarIdNhanVien.IsForeignKey = true;
				colvarIdNhanVien.IsReadOnly = false;
				colvarIdNhanVien.DefaultSetting = @"";
				
					colvarIdNhanVien.ForeignKeyTableName = "TblNhanVien";
				schema.Columns.Add(colvarIdNhanVien);
				
				TableSchema.TableColumn colvarThoiGian = new TableSchema.TableColumn(schema);
				colvarThoiGian.ColumnName = "ThoiGian";
				colvarThoiGian.DataType = DbType.DateTime;
				colvarThoiGian.MaxLength = 0;
				colvarThoiGian.AutoIncrement = false;
				colvarThoiGian.IsNullable = false;
				colvarThoiGian.IsPrimaryKey = false;
				colvarThoiGian.IsForeignKey = false;
				colvarThoiGian.IsReadOnly = false;
				colvarThoiGian.DefaultSetting = @"";
				colvarThoiGian.ForeignKeyTableName = "";
				schema.Columns.Add(colvarThoiGian);
				
				TableSchema.TableColumn colvarIdVanPhong = new TableSchema.TableColumn(schema);
				colvarIdVanPhong.ColumnName = "IdVanPhong";
				colvarIdVanPhong.DataType = DbType.Guid;
				colvarIdVanPhong.MaxLength = 0;
				colvarIdVanPhong.AutoIncrement = false;
				colvarIdVanPhong.IsNullable = false;
				colvarIdVanPhong.IsPrimaryKey = false;
				colvarIdVanPhong.IsForeignKey = true;
				colvarIdVanPhong.IsReadOnly = false;
				colvarIdVanPhong.DefaultSetting = @"";
				
					colvarIdVanPhong.ForeignKeyTableName = "TblVanPhong";
				schema.Columns.Add(colvarIdVanPhong);
				
				TableSchema.TableColumn colvarMoTa = new TableSchema.TableColumn(schema);
				colvarMoTa.ColumnName = "MoTa";
				colvarMoTa.DataType = DbType.Guid;
				colvarMoTa.MaxLength = 0;
				colvarMoTa.AutoIncrement = false;
				colvarMoTa.IsNullable = false;
				colvarMoTa.IsPrimaryKey = false;
				colvarMoTa.IsForeignKey = true;
				colvarMoTa.IsReadOnly = false;
				colvarMoTa.DefaultSetting = @"";
				
					colvarMoTa.ForeignKeyTableName = "TblMauThongBao";
				schema.Columns.Add(colvarMoTa);
				
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
				
				TableSchema.TableColumn colvarIdKhachhang = new TableSchema.TableColumn(schema);
				colvarIdKhachhang.ColumnName = "IdKhachhang";
				colvarIdKhachhang.DataType = DbType.Guid;
				colvarIdKhachhang.MaxLength = 0;
				colvarIdKhachhang.AutoIncrement = false;
				colvarIdKhachhang.IsNullable = true;
				colvarIdKhachhang.IsPrimaryKey = false;
				colvarIdKhachhang.IsForeignKey = false;
				colvarIdKhachhang.IsReadOnly = false;
				colvarIdKhachhang.DefaultSetting = @"";
				colvarIdKhachhang.ForeignKeyTableName = "";
				schema.Columns.Add(colvarIdKhachhang);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["ViewWeb"].AddSchema("TblThongBao",schema);
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
		  
		[XmlAttribute("IdNhanVien")]
		[Bindable(true)]
		public Guid IdNhanVien 
		{
			get { return GetColumnValue<Guid>(Columns.IdNhanVien); }
			set { SetColumnValue(Columns.IdNhanVien, value); }
		}
		  
		[XmlAttribute("ThoiGian")]
		[Bindable(true)]
		public DateTime ThoiGian 
		{
			get { return GetColumnValue<DateTime>(Columns.ThoiGian); }
			set { SetColumnValue(Columns.ThoiGian, value); }
		}
		  
		[XmlAttribute("IdVanPhong")]
		[Bindable(true)]
		public Guid IdVanPhong 
		{
			get { return GetColumnValue<Guid>(Columns.IdVanPhong); }
			set { SetColumnValue(Columns.IdVanPhong, value); }
		}
		  
		[XmlAttribute("MoTa")]
		[Bindable(true)]
		public Guid MoTa 
		{
			get { return GetColumnValue<Guid>(Columns.MoTa); }
			set { SetColumnValue(Columns.MoTa, value); }
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
		  
		[XmlAttribute("IdKhachhang")]
		[Bindable(true)]
		public Guid? IdKhachhang 
		{
			get { return GetColumnValue<Guid?>(Columns.IdKhachhang); }
			set { SetColumnValue(Columns.IdKhachhang, value); }
		}
		
		#endregion
		
		
			
		
		#region ForeignKey Properties
		
		/// <summary>
		/// Returns a TblNhanVien ActiveRecord object related to this TblThongBao
		/// 
		/// </summary>
		public Public.TblNhanVien TblNhanVien
		{
			get { return Public.TblNhanVien.FetchByID(this.IdNhanVien); }
			set { SetColumnValue("IdNhanVien", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a TblVanPhong ActiveRecord object related to this TblThongBao
		/// 
		/// </summary>
		public Public.TblVanPhong TblVanPhong
		{
			get { return Public.TblVanPhong.FetchByID(this.IdVanPhong); }
			set { SetColumnValue("IdVanPhong", value.Id); }
		}
		
		
		/// <summary>
		/// Returns a TblMauThongBao ActiveRecord object related to this TblThongBao
		/// 
		/// </summary>
		public Public.TblMauThongBao TblMauThongBao
		{
			get { return Public.TblMauThongBao.FetchByID(this.MoTa); }
			set { SetColumnValue("MoTa", value.Id); }
		}
		
		
		#endregion
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varId,Guid varIdNhanVien,DateTime varThoiGian,Guid varIdVanPhong,Guid varMoTa,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai,Guid? varIdKhachhang)
		{
			TblThongBao item = new TblThongBao();
			
			item.Id = varId;
			
			item.IdNhanVien = varIdNhanVien;
			
			item.ThoiGian = varThoiGian;
			
			item.IdVanPhong = varIdVanPhong;
			
			item.MoTa = varMoTa;
			
			item.NgayTao = varNgayTao;
			
			item.NguoiTao = varNguoiTao;
			
			item.NgayCapNhat = varNgayCapNhat;
			
			item.NguoiCapNhat = varNguoiCapNhat;
			
			item.TrangThai = varTrangThai;
			
			item.IdKhachhang = varIdKhachhang;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(Guid varId,Guid varIdNhanVien,DateTime varThoiGian,Guid varIdVanPhong,Guid varMoTa,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai,Guid? varIdKhachhang)
		{
			TblThongBao item = new TblThongBao();
			
				item.Id = varId;
			
				item.IdNhanVien = varIdNhanVien;
			
				item.ThoiGian = varThoiGian;
			
				item.IdVanPhong = varIdVanPhong;
			
				item.MoTa = varMoTa;
			
				item.NgayTao = varNgayTao;
			
				item.NguoiTao = varNguoiTao;
			
				item.NgayCapNhat = varNgayCapNhat;
			
				item.NguoiCapNhat = varNguoiCapNhat;
			
				item.TrangThai = varTrangThai;
			
				item.IdKhachhang = varIdKhachhang;
			
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
        
        
        
        public static TableSchema.TableColumn IdNhanVienColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn ThoiGianColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn IdVanPhongColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn MoTaColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayCapNhatColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiCapNhatColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangThaiColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn IdKhachhangColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"Id";
			 public static string IdNhanVien = @"IdNhanVien";
			 public static string ThoiGian = @"ThoiGian";
			 public static string IdVanPhong = @"IdVanPhong";
			 public static string MoTa = @"MoTa";
			 public static string NgayTao = @"NgayTao";
			 public static string NguoiTao = @"NguoiTao";
			 public static string NgayCapNhat = @"NgayCapNhat";
			 public static string NguoiCapNhat = @"NguoiCapNhat";
			 public static string TrangThai = @"TrangThai";
			 public static string IdKhachhang = @"IdKhachhang";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}