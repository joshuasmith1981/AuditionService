using AuditionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditionService.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        /// <summary>
        /// Adds an entity of type T to the repository.
        /// </summary>
        /// <param name="entity">The entity to be added.</param>
        /// <returns>The newly-added entity.</returns>
        T Add(T entity);

        /// <summary>
        /// Gets the first entity of type T matching the given predicate.
        /// </summary>
        /// <param name="predicate">The predicate function used to search for an entity.</param>
        /// <returns>The first entity matching the given predicate (if found), else null.</returns>
        T Get(Func<T, bool> predicate);

        /// <summary>
        /// Gets a collection of entities of type T matching the given predicate.
        /// </summary>
        /// <param name="predicate">The predicate function used to search for entities.</param>
        /// <returns>Collection (zero to many) of entities of type T.</returns>
        IEnumerable<T> GetMany(Func<T, bool> predicate);

        /// <summary>
        /// Gets a collection of all entities of type T.
        /// </summary>
        /// <returns>Collection (zero to many) of entities of type T.</returns>
        IEnumerable<T> All();

        /// <summary>
        /// Updates a given entity.
        /// </summary>
        /// <param name="entity">The entity to be updated.</param>
        /// <returns>The newly-updated entity.</returns>
        T Update(T entity);

        /// <summary>
        /// Deletes a given entity.
        /// </summary>
        /// <param name="entity">The entity to be deleted.</param>
        void Delete(T entity);
    }
}
