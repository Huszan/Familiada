using AutoMapper;
using Familiada.Contracts;
using Familiada.Data;
using Familiada.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class GameController : Controller
    {
        private readonly IGameRepository _gamerepo;
        private readonly IMapper _mapper;

        public GameController(IGameRepository gamerepo, IMapper mapper)
        {
            _gamerepo = gamerepo;
            _mapper = mapper;
        }

        // GET: GameController
        public ActionResult Index()
        {
            var games = _gamerepo.FindAll().ToList();
            var model = _mapper.Map<List<Game>, List<GameVM>>(games);
            return View(model);
        }

        // GET: GameController/Details/5
        public ActionResult Details(int id)
        {
            if (!_gamerepo.isExists(id))
            {
                return NotFound();
            }
            var game = _gamerepo.FindById(id);
            var model = _mapper.Map<GameVM>(game);
            return View(model);
        }

        // GET: GameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GameVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var game = _mapper.Map<Game>(model);
                game.Points = 0;
                game.Tries = 3;
                game.Finished = false;
                var isSuccess = _gamerepo.Create(game);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: GameController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_gamerepo.isExists(id))
            {
                return NotFound();
            }
            var game = _gamerepo.FindById(id);
            var model = _mapper.Map<GameVM>(game);
            return View(model);
        }

        // POST: GameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GameVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var game = _mapper.Map<Game>(model);
                var isSuccess = _gamerepo.Update(game);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "Something went wrong...");
                    return View(model);
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Something went wrong...");
                return View();
            }
        }

            // GET: GameController/Delete/5
            public ActionResult Delete(int id)
            {
                if (!_gamerepo.isExists(id))
                {
                    return NotFound();
                }
                var game = _gamerepo.FindById(id);
                var model = _mapper.Map<GameVM>(game);
                return View(model);
            }

            // POST: GameController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, GameVM model)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return View(model);
                    }
                    var game = _mapper.Map<Game>(model);
                    var isSuccess = _gamerepo.Delete(game);
                    if (!isSuccess)
                    {
                        ModelState.AddModelError("", "Something went wrong...");
                        return View(model);
                    }

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
        }
    }
