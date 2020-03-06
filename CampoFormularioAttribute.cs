using System;

namespace fiddle
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple = true)]
    public class CampoFormularioAttribute : Attribute
    {
        public int Tamanho;
        
    }
}