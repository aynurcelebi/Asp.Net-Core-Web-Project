using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Bussiness tarafında CRUD operasyonları için gerekli olan metotların çağırılmadan önce imzasını taşıyacak
namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> TGetList();
        T GetByID(int id);
    }
}
