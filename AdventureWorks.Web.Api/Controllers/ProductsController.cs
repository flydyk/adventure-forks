using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AdventureWorks.DbModel;
using log4net;

namespace AdventureWorks.Web.Api.Controllers
{
    public class ProductsController : ApiController
    {
        private static ILog Logger = LogManager.GetLogger("Products");

        // GET api/values
        public async Task<List<Product>> Get()
        {
            Logger.Error($"{nameof(ProductsController)}.{nameof(Get)}. Its not an error.");

            using (var entities = new Entities())
            {
                var list = await entities.Products.Take(10).Select(x => x).ToListAsync();
                return list;
            }
        }

        // GET api/values/5
        public async Task<Product> Get(int id)
        {
            using (var entities = new Entities())
            {
                var item = await entities.Products.SingleOrDefaultAsync(x => x.ProductID == id);
                return item;
            }
        }

        // POST api/values
        public void Post([FromBody]Product value)
        {
            Logger.Error($"{nameof(ProductsController)}.{nameof(Post)}. Its not an error.");
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Product value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
