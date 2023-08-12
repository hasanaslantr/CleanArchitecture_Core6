using System.Linq.Expressions;

namespace NLayer.Core.GenericRepositories
{
    public interface IGenericRepository<T> where T : class
    {

        #region IQueryable, nedir nasıl kullanılır?
        /*
         
         IQueryable arabirimi, genelikle veritabanı sorguları gibi büyük veri kümelerim de
         çalışşırken daha etkili ve verimli sorgular oluşturmak için kullanılır. 
         İhtiyac duyulduğun da veritabanına gönderilir, bu sayede optimize edebilir ve 
         gereksiz veri tranferini engelleyebiliriz.  
         */
        #endregion

        #region Task nedir, neden kullanırız?
        /* 
         Task, bir işin veya görevin asenkron olarak çalıştırılmasını temsil eder 
         ve bu görevin tamamlanmasını beklerken ana iş parçacığının (thread) bloke olmadan
         diğer işleri yapmasına olanak tanır.
         */
        #endregion

        #region IEnumerable, nedir neden kullanırız?
        /*
         IEnumerable arabirimi, bir sınıfın veya nesnenin, koleksiyon elemanlarını tek tek
         döndürebileceği bir yöntem olan GetEnumerator() yöntemini içermesi gereken bir arabirimdir. 
         Bu yöntem, koleksiyonun her elemanını sırayla döndüren bir "enumerator" (numaralandırıcı) nesnesi döndürmelidir. 
         */
        #endregion

        IQueryable<T> GetAll();
        Task<T> GetByIdAsycn(int id);
        Task<T> GetByIdsAsycn(int id, int id2);
        IQueryable<T> Where(Expression<Func<T, bool>> filter);
        Task<bool> AnyAsycn(Expression<Func<T, bool>> filter);
        Task AddAsycn(T entity);
        Task AddRangeAsycn(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entites);

    }
}
