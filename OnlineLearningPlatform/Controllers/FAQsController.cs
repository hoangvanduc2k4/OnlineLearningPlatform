using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Search;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineLearningPlatform.Data;
using OnlineLearningPlatform.Models.Entities.Others;
using OnlineLearningPlatform.Services.Interfaces;
using X.PagedList.Extensions;

namespace OnlineLearningPlatform.Controllers
{
    public class FAQsController : Controller
    {
        private readonly IFAQsService _faqsService;
        public FAQsController(IFAQsService faqsService)
        {
            _faqsService = faqsService;
        }
        public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 5, string searchTerm = null)
        {
            var pagedFaqs = await _faqsService.GetFAQsPagedAsync(pageNumber, pageSize, searchTerm);
            ViewBag.SearchTerm = searchTerm;
            ViewBag.PageSize = pageSize;
            return View(pagedFaqs);
        }

    }
}
