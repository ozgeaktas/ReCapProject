using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //BU vereceğimiz T yi sınırlandırmamız yani filtrelememiz lazım.
    //class demek referans tipi olabilir demektir.
    //newlenebilir olduğu için Ientities olmaz artık.
    public interface IEntityRepository<T> where T:class,IEntities,new()//sistemimiz böylece gerçekten veritabanı nesneleriyle çalışlabilir.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtreler yazabilmemizi sağlıyor.
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
