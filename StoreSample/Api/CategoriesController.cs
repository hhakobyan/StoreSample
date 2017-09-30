namespace StoreSample.Api
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    using StoreSample.Entities;

    public class CategoriesController : ApiController
    {
        private readonly StoreEntities db = new StoreEntities();

        public IEnumerable<Category> Get()
        {
            return this.db.Categories.Select(c => new { Id = c.Id, Name = c.Name }).ToList().Select(c => new Category { Id = c.Id, Name = c.Name });
        }

        public Category Get(int id)
        {
            return this.db.Categories.Find(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Category value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Category value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}