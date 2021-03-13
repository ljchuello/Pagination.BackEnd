using System.Data;

namespace Pagination.Backend.Controllers
{
    /// <summary>
    /// Objeto para paginar
    /// </summary>
    public class Paginacion
    {
        /// <summary>
        /// Parámetro búsqueda
        /// </summary>
        public string Q { set; get; } = string.Empty;

        /// <summary>
        /// Indica la página actual
        /// </summary>
        public int PageCurrent { set; get; } = 0;

        /// <summary>
        /// Indica el tamaño de la paginación
        /// </summary>
        public int PageSize { set; get; } = 10;

        /// <summary>
        /// Indica cuantas páginas hay en total
        /// </summary>
        public int PageCount { set; get; } = 0;

        /// <summary>
        /// Datos devueltos
        /// </summary>
        public DataTable Data { set; get; } = new DataTable();
    }
}
