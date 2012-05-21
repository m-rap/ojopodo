﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace mppl.Entiti
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ojopodoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ojopodoEntities object using the connection string found in the 'ojopodoEntities' section of the application configuration file.
        /// </summary>
        public ojopodoEntities() : base("name=ojopodoEntities", "ojopodoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ojopodoEntities object.
        /// </summary>
        public ojopodoEntities(string connectionString) : base(connectionString, "ojopodoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ojopodoEntities object.
        /// </summary>
        public ojopodoEntities(EntityConnection connection) : base(connection, "ojopodoEntities")
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
        public ObjectSet<dokumen> dokumen
        {
            get
            {
                if ((_dokumen == null))
                {
                    _dokumen = base.CreateObjectSet<dokumen>("dokumen");
                }
                return _dokumen;
            }
        }
        private ObjectSet<dokumen> _dokumen;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<user> user
        {
            get
            {
                if ((_user == null))
                {
                    _user = base.CreateObjectSet<user>("user");
                }
                return _user;
            }
        }
        private ObjectSet<user> _user;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the dokumen EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTodokumen(dokumen dokumen)
        {
            base.AddObject("dokumen", dokumen);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the user EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTouser(user user)
        {
            base.AddObject("user", user);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ojopodoModel", Name="dokumen")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class dokumen : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new dokumen object.
        /// </summary>
        /// <param name="id_dokumen">Initial value of the id_dokumen property.</param>
        public static dokumen Createdokumen(global::System.Int64 id_dokumen)
        {
            dokumen dokumen = new dokumen();
            dokumen.id_dokumen = id_dokumen;
            return dokumen;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 id_dokumen
        {
            get
            {
                return _id_dokumen;
            }
            set
            {
                if (_id_dokumen != value)
                {
                    Onid_dokumenChanging(value);
                    ReportPropertyChanging("id_dokumen");
                    _id_dokumen = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_dokumen");
                    Onid_dokumenChanged();
                }
            }
        }
        private global::System.Int64 _id_dokumen;
        partial void Onid_dokumenChanging(global::System.Int64 value);
        partial void Onid_dokumenChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String judul
        {
            get
            {
                return _judul;
            }
            set
            {
                OnjudulChanging(value);
                ReportPropertyChanging("judul");
                _judul = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("judul");
                OnjudulChanged();
            }
        }
        private global::System.String _judul;
        partial void OnjudulChanging(global::System.String value);
        partial void OnjudulChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String pengarang
        {
            get
            {
                return _pengarang;
            }
            set
            {
                OnpengarangChanging(value);
                ReportPropertyChanging("pengarang");
                _pengarang = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("pengarang");
                OnpengarangChanged();
            }
        }
        private global::System.String _pengarang;
        partial void OnpengarangChanging(global::System.String value);
        partial void OnpengarangChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String alamat_fingerprint
        {
            get
            {
                return _alamat_fingerprint;
            }
            set
            {
                Onalamat_fingerprintChanging(value);
                ReportPropertyChanging("alamat_fingerprint");
                _alamat_fingerprint = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("alamat_fingerprint");
                Onalamat_fingerprintChanged();
            }
        }
        private global::System.String _alamat_fingerprint;
        partial void Onalamat_fingerprintChanging(global::System.String value);
        partial void Onalamat_fingerprintChanged();

        #endregion
    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ojopodoModel", Name="user")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class user : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new user object.
        /// </summary>
        /// <param name="id_user">Initial value of the id_user property.</param>
        public static user Createuser(global::System.Int32 id_user)
        {
            user user = new user();
            user.id_user = id_user;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 id_user
        {
            get
            {
                return _id_user;
            }
            set
            {
                if (_id_user != value)
                {
                    Onid_userChanging(value);
                    ReportPropertyChanging("id_user");
                    _id_user = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("id_user");
                    Onid_userChanged();
                }
            }
        }
        private global::System.Int32 _id_user;
        partial void Onid_userChanging(global::System.Int32 value);
        partial void Onid_userChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String namauser
        {
            get
            {
                return _namauser;
            }
            set
            {
                OnnamauserChanging(value);
                ReportPropertyChanging("namauser");
                _namauser = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("namauser");
                OnnamauserChanged();
            }
        }
        private global::System.String _namauser;
        partial void OnnamauserChanging(global::System.String value);
        partial void OnnamauserChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String katasandi
        {
            get
            {
                return _katasandi;
            }
            set
            {
                OnkatasandiChanging(value);
                ReportPropertyChanging("katasandi");
                _katasandi = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("katasandi");
                OnkatasandiChanged();
            }
        }
        private global::System.String _katasandi;
        partial void OnkatasandiChanging(global::System.String value);
        partial void OnkatasandiChanged();

        #endregion
    
    }

    #endregion
    
}
