using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        public Category GetById(int id)
        {
           return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
             return _categoryDal.GetListAll();
        }



        /*
        //CategoryRepository categoryRepository = new CategoryRepository();
        GenericRepository<Category> repo = new GenericRepository<Category> ();

        public void CategoryAdd(Category category)
        {
            /*
            if (category.CategoryName != "" && category.CategoryDescription != "" && category.CategoryName.Length >= 5 && category.CategoryStatus == true)
            { categoryRepository.AddCategory(category); }
            else
            {
                // hata mesajı - fluent validation
            }
           */


        /*
            public void CategoryDelete(Category category)
            {
                if(category.CategoryID != 0)
                {
                    repo.Delete(category);
                }            
            }

            public void CategoryUpdate(Category category)
            {
                throw new NotImplementedException();
            }

            public Category GetById(int id)
            {
                throw new NotImplementedException();
            }

            public List<Category> GetList()
            {
                throw new NotImplementedException();
            }
        */
    }
}
