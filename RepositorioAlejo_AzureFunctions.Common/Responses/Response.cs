using System;
using System.Collections.Generic;
using System.Text;

namespace RepositorioAlejo_AzureFunctions.Common.Responses
{
    //Clase para las respuestas
    public class Response
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; } //Exitoso o fallo

        public object Result { get; set; }

    }
}
