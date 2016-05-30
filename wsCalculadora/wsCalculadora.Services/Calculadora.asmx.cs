using System;
using System.ComponentModel;
using System.Web.Services;

namespace wsCalculadora.Services
{
    /// <summary>
    /// Summary description for Calculadora
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Calculadora : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Int32 Somar(Int32 valor1, Int32 valor2)
        {
            return valor1 + valor2;
        }

        [WebMethod]
        public Int32 Subtrair(Int32 valor1, Int32 valor2)
        {
            //realiza a subtração e retorna o resultado.
            return (valor1 - valor2);
        }

        [WebMethod]
        public Int32 Dividir(Int32 valor1, Int32 valor2)
        {
            //realiza a divisão e retorna o resultado.
            return(valor1 / valor2);
        }

        [WebMethod]
        public Int32 Multiplicar(Int32 valor1, Int32 valor2)
        {
            //realiza a multiplicação e retorna o resultado.
            return (valor1 * valor2);
        }
    }
}
