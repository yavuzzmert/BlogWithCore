using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {

        List<Blog> GetListWithCategory();
        
        /*
        //tüm blog getir CRUD için read
        List<Blog> ListAllBlog();

        // CRUD için create
        void AddBlog(Blog blog);

        //CRUD için delete
        void DeleteBlog(Blog blog);

        //CRUD için update
        void UpdateBlog(Blog blog);


        //id'ye göre blog getir, sil, güncelle için
        Blog GetById(int id);
        */
        
    }
}
