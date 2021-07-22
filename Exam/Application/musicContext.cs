using Exam.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application
{
    public partial class musicContext : DbContext
    {
        public musicContext()
        {

        }
        public musicContext(DbContextOptions<musicContext> options) : base(options)
        {

        }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Album_song> Albums_Songs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NB24L70;Initial Catalog=music;Integrated Security=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
