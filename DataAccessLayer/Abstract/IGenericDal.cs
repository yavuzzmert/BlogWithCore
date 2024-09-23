using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        // ekleme metot
        void Insert(T item);

        //silme metot
        void Delete(T item);

        //güncellme metot
        void Update(T item);    

        //hepsini getir
        List<T> GetListAll();

        //sadece id ile getir
        T GetById(int id);

        //
        List<T> GetListAll(Expression<Func<T, bool>> filter);
    }
}
