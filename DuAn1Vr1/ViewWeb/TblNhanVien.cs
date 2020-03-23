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
	/// Strongly-typed collection for the TblNhanVien class.
	/// </summary>
    [Serializable]
	public partial class TblNhanVienCollection : ActiveList<TblNhanVien, TblNhanVienCollection>
	{	   
		public TblNhanVienCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>TblNhanVienCollection</returns>
		public TblNhanVienCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                TblNhanVien o = this[i];
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
	/// This is an ActiveRecord class which wraps the TblNhanVien table.
	/// </summary>
	[Serializable]
	public partial class TblNhanVien : ActiveRecord<TblNhanVien>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public TblNhanVien()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public TblNhanVien(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public TblNhanVien(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public TblNhanVien(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("TblNhanVien", TableType.Table, DataService.GetInstance("ViewWeb"));
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
				
				TableSchema.TableColumn colvarHoNhanVien = new TableSchema.TableColumn(schema);
				colvarHoNhanVien.ColumnName = "HoNhanVien";
				colvarHoNhanVien.DataType = DbType.String;
				colvarHoNhanVien.MaxLength = 10;
				colvarHoNhanVien.AutoIncrement = false;
				colvarHoNhanVien.IsNullable = false;
				colvarHoNhanVien.IsPrimaryKey = false;
				colvarHoNhanVien.IsForeignKey = false;
				colvarHoNhanVien.IsReadOnly = false;
				colvarHoNhanVien.DefaultSetting = @"";
				colvarHoNhanVien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarHoNhanVien);
				
				TableSchema.TableColumn colvarTenNhanVien = new TableSchema.TableColumn(schema);
				colvarTenNhanVien.ColumnName = "TenNhanVien";
				colvarTenNhanVien.DataType = DbType.String;
				colvarTenNhanVien.MaxLength = 50;
				colvarTenNhanVien.AutoIncrement = false;
				colvarTenNhanVien.IsNullable = false;
				colvarTenNhanVien.IsPrimaryKey = false;
				colvarTenNhanVien.IsForeignKey = false;
				colvarTenNhanVien.IsReadOnly = false;
				colvarTenNhanVien.DefaultSetting = @"";
				colvarTenNhanVien.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTenNhanVien);
				
				TableSchema.TableColumn colvarNamSinh = new TableSchema.TableColumn(schema);
				colvarNamSinh.ColumnName = "NamSinh";
				colvarNamSinh.DataType = DbType.DateTime;
				colvarNamSinh.MaxLength = 0;
				colvarNamSinh.AutoIncrement = false;
				colvarNamSinh.IsNullable = false;
				colvarNamSinh.IsPrimaryKey = false;
				colvarNamSinh.IsForeignKey = false;
				colvarNamSinh.IsReadOnly = false;
				colvarNamSinh.DefaultSetting = @"";
				colvarNamSinh.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNamSinh);
				
				TableSchema.TableColumn colvarNgayVaoLam = new TableSchema.TableColumn(schema);
				colvarNgayVaoLam.ColumnName = "NgayVaoLam";
				colvarNgayVaoLam.DataType = DbType.DateTime;
				colvarNgayVaoLam.MaxLength = 0;
				colvarNgayVaoLam.AutoIncrement = false;
				colvarNgayVaoLam.IsNullable = false;
				colvarNgayVaoLam.IsPrimaryKey = false;
				colvarNgayVaoLam.IsForeignKey = false;
				colvarNgayVaoLam.IsReadOnly = false;
				colvarNgayVaoLam.DefaultSetting = @"";
				colvarNgayVaoLam.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNgayVaoLam);
				
				TableSchema.TableColumn colvarSdt = new TableSchema.TableColumn(schema);
				colvarSdt.ColumnName = "SDT";
				colvarSdt.DataType = DbType.String;
				colvarSdt.MaxLength = 12;
				colvarSdt.AutoIncrement = false;
				colvarSdt.IsNullable = true;
				colvarSdt.IsPrimaryKey = false;
				colvarSdt.IsForeignKey = false;
				colvarSdt.IsReadOnly = false;
				colvarSdt.DefaultSetting = @"";
				colvarSdt.ForeignKeyTableName = "";
				schema.Columns.Add(colvarSdt);
				
				TableSchema.TableColumn colvarEmail = new TableSchema.TableColumn(schema);
				colvarEmail.ColumnName = "Email";
				colvarEmail.DataType = DbType.String;
				colvarEmail.MaxLength = 50;
				colvarEmail.AutoIncrement = false;
				colvarEmail.IsNullable = false;
				colvarEmail.IsPrimaryKey = false;
				colvarEmail.IsForeignKey = false;
				colvarEmail.IsReadOnly = false;
				colvarEmail.DefaultSetting = @"";
				colvarEmail.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEmail);
				
				TableSchema.TableColumn colvarDiaChi = new TableSchema.TableColumn(schema);
				colvarDiaChi.ColumnName = "DiaChi";
				colvarDiaChi.DataType = DbType.String;
				colvarDiaChi.MaxLength = 50;
				colvarDiaChi.AutoIncrement = false;
				colvarDiaChi.IsNullable = false;
				colvarDiaChi.IsPrimaryKey = false;
				colvarDiaChi.IsForeignKey = false;
				colvarDiaChi.IsReadOnly = false;
				colvarDiaChi.DefaultSetting = @"";
				colvarDiaChi.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDiaChi);
				
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
				DataService.Providers["ViewWeb"].AddSchema("TblNhanVien",schema);
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
		  
		[XmlAttribute("HoNhanVien")]
		[Bindable(true)]
		public string HoNhanVien 
		{
			get { return GetColumnValue<string>(Columns.HoNhanVien); }
			set { SetColumnValue(Columns.HoNhanVien, value); }
		}
		  
		[XmlAttribute("TenNhanVien")]
		[Bindable(true)]
		public string TenNhanVien 
		{
			get { return GetColumnValue<string>(Columns.TenNhanVien); }
			set { SetColumnValue(Columns.TenNhanVien, value); }
		}
		  
		[XmlAttribute("NamSinh")]
		[Bindable(true)]
		public DateTime NamSinh 
		{
			get { return GetColumnValue<DateTime>(Columns.NamSinh); }
			set { SetColumnValue(Columns.NamSinh, value); }
		}
		  
		[XmlAttribute("NgayVaoLam")]
		[Bindable(true)]
		public DateTime NgayVaoLam 
		{
			get { return GetColumnValue<DateTime>(Columns.NgayVaoLam); }
			set { SetColumnValue(Columns.NgayVaoLam, value); }
		}
		  
		[XmlAttribute("Sdt")]
		[Bindable(true)]
		public string Sdt 
		{
			get { return GetColumnValue<string>(Columns.Sdt); }
			set { SetColumnValue(Columns.Sdt, value); }
		}
		  
		[XmlAttribute("Email")]
		[Bindable(true)]
		public string Email 
		{
			get { return GetColumnValue<string>(Columns.Email); }
			set { SetColumnValue(Columns.Email, value); }
		}
		  
		[XmlAttribute("DiaChi")]
		[Bindable(true)]
		public string DiaChi 
		{
			get { return GetColumnValue<string>(Columns.DiaChi); }
			set { SetColumnValue(Columns.DiaChi, value); }
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
        
		
		public Public.TblBinhLuanCollection TblBinhLuanRecords()
		{
			return new Public.TblBinhLuanCollection().Where(TblBinhLuan.Columns.IdNguoiBinhLuan, Id).Load();
		}
		public Public.TblNguoiDungCollection TblNguoiDungRecords()
		{
			return new Public.TblNguoiDungCollection().Where(TblNguoiDung.Columns.IdNhanVien, Id).Load();
		}
		public Public.TblThongBaoCollection TblThongBaoRecords()
		{
			return new Public.TblThongBaoCollection().Where(TblThongBao.Columns.IdNhanVien, Id).Load();
		}
		#endregion
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(Guid varId,string varHoNhanVien,string varTenNhanVien,DateTime varNamSinh,DateTime varNgayVaoLam,string varSdt,string varEmail,string varDiaChi,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai)
		{
			TblNhanVien item = new TblNhanVien();
			
			item.Id = varId;
			
			item.HoNhanVien = varHoNhanVien;
			
			item.TenNhanVien = varTenNhanVien;
			
			item.NamSinh = varNamSinh;
			
			item.NgayVaoLam = varNgayVaoLam;
			
			item.Sdt = varSdt;
			
			item.Email = varEmail;
			
			item.DiaChi = varDiaChi;
			
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
		public static void Update(Guid varId,string varHoNhanVien,string varTenNhanVien,DateTime varNamSinh,DateTime varNgayVaoLam,string varSdt,string varEmail,string varDiaChi,DateTime varNgayTao,string varNguoiTao,DateTime? varNgayCapNhat,string varNguoiCapNhat,bool varTrangThai)
		{
			TblNhanVien item = new TblNhanVien();
			
				item.Id = varId;
			
				item.HoNhanVien = varHoNhanVien;
			
				item.TenNhanVien = varTenNhanVien;
			
				item.NamSinh = varNamSinh;
			
				item.NgayVaoLam = varNgayVaoLam;
			
				item.Sdt = varSdt;
			
				item.Email = varEmail;
			
				item.DiaChi = varDiaChi;
			
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
        
        
        
        public static TableSchema.TableColumn HoNhanVienColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TenNhanVienColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn NamSinhColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayVaoLamColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn SdtColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn EmailColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn DiaChiColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayTaoColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiTaoColumn
        {
            get { return Schema.Columns[9]; }
        }
        
        
        
        public static TableSchema.TableColumn NgayCapNhatColumn
        {
            get { return Schema.Columns[10]; }
        }
        
        
        
        public static TableSchema.TableColumn NguoiCapNhatColumn
        {
            get { return Schema.Columns[11]; }
        }
        
        
        
        public static TableSchema.TableColumn TrangThaiColumn
        {
            get { return Schema.Columns[12]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"Id";
			 public static string HoNhanVien = @"HoNhanVien";
			 public static string TenNhanVien = @"TenNhanVien";
			 public static string NamSinh = @"NamSinh";
			 public static string NgayVaoLam = @"NgayVaoLam";
			 public static string Sdt = @"SDT";
			 public static string Email = @"Email";
			 public static string DiaChi = @"DiaChi";
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
