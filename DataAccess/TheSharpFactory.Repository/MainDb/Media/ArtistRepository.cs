/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class ArtistRepository
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
    /// This class represents the Repository for: Artist.
    /// </summary>
    public partial class ArtistRepository:WritableRepositoryBase<Artist, ArtistProperty, ArtistNavProperty>, IArtistRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<ArtistNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<ArtistNavProperty, NavPropertyInfo>(1){ { ArtistNavProperty.Albums, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Album, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.ArtistProperty.ArtistId, OtherPropId = (int)MainDbE.Media.AlbumProperty.ArtistId, },} } },};
        #endregion
        #region Constructors
        public ArtistRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_Artist;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Artist__25706B5007020F21) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<ArtistProperty>(1){ SortFilter.New(ArtistProperty.ArtistId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Artist from the database by Primary Key.
        /// </summary>
        /// <param name="artistid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Artist</returns>
        public Artist ByPK(int artistid)
        {
            var where = new QueryFilters<ArtistProperty>(1){QueryFilter.New(ArtistProperty.ArtistId, FilterConditions.Equals, artistid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Artist from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="artistid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Artist</returns>
        public Artist ByPK(int artistid, NavProps<ArtistNavProperty> navprops)
        {
            var where = new QueryFilters<ArtistProperty>(1){QueryFilter.New(ArtistProperty.ArtistId, FilterConditions.Equals, artistid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Artist from the database by Primary Key.
        /// </summary>
        /// <param name="artistid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int artistid)
        {
            var where = new QueryFilters<ArtistProperty>(1){QueryFilter.New(ArtistProperty.ArtistId, FilterConditions.Equals, artistid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<ArtistProperty> ComposeKeys(Artist artist)
        {
            return new QueryFilters<ArtistProperty>{ QueryFilter.New(ArtistProperty.ArtistId, FilterConditions.Equals, artist.ArtistId) };
        }
        protected override QueryFilters<ArtistProperty> GetChanges(Artist original, Artist changed)
        {
            return ArtistUtils.GetChanges(original, changed);
        }
        protected override void Merge(Artist source, Artist target)
        {
            ArtistUtils.Merge(source, target);
        }
        protected override QueryFilters<ArtistProperty> ComposeInsertPredicate(Artist artist)
        {
            return new QueryFilters<ArtistProperty>{ QueryFilter.New(ArtistProperty.Name, FilterConditions.Equals, artist.Name) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 2);
        }
        private static Artist MaterializeSingleEntity(SqlDataReader r)
        {
            return new Artist
            {
                ArtistId = r.GetInt32(0),
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
                var np = (ArtistNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case ArtistNavProperty.Albums:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.AlbumRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (ArtistNavProperty)p.Value;
                switch(np)
                {
                    case ArtistNavProperty.Albums:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.AlbumRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.AlbumRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Artist> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Artist> ComposeDictionaryByPK(List<Artist> entities, MultiKeyDictionary<int, Artist> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Artist>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.ArtistId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Artist> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Artist>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (ArtistNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case ArtistNavProperty.Albums:
                    #region Albums
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Album>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.ArtistId];
                                p.Albums = AddEntityToList<TheSharpFactory.Entity.MainDb.Media.Album>(p.Albums, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.AlbumRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
