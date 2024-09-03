using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
   
        //tüm category getir CRUD için read
        List<Category> ListAllCategory();

        // CRUD için create
        void AddCategory(Category category);

        //CRUD için delete
        void DeleteCategory(Category category);

        //CRUD için update
        void UpdateCategory(Category category);


        //id'ye göre category getir, sil, güncelle için
        Category GetById(int id);
        
    }
}
