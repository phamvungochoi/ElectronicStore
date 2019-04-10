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

namespace ElectronicStore.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Electronic")]
	public partial class dbElectronicDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAD(AD instance);
    partial void UpdateAD(AD instance);
    partial void DeleteAD(AD instance);
    partial void InsertCTHD(CTHD instance);
    partial void UpdateCTHD(CTHD instance);
    partial void DeleteCTHD(CTHD instance);
    partial void InsertDONDATHANG(DONDATHANG instance);
    partial void UpdateDONDATHANG(DONDATHANG instance);
    partial void DeleteDONDATHANG(DONDATHANG instance);
    partial void InsertKHACHHANG(KHACHHANG instance);
    partial void UpdateKHACHHANG(KHACHHANG instance);
    partial void DeleteKHACHHANG(KHACHHANG instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    partial void InsertSP(SP instance);
    partial void UpdateSP(SP instance);
    partial void DeleteSP(SP instance);
    partial void InsertTHUONGHIEU(THUONGHIEU instance);
    partial void UpdateTHUONGHIEU(THUONGHIEU instance);
    partial void DeleteTHUONGHIEU(THUONGHIEU instance);
    #endregion
		
		public dbElectronicDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ElectronicConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbElectronicDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbElectronicDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbElectronicDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbElectronicDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<AD> ADs
		{
			get
			{
				return this.GetTable<AD>();
			}
		}
		
		public System.Data.Linq.Table<CTHD> CTHDs
		{
			get
			{
				return this.GetTable<CTHD>();
			}
		}
		
		public System.Data.Linq.Table<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this.GetTable<DONDATHANG>();
			}
		}
		
		public System.Data.Linq.Table<KHACHHANG> KHACHHANGs
		{
			get
			{
				return this.GetTable<KHACHHANG>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
		
		public System.Data.Linq.Table<SP> SPs
		{
			get
			{
				return this.GetTable<SP>();
			}
		}
		
		public System.Data.Linq.Table<THUONGHIEU> THUONGHIEUs
		{
			get
			{
				return this.GetTable<THUONGHIEU>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AD")]
	public partial class AD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _idadmin;
		
		private string _passadmin;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidadminChanging(string value);
    partial void OnidadminChanged();
    partial void OnpassadminChanging(string value);
    partial void OnpassadminChanged();
    #endregion
		
		public AD()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idadmin", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string idadmin
		{
			get
			{
				return this._idadmin;
			}
			set
			{
				if ((this._idadmin != value))
				{
					this.OnidadminChanging(value);
					this.SendPropertyChanging();
					this._idadmin = value;
					this.SendPropertyChanged("idadmin");
					this.OnidadminChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_passadmin", DbType="VarChar(50)")]
		public string passadmin
		{
			get
			{
				return this._passadmin;
			}
			set
			{
				if ((this._passadmin != value))
				{
					this.OnpassadminChanging(value);
					this.SendPropertyChanging();
					this._passadmin = value;
					this.SendPropertyChanged("passadmin");
					this.OnpassadminChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CTHD")]
	public partial class CTHD : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDH;
		
		private int _MaSP;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<decimal> _DonGia;
		
		private EntityRef<DONDATHANG> _DONDATHANG;
		
		private EntityRef<SP> _SP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDHChanging(int value);
    partial void OnMaDHChanged();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnDonGiaChanging(System.Nullable<decimal> value);
    partial void OnDonGiaChanged();
    #endregion
		
		public CTHD()
		{
			this._DONDATHANG = default(EntityRef<DONDATHANG>);
			this._SP = default(EntityRef<SP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDH", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDH
		{
			get
			{
				return this._MaDH;
			}
			set
			{
				if ((this._MaDH != value))
				{
					if ((this._DONDATHANG.HasLoadedOrAssignedValue || this._SP.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDHChanging(value);
					this.SendPropertyChanging();
					this._MaDH = value;
					this.SendPropertyChanged("MaDH");
					this.OnMaDHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CTHD", Storage="_DONDATHANG", ThisKey="MaDH", OtherKey="MADH", IsForeignKey=true)]
		public DONDATHANG DONDATHANG
		{
			get
			{
				return this._DONDATHANG.Entity;
			}
			set
			{
				DONDATHANG previousValue = this._DONDATHANG.Entity;
				if (((previousValue != value) 
							|| (this._DONDATHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DONDATHANG.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._DONDATHANG.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaDH = value.MADH;
					}
					else
					{
						this._MaDH = default(int);
					}
					this.SendPropertyChanged("DONDATHANG");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SP_CTHD", Storage="_SP", ThisKey="MaDH", OtherKey="MaSP", IsForeignKey=true)]
		public SP SP
		{
			get
			{
				return this._SP.Entity;
			}
			set
			{
				SP previousValue = this._SP.Entity;
				if (((previousValue != value) 
							|| (this._SP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SP.Entity = null;
						previousValue.CTHDs.Remove(this);
					}
					this._SP.Entity = value;
					if ((value != null))
					{
						value.CTHDs.Add(this);
						this._MaDH = value.MaSP;
					}
					else
					{
						this._MaDH = default(int);
					}
					this.SendPropertyChanged("SP");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DONDATHANG")]
	public partial class DONDATHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MADH;
		
		private System.Nullable<bool> _DaThanhToan;
		
		private System.Nullable<bool> _TinhTrangGiaoHang;
		
		private System.Nullable<System.DateTime> _NgayDat;
		
		private System.Nullable<System.DateTime> _NgayGiao;
		
		private System.Nullable<int> _MAKH;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<KHACHHANG> _KHACHHANG;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMADHChanging(int value);
    partial void OnMADHChanged();
    partial void OnDaThanhToanChanging(System.Nullable<bool> value);
    partial void OnDaThanhToanChanged();
    partial void OnTinhTrangGiaoHangChanging(System.Nullable<bool> value);
    partial void OnTinhTrangGiaoHangChanged();
    partial void OnNgayDatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayDatChanged();
    partial void OnNgayGiaoChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayGiaoChanged();
    partial void OnMAKHChanging(System.Nullable<int> value);
    partial void OnMAKHChanged();
    #endregion
		
		public DONDATHANG()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._KHACHHANG = default(EntityRef<KHACHHANG>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MADH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MADH
		{
			get
			{
				return this._MADH;
			}
			set
			{
				if ((this._MADH != value))
				{
					this.OnMADHChanging(value);
					this.SendPropertyChanging();
					this._MADH = value;
					this.SendPropertyChanged("MADH");
					this.OnMADHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DaThanhToan", DbType="Bit")]
		public System.Nullable<bool> DaThanhToan
		{
			get
			{
				return this._DaThanhToan;
			}
			set
			{
				if ((this._DaThanhToan != value))
				{
					this.OnDaThanhToanChanging(value);
					this.SendPropertyChanging();
					this._DaThanhToan = value;
					this.SendPropertyChanged("DaThanhToan");
					this.OnDaThanhToanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TinhTrangGiaoHang", DbType="Bit")]
		public System.Nullable<bool> TinhTrangGiaoHang
		{
			get
			{
				return this._TinhTrangGiaoHang;
			}
			set
			{
				if ((this._TinhTrangGiaoHang != value))
				{
					this.OnTinhTrangGiaoHangChanging(value);
					this.SendPropertyChanging();
					this._TinhTrangGiaoHang = value;
					this.SendPropertyChanged("TinhTrangGiaoHang");
					this.OnTinhTrangGiaoHangChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayDat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayDat
		{
			get
			{
				return this._NgayDat;
			}
			set
			{
				if ((this._NgayDat != value))
				{
					this.OnNgayDatChanging(value);
					this.SendPropertyChanging();
					this._NgayDat = value;
					this.SendPropertyChanged("NgayDat");
					this.OnNgayDatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayGiao", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayGiao
		{
			get
			{
				return this._NgayGiao;
			}
			set
			{
				if ((this._NgayGiao != value))
				{
					this.OnNgayGiaoChanging(value);
					this.SendPropertyChanging();
					this._NgayGiao = value;
					this.SendPropertyChanged("NgayGiao");
					this.OnNgayGiaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MAKH", DbType="Int")]
		public System.Nullable<int> MAKH
		{
			get
			{
				return this._MAKH;
			}
			set
			{
				if ((this._MAKH != value))
				{
					if (this._KHACHHANG.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMAKHChanging(value);
					this.SendPropertyChanging();
					this._MAKH = value;
					this.SendPropertyChanged("MAKH");
					this.OnMAKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DONDATHANG_CTHD", Storage="_CTHDs", ThisKey="MADH", OtherKey="MaDH")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_KHACHHANG", ThisKey="MAKH", OtherKey="MaKH", IsForeignKey=true)]
		public KHACHHANG KHACHHANG
		{
			get
			{
				return this._KHACHHANG.Entity;
			}
			set
			{
				KHACHHANG previousValue = this._KHACHHANG.Entity;
				if (((previousValue != value) 
							|| (this._KHACHHANG.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._KHACHHANG.Entity = null;
						previousValue.DONDATHANGs.Remove(this);
					}
					this._KHACHHANG.Entity = value;
					if ((value != null))
					{
						value.DONDATHANGs.Add(this);
						this._MAKH = value.MaKH;
					}
					else
					{
						this._MAKH = default(Nullable<int>);
					}
					this.SendPropertyChanged("KHACHHANG");
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
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.DONDATHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KHACHHANG")]
	public partial class KHACHHANG : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaKH;
		
		private string _HoTen;
		
		private string _TaiKhoan;
		
		private string _Email;
		
		private string _DiaChiKH;
		
		private string _DienThoaiKH;
		
		private string _MatKhau;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private EntitySet<DONDATHANG> _DONDATHANGs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaKHChanging(int value);
    partial void OnMaKHChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnTaiKhoanChanging(string value);
    partial void OnTaiKhoanChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDiaChiKHChanging(string value);
    partial void OnDiaChiKHChanged();
    partial void OnDienThoaiKHChanging(string value);
    partial void OnDienThoaiKHChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    #endregion
		
		public KHACHHANG()
		{
			this._DONDATHANGs = new EntitySet<DONDATHANG>(new Action<DONDATHANG>(this.attach_DONDATHANGs), new Action<DONDATHANG>(this.detach_DONDATHANGs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaKH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaKH
		{
			get
			{
				return this._MaKH;
			}
			set
			{
				if ((this._MaKH != value))
				{
					this.OnMaKHChanging(value);
					this.SendPropertyChanging();
					this._MaKH = value;
					this.SendPropertyChanged("MaKH");
					this.OnMaKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50)")]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TaiKhoan", DbType="VarChar(50)")]
		public string TaiKhoan
		{
			get
			{
				return this._TaiKhoan;
			}
			set
			{
				if ((this._TaiKhoan != value))
				{
					this.OnTaiKhoanChanging(value);
					this.SendPropertyChanging();
					this._TaiKhoan = value;
					this.SendPropertyChanged("TaiKhoan");
					this.OnTaiKhoanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChiKH", DbType="NVarChar(200)")]
		public string DiaChiKH
		{
			get
			{
				return this._DiaChiKH;
			}
			set
			{
				if ((this._DiaChiKH != value))
				{
					this.OnDiaChiKHChanging(value);
					this.SendPropertyChanging();
					this._DiaChiKH = value;
					this.SendPropertyChanged("DiaChiKH");
					this.OnDiaChiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoaiKH", DbType="VarChar(20)")]
		public string DienThoaiKH
		{
			get
			{
				return this._DienThoaiKH;
			}
			set
			{
				if ((this._DienThoaiKH != value))
				{
					this.OnDienThoaiKHChanging(value);
					this.SendPropertyChanging();
					this._DienThoaiKH = value;
					this.SendPropertyChanged("DienThoaiKH");
					this.OnDienThoaiKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="VarChar(50)")]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgaySinh
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="KHACHHANG_DONDATHANG", Storage="_DONDATHANGs", ThisKey="MaKH", OtherKey="MAKH")]
		public EntitySet<DONDATHANG> DONDATHANGs
		{
			get
			{
				return this._DONDATHANGs;
			}
			set
			{
				this._DONDATHANGs.Assign(value);
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
		
		private void attach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = this;
		}
		
		private void detach_DONDATHANGs(DONDATHANG entity)
		{
			this.SendPropertyChanging();
			entity.KHACHHANG = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaNV;
		
		private string _Username;
		
		private string _Password;
		
		private string _Email;
		
		private string _HoTen;
		
		private System.Nullable<System.DateTime> _NgaySinh;
		
		private bool _GioiTinh;
		
		private string _DiaChi;
		
		private string _DienThoai;
		
		private System.Nullable<int> _MaCV;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNVChanging(int value);
    partial void OnMaNVChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnHoTenChanging(string value);
    partial void OnHoTenChanged();
    partial void OnNgaySinhChanging(System.Nullable<System.DateTime> value);
    partial void OnNgaySinhChanged();
    partial void OnGioiTinhChanging(bool value);
    partial void OnGioiTinhChanged();
    partial void OnDiaChiChanging(string value);
    partial void OnDiaChiChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnMaCVChanging(System.Nullable<int> value);
    partial void OnMaCVChanged();
    #endregion
		
		public NhanVien()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNV", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaNV
		{
			get
			{
				return this._MaNV;
			}
			set
			{
				if ((this._MaNV != value))
				{
					this.OnMaNVChanging(value);
					this.SendPropertyChanging();
					this._MaNV = value;
					this.SendPropertyChanged("MaNV");
					this.OnMaNVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoTen", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string HoTen
		{
			get
			{
				return this._HoTen;
			}
			set
			{
				if ((this._HoTen != value))
				{
					this.OnHoTenChanging(value);
					this.SendPropertyChanging();
					this._HoTen = value;
					this.SendPropertyChanged("HoTen");
					this.OnHoTenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgaySinh", DbType="Date")]
		public System.Nullable<System.DateTime> NgaySinh
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="Bit NOT NULL")]
		public bool GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(200)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(11)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaCV", DbType="Int")]
		public System.Nullable<int> MaCV
		{
			get
			{
				return this._MaCV;
			}
			set
			{
				if ((this._MaCV != value))
				{
					this.OnMaCVChanging(value);
					this.SendPropertyChanging();
					this._MaCV = value;
					this.SendPropertyChanged("MaCV");
					this.OnMaCVChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SP")]
	public partial class SP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSP;
		
		private string _TenSP;
		
		private System.Nullable<decimal> _GiaBan;
		
		private string _MoTa;
		
		private System.Nullable<System.DateTime> _NgayCapNhat;
		
		private string _HinhSP;
		
		private System.Nullable<int> _SLTon;
		
		private System.Nullable<int> _MATH;
		
		private EntitySet<CTHD> _CTHDs;
		
		private EntityRef<THUONGHIEU> _THUONGHIEU;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSPChanging(int value);
    partial void OnMaSPChanged();
    partial void OnTenSPChanging(string value);
    partial void OnTenSPChanged();
    partial void OnGiaBanChanging(System.Nullable<decimal> value);
    partial void OnGiaBanChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    partial void OnNgayCapNhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayCapNhatChanged();
    partial void OnHinhSPChanging(string value);
    partial void OnHinhSPChanged();
    partial void OnSLTonChanging(System.Nullable<int> value);
    partial void OnSLTonChanged();
    partial void OnMATHChanging(System.Nullable<int> value);
    partial void OnMATHChanged();
    #endregion
		
		public SP()
		{
			this._CTHDs = new EntitySet<CTHD>(new Action<CTHD>(this.attach_CTHDs), new Action<CTHD>(this.detach_CTHDs));
			this._THUONGHIEU = default(EntityRef<THUONGHIEU>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSP", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaSP
		{
			get
			{
				return this._MaSP;
			}
			set
			{
				if ((this._MaSP != value))
				{
					this.OnMaSPChanging(value);
					this.SendPropertyChanging();
					this._MaSP = value;
					this.SendPropertyChanged("MaSP");
					this.OnMaSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSP", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string TenSP
		{
			get
			{
				return this._TenSP;
			}
			set
			{
				if ((this._TenSP != value))
				{
					this.OnTenSPChanging(value);
					this.SendPropertyChanging();
					this._TenSP = value;
					this.SendPropertyChanged("TenSP");
					this.OnTenSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaBan", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> GiaBan
		{
			get
			{
				return this._GiaBan;
			}
			set
			{
				if ((this._GiaBan != value))
				{
					this.OnGiaBanChanging(value);
					this.SendPropertyChanging();
					this._GiaBan = value;
					this.SendPropertyChanged("GiaBan");
					this.OnGiaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(MAX)")]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCapNhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayCapNhat
		{
			get
			{
				return this._NgayCapNhat;
			}
			set
			{
				if ((this._NgayCapNhat != value))
				{
					this.OnNgayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._NgayCapNhat = value;
					this.SendPropertyChanged("NgayCapNhat");
					this.OnNgayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HinhSP", DbType="VarChar(50)")]
		public string HinhSP
		{
			get
			{
				return this._HinhSP;
			}
			set
			{
				if ((this._HinhSP != value))
				{
					this.OnHinhSPChanging(value);
					this.SendPropertyChanging();
					this._HinhSP = value;
					this.SendPropertyChanged("HinhSP");
					this.OnHinhSPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SLTon", DbType="Int")]
		public System.Nullable<int> SLTon
		{
			get
			{
				return this._SLTon;
			}
			set
			{
				if ((this._SLTon != value))
				{
					this.OnSLTonChanging(value);
					this.SendPropertyChanging();
					this._SLTon = value;
					this.SendPropertyChanged("SLTon");
					this.OnSLTonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATH", DbType="Int")]
		public System.Nullable<int> MATH
		{
			get
			{
				return this._MATH;
			}
			set
			{
				if ((this._MATH != value))
				{
					this.OnMATHChanging(value);
					this.SendPropertyChanging();
					this._MATH = value;
					this.SendPropertyChanged("MATH");
					this.OnMATHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SP_CTHD", Storage="_CTHDs", ThisKey="MaSP", OtherKey="MaDH")]
		public EntitySet<CTHD> CTHDs
		{
			get
			{
				return this._CTHDs;
			}
			set
			{
				this._CTHDs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SP_THUONGHIEU", Storage="_THUONGHIEU", ThisKey="MaSP", OtherKey="MATH", IsUnique=true, IsForeignKey=false)]
		public THUONGHIEU THUONGHIEU
		{
			get
			{
				return this._THUONGHIEU.Entity;
			}
			set
			{
				THUONGHIEU previousValue = this._THUONGHIEU.Entity;
				if (((previousValue != value) 
							|| (this._THUONGHIEU.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._THUONGHIEU.Entity = null;
						previousValue.SP = null;
					}
					this._THUONGHIEU.Entity = value;
					if ((value != null))
					{
						value.SP = this;
					}
					this.SendPropertyChanged("THUONGHIEU");
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
		
		private void attach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SP = this;
		}
		
		private void detach_CTHDs(CTHD entity)
		{
			this.SendPropertyChanging();
			entity.SP = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.THUONGHIEU")]
	public partial class THUONGHIEU : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MATH;
		
		private string _TENTH;
		
		private EntityRef<SP> _SP;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMATHChanging(int value);
    partial void OnMATHChanged();
    partial void OnTENTHChanging(string value);
    partial void OnTENTHChanged();
    #endregion
		
		public THUONGHIEU()
		{
			this._SP = default(EntityRef<SP>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MATH", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MATH
		{
			get
			{
				return this._MATH;
			}
			set
			{
				if ((this._MATH != value))
				{
					if (this._SP.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMATHChanging(value);
					this.SendPropertyChanging();
					this._MATH = value;
					this.SendPropertyChanged("MATH");
					this.OnMATHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TENTH", DbType="NVarChar(50)")]
		public string TENTH
		{
			get
			{
				return this._TENTH;
			}
			set
			{
				if ((this._TENTH != value))
				{
					this.OnTENTHChanging(value);
					this.SendPropertyChanging();
					this._TENTH = value;
					this.SendPropertyChanged("TENTH");
					this.OnTENTHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="SP_THUONGHIEU", Storage="_SP", ThisKey="MATH", OtherKey="MaSP", IsForeignKey=true)]
		public SP SP
		{
			get
			{
				return this._SP.Entity;
			}
			set
			{
				SP previousValue = this._SP.Entity;
				if (((previousValue != value) 
							|| (this._SP.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._SP.Entity = null;
						previousValue.THUONGHIEU = null;
					}
					this._SP.Entity = value;
					if ((value != null))
					{
						value.THUONGHIEU = this;
						this._MATH = value.MaSP;
					}
					else
					{
						this._MATH = default(int);
					}
					this.SendPropertyChanged("SP");
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
}
#pragma warning restore 1591
