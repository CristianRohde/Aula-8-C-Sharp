# Aula-8-C-Sharp
Criar outro Metodo UsuarioControler passando como parametro string Id

no UsuarioControler criar 
 public ViewResult DeletaUsuario(string id) {
            return View(_usuarios.GetUsuario(id));
        }

 [HttpPost]
        public RedirectToRouteResult DeletaUsuario(string id, 
        FormCollection collection){
            _usuarios.DeletarUsuario(id);
            return RedirectToRoute("Index");
        }

Na View Usuario Index 
onde estava <a asp-action="Create">Create New</a> suplementar por  
@Html.ActionLink("Criar Usuário", "AdicionaUsuario")    isto es para 
modificar o link

Em UsuarioController fazer click direito na View(); do metodo 
AdicionaUsuaro() em name é o mesmo, em template  é Create , em Model 
é UsuarioModel 
Uma vez feito isso ao abrir a pagina /usuario ele fabrica uma pagina 
para prencher informaçoes e clicar em Create somente uma vez e logo 
clicar em Back to List

adicionar  using Microsoft.AspNetCore.Http;
