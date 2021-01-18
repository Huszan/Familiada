using AutoMapper;
using Familiada.Contracts;
using Familiada.Data;
using Familiada.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Familiada.Controllers
{
    public class AnswerController : Controller
    {
        private readonly IAnswerRepository _repo;
        private readonly IMapper _mapper;

        public AnswerController(IAnswerRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        // GET: AnswerController
        public ActionResult Index()
        {
            var answers = _repo.FindAll().ToList();
            var model = _mapper.Map<List<Answer>, List<AnswerVM>>(answers);
            return View(model);
        }

        // GET: AnswerController/Details/5
        public ActionResult Details(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var answer = _repo.FindById(id);
            var model = _mapper.Map<AnswerVM>(answer);
            return View(model);
        }

        // GET: AnswerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AnswerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnswerVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var answer = _mapper.Map<Answer>(model);
                var isSuccess = _repo.Create(answer);
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

        // GET: AnswerController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var answer = _repo.FindById(id);
            var model = _mapper.Map<AnswerVM>(answer);
            return View(model);
        }

        // POST: AnswerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AnswerVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var answer = _mapper.Map<Answer>(model);
                var isSuccess = _repo.Update(answer);
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

        // GET: AnswerController/Delete/5
        public ActionResult Delete(int id)
        {
            if (!_repo.isExists(id))
            {
                return NotFound();
            }
            var answer = _repo.FindById(id);
            var model = _mapper.Map<AnswerVM>(answer);
            return View(model);
        }

        // POST: AnswerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AnswerVM model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var answer = _mapper.Map<Answer>(model);
                var isSuccess = _repo.Delete(answer);
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
