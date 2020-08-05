﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="qlhocbong")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttlb_bomon(tlb_bomon instance);
    partial void Updatetlb_bomon(tlb_bomon instance);
    partial void Deletetlb_bomon(tlb_bomon instance);
    partial void Inserttlb_diemhk(tlb_diemhk instance);
    partial void Updatetlb_diemhk(tlb_diemhk instance);
    partial void Deletetlb_diemhk(tlb_diemhk instance);
    partial void Inserttlb_hocbong(tlb_hocbong instance);
    partial void Updatetlb_hocbong(tlb_hocbong instance);
    partial void Deletetlb_hocbong(tlb_hocbong instance);
    partial void Inserttlb_lop(tlb_lop instance);
    partial void Updatetlb_lop(tlb_lop instance);
    partial void Deletetlb_lop(tlb_lop instance);
    partial void Inserttlb_nganh(tlb_nganh instance);
    partial void Updatetlb_nganh(tlb_nganh instance);
    partial void Deletetlb_nganh(tlb_nganh instance);
    partial void Inserttlb_user(tlb_user instance);
    partial void Updatetlb_user(tlb_user instance);
    partial void Deletetlb_user(tlb_user instance);
    partial void Inserttlb_sinhvien(tlb_sinhvien instance);
    partial void Updatetlb_sinhvien(tlb_sinhvien instance);
    partial void Deletetlb_sinhvien(tlb_sinhvien instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::ClassLibrary1.Properties.Settings.Default.qlhocbongConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tlb_bomon> tlb_bomons
		{
			get
			{
				return this.GetTable<tlb_bomon>();
			}
		}
		
		public System.Data.Linq.Table<tlb_diemhk> tlb_diemhks
		{
			get
			{
				return this.GetTable<tlb_diemhk>();
			}
		}
		
		public System.Data.Linq.Table<tlb_hocbong> tlb_hocbongs
		{
			get
			{
				return this.GetTable<tlb_hocbong>();
			}
		}
		
		public System.Data.Linq.Table<tlb_lop> tlb_lops
		{
			get
			{
				return this.GetTable<tlb_lop>();
			}
		}
		
		public System.Data.Linq.Table<tlb_nganh> tlb_nganhs
		{
			get
			{
				return this.GetTable<tlb_nganh>();
			}
		}
		
		public System.Data.Linq.Table<tlb_user> tlb_users
		{
			get
			{
				return this.GetTable<tlb_user>();
			}
		}
		
		public System.Data.Linq.Table<tlb_sinhvien> tlb_sinhviens
		{
			get
			{
				return this.GetTable<tlb_sinhvien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_bomon")]
	public partial class tlb_bomon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ma_bm;
		
		private string _ten_bn;
		
		private EntitySet<tlb_nganh> _tlb_nganhs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onma_bmChanging(string value);
    partial void Onma_bmChanged();
    partial void Onten_bnChanging(string value);
    partial void Onten_bnChanged();
    #endregion
		
		public tlb_bomon()
		{
			this._tlb_nganhs = new EntitySet<tlb_nganh>(new Action<tlb_nganh>(this.attach_tlb_nganhs), new Action<tlb_nganh>(this.detach_tlb_nganhs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ma_bm", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ma_bm
		{
			get
			{
				return this._ma_bm;
			}
			set
			{
				if ((this._ma_bm != value))
				{
					this.Onma_bmChanging(value);
					this.SendPropertyChanging();
					this._ma_bm = value;
					this.SendPropertyChanged("ma_bm");
					this.Onma_bmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten_bn", DbType="NVarChar(100)")]
		public string ten_bn
		{
			get
			{
				return this._ten_bn;
			}
			set
			{
				if ((this._ten_bn != value))
				{
					this.Onten_bnChanging(value);
					this.SendPropertyChanging();
					this._ten_bn = value;
					this.SendPropertyChanged("ten_bn");
					this.Onten_bnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_bomon_tlb_nganh", Storage="_tlb_nganhs", ThisKey="ma_bm", OtherKey="ma_bm")]
		public EntitySet<tlb_nganh> tlb_nganhs
		{
			get
			{
				return this._tlb_nganhs;
			}
			set
			{
				this._tlb_nganhs.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tlb_nganhs(tlb_nganh entity)
		{
			this.SendPropertyChanging();
			entity.tlb_bomon = this;
		}
		
		private void detach_tlb_nganhs(tlb_nganh entity)
		{
			this.SendPropertyChanging();
			entity.tlb_bomon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_diemhk")]
	public partial class tlb_diemhk : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Mabangdiem;
		
		private string _MSSV;
		
		private string _HK;
		
		private string _Namhoc;
		
		private System.Nullable<double> _DiemTB;
		
		private System.Nullable<double> _DiemRL;
		
		private string _Xeploai;
		
		private EntityRef<tlb_sinhvien> _tlb_sinhvien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMabangdiemChanging(int value);
    partial void OnMabangdiemChanged();
    partial void OnMSSVChanging(string value);
    partial void OnMSSVChanged();
    partial void OnHKChanging(string value);
    partial void OnHKChanged();
    partial void OnNamhocChanging(string value);
    partial void OnNamhocChanged();
    partial void OnDiemTBChanging(System.Nullable<double> value);
    partial void OnDiemTBChanged();
    partial void OnDiemRLChanging(System.Nullable<double> value);
    partial void OnDiemRLChanged();
    partial void OnXeploaiChanging(string value);
    partial void OnXeploaiChanged();
    #endregion
		
		public tlb_diemhk()
		{
			this._tlb_sinhvien = default(EntityRef<tlb_sinhvien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mabangdiem", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Mabangdiem
		{
			get
			{
				return this._Mabangdiem;
			}
			set
			{
				if ((this._Mabangdiem != value))
				{
					this.OnMabangdiemChanging(value);
					this.SendPropertyChanging();
					this._Mabangdiem = value;
					this.SendPropertyChanged("Mabangdiem");
					this.OnMabangdiemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MSSV", DbType="NVarChar(10)")]
		public string MSSV
		{
			get
			{
				return this._MSSV;
			}
			set
			{
				if ((this._MSSV != value))
				{
					if (this._tlb_sinhvien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMSSVChanging(value);
					this.SendPropertyChanging();
					this._MSSV = value;
					this.SendPropertyChanged("MSSV");
					this.OnMSSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HK", DbType="NVarChar(20)")]
		public string HK
		{
			get
			{
				return this._HK;
			}
			set
			{
				if ((this._HK != value))
				{
					this.OnHKChanging(value);
					this.SendPropertyChanging();
					this._HK = value;
					this.SendPropertyChanged("HK");
					this.OnHKChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Namhoc", DbType="NVarChar(20)")]
		public string Namhoc
		{
			get
			{
				return this._Namhoc;
			}
			set
			{
				if ((this._Namhoc != value))
				{
					this.OnNamhocChanging(value);
					this.SendPropertyChanging();
					this._Namhoc = value;
					this.SendPropertyChanged("Namhoc");
					this.OnNamhocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemTB", DbType="Float")]
		public System.Nullable<double> DiemTB
		{
			get
			{
				return this._DiemTB;
			}
			set
			{
				if ((this._DiemTB != value))
				{
					this.OnDiemTBChanging(value);
					this.SendPropertyChanging();
					this._DiemTB = value;
					this.SendPropertyChanged("DiemTB");
					this.OnDiemTBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiemRL", DbType="Float")]
		public System.Nullable<double> DiemRL
		{
			get
			{
				return this._DiemRL;
			}
			set
			{
				if ((this._DiemRL != value))
				{
					this.OnDiemRLChanging(value);
					this.SendPropertyChanging();
					this._DiemRL = value;
					this.SendPropertyChanged("DiemRL");
					this.OnDiemRLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Xeploai", DbType="NVarChar(10)")]
		public string Xeploai
		{
			get
			{
				return this._Xeploai;
			}
			set
			{
				if ((this._Xeploai != value))
				{
					this.OnXeploaiChanging(value);
					this.SendPropertyChanging();
					this._Xeploai = value;
					this.SendPropertyChanged("Xeploai");
					this.OnXeploaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_diemhk", Storage="_tlb_sinhvien", ThisKey="MSSV", OtherKey="MaSV", IsForeignKey=true)]
		public tlb_sinhvien tlb_sinhvien
		{
			get
			{
				return this._tlb_sinhvien.Entity;
			}
			set
			{
				tlb_sinhvien previousValue = this._tlb_sinhvien.Entity;
				if (((previousValue != value) 
							|| (this._tlb_sinhvien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_sinhvien.Entity = null;
						previousValue.tlb_diemhks.Remove(this);
					}
					this._tlb_sinhvien.Entity = value;
					if ((value != null))
					{
						value.tlb_diemhks.Add(this);
						this._MSSV = value.MaSV;
					}
					else
					{
						this._MSSV = default(string);
					}
					this.SendPropertyChanged("tlb_sinhvien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_hocbong")]
	public partial class tlb_hocbong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _MaSV;
		
		private string _hoancanh;
		
		private string _dienkhokhan;
		
		private string _hientrang;
		
		private string _SDT;
		
		private string _STKNH;
		
		private string _TenNH;
		
		private EntityRef<tlb_sinhvien> _tlb_sinhvien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnhoancanhChanging(string value);
    partial void OnhoancanhChanged();
    partial void OndienkhokhanChanging(string value);
    partial void OndienkhokhanChanged();
    partial void OnhientrangChanging(string value);
    partial void OnhientrangChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnSTKNHChanging(string value);
    partial void OnSTKNHChanged();
    partial void OnTenNHChanging(string value);
    partial void OnTenNHChanged();
    #endregion
		
		public tlb_hocbong()
		{
			this._tlb_sinhvien = default(EntityRef<tlb_sinhvien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(10)")]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					if (this._tlb_sinhvien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hoancanh", DbType="NVarChar(50)")]
		public string hoancanh
		{
			get
			{
				return this._hoancanh;
			}
			set
			{
				if ((this._hoancanh != value))
				{
					this.OnhoancanhChanging(value);
					this.SendPropertyChanging();
					this._hoancanh = value;
					this.SendPropertyChanged("hoancanh");
					this.OnhoancanhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dienkhokhan", DbType="NVarChar(50)")]
		public string dienkhokhan
		{
			get
			{
				return this._dienkhokhan;
			}
			set
			{
				if ((this._dienkhokhan != value))
				{
					this.OndienkhokhanChanging(value);
					this.SendPropertyChanging();
					this._dienkhokhan = value;
					this.SendPropertyChanged("dienkhokhan");
					this.OndienkhokhanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_hientrang", DbType="NVarChar(50)")]
		public string hientrang
		{
			get
			{
				return this._hientrang;
			}
			set
			{
				if ((this._hientrang != value))
				{
					this.OnhientrangChanging(value);
					this.SendPropertyChanging();
					this._hientrang = value;
					this.SendPropertyChanged("hientrang");
					this.OnhientrangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="NVarChar(10)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_STKNH", DbType="NVarChar(10)")]
		public string STKNH
		{
			get
			{
				return this._STKNH;
			}
			set
			{
				if ((this._STKNH != value))
				{
					this.OnSTKNHChanging(value);
					this.SendPropertyChanging();
					this._STKNH = value;
					this.SendPropertyChanged("STKNH");
					this.OnSTKNHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNH", DbType="NVarChar(10)")]
		public string TenNH
		{
			get
			{
				return this._TenNH;
			}
			set
			{
				if ((this._TenNH != value))
				{
					this.OnTenNHChanging(value);
					this.SendPropertyChanging();
					this._TenNH = value;
					this.SendPropertyChanged("TenNH");
					this.OnTenNHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_hocbong", Storage="_tlb_sinhvien", ThisKey="MaSV", OtherKey="MaSV", IsForeignKey=true)]
		public tlb_sinhvien tlb_sinhvien
		{
			get
			{
				return this._tlb_sinhvien.Entity;
			}
			set
			{
				tlb_sinhvien previousValue = this._tlb_sinhvien.Entity;
				if (((previousValue != value) 
							|| (this._tlb_sinhvien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_sinhvien.Entity = null;
						previousValue.tlb_hocbongs.Remove(this);
					}
					this._tlb_sinhvien.Entity = value;
					if ((value != null))
					{
						value.tlb_hocbongs.Add(this);
						this._MaSV = value.MaSV;
					}
					else
					{
						this._MaSV = default(string);
					}
					this.SendPropertyChanged("tlb_sinhvien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_lop")]
	public partial class tlb_lop : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLop;
		
		private string _Tenlop;
		
		private string _ma_nganh;
		
		private EntitySet<tlb_sinhvien> _tlb_sinhviens;
		
		private EntityRef<tlb_nganh> _tlb_nganh;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    partial void OnTenlopChanging(string value);
    partial void OnTenlopChanged();
    partial void Onma_nganhChanging(string value);
    partial void Onma_nganhChanged();
    #endregion
		
		public tlb_lop()
		{
			this._tlb_sinhviens = new EntitySet<tlb_sinhvien>(new Action<tlb_sinhvien>(this.attach_tlb_sinhviens), new Action<tlb_sinhvien>(this.detach_tlb_sinhviens));
			this._tlb_nganh = default(EntityRef<tlb_nganh>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tenlop", DbType="NVarChar(100)")]
		public string Tenlop
		{
			get
			{
				return this._Tenlop;
			}
			set
			{
				if ((this._Tenlop != value))
				{
					this.OnTenlopChanging(value);
					this.SendPropertyChanging();
					this._Tenlop = value;
					this.SendPropertyChanged("Tenlop");
					this.OnTenlopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ma_nganh", DbType="NVarChar(10)")]
		public string ma_nganh
		{
			get
			{
				return this._ma_nganh;
			}
			set
			{
				if ((this._ma_nganh != value))
				{
					if (this._tlb_nganh.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onma_nganhChanging(value);
					this.SendPropertyChanging();
					this._ma_nganh = value;
					this.SendPropertyChanged("ma_nganh");
					this.Onma_nganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_lop_tlb_sinhvien", Storage="_tlb_sinhviens", ThisKey="MaLop", OtherKey="MaLop")]
		public EntitySet<tlb_sinhvien> tlb_sinhviens
		{
			get
			{
				return this._tlb_sinhviens;
			}
			set
			{
				this._tlb_sinhviens.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_nganh_tlb_lop", Storage="_tlb_nganh", ThisKey="ma_nganh", OtherKey="ma_nganh", IsForeignKey=true)]
		public tlb_nganh tlb_nganh
		{
			get
			{
				return this._tlb_nganh.Entity;
			}
			set
			{
				tlb_nganh previousValue = this._tlb_nganh.Entity;
				if (((previousValue != value) 
							|| (this._tlb_nganh.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_nganh.Entity = null;
						previousValue.tlb_lops.Remove(this);
					}
					this._tlb_nganh.Entity = value;
					if ((value != null))
					{
						value.tlb_lops.Add(this);
						this._ma_nganh = value.ma_nganh;
					}
					else
					{
						this._ma_nganh = default(string);
					}
					this.SendPropertyChanged("tlb_nganh");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tlb_sinhviens(tlb_sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tlb_lop = this;
		}
		
		private void detach_tlb_sinhviens(tlb_sinhvien entity)
		{
			this.SendPropertyChanging();
			entity.tlb_lop = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_nganh")]
	public partial class tlb_nganh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ma_nganh;
		
		private string _ten_nganh;
		
		private string _ma_bm;
		
		private EntitySet<tlb_lop> _tlb_lops;
		
		private EntityRef<tlb_bomon> _tlb_bomon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onma_nganhChanging(string value);
    partial void Onma_nganhChanged();
    partial void Onten_nganhChanging(string value);
    partial void Onten_nganhChanged();
    partial void Onma_bmChanging(string value);
    partial void Onma_bmChanged();
    #endregion
		
		public tlb_nganh()
		{
			this._tlb_lops = new EntitySet<tlb_lop>(new Action<tlb_lop>(this.attach_tlb_lops), new Action<tlb_lop>(this.detach_tlb_lops));
			this._tlb_bomon = default(EntityRef<tlb_bomon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ma_nganh", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ma_nganh
		{
			get
			{
				return this._ma_nganh;
			}
			set
			{
				if ((this._ma_nganh != value))
				{
					this.Onma_nganhChanging(value);
					this.SendPropertyChanging();
					this._ma_nganh = value;
					this.SendPropertyChanged("ma_nganh");
					this.Onma_nganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ten_nganh", DbType="NVarChar(100)")]
		public string ten_nganh
		{
			get
			{
				return this._ten_nganh;
			}
			set
			{
				if ((this._ten_nganh != value))
				{
					this.Onten_nganhChanging(value);
					this.SendPropertyChanging();
					this._ten_nganh = value;
					this.SendPropertyChanged("ten_nganh");
					this.Onten_nganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ma_bm", DbType="NVarChar(10)")]
		public string ma_bm
		{
			get
			{
				return this._ma_bm;
			}
			set
			{
				if ((this._ma_bm != value))
				{
					if (this._tlb_bomon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onma_bmChanging(value);
					this.SendPropertyChanging();
					this._ma_bm = value;
					this.SendPropertyChanged("ma_bm");
					this.Onma_bmChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_nganh_tlb_lop", Storage="_tlb_lops", ThisKey="ma_nganh", OtherKey="ma_nganh")]
		public EntitySet<tlb_lop> tlb_lops
		{
			get
			{
				return this._tlb_lops;
			}
			set
			{
				this._tlb_lops.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_bomon_tlb_nganh", Storage="_tlb_bomon", ThisKey="ma_bm", OtherKey="ma_bm", IsForeignKey=true)]
		public tlb_bomon tlb_bomon
		{
			get
			{
				return this._tlb_bomon.Entity;
			}
			set
			{
				tlb_bomon previousValue = this._tlb_bomon.Entity;
				if (((previousValue != value) 
							|| (this._tlb_bomon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_bomon.Entity = null;
						previousValue.tlb_nganhs.Remove(this);
					}
					this._tlb_bomon.Entity = value;
					if ((value != null))
					{
						value.tlb_nganhs.Add(this);
						this._ma_bm = value.ma_bm;
					}
					else
					{
						this._ma_bm = default(string);
					}
					this.SendPropertyChanged("tlb_bomon");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tlb_lops(tlb_lop entity)
		{
			this.SendPropertyChanging();
			entity.tlb_nganh = this;
		}
		
		private void detach_tlb_lops(tlb_lop entity)
		{
			this.SendPropertyChanging();
			entity.tlb_nganh = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_user")]
	public partial class tlb_user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _tentk;
		
		private string _mk;
		
		private System.Nullable<int> _quyen;
		
		private EntityRef<tlb_sinhvien> _tlb_sinhvien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntentkChanging(string value);
    partial void OntentkChanged();
    partial void OnmkChanging(string value);
    partial void OnmkChanged();
    partial void OnquyenChanging(System.Nullable<int> value);
    partial void OnquyenChanged();
    #endregion
		
		public tlb_user()
		{
			this._tlb_sinhvien = default(EntityRef<tlb_sinhvien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tentk", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string tentk
		{
			get
			{
				return this._tentk;
			}
			set
			{
				if ((this._tentk != value))
				{
					if (this._tlb_sinhvien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntentkChanging(value);
					this.SendPropertyChanging();
					this._tentk = value;
					this.SendPropertyChanged("tentk");
					this.OntentkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mk", DbType="NVarChar(100)")]
		public string mk
		{
			get
			{
				return this._mk;
			}
			set
			{
				if ((this._mk != value))
				{
					this.OnmkChanging(value);
					this.SendPropertyChanging();
					this._mk = value;
					this.SendPropertyChanged("mk");
					this.OnmkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quyen", DbType="Int")]
		public System.Nullable<int> quyen
		{
			get
			{
				return this._quyen;
			}
			set
			{
				if ((this._quyen != value))
				{
					this.OnquyenChanging(value);
					this.SendPropertyChanging();
					this._quyen = value;
					this.SendPropertyChanged("quyen");
					this.OnquyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_user", Storage="_tlb_sinhvien", ThisKey="tentk", OtherKey="MaSV", IsForeignKey=true)]
		public tlb_sinhvien tlb_sinhvien
		{
			get
			{
				return this._tlb_sinhvien.Entity;
			}
			set
			{
				tlb_sinhvien previousValue = this._tlb_sinhvien.Entity;
				if (((previousValue != value) 
							|| (this._tlb_sinhvien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_sinhvien.Entity = null;
						previousValue.tlb_user = null;
					}
					this._tlb_sinhvien.Entity = value;
					if ((value != null))
					{
						value.tlb_user = this;
						this._tentk = value.MaSV;
					}
					else
					{
						this._tentk = default(string);
					}
					this.SendPropertyChanged("tlb_sinhvien");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tlb_sinhvien")]
	public partial class tlb_sinhvien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaSV;
		
		private string _TenSV;
		
		private string _NgaySinh;
		
		private string _Gioitinh;
		
		private string _TenCVHT;
		
		private string _DiaChi;
		
		private string _MaLop;
		
		private EntitySet<tlb_diemhk> _tlb_diemhks;
		
		private EntitySet<tlb_hocbong> _tlb_hocbongs;
		
		private EntityRef<tlb_user> _tlb_user;
		
		private EntityRef<tlb_lop> _tlb_lop;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSVChanging(string value);
    partial void OnMaSVChanged();
    partial void OnTenSVChanging(string value);
    partial void OnTenSVChanged();
    partial void OnNgaySinhChanging(string value);
    partial void OnNgaySinhChanged();
    partial void OnGioitinhChanging(string value);
    partial void OnGioitinhChanged();
    partial void OnTenCVHTChanging(string value);
    partial void OnTenCVHTChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnMaLopChanging(string value);
    partial void OnMaLopChanged();
    #endregion
		
		public tlb_sinhvien()
		{
			this._tlb_diemhks = new EntitySet<tlb_diemhk>(new Action<tlb_diemhk>(this.attach_tlb_diemhks), new Action<tlb_diemhk>(this.detach_tlb_diemhks));
			this._tlb_hocbongs = new EntitySet<tlb_hocbong>(new Action<tlb_hocbong>(this.attach_tlb_hocbongs), new Action<tlb_hocbong>(this.detach_tlb_hocbongs));
			this._tlb_user = default(EntityRef<tlb_user>);
			this._tlb_lop = default(EntityRef<tlb_lop>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSV", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaSV
		{
			get
			{
				return this._MaSV;
			}
			set
			{
				if ((this._MaSV != value))
				{
					this.OnMaSVChanging(value);
					this.SendPropertyChanging();
					this._MaSV = value;
					this.SendPropertyChanged("MaSV");
					this.OnMaSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenSV
		{
			get
			{
				return this._TenSV;
			}
			set
			{
				if ((this._TenSV != value))
				{
					this.OnTenSVChanging(value);
					this.SendPropertyChanging();
					this._TenSV = value;
					this.SendPropertyChanged("TenSV");
					this.OnTenSVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NgaySinh
		{
			get
			{
				return this._NgaySinh;
			}
			set
			{
				if ((this._NgaySinh != value))
				{
					this.OnNgaySinhChanging(value);
					this.SendPropertyChanging();
					this._NgaySinh = value;
					this.SendPropertyChanged("NgaySinh");
					this.OnNgaySinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gioitinh", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Gioitinh
		{
			get
			{
				return this._Gioitinh;
			}
			set
			{
				if ((this._Gioitinh != value))
				{
					this.OnGioitinhChanging(value);
					this.SendPropertyChanging();
					this._Gioitinh = value;
					this.SendPropertyChanged("Gioitinh");
					this.OnGioitinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenCVHT", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenCVHT
		{
			get
			{
				return this._TenCVHT;
			}
			set
			{
				if ((this._TenCVHT != value))
				{
					this.OnTenCVHTChanging(value);
					this.SendPropertyChanging();
					this._TenCVHT = value;
					this.SendPropertyChanged("TenCVHT");
					this.OnTenCVHTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this.OnDiaChiChanging(value);
					this.SendPropertyChanging();
					this._DiaChi = value;
					this.SendPropertyChanged("DiaChi");
					this.OnDiaChiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLop", DbType="NVarChar(10)")]
		public string MaLop
		{
			get
			{
				return this._MaLop;
			}
			set
			{
				if ((this._MaLop != value))
				{
					if (this._tlb_lop.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLopChanging(value);
					this.SendPropertyChanging();
					this._MaLop = value;
					this.SendPropertyChanged("MaLop");
					this.OnMaLopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_diemhk", Storage="_tlb_diemhks", ThisKey="MaSV", OtherKey="MSSV")]
		public EntitySet<tlb_diemhk> tlb_diemhks
		{
			get
			{
				return this._tlb_diemhks;
			}
			set
			{
				this._tlb_diemhks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_hocbong", Storage="_tlb_hocbongs", ThisKey="MaSV", OtherKey="MaSV")]
		public EntitySet<tlb_hocbong> tlb_hocbongs
		{
			get
			{
				return this._tlb_hocbongs;
			}
			set
			{
				this._tlb_hocbongs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_sinhvien_tlb_user", Storage="_tlb_user", ThisKey="MaSV", OtherKey="tentk", IsUnique=true, IsForeignKey=false)]
		public tlb_user tlb_user
		{
			get
			{
				return this._tlb_user.Entity;
			}
			set
			{
				tlb_user previousValue = this._tlb_user.Entity;
				if (((previousValue != value) 
							|| (this._tlb_user.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_user.Entity = null;
						previousValue.tlb_sinhvien = null;
					}
					this._tlb_user.Entity = value;
					if ((value != null))
					{
						value.tlb_sinhvien = this;
					}
					this.SendPropertyChanged("tlb_user");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tlb_lop_tlb_sinhvien", Storage="_tlb_lop", ThisKey="MaLop", OtherKey="MaLop", IsForeignKey=true)]
		public tlb_lop tlb_lop
		{
			get
			{
				return this._tlb_lop.Entity;
			}
			set
			{
				tlb_lop previousValue = this._tlb_lop.Entity;
				if (((previousValue != value) 
							|| (this._tlb_lop.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tlb_lop.Entity = null;
						previousValue.tlb_sinhviens.Remove(this);
					}
					this._tlb_lop.Entity = value;
					if ((value != null))
					{
						value.tlb_sinhviens.Add(this);
						this._MaLop = value.MaLop;
					}
					else
					{
						this._MaLop = default(string);
					}
					this.SendPropertyChanged("tlb_lop");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tlb_diemhks(tlb_diemhk entity)
		{
			this.SendPropertyChanging();
			entity.tlb_sinhvien = this;
		}
		
		private void detach_tlb_diemhks(tlb_diemhk entity)
		{
			this.SendPropertyChanging();
			entity.tlb_sinhvien = null;
		}
		
		private void attach_tlb_hocbongs(tlb_hocbong entity)
		{
			this.SendPropertyChanging();
			entity.tlb_sinhvien = this;
		}
		
		private void detach_tlb_hocbongs(tlb_hocbong entity)
		{
			this.SendPropertyChanging();
			entity.tlb_sinhvien = null;
		}
	}
}
#pragma warning restore 1591
