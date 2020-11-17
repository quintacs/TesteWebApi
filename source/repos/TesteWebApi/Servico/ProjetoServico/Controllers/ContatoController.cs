using ProjetoServico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoServico.Controllers
{
    [RoutePrefix("api/contato")]
    public class ContatoController : ApiController
    {
        [Route("cadastrar")]
        [HttpPost]
        public HttpResponseMessage Cadastrar(ContatoModel contatoModel)
        {
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Contato cadastrado com sucesso.");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    ModelState.Values.SelectMany
                        (e => e.Errors.Select(s => s.ErrorMessage)));
            }

        }

        [Route("atualizar")]
        [HttpPut]
        public HttpResponseMessage Atualizar(ContatoModel contatoModel)
        {
            if (ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Contato atualizado com sucesso.");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest,
                    ModelState.Values.SelectMany
                        (e => e.Errors.Select(s => s.ErrorMessage)));
            }
        }

        [Route("excluir")]
        [HttpDelete]
        public HttpResponseMessage Excluir(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Contato excluido com sucesso.");
        }

        [Route("consultar")]
        [HttpGet]
        public HttpResponseMessage Consultar()
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("obterporid")]
        [HttpGet]
        public HttpResponseMessage ObterPorId(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}
