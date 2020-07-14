/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.People
{
    public partial interface IEmployeeRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.People;

namespace TheSharpFactory.Repository.Interfaces.MainDb.People
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a Employee.
    /// </summary>
    public partial interface IEmployeeRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee ByPK(int employeeid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee ByPK(int employeeid, NavProps<EmployeeNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.People.Employee</returns>
        List<Employee> Top(int topcount, Query<EmployeeProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.People.Employee</returns>
        List<Employee> Top(int topcount, Query<EmployeeProperty, EmployeeNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee FirstOrDefault(Query<EmployeeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee FirstOrDefault(Query<EmployeeProperty, EmployeeNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee First(Query<EmployeeProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee First(Query<EmployeeProperty, EmployeeNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee SingleOrDefault(Query<EmployeeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee SingleOrDefault(Query<EmployeeProperty, EmployeeNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee Single(Query<EmployeeProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.People.Employee</returns>
        Employee Single(Query<EmployeeProperty, EmployeeNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.People.Employee</returns>
        List<Employee> ToList(Query<EmployeeProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.People.Employee from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.People.Employee</returns>
        List<Employee> ToList(Query<EmployeeProperty, EmployeeNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.People.Employee from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.People.Employee</returns>
        List<Employee> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.People.Employee in the database.
        /// </summary>
        /// <param name="employee">The TheSharpFactory.Entity.MainDb.People.Employee to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Employee employee);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.People.Employee from the list in the database.
        /// </summary>
        /// <param name="employees">List of TheSharpFactory.Entity.MainDb.People.Employee to create.</param>
        /// <returns>void</returns>
        void Create(List<Employee> employees);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.People.Employee in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="employee">The TheSharpFactory.Entity.MainDb.People.Employee to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Employee employee);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Employee> Update(Query<EmployeeProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.People.Employee in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Employee original, Employee changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.People.Employee in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="employee">The TheSharpFactory.Entity.MainDb.People.Employee to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Employee employee);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.People.Employee from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="employees">List of TheSharpFactory.Entity.MainDb.People.Employee to update.</param>
        /// <returns>void</returns>
        void Update(List<Employee> employees);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.People.Employee from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="employees">List of TheSharpFactory.Entity.MainDb.People.Employee to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Employee> employees);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.People.Employee from the database by Primary Key.
        /// </summary>
        /// <param name="employeeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int employeeid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.People.Employee from the database.
        /// </summary>
        /// <param name="employee">The TheSharpFactory.Entity.MainDb.People.Employee to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Employee employee);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<EmployeeProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.People.Employee in the list from the database.
        /// </summary>
        /// <param name="employees">List of TheSharpFactory.Entity.MainDb.People.Employee to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Employee> employees);
        #endregion
    }
}
