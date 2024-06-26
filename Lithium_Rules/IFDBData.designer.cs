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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SOIFDBNew")]
	public partial class IFDBDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLithiumRule(LithiumRule instance);
    partial void UpdateLithiumRule(LithiumRule instance);
    partial void DeleteLithiumRule(LithiumRule instance);
    #endregion
		
		public IFDBDataDataContext() : 
				base(global::Lithium_Rules.Properties.Settings.Default.SOIFDBNewConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public IFDBDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IFDBDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IFDBDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IFDBDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<LithiumRule> LithiumRules
		{
			get
			{
				return this.GetTable<LithiumRule>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LithiumRules")]
	public partial class LithiumRule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _LithiumGroup;
		
		private string _LithiumType;
		
		private System.Nullable<char> _LithiumPromoRule;
		
		private System.Nullable<char> _LithiumRouteRule;
		
		private string _LithiumRoute;
		
		private string _LithiumOrderType;
		
		private System.Nullable<char> _LithiumShipAlone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLithiumGroupChanging(int value);
    partial void OnLithiumGroupChanged();
    partial void OnLithiumTypeChanging(string value);
    partial void OnLithiumTypeChanged();
    partial void OnLithiumPromoRuleChanging(System.Nullable<char> value);
    partial void OnLithiumPromoRuleChanged();
    partial void OnLithiumRouteRuleChanging(System.Nullable<char> value);
    partial void OnLithiumRouteRuleChanged();
    partial void OnLithiumRouteChanging(string value);
    partial void OnLithiumRouteChanged();
    partial void OnLithiumOrderTypeChanging(string value);
    partial void OnLithiumOrderTypeChanged();
    partial void OnLithiumShipAloneChanging(System.Nullable<char> value);
    partial void OnLithiumShipAloneChanged();
    #endregion
		
		public LithiumRule()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumGroup", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int LithiumGroup
		{
			get
			{
				return this._LithiumGroup;
			}
			set
			{
				if ((this._LithiumGroup != value))
				{
					this.OnLithiumGroupChanging(value);
					this.SendPropertyChanging();
					this._LithiumGroup = value;
					this.SendPropertyChanged("LithiumGroup");
					this.OnLithiumGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumType", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string LithiumType
		{
			get
			{
				return this._LithiumType;
			}
			set
			{
				if ((this._LithiumType != value))
				{
					this.OnLithiumTypeChanging(value);
					this.SendPropertyChanging();
					this._LithiumType = value;
					this.SendPropertyChanged("LithiumType");
					this.OnLithiumTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumPromoRule", DbType="NChar(1)")]
		public System.Nullable<char> LithiumPromoRule
		{
			get
			{
				return this._LithiumPromoRule;
			}
			set
			{
				if ((this._LithiumPromoRule != value))
				{
					this.OnLithiumPromoRuleChanging(value);
					this.SendPropertyChanging();
					this._LithiumPromoRule = value;
					this.SendPropertyChanged("LithiumPromoRule");
					this.OnLithiumPromoRuleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumRouteRule", DbType="NChar(1)")]
		public System.Nullable<char> LithiumRouteRule
		{
			get
			{
				return this._LithiumRouteRule;
			}
			set
			{
				if ((this._LithiumRouteRule != value))
				{
					this.OnLithiumRouteRuleChanging(value);
					this.SendPropertyChanging();
					this._LithiumRouteRule = value;
					this.SendPropertyChanged("LithiumRouteRule");
					this.OnLithiumRouteRuleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumRoute", DbType="NVarChar(30)")]
		public string LithiumRoute
		{
			get
			{
				return this._LithiumRoute;
			}
			set
			{
				if ((this._LithiumRoute != value))
				{
					this.OnLithiumRouteChanging(value);
					this.SendPropertyChanging();
					this._LithiumRoute = value;
					this.SendPropertyChanged("LithiumRoute");
					this.OnLithiumRouteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumOrderType", DbType="NVarChar(50)")]
		public string LithiumOrderType
		{
			get
			{
				return this._LithiumOrderType;
			}
			set
			{
				if ((this._LithiumOrderType != value))
				{
					this.OnLithiumOrderTypeChanging(value);
					this.SendPropertyChanging();
					this._LithiumOrderType = value;
					this.SendPropertyChanged("LithiumOrderType");
					this.OnLithiumOrderTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LithiumShipAlone", DbType="NChar(1)")]
		public System.Nullable<char> LithiumShipAlone
		{
			get
			{
				return this._LithiumShipAlone;
			}
			set
			{
				if ((this._LithiumShipAlone != value))
				{
					this.OnLithiumShipAloneChanging(value);
					this.SendPropertyChanging();
					this._LithiumShipAlone = value;
					this.SendPropertyChanged("LithiumShipAlone");
					this.OnLithiumShipAloneChanged();
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
