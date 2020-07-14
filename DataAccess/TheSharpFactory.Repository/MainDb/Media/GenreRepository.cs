/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class GenreRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TheSharpFactory.Repository.Common;
using TheSharpFactory.Repository.Interfaces.MainDb.Media;
using TheSharpFactory.Query;
using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Entity.Utils.MainDb.Media;
using MainDbE = TheSharpFactory.Entity.MainDb;

namespace TheSharpFactory.Repository.MainDb.Media
{

    /// <summary>
    /// This class represents the Repository for: Genre.
    /// </summary>
    public partial class GenreRepository:WritableRepositoryBase<Genre, GenreProperty, GenreNavProperty>, IGenreRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<GenreNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<GenreNavProperty, NavPropertyInfo>(1){ { GenreNavProperty.Tracks, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Track, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.GenreProperty.GenreId, OtherPropId = (int)MainDbE.Media.TrackProperty.GenreId, },} } },};
        #endregion
        #region Constructors
        public GenreRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_Genre;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Genre__0385057E7F60ED59) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<GenreProperty>(1){ SortFilter.New(GenreProperty.GenreId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        public Genre ByPK(int genreid)
        {
            var where = new QueryFilters<GenreProperty>(1){QueryFilter.New(GenreProperty.GenreId, FilterConditions.Equals, genreid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Genre</returns>
        public Genre ByPK(int genreid, NavProps<GenreNavProperty> navprops)
        {
            var where = new QueryFilters<GenreProperty>(1){QueryFilter.New(GenreProperty.GenreId, FilterConditions.Equals, genreid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Genre from the database by Primary Key.
        /// </summary>
        /// <param name="genreid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int genreid)
        {
            var where = new QueryFilters<GenreProperty>(1){QueryFilter.New(GenreProperty.GenreId, FilterConditions.Equals, genreid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<GenreProperty> ComposeKeys(Genre genre)
        {
            return new QueryFilters<GenreProperty>{ QueryFilter.New(GenreProperty.GenreId, FilterConditions.Equals, genre.GenreId) };
        }
        protected override QueryFilters<GenreProperty> GetChanges(Genre original, Genre changed)
        {
            return GenreUtils.GetChanges(original, changed);
        }
        protected override void Merge(Genre source, Genre target)
        {
            GenreUtils.Merge(source, target);
        }
        protected override QueryFilters<GenreProperty> ComposeInsertPredicate(Genre genre)
        {
            return new QueryFilters<GenreProperty>{ QueryFilter.New(GenreProperty.Name, FilterConditions.Equals, genre.Name) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 2);
        }
        private static Genre MaterializeSingleEntity(SqlDataReader r)
        {
            return new Genre
            {
                GenreId = r.GetInt32(0),
                Name = r.GetString(1),
            };
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class.
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        protected override List<NavPropertyInfo> BuildNavPropInfoTree(NavProps navprops) 
        {
            return BuildNavPropInfos(navprops);
        }
        /// <summary>
        /// Composes the Navigation Property tree sent to the Database class
        /// </summary>
        /// <returns>
        /// List of NavPropertyInfo
        /// </returns>
        internal static List<NavPropertyInfo> BuildNavPropInfos(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                    return null;
            var result = new List<NavPropertyInfo>(navprops.Count);
            foreach(var p in navprops)
            {
                var np = (GenreNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case GenreNavProperty.Tracks:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.TrackRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Composes the Navigation Property tree materializers.
        /// </summary>
        /// <returns>
        /// List of Func of SqlDataReader, object
        /// </returns>
        protected override List<Func<SqlDataReader, object>> GetNavPropMaterializers(NavProps navprops) 
        {
            return ComposeNavPropMaterializers(navprops);
        }
        internal static List<Func<SqlDataReader, object>> ComposeNavPropMaterializers(NavProps navprops) 
        {
            if(!(navprops?.Count > 0))
                return new List<Func<SqlDataReader, object>>(0);
            var result = new List<Func<SqlDataReader, object>>(navprops.TotalCount);
            foreach(var p in navprops)
            {
                var np = (GenreNavProperty)p.Value;
                switch(np)
                {
                    case GenreNavProperty.Tracks:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.TrackRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.TrackRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return result;
        }
        /// <summary>
        /// Populates the object graph with the materialized results.
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        protected override void BuildObjectGraph(List<Genre> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Genre> ComposeDictionaryByPK(List<Genre> entities, MultiKeyDictionary<int, Genre> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Genre>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.GenreId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Genre> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Genre>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (GenreNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case GenreNavProperty.Tracks:
                    #region Tracks
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Track>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.GenreId.Value];
                                p.Tracks = AddEntityToList<TheSharpFactory.Entity.MainDb.Media.Track>(p.Tracks, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.TrackRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    default:
                        throw new ArgumentException($"NavigationProperty {np} is not valid.");
                }
            }
            return resultsetindex;
        }
        #endregion
    }
}
