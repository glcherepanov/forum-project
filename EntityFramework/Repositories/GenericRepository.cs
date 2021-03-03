using Forum.EntityFramework;
using Forum.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        public IQueryable<TEntity> All { get; }

        private DbSet<TEntity> Table => _forumDbContext.Set<TEntity>();
        private readonly ForumDbContext _forumDbContext;

        public GenericRepository( ForumDbContext foodDbContext )
        {
            _forumDbContext = foodDbContext;
            All = Table;
        }

        public TEntity GetItem( int id ) => Table.Find( id );

        public TEntity Save( TEntity item )
        {
            TEntity savedEntity = item.Id == 0
                ? Table.Add( item ).Entity
                : Table.Update( item ).Entity;

            _forumDbContext.SaveChanges();

            return savedEntity;
        }

        public void Delete( TEntity item )
        {
            var entity = Table.Find( item );
            if ( entity != null )
            {
                Table.Remove( entity );
                _forumDbContext.SaveChanges();
            }
        }

        public void Delete( IEnumerable<TEntity> items )
        {
            foreach ( TEntity item in items )
            {
                var entity = Table.Find( item );
                if ( entity != null )
                {
                    Table.Remove( entity );
                }
            }
            _forumDbContext.SaveChanges();
        }

        public void Delete( int id )
        {
            var entity = Table.Find( id );
            if ( entity != null )
            {
                Table.Remove( entity );
                _forumDbContext.SaveChanges();
            }
        }
    }
}
