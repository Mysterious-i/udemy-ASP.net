using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain; //inherits from this

namespace NZWalks.API.Data
{
    public class NZWalksDBContext: DbContext
    { //in order to create a constructor ctor double enter
        
        //here we want to use DB options, since later we want to send our own connections through program.cs
        //which then we will pass the dbContextOptions to the base class
        public NZWalksDBContext(DbContextOptions dbContextOptions): base(dbContextOptions)
        {
            //now we want to create dbsets: a property of DB Context class that represents a collection of entities in the database
            //in our model we have 3 entities, difficulty/region/walk
            //we want to represent the set of each of these entities as a collection in our database and we will do that inside
        }
        //the Dbset takes a property 
        //then give a name to this colllection
        
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        //now we have 3 properties
        //we dont have a database yet, but these properties will create tables inside this new database
        //now we have to create a connection to this db
    }
}
