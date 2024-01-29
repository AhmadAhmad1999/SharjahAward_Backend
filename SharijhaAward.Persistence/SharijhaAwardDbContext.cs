using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Domain.Model.CategoryCommitteeModel;
using SharijhaAward.Domain.Model.CriterionItemScaleModel;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.TrainingWorkshopSubscriberModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence
{
    public class SharijhaAwardDbContext : DbContext
    {
        public SharijhaAwardDbContext(DbContextOptions<SharijhaAwardDbContext> options)
        : base(options) { }

        public DbSet<Event> Events { get; set; }
        public DbSet<PersonalInvitee> Personalnvitees { get; set; }
        public DbSet<GroupInvitee> GroupInvitees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CategoryCommittee> categoryCommittees { get; set; }
        public DbSet<CriterionItemScale> criterionItemScales { get; set; }
        public DbSet<TrainingWorkshopSubscriber> trainingWorkshopSubscribers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SharijhaAwardDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
