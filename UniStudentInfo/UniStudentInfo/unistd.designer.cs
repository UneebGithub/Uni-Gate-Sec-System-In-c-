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

namespace UniStudentInfo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="unistd")]
	public partial class unistdDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertstddata(stddata instance);
    partial void Updatestddata(stddata instance);
    partial void Deletestddata(stddata instance);
    #endregion
		
		public unistdDataContext() : 
				base(global::UniStudentInfo.Properties.Settings.Default.unistdConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public unistdDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public unistdDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public unistdDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public unistdDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<stddata> stddatas
		{
			get
			{
				return this.GetTable<stddata>();
			}
		}
		
		public System.Data.Linq.Table<ADMINLogin> ADMINLogins
		{
			get
			{
				return this.GetTable<ADMINLogin>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login
	{
		
		private string _username;
		
		private string _pass;
		
		public Login()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this._pass = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.stddata")]
	public partial class stddata : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _reg_no;
		
		private int _batch;
		
		private string _dep;
		
		private long _CNIC;
		
		private string _adr;
		
		private System.Data.Linq.Binary _picture;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void Onreg_noChanging(string value);
    partial void Onreg_noChanged();
    partial void OnbatchChanging(int value);
    partial void OnbatchChanged();
    partial void OndepChanging(string value);
    partial void OndepChanged();
    partial void OnCNICChanging(long value);
    partial void OnCNICChanged();
    partial void OnadrChanging(string value);
    partial void OnadrChanged();
    partial void OnpictureChanging(System.Data.Linq.Binary value);
    partial void OnpictureChanged();
    #endregion
		
		public stddata()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_reg_no", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string reg_no
		{
			get
			{
				return this._reg_no;
			}
			set
			{
				if ((this._reg_no != value))
				{
					this.Onreg_noChanging(value);
					this.SendPropertyChanging();
					this._reg_no = value;
					this.SendPropertyChanged("reg_no");
					this.Onreg_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_batch", DbType="Int NOT NULL")]
		public int batch
		{
			get
			{
				return this._batch;
			}
			set
			{
				if ((this._batch != value))
				{
					this.OnbatchChanging(value);
					this.SendPropertyChanging();
					this._batch = value;
					this.SendPropertyChanged("batch");
					this.OnbatchChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dep", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string dep
		{
			get
			{
				return this._dep;
			}
			set
			{
				if ((this._dep != value))
				{
					this.OndepChanging(value);
					this.SendPropertyChanging();
					this._dep = value;
					this.SendPropertyChanged("dep");
					this.OndepChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CNIC", DbType="BigInt NOT NULL")]
		public long CNIC
		{
			get
			{
				return this._CNIC;
			}
			set
			{
				if ((this._CNIC != value))
				{
					this.OnCNICChanging(value);
					this.SendPropertyChanging();
					this._CNIC = value;
					this.SendPropertyChanged("CNIC");
					this.OnCNICChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_adr", DbType="Char(50) NOT NULL", CanBeNull=false)]
		public string adr
		{
			get
			{
				return this._adr;
			}
			set
			{
				if ((this._adr != value))
				{
					this.OnadrChanging(value);
					this.SendPropertyChanging();
					this._adr = value;
					this.SendPropertyChanged("adr");
					this.OnadrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_picture", DbType="Image", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if ((this._picture != value))
				{
					this.OnpictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("picture");
					this.OnpictureChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ADMINLogin")]
	public partial class ADMINLogin
	{
		
		private string _username;
		
		private string _pass;
		
		public ADMINLogin()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="Char(30) NOT NULL", CanBeNull=false)]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this._pass = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
