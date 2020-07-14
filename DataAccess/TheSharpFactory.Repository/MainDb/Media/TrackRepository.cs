/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class TrackRepository
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
    /// This class represents the Repository for: Track.
    /// </summary>
    public partial class TrackRepository:WritableRepositoryBase<Track, TrackProperty, TrackNavProperty>, ITrackRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<TrackNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<TrackNavProperty, NavPropertyInfo>(5){ { TrackNavProperty.InvoiceLines, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Accounting_InvoiceLine, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.TrackProperty.TrackId, OtherPropId = (int)MainDbE.Accounting.InvoiceLineProperty.TrackId, },} } }, { TrackNavProperty.PlaylistTracks, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_PlaylistTrack, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.TrackProperty.TrackId, OtherPropId = (int)MainDbE.Media.PlaylistTrackProperty.TrackId, },} } }, { TrackNavProperty.Album, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Album, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.TrackProperty.AlbumId, OtherPropId = (int)MainDbE.Media.AlbumProperty.AlbumId, },} } }, { TrackNavProperty.Genre, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Genre, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.TrackProperty.GenreId, OtherPropId = (int)MainDbE.Media.GenreProperty.GenreId, },} } }, { TrackNavProperty.MediaType, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_MediaType, IsParent = true, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.TrackProperty.MediaTypeId, OtherPropId = (int)MainDbE.Media.MediaTypeProperty.MediaTypeId, },} } },};
        #endregion
        #region Constructors
        public TrackRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_Track;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__Track__7A74F8E00EA330E9) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<TrackProperty>(1){ SortFilter.New(TrackProperty.TrackId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        public Track ByPK(int trackid)
        {
            var where = new QueryFilters<TrackProperty>(1){QueryFilter.New(TrackProperty.TrackId, FilterConditions.Equals, trackid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.Track</returns>
        public Track ByPK(int trackid, NavProps<TrackNavProperty> navprops)
        {
            var where = new QueryFilters<TrackProperty>(1){QueryFilter.New(TrackProperty.TrackId, FilterConditions.Equals, trackid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.Track from the database by Primary Key.
        /// </summary>
        /// <param name="trackid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int trackid)
        {
            var where = new QueryFilters<TrackProperty>(1){QueryFilter.New(TrackProperty.TrackId, FilterConditions.Equals, trackid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<TrackProperty> ComposeKeys(Track track)
        {
            return new QueryFilters<TrackProperty>{ QueryFilter.New(TrackProperty.TrackId, FilterConditions.Equals, track.TrackId) };
        }
        protected override QueryFilters<TrackProperty> GetChanges(Track original, Track changed)
        {
            return TrackUtils.GetChanges(original, changed);
        }
        protected override void Merge(Track source, Track target)
        {
            TrackUtils.Merge(source, target);
        }
        protected override QueryFilters<TrackProperty> ComposeInsertPredicate(Track track)
        {
            return new QueryFilters<TrackProperty>{ QueryFilter.New(TrackProperty.Name, FilterConditions.Equals, track.Name), QueryFilter.New(TrackProperty.AlbumId, FilterConditions.Equals, track.AlbumId), QueryFilter.New(TrackProperty.MediaTypeId, FilterConditions.Equals, track.MediaTypeId), QueryFilter.New(TrackProperty.GenreId, FilterConditions.Equals, track.GenreId), QueryFilter.New(TrackProperty.Composer, FilterConditions.Equals, track.Composer), QueryFilter.New(TrackProperty.Milliseconds, FilterConditions.Equals, track.Milliseconds), QueryFilter.New(TrackProperty.Bytes, FilterConditions.Equals, track.Bytes), QueryFilter.New(TrackProperty.UnitPrice, FilterConditions.Equals, track.UnitPrice) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 9);
        }
        private static Track MaterializeSingleEntity(SqlDataReader r)
        {
            return new Track
            {
                TrackId = r.GetInt32(0),
                Name = r.GetString(1),
                AlbumId = r.GetValue(2) as int?,
                MediaTypeId = r.GetInt32(3),
                GenreId = r.GetValue(4) as int?,
                Composer = r.GetValue(5) as string,
                Milliseconds = r.GetInt32(6),
                Bytes = r.GetValue(7) as int?,
                UnitPrice = r.GetDecimal(8),
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
                var np = (TrackNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case TrackNavProperty.InvoiceLines:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TrackNavProperty.PlaylistTracks:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TrackNavProperty.Album:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.AlbumRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TrackNavProperty.Genre:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.GenreRepository.BuildNavPropInfos(p.NavProps);
                        break;
                    case TrackNavProperty.MediaType:
                        npInfo.NavProps = TheSharpFactory.Repository.MainDb.Media.MediaTypeRepository.BuildNavPropInfos(p.NavProps);
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
                var np = (TrackNavProperty)p.Value;
                switch(np)
                {
                    case TrackNavProperty.InvoiceLines:
                        result.Add(TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TrackNavProperty.PlaylistTracks:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TrackNavProperty.Album:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.AlbumRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.AlbumRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TrackNavProperty.Genre:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.GenreRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.GenreRepository.ComposeNavPropMaterializers(p.NavProps));
                        break;
                    case TrackNavProperty.MediaType:
                        result.Add(TheSharpFactory.Repository.MainDb.Media.MediaTypeRepository.Materialize);
                        if(p.NavProps?.Count > 0)
                            result.AddRange(TheSharpFactory.Repository.MainDb.Media.MediaTypeRepository.ComposeNavPropMaterializers(p.NavProps));
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
        protected override void BuildObjectGraph(List<Track> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, Track> ComposeDictionaryByPK(List<Track> entities, MultiKeyDictionary<int, Track> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, Track>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.TrackId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<Track> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, Track>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (TrackNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case TrackNavProperty.InvoiceLines:
                    #region InvoiceLines
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.TrackId];
                                p.InvoiceLines = AddEntityToList<TheSharpFactory.Entity.MainDb.Accounting.InvoiceLine>(p.InvoiceLines, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Accounting.InvoiceLineRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TrackNavProperty.PlaylistTracks:
                    #region PlaylistTracks
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.TrackId];
                                p.PlaylistTracks = AddEntityToList<TheSharpFactory.Entity.MainDb.Media.PlaylistTrack>(p.PlaylistTracks, c);
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.PlaylistTrackRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TrackNavProperty.Album:
                    #region Album
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Album>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Album>();
                            foreach(var p in list)
                                navByKey.Add(p.AlbumId, p);
                            foreach(var c in entities)
                            {
                                if(!c.AlbumId.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.AlbumId.Value))
                                    c.Album = navByKey[c.AlbumId.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.AlbumRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TrackNavProperty.Genre:
                    #region Genre
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Genre>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.Genre>();
                            foreach(var p in list)
                                navByKey.Add(p.GenreId, p);
                            foreach(var c in entities)
                            {
                                if(!c.GenreId.HasValue)
                                    continue;
                                if(navByKey.ContainsKey(c.GenreId.Value))
                                    c.Genre = navByKey[c.GenreId.Value];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.GenreRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
                    }
                    #endregion
                        break;
                    case TrackNavProperty.MediaType:
                    #region MediaType
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.MediaType>(result);
                        if(list?.Count > 0)
                        {
                            var navByKey = new MultiKeyDictionary<int, TheSharpFactory.Entity.MainDb.Media.MediaType>();
                            foreach(var p in list)
                                navByKey.Add(p.MediaTypeId, p);
                            foreach(var c in entities)
                            {
                                if(navByKey.ContainsKey(c.MediaTypeId))
                                    c.MediaType = navByKey[c.MediaTypeId];
                            }
                        }
                        if(navprop.NavProps?.Count > 0)
                            resultsetindex = TheSharpFactory.Repository.MainDb.Media.MediaTypeRepository.PopulateNavProperties(list, results, navprop.NavProps, resultsetindex);
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
