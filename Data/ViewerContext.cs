using Microsoft.EntityFrameworkCore;
using DHF_Viewer_WebApp.Models;

namespace DHF_Viewer_WebApp.Data;

public class ViewerContext : DbContext
{
    public ViewerContext(DbContextOptions<ViewerContext> options) 
        : base(options)
    {
    }

    public DbSet<DHF_Sections> Sections => Set<DHF_Sections>();
    public DbSet<Document> Documents => Set<Document>();
    public DbSet<Products> Products => Set<Products>();
}