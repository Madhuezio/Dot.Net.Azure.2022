using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly EcommerceDbContext _ecommerceDbContext;
        public CategoryController(EcommerceDbContext ecommerceDbContext)
        {
            _ecommerceDbContext = ecommerceDbContext;
        }


        [HttpGet]
        public IEnumerable<TblCategory> GetCategories()
        {
            return _ecommerceDbContext.TblCategories.ToList();
        }
        [HttpPost]
        [Consumes("application/x-www-form-urlencoded")]
        [Route("save-category")]
        public void SaveCategory([FromBody] TblCategory tblCategory)
        {
            var category = new TblCategory();
            category.Id = tblCategory.Id;
            category.CategoryName = tblCategory.CategoryName;
            category.Colour = tblCategory.Colour;
            category.CreatedBy = tblCategory.CreatedBy;
            category.CreatedBy = tblCategory.CreatedBy;
            category.IsDeleted = tblCategory.IsDeleted;
            category.ParentId = tblCategory.ParentId;
            category.Size = tblCategory.Size;
            category.UpdatedBy = tblCategory.UpdatedBy;
            category.UpdatedOn = tblCategory.UpdatedOn;
            _ecommerceDbContext.SaveChanges();

        }
    }
}
