﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4918
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class DataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertFavoriteSite(FavoriteSite instance);
  partial void UpdateFavoriteSite(FavoriteSite instance);
  partial void DeleteFavoriteSite(FavoriteSite instance);
  partial void InsertOAuthConsumer(OAuthConsumer instance);
  partial void UpdateOAuthConsumer(OAuthConsumer instance);
  partial void DeleteOAuthConsumer(OAuthConsumer instance);
  partial void InsertOAuthToken(OAuthToken instance);
  partial void UpdateOAuthToken(OAuthToken instance);
  partial void DeleteOAuthToken(OAuthToken instance);
  #endregion
	
	public DataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<FavoriteSite> FavoriteSites
	{
		get
		{
			return this.GetTable<FavoriteSite>();
		}
	}
	
	public System.Data.Linq.Table<OAuthConsumer> OAuthConsumers
	{
		get
		{
			return this.GetTable<OAuthConsumer>();
		}
	}
	
	public System.Data.Linq.Table<OAuthToken> OAuthTokens
	{
		get
		{
			return this.GetTable<OAuthToken>();
		}
	}
}

[Table(Name="dbo.[User]")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserId;
	
	private string _OpenIDClaimedIdentifier;
	
	private string _OpenIDFriendlyIdentifier;
	
	private string _FullName;
	
	private System.Nullable<int> _Age;
	
	private EntitySet<FavoriteSite> _FavoriteSites;
	
	private EntitySet<OAuthToken> _OAuthTokens;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnOpenIDClaimedIdentifierChanging(string value);
    partial void OnOpenIDClaimedIdentifierChanged();
    partial void OnOpenIDFriendlyIdentifierChanging(string value);
    partial void OnOpenIDFriendlyIdentifierChanged();
    partial void OnFullNameChanging(string value);
    partial void OnFullNameChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    #endregion
	
	public User()
	{
		this._FavoriteSites = new EntitySet<FavoriteSite>(new Action<FavoriteSite>(this.attach_FavoriteSites), new Action<FavoriteSite>(this.detach_FavoriteSites));
		this._OAuthTokens = new EntitySet<OAuthToken>(new Action<OAuthToken>(this.attach_OAuthTokens), new Action<OAuthToken>(this.detach_OAuthTokens));
		OnCreated();
	}
	
	[Column(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[Column(Storage="_OpenIDClaimedIdentifier", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
	public string OpenIDClaimedIdentifier
	{
		get
		{
			return this._OpenIDClaimedIdentifier;
		}
		set
		{
			if ((this._OpenIDClaimedIdentifier != value))
			{
				this.OnOpenIDClaimedIdentifierChanging(value);
				this.SendPropertyChanging();
				this._OpenIDClaimedIdentifier = value;
				this.SendPropertyChanged("OpenIDClaimedIdentifier");
				this.OnOpenIDClaimedIdentifierChanged();
			}
		}
	}
	
	[Column(Storage="_OpenIDFriendlyIdentifier", DbType="NVarChar(150)")]
	public string OpenIDFriendlyIdentifier
	{
		get
		{
			return this._OpenIDFriendlyIdentifier;
		}
		set
		{
			if ((this._OpenIDFriendlyIdentifier != value))
			{
				this.OnOpenIDFriendlyIdentifierChanging(value);
				this.SendPropertyChanging();
				this._OpenIDFriendlyIdentifier = value;
				this.SendPropertyChanged("OpenIDFriendlyIdentifier");
				this.OnOpenIDFriendlyIdentifierChanged();
			}
		}
	}
	
	[Column(Storage="_FullName", DbType="NVarChar(150)", CanBeNull=false)]
	public string FullName
	{
		get
		{
			return this._FullName;
		}
		set
		{
			if ((this._FullName != value))
			{
				this.OnFullNameChanging(value);
				this.SendPropertyChanging();
				this._FullName = value;
				this.SendPropertyChanged("FullName");
				this.OnFullNameChanged();
			}
		}
	}
	
	[Column(Storage="_Age", DbType="int")]
	public System.Nullable<int> Age
	{
		get
		{
			return this._Age;
		}
		set
		{
			if ((this._Age != value))
			{
				this.OnAgeChanging(value);
				this.SendPropertyChanging();
				this._Age = value;
				this.SendPropertyChanged("Age");
				this.OnAgeChanged();
			}
		}
	}
	
	[Association(Name="User_FavoriteSite", Storage="_FavoriteSites", ThisKey="UserId", OtherKey="UserId")]
	public EntitySet<FavoriteSite> FavoriteSites
	{
		get
		{
			return this._FavoriteSites;
		}
		set
		{
			this._FavoriteSites.Assign(value);
		}
	}
	
	[Association(Name="User_OAuthToken", Storage="_OAuthTokens", ThisKey="UserId", OtherKey="UserId")]
	public EntitySet<OAuthToken> OAuthTokens
	{
		get
		{
			return this._OAuthTokens;
		}
		set
		{
			this._OAuthTokens.Assign(value);
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
	
	private void attach_FavoriteSites(FavoriteSite entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_FavoriteSites(FavoriteSite entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
	
	private void attach_OAuthTokens(OAuthToken entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_OAuthTokens(OAuthToken entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}

[Table(Name="dbo.FavoriteSite")]
public partial class FavoriteSite : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _FavoriteSiteId;
	
	private int _UserId;
	
	private string _SiteUrl;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFavoriteSiteIdChanging(int value);
    partial void OnFavoriteSiteIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnSiteUrlChanging(string value);
    partial void OnSiteUrlChanged();
    #endregion
	
	public FavoriteSite()
	{
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[Column(Storage="_FavoriteSiteId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int FavoriteSiteId
	{
		get
		{
			return this._FavoriteSiteId;
		}
		set
		{
			if ((this._FavoriteSiteId != value))
			{
				this.OnFavoriteSiteIdChanging(value);
				this.SendPropertyChanging();
				this._FavoriteSiteId = value;
				this.SendPropertyChanged("FavoriteSiteId");
				this.OnFavoriteSiteIdChanged();
			}
		}
	}
	
	[Column(Storage="_UserId", DbType="Int NOT NULL")]
	public int UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[Column(Storage="_SiteUrl", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
	public string SiteUrl
	{
		get
		{
			return this._SiteUrl;
		}
		set
		{
			if ((this._SiteUrl != value))
			{
				this.OnSiteUrlChanging(value);
				this.SendPropertyChanging();
				this._SiteUrl = value;
				this.SendPropertyChanged("SiteUrl");
				this.OnSiteUrlChanged();
			}
		}
	}
	
	[Association(Name="User_FavoriteSite", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.FavoriteSites.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.FavoriteSites.Add(this);
					this._UserId = value.UserId;
				}
				else
				{
					this._UserId = default(int);
				}
				this.SendPropertyChanged("User");
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

[Table(Name="dbo.OAuthConsumer")]
public partial class OAuthConsumer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ConsumerId;
	
	private string _ConsumerKey;
	
	private string _ConsumerSecret;
	
	private string _Callback;
	
	private DotNetOpenAuth.OAuth.VerificationCodeFormat _VerificationCodeFormat;
	
	private int _VerificationCodeLength;
	
	private EntitySet<OAuthToken> _OAuthTokens;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnConsumerIdChanging(int value);
    partial void OnConsumerIdChanged();
    partial void OnConsumerKeyChanging(string value);
    partial void OnConsumerKeyChanged();
    partial void OnConsumerSecretChanging(string value);
    partial void OnConsumerSecretChanged();
    partial void OnCallbackChanging(string value);
    partial void OnCallbackChanged();
    partial void OnVerificationCodeFormatChanging(DotNetOpenAuth.OAuth.VerificationCodeFormat value);
    partial void OnVerificationCodeFormatChanged();
    partial void OnVerificationCodeLengthChanging(int value);
    partial void OnVerificationCodeLengthChanged();
    #endregion
	
	public OAuthConsumer()
	{
		this._OAuthTokens = new EntitySet<OAuthToken>(new Action<OAuthToken>(this.attach_OAuthTokens), new Action<OAuthToken>(this.detach_OAuthTokens));
		OnCreated();
	}
	
	[Column(Storage="_ConsumerId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int ConsumerId
	{
		get
		{
			return this._ConsumerId;
		}
		set
		{
			if ((this._ConsumerId != value))
			{
				this.OnConsumerIdChanging(value);
				this.SendPropertyChanging();
				this._ConsumerId = value;
				this.SendPropertyChanged("ConsumerId");
				this.OnConsumerIdChanged();
			}
		}
	}
	
	[Column(Storage="_ConsumerKey", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ConsumerKey
	{
		get
		{
			return this._ConsumerKey;
		}
		set
		{
			if ((this._ConsumerKey != value))
			{
				this.OnConsumerKeyChanging(value);
				this.SendPropertyChanging();
				this._ConsumerKey = value;
				this.SendPropertyChanged("ConsumerKey");
				this.OnConsumerKeyChanged();
			}
		}
	}
	
	[Column(Storage="_ConsumerSecret", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string ConsumerSecret
	{
		get
		{
			return this._ConsumerSecret;
		}
		set
		{
			if ((this._ConsumerSecret != value))
			{
				this.OnConsumerSecretChanging(value);
				this.SendPropertyChanging();
				this._ConsumerSecret = value;
				this.SendPropertyChanged("ConsumerSecret");
				this.OnConsumerSecretChanged();
			}
		}
	}
	
	[Column(Storage="_Callback")]
	public string Callback
	{
		get
		{
			return this._Callback;
		}
		set
		{
			if ((this._Callback != value))
			{
				this.OnCallbackChanging(value);
				this.SendPropertyChanging();
				this._Callback = value;
				this.SendPropertyChanged("Callback");
				this.OnCallbackChanged();
			}
		}
	}
	
	[Column(Storage="_VerificationCodeFormat")]
	public DotNetOpenAuth.OAuth.VerificationCodeFormat VerificationCodeFormat
	{
		get
		{
			return this._VerificationCodeFormat;
		}
		set
		{
			if ((this._VerificationCodeFormat != value))
			{
				this.OnVerificationCodeFormatChanging(value);
				this.SendPropertyChanging();
				this._VerificationCodeFormat = value;
				this.SendPropertyChanged("VerificationCodeFormat");
				this.OnVerificationCodeFormatChanged();
			}
		}
	}
	
	[Column(Storage="_VerificationCodeLength")]
	public int VerificationCodeLength
	{
		get
		{
			return this._VerificationCodeLength;
		}
		set
		{
			if ((this._VerificationCodeLength != value))
			{
				this.OnVerificationCodeLengthChanging(value);
				this.SendPropertyChanging();
				this._VerificationCodeLength = value;
				this.SendPropertyChanged("VerificationCodeLength");
				this.OnVerificationCodeLengthChanged();
			}
		}
	}
	
	[Association(Name="OAuthConsumer_OAuthToken", Storage="_OAuthTokens", ThisKey="ConsumerId", OtherKey="ConsumerId")]
	public EntitySet<OAuthToken> OAuthTokens
	{
		get
		{
			return this._OAuthTokens;
		}
		set
		{
			this._OAuthTokens.Assign(value);
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
	
	private void attach_OAuthTokens(OAuthToken entity)
	{
		this.SendPropertyChanging();
		entity.OAuthConsumer = this;
	}
	
	private void detach_OAuthTokens(OAuthToken entity)
	{
		this.SendPropertyChanging();
		entity.OAuthConsumer = null;
	}
}

[Table(Name="dbo.OAuthToken")]
public partial class OAuthToken : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _TokenId;
	
	private string _Token;
	
	private string _TokenSecret;
	
	private TokenAuthorizationState _State;
	
	private System.DateTime _IssueDate;
	
	private int _ConsumerId;
	
	private System.Nullable<int> _UserId;
	
	private string _Scope;
	
	private string _RequestTokenVerifier;
	
	private string _RequestTokenCallback;
	
	private string _ConsumerVersion;
	
	private EntityRef<OAuthConsumer> _OAuthConsumer;
	
	private EntityRef<User> _User;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTokenIdChanging(int value);
    partial void OnTokenIdChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    partial void OnTokenSecretChanging(string value);
    partial void OnTokenSecretChanged();
    partial void OnStateChanging(TokenAuthorizationState value);
    partial void OnStateChanged();
    partial void OnIssueDateChanging(System.DateTime value);
    partial void OnIssueDateChanged();
    partial void OnConsumerIdChanging(int value);
    partial void OnConsumerIdChanged();
    partial void OnUserIdChanging(System.Nullable<int> value);
    partial void OnUserIdChanged();
    partial void OnScopeChanging(string value);
    partial void OnScopeChanged();
    partial void OnRequestTokenVerifierChanging(string value);
    partial void OnRequestTokenVerifierChanged();
    partial void OnRequestTokenCallbackChanging(string value);
    partial void OnRequestTokenCallbackChanged();
    partial void OnConsumerVersionChanging(string value);
    partial void OnConsumerVersionChanged();
    #endregion
	
	public OAuthToken()
	{
		this._OAuthConsumer = default(EntityRef<OAuthConsumer>);
		this._User = default(EntityRef<User>);
		OnCreated();
	}
	
	[Column(Storage="_TokenId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int TokenId
	{
		get
		{
			return this._TokenId;
		}
		set
		{
			if ((this._TokenId != value))
			{
				this.OnTokenIdChanging(value);
				this.SendPropertyChanging();
				this._TokenId = value;
				this.SendPropertyChanged("TokenId");
				this.OnTokenIdChanged();
			}
		}
	}
	
	[Column(Storage="_Token", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string Token
	{
		get
		{
			return this._Token;
		}
		set
		{
			if ((this._Token != value))
			{
				this.OnTokenChanging(value);
				this.SendPropertyChanging();
				this._Token = value;
				this.SendPropertyChanged("Token");
				this.OnTokenChanged();
			}
		}
	}
	
	[Column(Storage="_TokenSecret", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
	public string TokenSecret
	{
		get
		{
			return this._TokenSecret;
		}
		set
		{
			if ((this._TokenSecret != value))
			{
				this.OnTokenSecretChanging(value);
				this.SendPropertyChanging();
				this._TokenSecret = value;
				this.SendPropertyChanged("TokenSecret");
				this.OnTokenSecretChanged();
			}
		}
	}
	
	[Column(Storage="_State", DbType="INT NOT NULL", CanBeNull=false)]
	public TokenAuthorizationState State
	{
		get
		{
			return this._State;
		}
		set
		{
			if ((this._State != value))
			{
				this.OnStateChanging(value);
				this.SendPropertyChanging();
				this._State = value;
				this.SendPropertyChanged("State");
				this.OnStateChanged();
			}
		}
	}
	
	[Column(Storage="_IssueDate", DbType="DateTime NOT NULL")]
	public System.DateTime IssueDate
	{
		get
		{
			return this._IssueDate;
		}
		set
		{
			if ((this._IssueDate != value))
			{
				this.OnIssueDateChanging(value);
				this.SendPropertyChanging();
				this._IssueDate = value;
				this.SendPropertyChanged("IssueDate");
				this.OnIssueDateChanged();
			}
		}
	}
	
	[Column(Storage="_ConsumerId", DbType="Int NOT NULL")]
	public int ConsumerId
	{
		get
		{
			return this._ConsumerId;
		}
		set
		{
			if ((this._ConsumerId != value))
			{
				if (this._OAuthConsumer.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnConsumerIdChanging(value);
				this.SendPropertyChanging();
				this._ConsumerId = value;
				this.SendPropertyChanged("ConsumerId");
				this.OnConsumerIdChanged();
			}
		}
	}
	
	[Column(Storage="_UserId", DbType="Int")]
	public System.Nullable<int> UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[Column(Storage="_Scope", DbType="nvarchar(MAX)", CanBeNull=false)]
	public string Scope
	{
		get
		{
			return this._Scope;
		}
		set
		{
			if ((this._Scope != value))
			{
				this.OnScopeChanging(value);
				this.SendPropertyChanging();
				this._Scope = value;
				this.SendPropertyChanged("Scope");
				this.OnScopeChanged();
			}
		}
	}
	
	[Column(Storage="_RequestTokenVerifier")]
	public string RequestTokenVerifier
	{
		get
		{
			return this._RequestTokenVerifier;
		}
		set
		{
			if ((this._RequestTokenVerifier != value))
			{
				this.OnRequestTokenVerifierChanging(value);
				this.SendPropertyChanging();
				this._RequestTokenVerifier = value;
				this.SendPropertyChanged("RequestTokenVerifier");
				this.OnRequestTokenVerifierChanged();
			}
		}
	}
	
	[Column(Storage="_RequestTokenCallback")]
	public string RequestTokenCallback
	{
		get
		{
			return this._RequestTokenCallback;
		}
		set
		{
			if ((this._RequestTokenCallback != value))
			{
				this.OnRequestTokenCallbackChanging(value);
				this.SendPropertyChanging();
				this._RequestTokenCallback = value;
				this.SendPropertyChanged("RequestTokenCallback");
				this.OnRequestTokenCallbackChanged();
			}
		}
	}
	
	[Column(Storage="_ConsumerVersion")]
	public string ConsumerVersion
	{
		get
		{
			return this._ConsumerVersion;
		}
		set
		{
			if ((this._ConsumerVersion != value))
			{
				this.OnConsumerVersionChanging(value);
				this.SendPropertyChanging();
				this._ConsumerVersion = value;
				this.SendPropertyChanged("ConsumerVersion");
				this.OnConsumerVersionChanged();
			}
		}
	}
	
	[Association(Name="OAuthConsumer_OAuthToken", Storage="_OAuthConsumer", ThisKey="ConsumerId", OtherKey="ConsumerId", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
	public OAuthConsumer OAuthConsumer
	{
		get
		{
			return this._OAuthConsumer.Entity;
		}
		set
		{
			OAuthConsumer previousValue = this._OAuthConsumer.Entity;
			if (((previousValue != value) 
						|| (this._OAuthConsumer.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._OAuthConsumer.Entity = null;
					previousValue.OAuthTokens.Remove(this);
				}
				this._OAuthConsumer.Entity = value;
				if ((value != null))
				{
					value.OAuthTokens.Add(this);
					this._ConsumerId = value.ConsumerId;
				}
				else
				{
					this._ConsumerId = default(int);
				}
				this.SendPropertyChanged("OAuthConsumer");
			}
		}
	}
	
	[Association(Name="User_OAuthToken", Storage="_User", ThisKey="UserId", OtherKey="UserId", IsForeignKey=true, DeleteRule="CASCADE")]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.OAuthTokens.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.OAuthTokens.Add(this);
					this._UserId = value.UserId;
				}
				else
				{
					this._UserId = default(Nullable<int>);
				}
				this.SendPropertyChanged("User");
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
#pragma warning restore 1591
