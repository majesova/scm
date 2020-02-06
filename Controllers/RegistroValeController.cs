using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using AutoMapper;
using CargaDescarga;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Scm.Controllers.Dtos;
using Scm.Service;

namespace Scm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    [ProducesResponseType(401, Type = typeof(string))]
    public class RegistroValeController : ControllerBase
    {
        private readonly RegistroValeService _registroValeService;

        private IMapper _mapper;

        
        public RegistroValeController(RegistroValeService registroValeService, IMapper mapper)
        {
            _registroValeService = registroValeService;
            _mapper = mapper;
        }

        private string CurrentUserId(ClaimsPrincipal claims){
                return claims.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Post(RegisterValesDto dto){
                
                var registroVale = _mapper.Map<RegistroVale>(dto);
                //Completar datos de control
                registroVale.Fecha = DateTime.Now;
                registroVale.UsuarioId = CurrentUserId(User as ClaimsPrincipal);
                var serviceResult = _registroValeService.Save(registroVale);
                if (serviceResult.isSuccess){
                    var result = _mapper.Map<RegisterValesResponseDto>(serviceResult.Result);

                    result.Subtotal = serviceResult.Result.GetSubTotalVale();
                    result.MontoIVA = serviceResult.Result.GetIVA();
                    result.Total = serviceResult.Result.Total();
                    return Ok(result);
                }else{

                        return BadRequest(serviceResult.Errors);

                }

                
        }

        
    }
}
