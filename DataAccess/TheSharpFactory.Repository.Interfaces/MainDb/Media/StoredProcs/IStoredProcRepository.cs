/*SFF*/
/************************************************
This interface has been generated dynamically.
Any changes you make here will be overwritten.
To add your own code create a partial interface
in a sepparate file.
with the following declaration:

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{
    public partial interface IStoredProcRepository
    {
    }
}

************************************************/

using System;
using System.Collections.Generic;
using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Query;

namespace TheSharpFactory.Repository.Interfaces.MainDb.Media
{

    /// <summary>
    /// This interface represents the Repository for all Stored Procedures under the Media schema.
    /// </summary>
    public partial interface IStoredProcRepository
    {
        /// <summary>
        /// Executes Stored Procedure named CheckAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckAlbum_Result</returns>
        StoredProcResult<CheckAlbum_Result> CheckAlbum(CheckAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckArtist_Result</returns>
        StoredProcResult<CheckArtist_Result> CheckArtist(CheckArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckGenre_Result</returns>
        StoredProcResult<CheckGenre_Result> CheckGenre(CheckGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckMediaType_Result</returns>
        StoredProcResult<CheckMediaType_Result> CheckMediaType(CheckMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckPlaylist_Result</returns>
        StoredProcResult<CheckPlaylist_Result> CheckPlaylist(CheckPlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckPlaylistTrack_Result</returns>
        StoredProcResult<CheckPlaylistTrack_Result> CheckPlaylistTrack(CheckPlaylistTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named CheckTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of CheckTrack_Result</returns>
        StoredProcResult<CheckTrack_Result> CheckTrack(CheckTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteAlbum(DeleteAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteArtist(DeleteArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteGenre(DeleteGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteMediaType(DeleteMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeletePlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeletePlaylist(DeletePlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeletePlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeletePlaylistTrack(DeletePlaylistTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named DeleteTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int DeleteTrack(DeleteTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetAlbum_Result</returns>
        StoredProcResult<GetAlbum_Result> GetAlbum(GetAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetAlbumsByArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetAlbumsByArtist_Result</returns>
        StoredProcResult<GetAlbumsByArtist_Result> GetAlbumsByArtist(GetAlbumsByArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetAllAlbums.
        /// </summary>
        /// <returns>StoredProcResult of GetAllAlbums_Result</returns>
        StoredProcResult<GetAllAlbums_Result> GetAllAlbums();
        /// <summary>
        /// Executes Stored Procedure named GetAllArtists.
        /// </summary>
        /// <returns>StoredProcResult of GetAllArtists_Result</returns>
        StoredProcResult<GetAllArtists_Result> GetAllArtists();
        /// <summary>
        /// Executes Stored Procedure named GetAllGenres.
        /// </summary>
        /// <returns>StoredProcResult of GetAllGenres_Result</returns>
        StoredProcResult<GetAllGenres_Result> GetAllGenres();
        /// <summary>
        /// Executes Stored Procedure named GetAllMediaTypes.
        /// </summary>
        /// <returns>StoredProcResult of GetAllMediaTypes_Result</returns>
        StoredProcResult<GetAllMediaTypes_Result> GetAllMediaTypes();
        /// <summary>
        /// Executes Stored Procedure named GetAllPlaylists.
        /// </summary>
        /// <returns>StoredProcResult of GetAllPlaylists_Result</returns>
        StoredProcResult<GetAllPlaylists_Result> GetAllPlaylists();
        /// <summary>
        /// Executes Stored Procedure named GetAllPlaylistTracks.
        /// </summary>
        /// <returns>StoredProcResult of GetAllPlaylistTracks_Result</returns>
        StoredProcResult<GetAllPlaylistTracks_Result> GetAllPlaylistTracks();
        /// <summary>
        /// Executes Stored Procedure named GetAllTracks.
        /// </summary>
        /// <returns>StoredProcResult of GetAllTracks_Result</returns>
        StoredProcResult<GetAllTracks_Result> GetAllTracks();
        /// <summary>
        /// Executes Stored Procedure named GetArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetArtist_Result</returns>
        StoredProcResult<GetArtist_Result> GetArtist(GetArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetGenre_Result</returns>
        StoredProcResult<GetGenre_Result> GetGenre(GetGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetMediaType_Result</returns>
        StoredProcResult<GetMediaType_Result> GetMediaType(GetMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylist_Result</returns>
        StoredProcResult<GetPlaylist_Result> GetPlaylist(GetPlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetPlaylistsByTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylistsByTrack_Result</returns>
        StoredProcResult<GetPlaylistsByTrack_Result> GetPlaylistsByTrack(GetPlaylistsByTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetPlaylistTrack_Result</returns>
        StoredProcResult<GetPlaylistTrack_Result> GetPlaylistTrack(GetPlaylistTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTrack_Result</returns>
        StoredProcResult<GetTrack_Result> GetTrack(GetTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByAlbum_Result</returns>
        StoredProcResult<GetTracksByAlbum_Result> GetTracksByAlbum(GetTracksByAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByArtist_Result</returns>
        StoredProcResult<GetTracksByArtist_Result> GetTracksByArtist(GetTracksByArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByGenre_Result</returns>
        StoredProcResult<GetTracksByGenre_Result> GetTracksByGenre(GetTracksByGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByInvoice.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByInvoice_Result</returns>
        StoredProcResult<GetTracksByInvoice_Result> GetTracksByInvoice(GetTracksByInvoice_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByMediaType_Result</returns>
        StoredProcResult<GetTracksByMediaType_Result> GetTracksByMediaType(GetTracksByMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named GetTracksByPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>StoredProcResult of GetTracksByPlaylist_Result</returns>
        StoredProcResult<GetTracksByPlaylist_Result> GetTracksByPlaylist(GetTracksByPlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertAlbum(InsertAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertArtist(InsertArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertGenre(InsertGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertMediaType(InsertMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertPlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertPlaylist(InsertPlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertPlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertPlaylistTrack(InsertPlaylistTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named InsertTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int InsertTrack(InsertTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateAlbum.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateAlbum(UpdateAlbum_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateArtist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateArtist(UpdateArtist_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateGenre.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateGenre(UpdateGenre_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateMediaType.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateMediaType(UpdateMediaType_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdatePlaylist.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdatePlaylist(UpdatePlaylist_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdatePlaylistTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdatePlaylistTrack(UpdatePlaylistTrack_Request request);
        /// <summary>
        /// Executes Stored Procedure named UpdateTrack.
        /// </summary>
        /// <param name="request">The request containing all parameters to call this stored procedure.</param>
        /// <returns>int</returns>
        int UpdateTrack(UpdateTrack_Request request);
    }
}
