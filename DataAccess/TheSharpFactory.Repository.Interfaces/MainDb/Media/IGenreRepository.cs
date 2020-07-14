/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{
    public partial interface IGenreRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Media;

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{

    /// <summary>
    /// This interface represents the contract to exchange data with a Repository for a Genre.
    /// </summary>
    public partial interface IGenreRepository
    {
        #region Get
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre ByPK(int genreid);
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre ByPK(int genreid, NavProps<GenreNavProperty> navprops);
        #endregion
        #region Top
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        List<Genre> Top(int topcount, Query<GenreProperty> query);
        /// <summary>
        /// Performs a select top N TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object.
        /// </summary>
        /// <param name="topcount">Max item count expected in the result.</param>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        List<Genre> Top(int topcount, Query<GenreProperty, GenreNavProperty> query);
        #endregion
        #region FirstOrDefault
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre FirstOrDefault(Query<GenreProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Returns null if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre FirstOrDefault(Query<GenreProperty, GenreNavProperty> query);
        #endregion
        #region First
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre First(Query<GenreProperty> query);
        /// <summary>
        /// Performs a select top 1 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Throws InvalidOperationException if none are found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre First(Query<GenreProperty, GenreNavProperty> query);
        #endregion
        #region SingleOrDefault
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre SingleOrDefault(Query<GenreProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Returns null if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre SingleOrDefault(Query<GenreProperty, GenreNavProperty> query);
        #endregion
        #region Single
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre Single(Query<GenreProperty> query);
        /// <summary>
        /// Performs a select top 2 TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object. Throws InvalidOperationException if none are found. Throws InvalidOperationException if more than one is found.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        Genre Single(Query<GenreProperty, GenreNavProperty> query);
        #endregion
        #region ToList
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        List<Genre> ToList(Query<GenreProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Genre from the database based on a Query object.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        List<Genre> ToList(Query<GenreProperty, GenreNavProperty> query);
        /// <summary>
        /// Gets List of TheSharpFactory.Entity.MainDb.Media.Genre from the database. No filtering.
        /// </summary>
        /// <returns>List of TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        List<Genre> ToList();
        #endregion
        #region Create
        /// <summary>
        /// Creates the specified TheSharpFactory.Entity.MainDb.Media.Genre in the database.
        /// </summary>
        /// <param name="genre">The TheSharpFactory.Entity.MainDb.Media.Genre to create.</param>
        /// <returns>True if succeeded. False if it already exists.</returns>
        bool Create(Genre genre);
        /// <summary>
        /// Creates each TheSharpFactory.Entity.MainDb.Media.Genre from the list in the database.
        /// </summary>
        /// <param name="genres">List of TheSharpFactory.Entity.MainDb.Media.Genre to create.</param>
        /// <returns>void</returns>
        void Create(List<Genre> genres);
        #endregion
        #region Update
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Genre in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="genre">The TheSharpFactory.Entity.MainDb.Media.Genre to update.</param>
        /// <returns>True if succeeded. False if it does not exist or if no changes were made.</returns>
        bool Update(Genre genre);
        /// <summary>
        /// Updates all Entities from the database that match the query specified. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The list of updated entities.</returns>
        List<Genre> Update(Query<GenreProperty> query);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Genre in the database.</para><para>This method only updates those fields that have changed. Compares original to changed.</para><para>If no fields have changed then no call is made to the database.</para><para>WARNING: This method allows changes to PrimaryKey, Unique Keys, and Identity.</para>
        /// </summary>
        /// <param name="original">The original Entity.</param>
        /// <param name="changed">The changed Entity.</param>
        /// <returns>True if succeeded. False if no changes found.</returns>
        bool Update(Genre original, Genre changed);
        /// <summary>
        /// <para>Updates the specified TheSharpFactory.Entity.MainDb.Media.Genre in the database. If not found then it is created.</para><para>This function only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="genre">The TheSharpFactory.Entity.MainDb.Media.Genre to update or create.</param>
        /// <returns>True if succeeded. False if it already exists but no chages were made.</returns>
        bool UpdateOrCreate(Genre genre);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Genre from the list in the database.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="genres">List of TheSharpFactory.Entity.MainDb.Media.Genre to update.</param>
        /// <returns>void</returns>
        void Update(List<Genre> genres);
        /// <summary>
        /// <para>Updates each TheSharpFactory.Entity.MainDb.Media.Genre from the list in the database. Creates them if not found.</para><para>This method only updates those fields that have changed.</para><para>If no fields have changed then no call is made to the database.</para>
        /// </summary>
        /// <param name="genres">List of TheSharpFactory.Entity.MainDb.Media.Genre to update or create.</param>
        /// <returns>void</returns>
        void UpdateOrCreate(List<Genre> genres);
        #endregion
        #region Delete
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool DeleteByPK(int genreid);
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database.
        /// </summary>
        /// <param name="genre">The TheSharpFactory.Entity.MainDb.Media.Genre to update.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        bool Delete(Genre genre);
        /// <summary>
        /// Deletes all Entities from the database that match the filters specified in the Query. Supports filtering.
        /// </summary>
        /// <param name="query">Represents the query to use.</param>
        /// <returns>The number of deleted records.</returns>
        int Delete(Query<GenreProperty> query);
        /// <summary>
        /// Deletes each TheSharpFactory.Entity.MainDb.Media.Genre in the list from the database.
        /// </summary>
        /// <param name="genres">List of TheSharpFactory.Entity.MainDb.Media.Genre to delete.</param>
        /// <returns>void</returns>
        void Delete(List<Genre> genres);
        #endregion
    }
}
