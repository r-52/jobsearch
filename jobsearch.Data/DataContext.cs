namespace jobsearch.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

#if DEBUG
            optionsBuilder.EnableSensitiveDataLogging();
#endif
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new JobConfiguration())
                    .ApplyConfiguration(new JobTypeConfiguration());
        }

        public override int SaveChanges()
        {
            // get entries that are being Added or Updated
            var modifiedEntries = ChangeTracker.Entries()
                    .Where(x => (x.State == EntityState.Added || x.State == EntityState.Modified));


            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as BaseModel;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.Now;
                    entity.Revision = 0;
                }

                entity.UpdatedAt = DateTime.Now;
                entity.Revision += 1;
            }

            return base.SaveChanges();
        }
        #region DbSets
        public DbSet<JobEntity> Jobs { get; set; }
        #endregion
    }
}
