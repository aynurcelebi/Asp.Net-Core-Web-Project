using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    // T bir class'a ait bütün değerleri üzerine alabilir.
    // Aslında burada bir sınıf gönreceğim bu sınıfta Entity'den gelen bir sınıf olacak
    public interface IGenericDal<T> where T : class 
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
