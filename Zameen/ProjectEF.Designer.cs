﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace HtmlReader
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ProjectEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProjectEntities object using the connection string found in the 'ProjectEntities' section of the application configuration file.
        /// </summary>
        public ProjectEntities() : base("name=ProjectEntities", "ProjectEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectEntities object.
        /// </summary>
        public ProjectEntities(string connectionString) : base(connectionString, "ProjectEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectEntities object.
        /// </summary>
        public ProjectEntities(EntityConnection connection) : base(connection, "ProjectEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<AppSetting> AppSettings
        {
            get
            {
                if ((_AppSettings == null))
                {
                    _AppSettings = base.CreateObjectSet<AppSetting>("AppSettings");
                }
                return _AppSettings;
            }
        }
        private ObjectSet<AppSetting> _AppSettings;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SearchFilter> SearchFilters
        {
            get
            {
                if ((_SearchFilters == null))
                {
                    _SearchFilters = base.CreateObjectSet<SearchFilter>("SearchFilters");
                }
                return _SearchFilters;
            }
        }
        private ObjectSet<SearchFilter> _SearchFilters;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the AppSettings EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAppSettings(AppSetting appSetting)
        {
            base.AddObject("AppSettings", appSetting);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the SearchFilters EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSearchFilters(SearchFilter searchFilter)
        {
            base.AddObject("SearchFilters", searchFilter);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProjectModel", Name="AppSetting")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class AppSetting : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new AppSetting object.
        /// </summary>
        /// <param name="appSettingID">Initial value of the AppSettingID property.</param>
        /// <param name="appSettingName">Initial value of the AppSettingName property.</param>
        /// <param name="appSettingValue">Initial value of the AppSettingValue property.</param>
        /// <param name="description">Initial value of the Description property.</param>
        public static AppSetting CreateAppSetting(global::System.Int64 appSettingID, global::System.String appSettingName, global::System.String appSettingValue, global::System.String description)
        {
            AppSetting appSetting = new AppSetting();
            appSetting.AppSettingID = appSettingID;
            appSetting.AppSettingName = appSettingName;
            appSetting.AppSettingValue = appSettingValue;
            appSetting.Description = description;
            return appSetting;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 AppSettingID
        {
            get
            {
                return _AppSettingID;
            }
            set
            {
                if (_AppSettingID != value)
                {
                    OnAppSettingIDChanging(value);
                    ReportPropertyChanging("AppSettingID");
                    _AppSettingID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AppSettingID");
                    OnAppSettingIDChanged();
                }
            }
        }
        private global::System.Int64 _AppSettingID;
        partial void OnAppSettingIDChanging(global::System.Int64 value);
        partial void OnAppSettingIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AppSettingName
        {
            get
            {
                return _AppSettingName;
            }
            set
            {
                OnAppSettingNameChanging(value);
                ReportPropertyChanging("AppSettingName");
                _AppSettingName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AppSettingName");
                OnAppSettingNameChanged();
            }
        }
        private global::System.String _AppSettingName;
        partial void OnAppSettingNameChanging(global::System.String value);
        partial void OnAppSettingNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AppSettingValue
        {
            get
            {
                return _AppSettingValue;
            }
            set
            {
                OnAppSettingValueChanging(value);
                ReportPropertyChanging("AppSettingValue");
                _AppSettingValue = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("AppSettingValue");
                OnAppSettingValueChanged();
            }
        }
        private global::System.String _AppSettingValue;
        partial void OnAppSettingValueChanging(global::System.String value);
        partial void OnAppSettingValueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ProjectModel", Name="SearchFilter")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SearchFilter : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new SearchFilter object.
        /// </summary>
        /// <param name="searchFilterID">Initial value of the SearchFilterID property.</param>
        /// <param name="filterText">Initial value of the FilterText property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        public static SearchFilter CreateSearchFilter(global::System.Int64 searchFilterID, global::System.String filterText, global::System.String title)
        {
            SearchFilter searchFilter = new SearchFilter();
            searchFilter.SearchFilterID = searchFilterID;
            searchFilter.FilterText = filterText;
            searchFilter.Title = title;
            return searchFilter;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 SearchFilterID
        {
            get
            {
                return _SearchFilterID;
            }
            set
            {
                if (_SearchFilterID != value)
                {
                    OnSearchFilterIDChanging(value);
                    ReportPropertyChanging("SearchFilterID");
                    _SearchFilterID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SearchFilterID");
                    OnSearchFilterIDChanged();
                }
            }
        }
        private global::System.Int64 _SearchFilterID;
        partial void OnSearchFilterIDChanging(global::System.Int64 value);
        partial void OnSearchFilterIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FilterText
        {
            get
            {
                return _FilterText;
            }
            set
            {
                OnFilterTextChanging(value);
                ReportPropertyChanging("FilterText");
                _FilterText = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FilterText");
                OnFilterTextChanged();
            }
        }
        private global::System.String _FilterText;
        partial void OnFilterTextChanging(global::System.String value);
        partial void OnFilterTextChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion

    
    }

    #endregion

    
}
