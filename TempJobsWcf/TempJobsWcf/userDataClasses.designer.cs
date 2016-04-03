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

namespace TempJobsWcf
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class userDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUserdata(Userdata instance);
    partial void UpdateUserdata(Userdata instance);
    partial void DeleteUserdata(Userdata instance);
    partial void InsertInformalSkill(InformalSkill instance);
    partial void UpdateInformalSkill(InformalSkill instance);
    partial void DeleteInformalSkill(InformalSkill instance);
    #endregion
		
		public userDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public userDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public userDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public userDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public userDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Userdata> Userdatas
		{
			get
			{
				return this.GetTable<Userdata>();
			}
		}
		
		public System.Data.Linq.Table<InformalSkill> InformalSkills
		{
			get
			{
				return this.GetTable<InformalSkill>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Userdata")]
	public partial class Userdata : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _password;
		
		private string _Email;
		
		private string _contactNumber;
		
		private string _alternativeNumber;
		
		private string _address;
		
		private System.Nullable<int> _authinticationLevel;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _ProfileImage;
		
		private EntitySet<InformalSkill> _InformalSkills;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OncontactNumberChanging(string value);
    partial void OncontactNumberChanged();
    partial void OnalternativeNumberChanging(string value);
    partial void OnalternativeNumberChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    partial void OnauthinticationLevelChanging(System.Nullable<int> value);
    partial void OnauthinticationLevelChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnProfileImageChanging(string value);
    partial void OnProfileImageChanged();
    #endregion
		
		public Userdata()
		{
			this._InformalSkills = new EntitySet<InformalSkill>(new Action<InformalSkill>(this.attach_InformalSkills), new Action<InformalSkill>(this.detach_InformalSkills));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contactNumber", DbType="VarChar(50)")]
		public string contactNumber
		{
			get
			{
				return this._contactNumber;
			}
			set
			{
				if ((this._contactNumber != value))
				{
					this.OncontactNumberChanging(value);
					this.SendPropertyChanging();
					this._contactNumber = value;
					this.SendPropertyChanged("contactNumber");
					this.OncontactNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alternativeNumber", DbType="VarChar(50)")]
		public string alternativeNumber
		{
			get
			{
				return this._alternativeNumber;
			}
			set
			{
				if ((this._alternativeNumber != value))
				{
					this.OnalternativeNumberChanging(value);
					this.SendPropertyChanging();
					this._alternativeNumber = value;
					this.SendPropertyChanged("alternativeNumber");
					this.OnalternativeNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authinticationLevel", DbType="Int")]
		public System.Nullable<int> authinticationLevel
		{
			get
			{
				return this._authinticationLevel;
			}
			set
			{
				if ((this._authinticationLevel != value))
				{
					this.OnauthinticationLevelChanging(value);
					this.SendPropertyChanging();
					this._authinticationLevel = value;
					this.SendPropertyChanged("authinticationLevel");
					this.OnauthinticationLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="VarChar(50)")]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="VarChar(50)")]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProfileImage", DbType="VarChar(MAX)")]
		public string ProfileImage
		{
			get
			{
				return this._ProfileImage;
			}
			set
			{
				if ((this._ProfileImage != value))
				{
					this.OnProfileImageChanging(value);
					this.SendPropertyChanging();
					this._ProfileImage = value;
					this.SendPropertyChanged("ProfileImage");
					this.OnProfileImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Userdata_InformalSkill", Storage="_InformalSkills", ThisKey="Id", OtherKey="UserData_ID")]
		public EntitySet<InformalSkill> InformalSkills
		{
			get
			{
				return this._InformalSkills;
			}
			set
			{
				this._InformalSkills.Assign(value);
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
		
		private void attach_InformalSkills(InformalSkill entity)
		{
			this.SendPropertyChanging();
			entity.Userdata = this;
		}
		
		private void detach_InformalSkills(InformalSkill entity)
		{
			this.SendPropertyChanging();
			entity.Userdata = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.InformalSkills")]
	public partial class InformalSkill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Skill_ID;
		
		private string _Name;
		
		private System.Nullable<int> _UserData_ID;
		
		private EntityRef<Userdata> _Userdata;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSkill_IDChanging(int value);
    partial void OnSkill_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnUserData_IDChanging(System.Nullable<int> value);
    partial void OnUserData_IDChanged();
    #endregion
		
		public InformalSkill()
		{
			this._Userdata = default(EntityRef<Userdata>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Skill_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Skill_ID
		{
			get
			{
				return this._Skill_ID;
			}
			set
			{
				if ((this._Skill_ID != value))
				{
					this.OnSkill_IDChanging(value);
					this.SendPropertyChanging();
					this._Skill_ID = value;
					this.SendPropertyChanged("Skill_ID");
					this.OnSkill_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserData_ID", DbType="Int")]
		public System.Nullable<int> UserData_ID
		{
			get
			{
				return this._UserData_ID;
			}
			set
			{
				if ((this._UserData_ID != value))
				{
					if (this._Userdata.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserData_IDChanging(value);
					this.SendPropertyChanging();
					this._UserData_ID = value;
					this.SendPropertyChanged("UserData_ID");
					this.OnUserData_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Userdata_InformalSkill", Storage="_Userdata", ThisKey="UserData_ID", OtherKey="Id", IsForeignKey=true)]
		public Userdata Userdata
		{
			get
			{
				return this._Userdata.Entity;
			}
			set
			{
				Userdata previousValue = this._Userdata.Entity;
				if (((previousValue != value) 
							|| (this._Userdata.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Userdata.Entity = null;
						previousValue.InformalSkills.Remove(this);
					}
					this._Userdata.Entity = value;
					if ((value != null))
					{
						value.InformalSkills.Add(this);
						this._UserData_ID = value.Id;
					}
					else
					{
						this._UserData_ID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Userdata");
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
