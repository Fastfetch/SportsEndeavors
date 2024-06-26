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

namespace Lithium_Rules
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SOTNewHost")]
	public partial class HostDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    partial void InsertUserPswd(UserPswd instance);
    partial void UpdateUserPswd(UserPswd instance);
    partial void DeleteUserPswd(UserPswd instance);
    partial void InsertRequiredAuthority(RequiredAuthority instance);
    partial void UpdateRequiredAuthority(RequiredAuthority instance);
    partial void DeleteRequiredAuthority(RequiredAuthority instance);
    #endregion
		
		public HostDataClassesDataContext() : 
				base(global::Lithium_Rules.Properties.Settings.Default.SOTNewHostConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HostDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HostDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HostDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HostDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		public System.Data.Linq.Table<UserPswd> UserPswds
		{
			get
			{
				return this.GetTable<UserPswd>();
			}
		}
		
		public System.Data.Linq.Table<RequiredAuthority> RequiredAuthorities
		{
			get
			{
				return this.GetTable<RequiredAuthority>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UserID;
		
		private string _MenuPrivilege;
		
		private string _CurrentPDA;
		
		private System.Nullable<System.DateTime> _UpdateTimestamp;
		
		private string _LanguageDir;
		
		private string _UserName;
		
		private string _UserBadge;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(string value);
    partial void OnUserIDChanged();
    partial void OnMenuPrivilegeChanging(string value);
    partial void OnMenuPrivilegeChanged();
    partial void OnCurrentPDAChanging(string value);
    partial void OnCurrentPDAChanged();
    partial void OnUpdateTimestampChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdateTimestampChanged();
    partial void OnLanguageDirChanging(string value);
    partial void OnLanguageDirChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnUserBadgeChanging(string value);
    partial void OnUserBadgeChanged();
    #endregion
		
		public tblUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MenuPrivilege", DbType="NVarChar(10)")]
		public string MenuPrivilege
		{
			get
			{
				return this._MenuPrivilege;
			}
			set
			{
				if ((this._MenuPrivilege != value))
				{
					this.OnMenuPrivilegeChanging(value);
					this.SendPropertyChanging();
					this._MenuPrivilege = value;
					this.SendPropertyChanged("MenuPrivilege");
					this.OnMenuPrivilegeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentPDA", DbType="NVarChar(50)")]
		public string CurrentPDA
		{
			get
			{
				return this._CurrentPDA;
			}
			set
			{
				if ((this._CurrentPDA != value))
				{
					this.OnCurrentPDAChanging(value);
					this.SendPropertyChanging();
					this._CurrentPDA = value;
					this.SendPropertyChanged("CurrentPDA");
					this.OnCurrentPDAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdateTimestamp", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdateTimestamp
		{
			get
			{
				return this._UpdateTimestamp;
			}
			set
			{
				if ((this._UpdateTimestamp != value))
				{
					this.OnUpdateTimestampChanging(value);
					this.SendPropertyChanging();
					this._UpdateTimestamp = value;
					this.SendPropertyChanged("UpdateTimestamp");
					this.OnUpdateTimestampChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LanguageDir", DbType="NVarChar(50)")]
		public string LanguageDir
		{
			get
			{
				return this._LanguageDir;
			}
			set
			{
				if ((this._LanguageDir != value))
				{
					this.OnLanguageDirChanging(value);
					this.SendPropertyChanging();
					this._LanguageDir = value;
					this.SendPropertyChanged("LanguageDir");
					this.OnLanguageDirChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="NVarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserBadge", DbType="NVarChar(50)")]
		public string UserBadge
		{
			get
			{
				return this._UserBadge;
			}
			set
			{
				if ((this._UserBadge != value))
				{
					this.OnUserBadgeChanging(value);
					this.SendPropertyChanging();
					this._UserBadge = value;
					this.SendPropertyChanged("UserBadge");
					this.OnUserBadgeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserPswd")]
	public partial class UserPswd : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _UPUserID;
		
		private System.Data.Linq.Binary _UPPswd;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUPUserIDChanging(string value);
    partial void OnUPUserIDChanged();
    partial void OnUPPswdChanging(System.Data.Linq.Binary value);
    partial void OnUPPswdChanged();
    #endregion
		
		public UserPswd()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPUserID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string UPUserID
		{
			get
			{
				return this._UPUserID;
			}
			set
			{
				if ((this._UPUserID != value))
				{
					this.OnUPUserIDChanging(value);
					this.SendPropertyChanging();
					this._UPUserID = value;
					this.SendPropertyChanged("UPUserID");
					this.OnUPUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UPPswd", DbType="VarBinary(50)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary UPPswd
		{
			get
			{
				return this._UPPswd;
			}
			set
			{
				if ((this._UPPswd != value))
				{
					this.OnUPPswdChanging(value);
					this.SendPropertyChanging();
					this._UPPswd = value;
					this.SendPropertyChanged("UPPswd");
					this.OnUPPswdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.RequiredAuthority")]
	public partial class RequiredAuthority : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _RAProgram;
		
		private string _RATask;
		
		private string _RAReqAuthority;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRAProgramChanging(string value);
    partial void OnRAProgramChanged();
    partial void OnRATaskChanging(string value);
    partial void OnRATaskChanged();
    partial void OnRAReqAuthorityChanging(string value);
    partial void OnRAReqAuthorityChanged();
    #endregion
		
		public RequiredAuthority()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAProgram", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RAProgram
		{
			get
			{
				return this._RAProgram;
			}
			set
			{
				if ((this._RAProgram != value))
				{
					this.OnRAProgramChanging(value);
					this.SendPropertyChanging();
					this._RAProgram = value;
					this.SendPropertyChanged("RAProgram");
					this.OnRAProgramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RATask", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string RATask
		{
			get
			{
				return this._RATask;
			}
			set
			{
				if ((this._RATask != value))
				{
					this.OnRATaskChanging(value);
					this.SendPropertyChanging();
					this._RATask = value;
					this.SendPropertyChanged("RATask");
					this.OnRATaskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RAReqAuthority", DbType="NVarChar(20)")]
		public string RAReqAuthority
		{
			get
			{
				return this._RAReqAuthority;
			}
			set
			{
				if ((this._RAReqAuthority != value))
				{
					this.OnRAReqAuthorityChanging(value);
					this.SendPropertyChanging();
					this._RAReqAuthority = value;
					this.SendPropertyChanged("RAReqAuthority");
					this.OnRAReqAuthorityChanged();
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