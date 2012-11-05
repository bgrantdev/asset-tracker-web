﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asset_tracker_web
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="asset_tracker_db")]
	public partial class AssetTrackerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertfacility(facility instance);
    partial void Updatefacility(facility instance);
    partial void Deletefacility(facility instance);
    partial void Insertroom(room instance);
    partial void Updateroom(room instance);
    partial void Deleteroom(room instance);
    partial void Insertasset(asset instance);
    partial void Updateasset(asset instance);
    partial void Deleteasset(asset instance);
    #endregion
		
		public AssetTrackerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AssetTrackerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssetTrackerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssetTrackerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AssetTrackerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<facility> facilities
		{
			get
			{
				return this.GetTable<facility>();
			}
		}
		
		public System.Data.Linq.Table<room> rooms
		{
			get
			{
				return this.GetTable<room>();
			}
		}
		
		public System.Data.Linq.Table<asset> assets
		{
			get
			{
				return this.GetTable<asset>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.facility")]
	public partial class facility : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.DateTime _add_date;
		
		private System.Guid _user_id;
		
		private EntitySet<room> _rooms;
		
		private EntitySet<asset> _assets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onadd_dateChanging(System.DateTime value);
    partial void Onadd_dateChanged();
    partial void Onuser_idChanging(System.Guid value);
    partial void Onuser_idChanged();
    #endregion
		
		public facility()
		{
			this._rooms = new EntitySet<room>(new Action<room>(this.attach_rooms), new Action<room>(this.detach_rooms));
			this._assets = new EntitySet<asset>(new Action<asset>(this.attach_assets), new Action<asset>(this.detach_assets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_add_date", DbType="DateTime NOT NULL")]
		public System.DateTime add_date
		{
			get
			{
				return this._add_date;
			}
			set
			{
				if ((this._add_date != value))
				{
					this.Onadd_dateChanging(value);
					this.SendPropertyChanging();
					this._add_date = value;
					this.SendPropertyChanged("add_date");
					this.Onadd_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_user_id", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid user_id
		{
			get
			{
				return this._user_id;
			}
			set
			{
				if ((this._user_id != value))
				{
					this.Onuser_idChanging(value);
					this.SendPropertyChanging();
					this._user_id = value;
					this.SendPropertyChanged("user_id");
					this.Onuser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facility_room", Storage="_rooms", ThisKey="id", OtherKey="facility")]
		public EntitySet<room> rooms
		{
			get
			{
				return this._rooms;
			}
			set
			{
				this._rooms.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facility_asset", Storage="_assets", ThisKey="id", OtherKey="facility")]
		public EntitySet<asset> assets
		{
			get
			{
				return this._assets;
			}
			set
			{
				this._assets.Assign(value);
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
		
		private void attach_rooms(room entity)
		{
			this.SendPropertyChanging();
			entity.facility1 = this;
		}
		
		private void detach_rooms(room entity)
		{
			this.SendPropertyChanging();
			entity.facility1 = null;
		}
		
		private void attach_assets(asset entity)
		{
			this.SendPropertyChanging();
			entity.facility1 = this;
		}
		
		private void detach_assets(asset entity)
		{
			this.SendPropertyChanging();
			entity.facility1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.room")]
	public partial class room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private System.DateTime _add_date;
		
		private int _facility;
		
		private EntitySet<asset> _assets;
		
		private EntityRef<facility> _facility1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void Onadd_dateChanging(System.DateTime value);
    partial void Onadd_dateChanged();
    partial void OnfacilityChanging(int value);
    partial void OnfacilityChanged();
    #endregion
		
		public room()
		{
			this._assets = new EntitySet<asset>(new Action<asset>(this.attach_assets), new Action<asset>(this.detach_assets));
			this._facility1 = default(EntityRef<facility>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_add_date", DbType="DateTime NOT NULL")]
		public System.DateTime add_date
		{
			get
			{
				return this._add_date;
			}
			set
			{
				if ((this._add_date != value))
				{
					this.Onadd_dateChanging(value);
					this.SendPropertyChanging();
					this._add_date = value;
					this.SendPropertyChanged("add_date");
					this.Onadd_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_facility", DbType="Int NOT NULL")]
		public int facility
		{
			get
			{
				return this._facility;
			}
			set
			{
				if ((this._facility != value))
				{
					if (this._facility1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnfacilityChanging(value);
					this.SendPropertyChanging();
					this._facility = value;
					this.SendPropertyChanged("facility");
					this.OnfacilityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_asset", Storage="_assets", ThisKey="id", OtherKey="room")]
		public EntitySet<asset> assets
		{
			get
			{
				return this._assets;
			}
			set
			{
				this._assets.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facility_room", Storage="_facility1", ThisKey="facility", OtherKey="id", IsForeignKey=true)]
		public facility facility1
		{
			get
			{
				return this._facility1.Entity;
			}
			set
			{
				facility previousValue = this._facility1.Entity;
				if (((previousValue != value) 
							|| (this._facility1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._facility1.Entity = null;
						previousValue.rooms.Remove(this);
					}
					this._facility1.Entity = value;
					if ((value != null))
					{
						value.rooms.Add(this);
						this._facility = value.id;
					}
					else
					{
						this._facility = default(int);
					}
					this.SendPropertyChanged("facility1");
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
		
		private void attach_assets(asset entity)
		{
			this.SendPropertyChanging();
			entity.room1 = this;
		}
		
		private void detach_assets(asset entity)
		{
			this.SendPropertyChanging();
			entity.room1 = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.asset")]
	public partial class asset : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _sku;
		
		private System.DateTime _add_date;
		
		private System.DateTime _last_scan;
		
		private int _room;
		
		private int _facility;
		
		private EntityRef<facility> _facility1;
		
		private EntityRef<room> _room1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnskuChanging(string value);
    partial void OnskuChanged();
    partial void Onadd_dateChanging(System.DateTime value);
    partial void Onadd_dateChanged();
    partial void Onlast_scanChanging(System.DateTime value);
    partial void Onlast_scanChanged();
    partial void OnroomChanging(int value);
    partial void OnroomChanged();
    partial void OnfacilityChanging(int value);
    partial void OnfacilityChanged();
    #endregion
		
		public asset()
		{
			this._facility1 = default(EntityRef<facility>);
			this._room1 = default(EntityRef<room>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sku", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string sku
		{
			get
			{
				return this._sku;
			}
			set
			{
				if ((this._sku != value))
				{
					this.OnskuChanging(value);
					this.SendPropertyChanging();
					this._sku = value;
					this.SendPropertyChanged("sku");
					this.OnskuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_add_date", DbType="DateTime NOT NULL")]
		public System.DateTime add_date
		{
			get
			{
				return this._add_date;
			}
			set
			{
				if ((this._add_date != value))
				{
					this.Onadd_dateChanging(value);
					this.SendPropertyChanging();
					this._add_date = value;
					this.SendPropertyChanged("add_date");
					this.Onadd_dateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_scan", DbType="DateTime NOT NULL")]
		public System.DateTime last_scan
		{
			get
			{
				return this._last_scan;
			}
			set
			{
				if ((this._last_scan != value))
				{
					this.Onlast_scanChanging(value);
					this.SendPropertyChanging();
					this._last_scan = value;
					this.SendPropertyChanged("last_scan");
					this.Onlast_scanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_room", DbType="Int NOT NULL")]
		public int room
		{
			get
			{
				return this._room;
			}
			set
			{
				if ((this._room != value))
				{
					if (this._room1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnroomChanging(value);
					this.SendPropertyChanging();
					this._room = value;
					this.SendPropertyChanged("room");
					this.OnroomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_facility", DbType="Int NOT NULL")]
		public int facility
		{
			get
			{
				return this._facility;
			}
			set
			{
				if ((this._facility != value))
				{
					if (this._facility1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnfacilityChanging(value);
					this.SendPropertyChanging();
					this._facility = value;
					this.SendPropertyChanged("facility");
					this.OnfacilityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="facility_asset", Storage="_facility1", ThisKey="facility", OtherKey="id", IsForeignKey=true)]
		public facility facility1
		{
			get
			{
				return this._facility1.Entity;
			}
			set
			{
				facility previousValue = this._facility1.Entity;
				if (((previousValue != value) 
							|| (this._facility1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._facility1.Entity = null;
						previousValue.assets.Remove(this);
					}
					this._facility1.Entity = value;
					if ((value != null))
					{
						value.assets.Add(this);
						this._facility = value.id;
					}
					else
					{
						this._facility = default(int);
					}
					this.SendPropertyChanged("facility1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="room_asset", Storage="_room1", ThisKey="room", OtherKey="id", IsForeignKey=true)]
		public room room1
		{
			get
			{
				return this._room1.Entity;
			}
			set
			{
				room previousValue = this._room1.Entity;
				if (((previousValue != value) 
							|| (this._room1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._room1.Entity = null;
						previousValue.assets.Remove(this);
					}
					this._room1.Entity = value;
					if ((value != null))
					{
						value.assets.Add(this);
						this._room = value.id;
					}
					else
					{
						this._room = default(int);
					}
					this.SendPropertyChanged("room1");
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