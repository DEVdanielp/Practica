using Microsoft.EntityFrameworkCore;
using PrivateBlog.Start.Data.Entities;


//Archivo donde se construyen las tablas de la base de datos (ORM)
namespace Libreria.Web.DATA
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Section> Section { get; set; }

        //Se crea una propiedad de tipo DbSet que recibe la clase de la tabla que se vaya a crear
    }

    /*Comandos ORM:
     1. Crear una migracion: add-migration nombre de la migracion
     2. Ejecutar migracion: update-database (ejecuta todas las migraciones no ejecutadas)
     */
}