/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class AlbumRepository
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
    /// This class represents the Repository for: Album.
    /// </summary>
    public partial class AlbumRepository:WritableRepositoryBase<Album, AlbumProperty, AlbumNavProperty>, IAlbumRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<AlbumNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<AlbumNavProperty, NavPropertyInfo>(2){ { AlbumNavProperty.Artist, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Artist, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.AlbumProperty.ArtistId, OtherPropId = (int)MainDbE.Media.ArtistProperty.ArtistId, },} } }, { AlbumNavProperty.Tracks, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Track, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.AlbumProperty.AlbumId, OtherPropId = (int)MainDbE.Media.TrackProperty.AlbumId, },} } },};
        #endregion
        #region Constructors
        public AlbumRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_Album;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Album__97B4BE370AD2A005) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<AlbumProperty>(1){ SortFilter.New(AlbumProperty.AlbumId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        public Album ByPK(int albumid)
        {
            var where = new QueryFilters<AlbumProperty>(1){QueryFilter.New(AlbumProperty.AlbumId, FilterConditions.Equals, albumid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Album</returns>
        public Album ByPK(int albumid, NavProps<AlbumNavProperty> navprops)
        {
            var where = new QueryFilters<AlbumProperty>(1){QueryFilter.New(AlbumProperty.AlbumId, FilterConditions.Equals, albumid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Album from the database by Primary Key.
        /// </summary>
        /// <param name="albumid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int albumid)
        {
            var where = new QueryFilters<AlbumProperty>(1){QueryFilter.New(AlbumProperty.AlbumId, FilterConditions.Equals, albumid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<AlbumProperty> ComposeKeys(Album album)
        {
            return new QueryFilters<AlbumProperty>{ QueryFilter.New(AlbumProperty.AlbumId, FilterConditions.Equals, album.AlbumId) };
        }
        protected override QueryFilters<AlbumProperty> GetChanges(Album original, Album changed)
        {
            return AlbumUtils.GetChanges(original, changed);
        }
        protected override void Merge(Album source, Album target)
        {
            AlbumUtils.Merge(source, target);
        }
        protected override QueryFilters<AlbumProperty> ComposeInsertPredicate(Album album)
        {
            return new QueryFilters<AlbumProperty>{ QueryFilter.New(AlbumProperty.Title, FilterConditions.Equals, album.Title), QueryFilter.New(AlbumProperty.ArtistId, FilterConditions.Equals, album.ArtistId) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 3);
        }
        private static Album MaterializeSingleEntity(SqlDataReader r)
        {
            return new Album
            {
                AlbumId = r.GetInt32(0),
                Title = r.GetString(1),
                ArtistId = r.GetInt32(2),
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
                var np = (AlbumNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case AlbumNavProperty.Artist:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.ArtistRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case AlbumNavProperty.Tracks:
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
                var np = (AlbumNavProperty)p.Value;
                switch(np)
                {
                    case AlbumNavProperty.Artist:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.ArtistRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.ArtistRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case AlbumNavProperty.Tracks:
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
        protected override void BuildObjectGraph(List<Album> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Album> ComposeDictionaryByPK(List<Album> entities, MultiKeyDictionary<int, Album> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Album>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.AlbumId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Album> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Album>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (AlbumNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case AlbumNavProperty.Artist:
                    #region Artist
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Artist>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Artist>();
                            foreach(var p in list)
                                navByKey.Add(p.ArtistId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.ArtistId))
                                    c.Artist = navByKey[c.ArtistId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.ArtistRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case AlbumNavProperty.Tracks:
                    #region Tracks
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Track>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.AlbumId.Value];
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
