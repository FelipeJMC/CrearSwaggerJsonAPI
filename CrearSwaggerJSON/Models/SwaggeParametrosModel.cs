using System.Xml.XPath;

namespace CrearSwaggerJSON.Models
{
    public class SwaggeParametrosModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public Dictionary<string, PathItem> Paths { get; set; }
    }
    public class PathItem
    {
        public string Summary { get; set; }
        public string OperationId { get; set; }
        public string[] Tags { get; set; }
        // aca se pueden agregar mas parametros si necesitas para powerapps
    }
}
