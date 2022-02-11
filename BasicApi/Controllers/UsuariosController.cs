using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {

        static List<string> usuarios = new List<string>() {
            "Jose",
            "Joana"
        };
        

        public UsuariosController()
        {
        }

        [HttpGet]
        public List<string> Get()
        {
            return usuarios;
        }

        [HttpPost]
        public string Post([FromBody] string usuario)
        {
            usuarios.Add(usuario);
            return usuario;

        }

        [HttpPut]
        public bool Put([FromQuery] int index, [FromBody] string usuarioatt)
        {
            usuarios[index] = usuarioatt;
            return true;

        }

        [HttpDelete]
        public bool Delete([FromBody] string index)
        {
            //usuarios.RemoveAt(index);
            usuarios.RemoveAt(index.CompareTo(index));
            return true;

        }

        //[HttpDelete]
        //public bool Delete([FromBody] int index)
        //{
        //    usuarios.RemoveAt(index);
        //    return true;

        //}

    }
}

