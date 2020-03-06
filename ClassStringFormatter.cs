using System.Linq;
using System.Text;

namespace fiddle
{
    public class ClassStringFormatter
    {
        public static string Format(object obj)
        {
            var type = obj.GetType();
            var properties = obj.GetType().GetProperties();

            var builder = new StringBuilder();

            foreach (var p in properties)
            {
                var campoFormulario = p.GetCustomAttributes(false).FirstOrDefault() as CampoFormularioAttribute;
                var tamanho = campoFormulario.Tamanho;
                var valor = p.GetValue(obj).ToString();

                if(valor.Length > tamanho)
                    valor = valor.Substring(0,tamanho);
                else
                    valor = valor.PadRight(tamanho,' ');
                    
                builder.Append($"{valor}#");
            }
            
            var result = builder.ToString();
            return  result.Remove(result.Length - 1);
        }

    }
}