/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial class
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.MainDb.Media
{
    public partial class MediaTypeRepository
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
    /// This class represents the Repository for: MediaType.
    /// </summary>
    public partial class MediaTypeRepository:WritableRepositoryBase<MediaType, MediaTypeProperty, MediaTypeNavProperty>, IMediaTypeRepository
    {
        #region Navigation Property Info
        //Contains information about the Navigation Properties for this entity.
        private static readonly Dictionary<MediaTypeNavProperty, NavPropertyInfo> _navPropInfos = new Dictionary<MediaTypeNavProperty, NavPropertyInfo>(1){ { MediaTypeNavProperty.Tracks, new NavPropertyInfo{ EntityId = RepoLookup.EntityId.MainDb_Media_Track, IsParent = false, Predicate = new List<NavPropertyPair>(1){ new NavPropertyPair{ PropId = (int)MainDbE.Media.MediaTypeProperty.MediaTypeId, OtherPropId = (int)MainDbE.Media.TrackProperty.MediaTypeId, },} } },};
        #endregion
        #region Constructors
        public MediaTypeRepository()
        {
            //this is the unique id for the model to which this repository belongs to. used to find the correct connection string
            ModelId = RepoLookup.ModelId.MainDb;
            //this is the unique id for the entity. used to retrieve EntityInfo object from the RepoLookup.EntityId
            EntityId = RepoLookup.EntityId.MainDb_Media_MediaType;
            //tables with triggers have limitations that need to be accounted for
            HasTriggers = false;
            #region Default Sorting
            //this is the PK (PK__MediaTyp__0E6FCB7203317E3D) sorting. used as default for method overloads that DO NOT take a SortFilters parameter
            DefaultSort = new SortFilters<MediaTypeProperty>(1){ SortFilter.New(MediaTypeProperty.MediaTypeId),};
            #endregion
        }
        #endregion
        #region ByPK
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.MediaType from the database by Primary Key.
        /// </summary>
        /// <param name="mediatypeid">Primary Key Field.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.MediaType</returns>
        public MediaType ByPK(int mediatypeid)
        {
            var where = new QueryFilters<MediaTypeProperty>(1){QueryFilter.New(MediaTypeProperty.MediaTypeId, FilterConditions.Equals, mediatypeid ), };
            return SelectSingle(where, DefaultSort);
        }
        /// <summary>
        /// Gets the specified TheSharpFactory.Entity.MainDb.Media.MediaType from the database by Primary Key. Supports navigation properties.
        /// </summary>
        /// <param name="mediatypeid">Primary Key Field.</param>
        /// <param name="navprops">The navigation properties to include in the result.</param>
        /// <returns>Single TheSharpFactory.Entity.MainDb.Media.MediaType</returns>
        public MediaType ByPK(int mediatypeid, NavProps<MediaTypeNavProperty> navprops)
        {
            var where = new QueryFilters<MediaTypeProperty>(1){QueryFilter.New(MediaTypeProperty.MediaTypeId, FilterConditions.Equals, mediatypeid ), };
            return SelectSingle(where, DefaultSort, navprops);
        }
        #endregion
        #region DeleteByPK
        /// <summary>
        /// Deletes the specified TheSharpFactory.Entity.MainDb.Media.MediaType from the database by Primary Key.
        /// </summary>
        /// <param name="mediatypeid">Primary Key Field.</param>
        /// <returns>True if succeeded. False if it does not exist.</returns>
        public bool DeleteByPK(int mediatypeid)
        {
            var where = new QueryFilters<MediaTypeProperty>(1){QueryFilter.New(MediaTypeProperty.MediaTypeId, FilterConditions.Equals, mediatypeid), };
            return DeleteAny(where) > 0;
        }
        #endregion
        #region Materialization
        protected override QueryFilters<MediaTypeProperty> ComposeKeys(MediaType mediatype)
        {
            return new QueryFilters<MediaTypeProperty>{ QueryFilter.New(MediaTypeProperty.MediaTypeId, FilterConditions.Equals, mediatype.MediaTypeId) };
        }
        protected override QueryFilters<MediaTypeProperty> GetChanges(MediaType original, MediaType changed)
        {
            return MediaTypeUtils.GetChanges(original, changed);
        }
        protected override void Merge(MediaType source, MediaType target)
        {
            MediaTypeUtils.Merge(source, target);
        }
        protected override QueryFilters<MediaTypeProperty> ComposeInsertPredicate(MediaType mediatype)
        {
            return new QueryFilters<MediaTypeProperty>{ QueryFilter.New(MediaTypeProperty.Name, FilterConditions.Equals, mediatype.Name) };
        }
        protected override object MaterializeEntity(SqlDataReader r)
        {
            return Materialize(r);
        }
        internal static object Materialize(SqlDataReader r)
        {
            return MaterializeEntityResult(r, MaterializeSingleEntity, 2);
        }
        private static MediaType MaterializeSingleEntity(SqlDataReader r)
        {
            return new MediaType
            {
                MediaTypeId = r.GetInt32(0),
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
                var np = (MediaTypeNavProperty)p.Value;
                var npInfo = _navPropInfos[np];
                result.Add(npInfo);
                if(!(p.NavProps?.Count > 0))
                    continue;
                switch(np)
                {
                    case MediaTypeNavProperty.Tracks:
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
                var np = (MediaTypeNavProperty)p.Value;
                switch(np)
                {
                    case MediaTypeNavProperty.Tracks:
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
        protected override void BuildObjectGraph(List<MediaType> entities, object[] results, NavProps navprops) 
        {
            PopulateNavProperties(entities, results, navprops);
        }
        private static MultiKeyDictionary<int, MediaType> ComposeDictionaryByPK(List<MediaType> entities, MultiKeyDictionary<int, MediaType> entByKey) 
        {
            // creates a dictionary by Primary Key
            if(entByKey?.Count > 0)
                return entByKey;
            entByKey = new MultiKeyDictionary<int, MediaType>(entities.Count);
            foreach(var p in entities)
                entByKey.Add(p.MediaTypeId, p);
            return entByKey;
        }
        internal static int PopulateNavProperties(List<MediaType> entities, object[] results, NavProps navprops, int resultsetindex = 0) 
        {
            if(results?.Length < resultsetindex + 1)
                return resultsetindex;
            var entByPK = (MultiKeyDictionary<int, MediaType>)null;
            foreach(var navprop in navprops)
            {
                resultsetindex++;
                var np = (MediaTypeNavProperty)navprop.Value;
                var result = results[resultsetindex];
                switch(np)
                {
                    case MediaTypeNavProperty.Tracks:
                    #region Tracks
                    {
                        var list = UnboxEntityList<TheSharpFactory.Entity.MainDb.Media.Track>(result);
                        if(list?.Count > 0)
                        {
                            entByPK = ComposeDictionaryByPK(entities, entByPK);
                            foreach(var c in list)
                            {
                                var p = entByPK[c.MediaTypeId];
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
