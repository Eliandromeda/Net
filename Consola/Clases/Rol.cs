namespace Consola
{    
    using System;

    [Serializable]
    public class Rol
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}