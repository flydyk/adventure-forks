using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using AdventureWorks.DbModel;

namespace AdventureWorks.Web.Api.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/values
        public async Task<IEnumerable<string>> Get()
        {
            using (var entities = new Entities())
            {
                var list = await entities.Products.Take(10).Select(x => x.Name).ToListAsync();
                return list;
            }
        }

        // GET api/values/5
        public async Task<string> Get(int id)
        {
            using (var entities = new Entities())
            {
                var item = await entities.Products.SingleOrDefaultAsync(x => x.ProductID == id);
                return item?.Name;
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
