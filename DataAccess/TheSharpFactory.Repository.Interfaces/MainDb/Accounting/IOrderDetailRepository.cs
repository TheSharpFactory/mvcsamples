/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Accounting
{
    public partial interface IOrderDetailRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Accounting;

namespace TheSharpFactory.Repository.Interfaces.MainDb.Accounting
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a OrderDetail.
    /// </summary>
    public partial interface IOrderDetailRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Identity.
        /// </summary>
        /// <param name="id">The identity of this Entity.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail ById(int id);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Primary Key.
        /// </summary>
        /// <param name="id">Primary Key Field.</param>
        /// <param name="subid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail ByPK(int id, string subid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Unique Key named UK_OrderDetail_Name.
        /// </summary>
        /// <param name="name">Unique Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail ByUK(string name);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        List<OrderDetail> Top(int topcount, Query<OrderDetailProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail FirstOrDefault(Query<OrderDetailProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail First(Query<OrderDetailProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail SingleOrDefault(Query<OrderDetailProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        OrderDetail Single(Query<OrderDetailProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        List<OrderDetail> ToList(Query<OrderDetailProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail</returns>
        List<OrderDetail> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail in the database.
        /// </summary>
        /// <param name="orderdetail">The TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(OrderDetail orderdetail);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the list in the database.
        /// </summary>
        /// <param name="orderdetails">List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to create.</param>
        /// <returns>void</returns>
        void Create(List<OrderDetail> orderdetails);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="orderdetail">The TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(OrderDetail orderdetail);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<OrderDetail> Update(Query<OrderDetailProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(OrderDetail original, OrderDetail changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="orderdetail">The TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(OrderDetail orderdetail);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="orderdetails">List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to update.</param>
        /// <returns>void</returns>
        void Update(List<OrderDetail> orderdetails);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="orderdetails">List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<OrderDetail> orderdetails);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Identity.
        /// </summary>
        /// <param name="id">The identity of this Entity.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteById(int id);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Primary Key.
        /// </summary>
        /// <param name="id">Primary Key Field.</param>
        /// <param name="subid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int id, string subid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database by Unique Key named UK_OrderDetail_Name
        /// </summary>
        /// <param name="name">Unique Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByUK(string name);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Accounting.OrderDetail from the database.
        /// </summary>
        /// <param name="orderdetail">The TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(OrderDetail orderdetail);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<OrderDetailProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.Accounting.OrderDetail in the list from the database.
        /// </summary>
        /// <param name="orderdetails">List of TheSharpFactory.Entity.MainDb.Accounting.OrderDetail to delete.</param>
        /// <returns>void</returns>
        void Delete(List<OrderDetail> orderdetails);
        #endregion
    }
}
