﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using TheSharpFactory.Entity.MainDb.Media;
using TheSharpFactory.Query;
using TheSharpFactory.Repository.Container.Interfaces;
using TheSharpFactory.Web.Models;

namespace TheSharpFactory.Web.Areas.Media.Controllers
{
    [Area("Media")]
    public class AlbumsController : Controller
    {
        //reference to the repository generated by The Sharp Factory
        private readonly IRepositoryContainer _repository;

        public AlbumsController(IRepositoryContainer repository)
        {
            _repository = repository;
        }

        // GET: Albums/artistId
        public ActionResult Index(int? artistId)
        {
            var query = new Query<AlbumProperty, AlbumNavProperty>()
                .BeginNavProps()
                    .Append(AlbumNavProperty.Artist)
                .EndNavProps();

            if (artistId != null)
            {
                query = query
                    .BeginPredicate()
                    .Where(AlbumProperty.ArtistId).Equals(artistId)
                    .EndPredicate();
            }
            var model = _repository.MainDb.Media.Album.ToList(query);
            return View(model);
        }


        // GET: Albums/Details/5
        public ActionResult Details(int id)
        {
            var model = _repository.MainDb.Media.Album.ByPK(id, new NavProps<AlbumNavProperty> {AlbumNavProperty.Artist});

            return View(model);
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Album album)
        {
            _repository.MainDb.Media.Album.Create(album);

            return RedirectToAction(nameof(Index));
        }

        // GET: Albums/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _repository.MainDb.Media.Album.ByPK(id);

            return View(model);
        }

        // POST: Albums/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Album album)
        {
            _repository.MainDb.Media.Album.Update(album);

            var model = _repository.MainDb.Media.Album.ByPK(album.AlbumId);

            //return View(model);
            return RedirectToAction(nameof(Index));
        }

        // GET: AlbumsController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _repository.MainDb.Media.Album.ByPK(id);

            return View(model);
        }

        // POST: AlbumsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Album album)
        {
            _repository.MainDb.Media.Album.Delete(album);

            return RedirectToAction(nameof(Index));
        }
    }
}
