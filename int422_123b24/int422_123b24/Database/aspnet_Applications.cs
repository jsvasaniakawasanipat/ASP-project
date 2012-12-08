//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace int422_123b24.Database
{
    public partial class aspnet_Applications
    {
        #region Primitive Properties
    
        public virtual string ApplicationName
        {
            get;
            set;
        }
    
        public virtual string LoweredApplicationName
        {
            get;
            set;
        }
    
        public virtual System.Guid ApplicationId
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<aspnet_Membership> aspnet_Membership
        {
            get
            {
                if (_aspnet_Membership == null)
                {
                    var newCollection = new FixupCollection<aspnet_Membership>();
                    newCollection.CollectionChanged += Fixupaspnet_Membership;
                    _aspnet_Membership = newCollection;
                }
                return _aspnet_Membership;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_Membership, value))
                {
                    var previousValue = _aspnet_Membership as FixupCollection<aspnet_Membership>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_Membership;
                    }
                    _aspnet_Membership = value;
                    var newValue = value as FixupCollection<aspnet_Membership>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_Membership;
                    }
                }
            }
        }
        private ICollection<aspnet_Membership> _aspnet_Membership;
    
        public virtual ICollection<aspnet_Paths> aspnet_Paths
        {
            get
            {
                if (_aspnet_Paths == null)
                {
                    var newCollection = new FixupCollection<aspnet_Paths>();
                    newCollection.CollectionChanged += Fixupaspnet_Paths;
                    _aspnet_Paths = newCollection;
                }
                return _aspnet_Paths;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_Paths, value))
                {
                    var previousValue = _aspnet_Paths as FixupCollection<aspnet_Paths>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_Paths;
                    }
                    _aspnet_Paths = value;
                    var newValue = value as FixupCollection<aspnet_Paths>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_Paths;
                    }
                }
            }
        }
        private ICollection<aspnet_Paths> _aspnet_Paths;
    
        public virtual ICollection<aspnet_Roles> aspnet_Roles
        {
            get
            {
                if (_aspnet_Roles == null)
                {
                    var newCollection = new FixupCollection<aspnet_Roles>();
                    newCollection.CollectionChanged += Fixupaspnet_Roles;
                    _aspnet_Roles = newCollection;
                }
                return _aspnet_Roles;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_Roles, value))
                {
                    var previousValue = _aspnet_Roles as FixupCollection<aspnet_Roles>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_Roles;
                    }
                    _aspnet_Roles = value;
                    var newValue = value as FixupCollection<aspnet_Roles>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_Roles;
                    }
                }
            }
        }
        private ICollection<aspnet_Roles> _aspnet_Roles;
    
        public virtual ICollection<aspnet_Users> aspnet_Users
        {
            get
            {
                if (_aspnet_Users == null)
                {
                    var newCollection = new FixupCollection<aspnet_Users>();
                    newCollection.CollectionChanged += Fixupaspnet_Users;
                    _aspnet_Users = newCollection;
                }
                return _aspnet_Users;
            }
            set
            {
                if (!ReferenceEquals(_aspnet_Users, value))
                {
                    var previousValue = _aspnet_Users as FixupCollection<aspnet_Users>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= Fixupaspnet_Users;
                    }
                    _aspnet_Users = value;
                    var newValue = value as FixupCollection<aspnet_Users>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += Fixupaspnet_Users;
                    }
                }
            }
        }
        private ICollection<aspnet_Users> _aspnet_Users;

        #endregion
        #region Association Fixup
    
        private void Fixupaspnet_Membership(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_Membership item in e.NewItems)
                {
                    item.aspnet_Applications = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_Membership item in e.OldItems)
                {
                    if (ReferenceEquals(item.aspnet_Applications, this))
                    {
                        item.aspnet_Applications = null;
                    }
                }
            }
        }
    
        private void Fixupaspnet_Paths(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_Paths item in e.NewItems)
                {
                    item.aspnet_Applications = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_Paths item in e.OldItems)
                {
                    if (ReferenceEquals(item.aspnet_Applications, this))
                    {
                        item.aspnet_Applications = null;
                    }
                }
            }
        }
    
        private void Fixupaspnet_Roles(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_Roles item in e.NewItems)
                {
                    item.aspnet_Applications = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_Roles item in e.OldItems)
                {
                    if (ReferenceEquals(item.aspnet_Applications, this))
                    {
                        item.aspnet_Applications = null;
                    }
                }
            }
        }
    
        private void Fixupaspnet_Users(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (aspnet_Users item in e.NewItems)
                {
                    item.aspnet_Applications = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (aspnet_Users item in e.OldItems)
                {
                    if (ReferenceEquals(item.aspnet_Applications, this))
                    {
                        item.aspnet_Applications = null;
                    }
                }
            }
        }

        #endregion
    }
}
