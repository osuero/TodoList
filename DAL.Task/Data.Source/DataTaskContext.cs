using Microsoft.EntityFrameworkCore;

namespace DAL.Task.Data.Source
{

    /// <summary>
    /// code first entity framework
    /// Hinerate from db context
    /// </summary>
    public class DataTaskContext : DbContext
    {

        /// <summary>
        /// pass context as parametter in constructor
        /// </summary>
        /// <param name="context"></param>
        public DataTaskContext(DbContextOptions<DataTaskContext> context)
            :base(context)
        {
            //this "EnsureCreated" this line check if the database is created
            //if it is created it won't take any action
            //if it is not created it will created from scrash
            Database.EnsureCreated();
        }

        //here I'm adding the model to create a table
        //the model will contains a key and some other properties
        public DbSet<Models.Task> Tasks { get; set; }
      

       
    }
}
