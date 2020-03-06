using System;

namespace fiddle
{
    public class Product
    {
        [CampoFormulario(Tamanho = 1)]
        public int Id { get; set; }
        [CampoFormulario(Tamanho = 10)]
        public string Name { get; set; }
        [CampoFormulario(Tamanho = 20)]
        public decimal Value { get; set; }
        [CampoFormulario(Tamanho = 30)]
        public string DateAdded { get; set; }
    }
}